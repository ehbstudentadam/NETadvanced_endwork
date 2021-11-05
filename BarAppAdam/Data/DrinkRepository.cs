using BarAppAdam.Data;
using BarAppAdam.Entities;
using BarAppAdam.Entities.Drinks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam
{
    public class DrinkRepository : BaseRepository<Drink>
    {
        protected override Drink Insert(Drink entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Drinks] ([DrinkType], [Price]) VALUES (@DrinkType, @Price); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@DrinkType", entity.Type.ToString());
            command.Parameters.AddWithValue("@Price", entity.Price);

            using var reader = command.ExecuteReader();
            reader.Read();
            entity.Id = (int)reader.GetDecimal(0);

            return entity;
        }

        protected override void Update(Drink entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Drinks] SET [DrinkType] = @Type, [Price] = @Price WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@Type", entity.Type.ToString());

            command.ExecuteNonQuery();
        }

        public override Drink? GetEntity(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [DrinkType], [Price] FROM [Drinks] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)                                                    //Skip if database has no records and return null.
            {
                return null;
            }

            string drinkTypeFromDatabase = reader.GetString(1);                     //Check which Subclass (Beer, Wine, Softdrink, Shot or Cocktail) of Drinks has been retrieved from DB.
            Drink? drinkFromDatabase = null;

            if (drinkTypeFromDatabase.Equals(Drink.DrinkType.Beer.ToString()))
            {
                drinkFromDatabase = new Beer();
            }
            if (drinkTypeFromDatabase.Equals(Drink.DrinkType.Wine.ToString()))
            {
                drinkFromDatabase = new Wine();
            }
            if (drinkTypeFromDatabase.Equals(Drink.DrinkType.Softdrink.ToString()))
            {
                drinkFromDatabase = new Softdrink();
            }
            if (drinkTypeFromDatabase.Equals(Drink.DrinkType.Shot.ToString()))
            {
                drinkFromDatabase = new Shot();
            }
            if (drinkTypeFromDatabase.Equals(Drink.DrinkType.Cocktail.ToString()))
            {
                drinkFromDatabase = new Cocktail();
            }
            if (drinkFromDatabase == null)
            {
                return null;
            }
            drinkFromDatabase.Id = id;
            drinkFromDatabase.Price = reader.GetDecimal(2);                             //Make sure to get latest updated drinkprice from specific subclass. Apply locally.

            return drinkFromDatabase; 
        }

        public void TruncateTable()                                                     //Method used when DB Table Drinks has locally been tempered with.
        {                                                                               //There is a necessary structure/sequence of drinks (1:Beer, 2:Wine, 3:Softdrink, 4:Shot, 5:Cocktail)
            using var command = _connection.CreateCommand();
            command.CommandText = "TRUNCATE TABLE [Drinks]";

            command.ExecuteNonQuery();
        }

    }
}
