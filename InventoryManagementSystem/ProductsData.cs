using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    internal class ProductsData
    {
        // Properties
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        // Method to retrieve all product data
        public List<ProductsData> AllProductData()
        {
            List<ProductsData> listData = new List<ProductsData>();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30";

            string selectQuery = "SELECT p.id, p.prod_id, p.prod_name, p.prod_price, p.prod_stock, p.image_path, p.prod_status, c.category, p.date " +
                                 "FROM products p " +
                                 "JOIN categories c ON p.categoryID = c.id";

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductsData productsData = new ProductsData
                                {
                                    ID = reader["id"] != DBNull.Value ? (int)reader["id"] : 0,
                                    ProductID = reader["prod_id"]?.ToString(),
                                    ProdName = reader["prod_name"]?.ToString(),
                                    Category = reader["category"]?.ToString(),
                                    Price = reader["prod_price"]?.ToString(),
                                    Stock = reader["prod_stock"]?.ToString(),
                                    Status = reader["prod_status"]?.ToString(),
                                    ImagePath = reader["image_path"]?.ToString(),
                                    Date = reader["date"]?.ToString()
                                };

                                listData.Add(productsData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listData;
        }

        public List<ProductsData> allAvailableProducts()
        {
            List<ProductsData> listData = new List<ProductsData>();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30";

            string selectQuery = "SELECT p.id, p.prod_id, p.prod_name, p.prod_price, p.prod_stock, p.image_path, p.prod_status, c.category, p.date " +
                     "FROM products p " +
                     "JOIN categories c ON p.categoryID = c.id " +  
                     "WHERE prod_status = @status";


            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductsData productsData = new ProductsData
                                {
                                    ID = reader["id"] != DBNull.Value ? (int)reader["id"] : 0,
                                    ProductID = reader["prod_id"]?.ToString(),
                                    ProdName = reader["prod_name"]?.ToString(),
                                    Category = reader["category"]?.ToString(),
                                    Price = reader["prod_price"]?.ToString(),
                                    Stock = reader["prod_stock"]?.ToString(),
                                    Status = reader["prod_status"]?.ToString(),
                                    ImagePath = reader["image_path"]?.ToString(),
                                    Date = reader["date"]?.ToString()
                                };

                                listData.Add(productsData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listData;
        }
    }
}
