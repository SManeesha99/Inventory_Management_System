using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Drawing;

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
            displayOrders();
            displayTotalPrice();
        }

        public void displayOrders()
        {
            OrderData oData = new OrderData();
            List<OrderData> listdata = oData.GetAllOrderData();

            orderDataGridView.DataSource = listdata;

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

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Explicitly set the DataSource, DisplayMember, and ValueMember
                    oder_cat.DataSource = table;
                    oder_cat.DisplayMember = "category";
                    oder_cat.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }


        private void oder_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oder_cat.SelectedValue != null && int.TryParse(oder_cat.SelectedValue.ToString(), out int selectedCategoryID))
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT prod_id FROM products WHERE categoryID = @categoryID AND prod_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@categoryID", selectedCategoryID); // Use parsed integer
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
                        MessageBox.Show("Error retrieving category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                // Format price as decimal
                                proPrice_lable.Text = productPrice.ToString("F2");
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

        private float totalPrice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", iGen);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);
                            label7.Text = totalPrice.ToString("0.00");
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Faild : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void orderAddBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (oder_cat.SelectedIndex == -1 || order_proID.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(proName_lable.Text) ||
                string.IsNullOrWhiteSpace(proPrice_lable.Text) ||
                order_quantity.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    float getPrice = 0;
                    string selectOrder = "SELECT prod_price FROM products WHERE prod_id = @prodID";

                    using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                    {
                        getOrder.Parameters.AddWithValue("@prodID", order_proID.SelectedItem); // Use ToString() to get the ID

                        using (SqlDataReader reader = getOrder.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object rawValue = reader["prod_price"];

                                if (rawValue != DBNull.Value)
                                {
                                    getPrice = Convert.ToSingle(rawValue);
                                }
                            }
                        }
                    }

                    string insertData = "INSERT INTO orders (customer_id, pro_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                                        "VALUES (@cusID, @proID, @proName, @cat, @qty, @oPrice, @tPrice, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cusID", iGen);
                        cmd.Parameters.AddWithValue("@proID", order_proID.SelectedItem);
                        cmd.Parameters.AddWithValue("@proName", proName_lable.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", oder_cat.SelectedValue.ToString()); // Use SelectedValue for category
                        cmd.Parameters.AddWithValue("@qty", order_quantity.Value);
                        cmd.Parameters.AddWithValue("@oPrice", getPrice);

                        float totalP = getPrice * (int)order_quantity.Value;
                        cmd.Parameters.AddWithValue("@tPrice", totalP);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            displayOrders();
            displayTotalPrice();
        }



        private int iGen;
        private void IDGenerator()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);
                        if (temp == 0)
                        {
                            iGen = 1;
                        }
                        else
                        {
                            iGen = temp + 1;
                        }
                    }
                    else
                    {
                        iGen = 1;
                    }

                }
            }
        }

        private void orderRemoveBtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove ID " + prodID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", prodID);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Order deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayOrders();
            displayTotalPrice();
        }

        private int prodID = 0;
        private void proDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = orderDataGridView.Rows[e.RowIndex];
                prodID = (int)row.Cells[0].Value;
            }
        }

        public void clearFields()
        {
            oder_cat.SelectedIndex = -1;
            order_proID.SelectedIndex = -1;
            proName_lable.Text = "";
            order_quantity.Value = 0;
            proPrice_lable.Text = "";
        }
        private void orderClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void payOrderBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || orderDataGridView.Rows.Count < 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to pay your orders ?" + prodID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, order_date)" +
                                "VALUES (@cusID, @totalPrice, @amount, @change, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cusID", iGen);
                                cmd.Parameters.AddWithValue("@totalPrice", label7.Text);
                                cmd.Parameters.AddWithValue("@amount", textBox1.Text);
                                cmd.Parameters.AddWithValue("@change", label13.Text);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();
            textBox1.Text = "";
            label13.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(textBox1.Text);
                    float getChange = (getAmount - totalPrice);

                    if (getChange <= 0)
                    {
                        textBox1.Text = "";
                        label13.Text = "";
                    }
                    else
                    {
                        label13.Text = getChange.ToString("0.00");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    label13.Text = "";

                }
            }
        }

        private int rowIndex = 0;
        private int labelmargin;

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Fonts and styles
            Font titleFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font contentFont = new Font("Tahoma", 10);
            Font footerFont = new Font("Tahoma", 10, FontStyle.Bold);

            // Margins and measurements
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float y = topMargin;

            // Column widths (dynamic calculation)
            int numColumns = 7; // CID, PID, PName, Category, QTY, Price, Total
            float colWidth = (rightMargin - leftMargin) / numColumns;

            // Title
            string title = "MarcoMan's Inventory Management System";
            e.Graphics.DrawString(
                title,
                titleFont,
                Brushes.Black,
                leftMargin + ((rightMargin - leftMargin) - e.Graphics.MeasureString(title, titleFont).Width) / 2,
                y
            );
            y += titleFont.GetHeight(e.Graphics) + 20;

            // Date and Time
            string dateText = "Date: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            e.Graphics.DrawString(dateText, contentFont, Brushes.Black, leftMargin, y);
            y += contentFont.GetHeight(e.Graphics) + 20;

            // Table Header
            string[] headers = { "CID", "PID", "PName", "Category", "QTY", "Price", "Total" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(
                    headers[i],
                    headerFont,
                    Brushes.Black,
                    leftMargin + i * colWidth,
                    y
                );
            }
            y += headerFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y); // Separator
            y += 5;

            // Table Content
            while (rowIndex < orderDataGridView.Rows.Count)
            {
                DataGridViewRow row = orderDataGridView.Rows[rowIndex];

                for (int i = 0; i < headers.Length; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cellText = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    e.Graphics.DrawString(
                        cellText,
                        contentFont,
                        Brushes.Black,
                        leftMargin + i * colWidth,
                        y
                    );
                }

                y += contentFont.GetHeight(e.Graphics) + 5;
                rowIndex++;

                // Check for page overflow
                if (y + contentFont.GetHeight(e.Graphics) > bottomMargin - 100) // Reserve space for footer
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Footer
            y += 20;
            e.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y); // Separator
            y += 10;

            e.Graphics.DrawString("Total Price: $ " + totalPrice, footerFont, Brushes.Black, leftMargin, y);
            y += footerFont.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Amount Paid: $ " + textBox1.Text.Trim(), contentFont, Brushes.Black, leftMargin, y);
            y += contentFont.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Change: $ " + label13.Text.Trim(), contentFont, Brushes.Black, leftMargin, y);
            y += contentFont.GetHeight(e.Graphics) + 20;

            // Thank You Message
            string thankYouText = "Thank you for your purchase!";
            e.Graphics.DrawString(
                thankYouText,
                footerFont,
                Brushes.Black,
                leftMargin + ((rightMargin - leftMargin) - e.Graphics.MeasureString(thankYouText, footerFont).Width) / 2,
                y
            );
        }


    }
}
