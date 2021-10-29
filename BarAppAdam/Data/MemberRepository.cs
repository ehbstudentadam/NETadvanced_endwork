using BarAppAdam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Data
{
    public class MemberRepository : BaseRepository<Member>
    {
        
        protected override Member Insert(Member entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Members] " +
                "([Firstname], [Lastname], [Address], [Email], [Wallet], [IsOwner], [CreatedDate]) " +
                "VALUES (@Firstname, @Lastname, @Address, @Email, @Wallet, @IsOwner, @CreatedDate); " +
                "SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Firstname", entity.FirstName);
            command.Parameters.AddWithValue("@Lastname", entity.LastName);
            command.Parameters.AddWithValue("@Address", entity.Address);            
            command.Parameters.AddWithValue("@Email", entity.Email);
            command.Parameters.AddWithValue("@Wallet", entity.Wallet);
            command.Parameters.AddWithValue("@IsOwner", entity.IsOwner.ToString());
            command.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate);

            using var reader = command.ExecuteReader();
            reader.Read();
            entity.Id = (int)reader.GetDecimal(0);

            return entity;
        }

        protected override void Update(Member entity)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Members] " +
                "([Firstname], [Lastname], [Address], [Email], [Wallet], [IsOwner], [CreatedDate]) " +
                "VALUES (@Firstname, @Lastname, @Address, @Email, @Wallet, @IsOwner, @CreatedDate)";
            command.Parameters.AddWithValue("@Firstname", entity.FirstName);
            command.Parameters.AddWithValue("@Lastname", entity.LastName);
            command.Parameters.AddWithValue("@Address", entity.Address);            
            command.Parameters.AddWithValue("@Email", entity.Email);
            command.Parameters.AddWithValue("@Wallet", entity.Wallet);
            command.Parameters.AddWithValue("@IsOwner", entity.IsOwner.ToString());
            command.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate);

            command.ExecuteNonQuery();
        }

        public override Member? GetEntity(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id] FROM [Members] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            reader.Read();

            int databaseId = (int)reader.GetDecimal(0);
            string firstName = reader.GetString(1);
            string lastName = reader.GetString(2);
            string address = reader.GetString(3);
            string email = reader.GetString(4);
            decimal wallet = reader.GetDecimal(5);
            bool isOwner = bool.Parse(reader.GetString(6));
            DateTime dateTime = DateTime.Parse(reader.GetString(7));

            Member member = new Member(firstName, lastName, address, email, isOwner);
            member.CreatedDate = dateTime;
            member.Wallet = wallet;
            member.Id = databaseId;

            return member;
        }
    }
}
