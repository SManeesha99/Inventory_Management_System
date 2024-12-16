using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class ProductsData
    {
        // Connection string to the database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        // Properties
        public int ID { get; set; }
        public string ProductID { get; set; } //1
        public string ProdName { get; set; } //2
        public string Category { get; set; } //3
        public string Price { get; set; } //4
        public string ImagePath { get; set; } //5
        public string Stock { get; set; } //6
        public string Status { get; set; } //7
        public string Date { get; set; } //8

        // Method to retrieve all product data
        public List<ProductsData> AllProductData()
        {
            List<ProductsData> listData = new List<ProductsData>();

            try
            {
                connect.Open();

                string selectQuery = "SELECT p.id, p.prod_id, p.prod_name, p.prod_price, p.prod_stock, p.image_path, p.prod_status, c.category, p.date " +
                    "FROM products p " +
                    "JOIN categories c ON p.categoryID = c.id";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductsData productsData = new ProductsData();
                        productsData.ID = (int)reader["id"];
                        productsData.ProductID = reader["prod_id"].ToString();
                        productsData.ProdName = reader["prod_name"].ToString();
                        productsData.Category = reader["Category"].ToString();
                        productsData.Price = reader["prod_price"].ToString();
                        productsData.ImagePath = reader["image_path"].ToString();
                        productsData.Stock = reader["prod_stock"].ToString();
                        productsData.Status = reader["prod_status"].ToString();
                        productsData.Date = reader["date"].ToString();


                        listData.Add(productsData);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine("Error retrieving data: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return listData;
        }
    }
}
