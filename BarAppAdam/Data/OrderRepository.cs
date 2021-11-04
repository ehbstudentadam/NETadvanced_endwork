﻿using BarAppAdam.Entities;
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
        protected MemberRepository memberRepository = new();

        public override Order? GetEntity(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal] FROM [Orders] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                return null;
            }

            int databaseId = (int)reader.GetDecimal(0);
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

            return order;            
        }

        public List<Order> GetAllFromTill(int from, int untill)         //make sure maximum till overexceeds testing to be done
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [CreatedDate], [Member], [MemberID], [Drinks], [PriceTotal] FROM [Orders] WHERE [Id] BETWEEN @From AND @Untill";
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@Untill", untill);

            using var reader = command.ExecuteReader();

            var orders = new List<Order>();
            while (reader.Read())
            {
                int databaseId = (int)reader.GetDecimal(0);
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

                orders.Add(order);
            }
            return orders;
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

        private List<KeyValuePair<Drink, int>> ConvertStringToKVList(string databaseString)
        {
            List<KeyValuePair<Drink, int>> result = new List<KeyValuePair<Drink, int>>();
            
            if (new Regex("Beer:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Beer: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(new Beer(), quantityValue));
            }
            if (new Regex("Wine:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Wine: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(new Wine(), quantityValue));
            }
            if (new Regex("Softdrink:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Softdrink: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(new Softdrink(), quantityValue));
            }
            if (new Regex("Shot:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Shot: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(new Shot(), quantityValue));
            }
            if (new Regex("Cocktail:").IsMatch(databaseString))
            {
                var extractQuantity = Regex.Match(databaseString, @"Cocktail: (\d?\d?\d?)");
                string quantity = extractQuantity.Groups[1].Value;
                int quantityValue = Convert.ToInt32(quantity);
                result.Add(new KeyValuePair<Drink, int>(new Cocktail(), quantityValue));
            }
            return result;
        }
    }
}
