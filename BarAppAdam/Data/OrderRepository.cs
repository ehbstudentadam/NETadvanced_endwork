using BarAppAdam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Data
{
    public class OrderRepository : BaseRepository<Order>
    {
        protected override Order? GetEntity(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id] FROM [Members] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            reader.Read();


        }

        protected override Order Insert(Order entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Orders] ([CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal])" +
                "VALUES (@CreatedDate, @Member, @MemberID, @Drinks, @PriceTotal);" +
                "SELECT SCOPE_IDENTITY";
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
            command.CommandText = "INSERT INTO [Orders] ([CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal])" +
                "VALUES (@CreatedDate, @Member, @MemberID, @Drinks, @PriceTotal);";
            command.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate.ToString());
            command.Parameters.AddWithValue("@Member", entity.Member.ToString());
            command.Parameters.AddWithValue("@MemberID", entity.Member.Id);
            command.Parameters.AddWithValue("@Drinks", entity.PrintAllDrinks());
            command.Parameters.AddWithValue("@PriceTotal", entity.PriceTotal);

            command.ExecuteNonQuery();
        }
    }
}
