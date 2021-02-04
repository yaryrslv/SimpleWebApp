using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class BasketCore
    {
        private static int LastTotalId { get; set; } = 0;
        private static string serverName { get; set; } = "DESKTOP-HKC7A64\\MSSQLSERVER01";
        private static string databaseName { get; set; }  = "Store";
        private static string salesTableName { get; set; } = "SalesTable";
        private static string connectionString { get; set; }  = @"Server=" + serverName + ";Database=" + databaseName + ";Trusted_Connection=True;MultipleActiveResultSets=true";
        public BasketCore()
        {
            string sqlInsert = "SELECT COUNT(*) FROM " + salesTableName;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int сount = (int)command.ExecuteScalar();
                LastTotalId = сount + 1;
                connection.Close();
            }
        }
        public void Insert(string UserName, string Name, int Cost)
        {
            string sqlInsert = "INSERT INTO " + salesTableName + " VALUES(" + LastTotalId + ", '" + UserName + "', '" + Name + "'," + Cost + ")";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
            LastTotalId = +1;
        }
        public void Delete(int TotalId, string UserName)
        {
            string sqlInsert = "DELETE FROM " + salesTableName + " WHERE TotalId = " 
                + TotalId + " AND UserName = '" + UserName + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<BasketItem> Get(string CurrentUserName)
        {
            List<BasketItem> UserBasket = new List<BasketItem>();
            string sqlInsert = "SELECT * FROM " + salesTableName + " WHERE UserName = '" + CurrentUserName + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    object TotalId = reader.GetValue(0);
                    object UserName = reader.GetValue(1);
                    object Name = reader.GetValue(2);
                    object Cost = reader.GetValue(3);
                    UserBasket.Add(new BasketItem()
                    {
                        TotalId = Convert.ToInt32(TotalId),
                        UserName = UserName.ToString(),
                        Name = Name.ToString(),
                        Cost = Convert.ToInt32(Cost)
                    });
                }
                connection.Close();
                return UserBasket;
            }
        }
    }
    public class BasketItem
    {
        public int TotalId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
