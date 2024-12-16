using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class UsersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> listdata = new List<UsersData>();

            using(SqlConnection conn = connect)
            {
                connect.Open();

                string selectQuery = "SELECT * FROM users";

                using(SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData usersData = new UsersData();
                        usersData.ID = (int)reader["id"];
                        usersData.Username = reader["username"].ToString();
                        usersData.Password = reader["password"].ToString();
                        usersData.Role = reader["role"].ToString();
                        usersData.Status = reader["status"].ToString();
                        //usersData.Date = reader["date"].ToString();

                        listdata.Add(usersData);
                    }
                }

            }
            return listdata;
        }

    }
}
