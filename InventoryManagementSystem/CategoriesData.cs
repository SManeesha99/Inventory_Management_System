using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class CategoriesData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }

        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listdata = new List<CategoriesData>();

            using (SqlConnection conn = connect)
            {
                connect.Open();

                string selectQuery = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesData catData = new CategoriesData();
                        catData.ID = (int)reader["id"];
                        catData.Category = reader["category"].ToString();
                        catData.Date = Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd");

                        listdata.Add(catData);
                    }
                }

            }
            return listdata;
        }
    }
}
