using BarAppAdam.Entities;
using BarAppAdam.Entities.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BarAppAdam.Data
{
    public class OrderRepository : BaseRepository<Order>
    {
        private readonly MemberRepository memberRepository = new();
        private readonly DrinkRepository drinkRepository = new();


        public override Order? GetEntity(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal] FROM [Orders] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)                                                            //Return null if DB Table is empty.
            {
                return null;
            }

            int databaseId = (int)reader.GetDecimal(0);
            DateTime dateTime = DateTime.Parse(reader.GetString(1));
            int memberID = reader.GetInt32(3);
            Member? member = memberRepository.GetEntity(memberID);
            List<KeyValuePair<Drink, int>> drinks = ConvertStringToKVList(reader.GetString(4));

            if (member == null)                                                             //If no member is attached to order for some reason.?. Throw Exception.
            {                                                                               //Program allowed to crash because this is abnormal behaviour that needs a deeper look.
                throw new Exception("memberID not found when retrieving member from database.");
            }

            Order order = new(member, drinks);
            order.CreatedDate = dateTime;
            order.Id = databaseId;

            return order;            
        }

        public List<Order> GetAllFromTill(int from, int untill)                             //Retreive parts of database to reduce networktraffic and waiting times.
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal] FROM [Orders] WHERE [Id] BETWEEN @From AND @Untill";
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@Untill", untill);

            using var reader = command.ExecuteReader();

            var orders = new List<Order>();
            while (reader.Read())
            {
                int databaseId = reader.GetInt32(0);
                DateTime dateTime = DateTime.Parse(reader.GetString(1));
                int memberID = reader.GetInt32(3);
                Member? member = memberRepository.GetEntity(memberID);
                List<KeyValuePair<Drink, int>> drinks = ConvertStringToKVList(reader.GetString(4));

                if (member == null)
                {
                    throw new Exception("memberID not found when retrieving member from database.");
                }
                Order order = new(member, drinks);
                order.CreatedDate = dateTime;
                order.Id = databaseId;
                order.PriceTotal = reader.GetDecimal(5);

                orders.Add(order);
            }
            return orders;
        }


        protected override Order Insert(Order entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Orders] ([CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal])" +
                "VALUES (@CreatedDate, @Member, @MemberID, @Drinks, @PriceTotal);" +
                "SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate.ToString());
            command.Parameters.AddWithValue("@Member", entity.Member.ToString());
            command.Parameters.AddWithValue("@MemberID", entity.Member.Id);
            command.Parameters.AddWithValue("@Drinks", entity.PrintAllDrinks());            
            command.Parameters.AddWithValue("@PriceTotal", entity.PriceTotal);

            using var reader = command.ExecuteReader();
            reader.Read();
            entity.Id = (int)reader.GetDecimal(0);

            return entity;
        }

        protected override void Update(Order entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Orders] SET [CreatedDate] = @CreatedDate, [Member] = @Member, [MemberID] = @MemberID, " +
                "[Drinks] = @Drinks, [PriceTotal] = @PriceTotal WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate.ToString());
            command.Parameters.AddWithValue("@Member", entity.Member.ToString());
            command.Parameters.AddWithValue("@MemberID", entity.Member.Id);
            command.Parameters.AddWithValue("@Drinks", entity.PrintAllDrinks());
            command.Parameters.AddWithValue("@PriceTotal", entity.PriceTotal);

            command.ExecuteNonQuery();
        }

        private List<KeyValuePair<Drink, int>> ConvertStringToKVList(string databaseString)     //An order needs a List with Key:Drink Value:intQuantity but is saved as string in DB.
        {                                                                                       //Here the retrieved string from DB is converted to K/V Pair List by help of Regex.
            List<KeyValuePair<Drink, int>> result = new List<KeyValuePair<Drink, int>>();
            if (drinkRepository.GetEntity(1) == null || drinkRepository.GetEntity(2) == null || drinkRepository.GetEntity(3) == null || drinkRepository.GetEntity(4) == null || drinkRepository.GetEntity(5) == null)
            {
                return result;                                                                  //Ineffective nullcheck for VSCode to stop complaining.
            }                                                                                   //See green undelines below.

            if (new Regex("Beer:").IsMatch(databaseString))                                             //Example of how drinks are stored in DB:
            {                                                                                           //[Beer: 3] [Wine: 2] [Softdrink: 0] [Shot: 0] [Cocktail: 1] 
                var extractQuantity = Regex.Match(databaseString, @"Beer: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(drinkRepository.GetEntity(1), quantityValue));
            }
            if (new Regex("Wine:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Wine: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(drinkRepository.GetEntity(2), quantityValue));
            }
            if (new Regex("Softdrink:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Softdrink: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(drinkRepository.GetEntity(3), quantityValue));
            }
            if (new Regex("Shot:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Shot: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(drinkRepository.GetEntity(4), quantityValue));
            }
            if (new Regex("Cocktail:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Cocktail: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(drinkRepository.GetEntity(5), quantityValue));
            }
            return result;
        }
    }
}
