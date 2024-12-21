using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class OrderData
    {
        private readonly SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string CID { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public decimal OrigPrice { get; set; }
        public int QTY { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public List<OrderData> GetAllOrderData()
        {
            var listData = new List<OrderData>();

            try
            {
                _connection.Open();

                // Get the latest customer ID
                int cusID = 0;
                string selectCustomerQuery = "SELECT ISNULL(MAX(customer_id), 0) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectCustomerQuery, _connection))
                {
                    cusID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (cusID == 0)
                {
                    return listData; // No customers found, return empty list
                }

                // Fetch order data for the latest customer
                string selectOrderQuery = "SELECT * FROM orders WHERE customer_id = @cusID";

                using (SqlCommand cmd = new SqlCommand(selectOrderQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("@cusID", cusID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var data = new OrderData
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                CID = reader["customer_id"].ToString(),
                                PID = reader["pro_id"].ToString(),
                                PName = reader["prod_name"].ToString(),
                                Category = reader["category"].ToString(),
                                QTY = Convert.ToInt32(reader["qty"]),
                                OrigPrice = Convert.ToDecimal(reader["orig_price"]),
                                TotalPrice = Convert.ToDecimal(reader["total_price"]),
                                Date = Convert.ToDateTime(reader["order_date"])
                            };

                            listData.Add(data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error or rethrow
                Console.WriteLine($"Error retrieving order data: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return listData;
        }
    }
}
