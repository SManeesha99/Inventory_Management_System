using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrder()
        {
            InitializeComponent();
            diaplayAvailableProducts();
            LoadCategories();
        }

        public void diaplayAvailableProducts()
        {
            ProductsData uData = new ProductsData();

            List<ProductsData> listData = uData.allAvailableProducts();

            proDataGridView.DataSource = listData;
        }

        private void LoadCategories()
        {
            string query = "SELECT id, category FROM categories";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                oder_cat.DataSource = table;
                oder_cat.DisplayMember = "category";
                oder_cat.ValueMember = "id";
            }
        }

        private void oder_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous data
            order_proID.SelectedIndex = -1;
            order_proID.Items.Clear();
            proName_lable.Text = "";

            // Retrieve the selected category ID
            DataRowView selectedRow = oder_cat.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedCategoryID = selectedRow["id"].ToString();

                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        // Use parameterized query to fetch products for the selected category
                        string selectData = "SELECT prod_id FROM products WHERE categoryID = @categoryID AND prod_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@categoryID", selectedCategoryID);
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodID = reader["prod_id"].ToString();
                                    order_proID.Items.Add(prodID); // Populate the product ID dropdown
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving product IDs: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void order_proID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous product details
            proName_lable.Text = "";
            proPrice_lable.Text = "";

            // Retrieve the selected product ID
            string selectedProductID = order_proID.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedProductID) && checkConnection())
            {
                try
                {
                    connect.Open();

                    // Use parameterized query to fetch product details
                    string selectData = "SELECT prod_name, prod_price FROM products WHERE prod_id = @prodID AND prod_status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", selectedProductID);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fetch product details
                                string productName = reader["prod_name"].ToString();
                                float productPrice = Convert.ToSingle(reader["prod_price"]);

                                // Assign product details to labels
                                proName_lable.Text = productName;
                                proPrice_lable.Text = productPrice.ToString("F2"); // Format price as decimal
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving product details: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

    }
}
