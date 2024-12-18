namespace InventoryManagementSystem
{
    partial class CashierOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            proDataGridView = new DataGridView();
            panel2 = new Panel();
            orderClearBtn = new Button();
            orderRemoveBtn = new Button();
            orderAddBtn = new Button();
            order_quantity = new NumericUpDown();
            order_proID = new ComboBox();
            oder_cat = new ComboBox();
            label9 = new Label();
            proPrice_lable = new Label();
            proName_lable = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            receiptBtn = new Button();
            payOrderBtn = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            orderDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_quantity).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(proDataGridView);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 353);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(185, 24);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // proDataGridView
            // 
            proDataGridView.AllowUserToAddRows = false;
            proDataGridView.AllowUserToDeleteRows = false;
            proDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proDataGridView.Location = new Point(15, 55);
            proDataGridView.Name = "proDataGridView";
            proDataGridView.ReadOnly = true;
            proDataGridView.RowHeadersWidth = 51;
            proDataGridView.RowTemplate.Height = 29;
            proDataGridView.Size = new Size(597, 285);
            proDataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(orderClearBtn);
            panel2.Controls.Add(orderRemoveBtn);
            panel2.Controls.Add(orderAddBtn);
            panel2.Controls.Add(order_quantity);
            panel2.Controls.Add(order_proID);
            panel2.Controls.Add(oder_cat);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(proPrice_lable);
            panel2.Controls.Add(proName_lable);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 344);
            panel2.TabIndex = 1;
            // 
            // orderClearBtn
            // 
            orderClearBtn.BackColor = Color.FromArgb(2, 122, 74);
            orderClearBtn.FlatAppearance.BorderSize = 0;
            orderClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            orderClearBtn.FlatStyle = FlatStyle.Flat;
            orderClearBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderClearBtn.ForeColor = Color.White;
            orderClearBtn.Location = new Point(504, 274);
            orderClearBtn.Name = "orderClearBtn";
            orderClearBtn.Size = new Size(94, 35);
            orderClearBtn.TabIndex = 19;
            orderClearBtn.Text = "Clear";
            orderClearBtn.UseVisualStyleBackColor = false;
            // 
            // orderRemoveBtn
            // 
            orderRemoveBtn.BackColor = Color.FromArgb(2, 122, 74);
            orderRemoveBtn.FlatAppearance.BorderSize = 0;
            orderRemoveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            orderRemoveBtn.FlatStyle = FlatStyle.Flat;
            orderRemoveBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderRemoveBtn.ForeColor = Color.White;
            orderRemoveBtn.Location = new Point(211, 274);
            orderRemoveBtn.Name = "orderRemoveBtn";
            orderRemoveBtn.Size = new Size(94, 35);
            orderRemoveBtn.TabIndex = 18;
            orderRemoveBtn.Text = "Remove";
            orderRemoveBtn.UseVisualStyleBackColor = false;
            // 
            // orderAddBtn
            // 
            orderAddBtn.BackColor = Color.FromArgb(2, 122, 74);
            orderAddBtn.FlatAppearance.BorderSize = 0;
            orderAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            orderAddBtn.FlatStyle = FlatStyle.Flat;
            orderAddBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderAddBtn.ForeColor = Color.White;
            orderAddBtn.Location = new Point(80, 274);
            orderAddBtn.Name = "orderAddBtn";
            orderAddBtn.Size = new Size(94, 35);
            orderAddBtn.TabIndex = 17;
            orderAddBtn.Text = "Add";
            orderAddBtn.UseVisualStyleBackColor = false;
            // 
            // order_quantity
            // 
            order_quantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            order_quantity.Location = new Point(421, 115);
            order_quantity.Name = "order_quantity";
            order_quantity.Size = new Size(177, 30);
            order_quantity.TabIndex = 16;
            // 
            // order_proID
            // 
            order_proID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            order_proID.FormattingEnabled = true;
            order_proID.Location = new Point(421, 67);
            order_proID.Name = "order_proID";
            order_proID.Size = new Size(177, 31);
            order_proID.TabIndex = 15;
            order_proID.SelectedIndexChanged += order_proID_SelectedIndexChanged;
            // 
            // oder_cat
            // 
            oder_cat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            oder_cat.FormattingEnabled = true;
            oder_cat.Location = new Point(112, 67);
            oder_cat.Name = "oder_cat";
            oder_cat.Size = new Size(177, 31);
            oder_cat.TabIndex = 14;
            oder_cat.SelectedIndexChanged += oder_cat_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(330, 122);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 13;
            label9.Text = "Quantity:";
            // 
            // proPrice_lable
            // 
            proPrice_lable.AutoSize = true;
            proPrice_lable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proPrice_lable.Location = new Point(137, 173);
            proPrice_lable.Name = "proPrice_lable";
            proPrice_lable.Size = new Size(77, 20);
            proPrice_lable.TabIndex = 12;
            proPrice_lable.Text = "Category:";
            // 
            // proName_lable
            // 
            proName_lable.AutoSize = true;
            proName_lable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proName_lable.Location = new Point(137, 125);
            proName_lable.Name = "proName_lable";
            proName_lable.Size = new Size(77, 20);
            proName_lable.TabIndex = 11;
            proName_lable.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 173);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 10;
            label6.Text = "Price (Rs.):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 125);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 70);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 8;
            label4.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 70);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 7;
            label3.Text = "Category:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(receiptBtn);
            panel3.Controls.Add(payOrderBtn);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(orderDataGridView);
            panel3.Location = new Point(642, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(393, 718);
            panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(217, 456);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 30);
            textBox1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(217, 411);
            label7.Name = "label7";
            label7.Size = new Size(45, 23);
            label7.TabIndex = 22;
            label7.Text = "0.00";
            // 
            // receiptBtn
            // 
            receiptBtn.BackColor = Color.FromArgb(2, 122, 74);
            receiptBtn.FlatAppearance.BorderSize = 0;
            receiptBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            receiptBtn.FlatStyle = FlatStyle.Flat;
            receiptBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            receiptBtn.ForeColor = Color.White;
            receiptBtn.Location = new Point(17, 626);
            receiptBtn.Name = "receiptBtn";
            receiptBtn.Size = new Size(358, 35);
            receiptBtn.TabIndex = 21;
            receiptBtn.Text = "Receipt";
            receiptBtn.UseVisualStyleBackColor = false;
            // 
            // payOrderBtn
            // 
            payOrderBtn.BackColor = Color.FromArgb(2, 122, 74);
            payOrderBtn.FlatAppearance.BorderSize = 0;
            payOrderBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            payOrderBtn.FlatStyle = FlatStyle.Flat;
            payOrderBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            payOrderBtn.ForeColor = Color.White;
            payOrderBtn.Location = new Point(17, 574);
            payOrderBtn.Name = "payOrderBtn";
            payOrderBtn.Size = new Size(358, 35);
            payOrderBtn.TabIndex = 20;
            payOrderBtn.Text = "Pay Orders";
            payOrderBtn.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(217, 511);
            label13.Name = "label13";
            label13.Size = new Size(45, 23);
            label13.TabIndex = 17;
            label13.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(127, 511);
            label12.Name = "label12";
            label12.Size = new Size(75, 23);
            label12.TabIndex = 16;
            label12.Text = "Change:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(82, 463);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 15;
            label11.Text = "Amount (Rs.):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(64, 411);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 14;
            label10.Text = "Total Price (Rs.):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(185, 24);
            label2.TabIndex = 2;
            label2.Text = "Available Products";
            // 
            // orderDataGridView
            // 
            orderDataGridView.AllowUserToAddRows = false;
            orderDataGridView.AllowUserToDeleteRows = false;
            orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Location = new Point(17, 55);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.ReadOnly = true;
            orderDataGridView.RowHeadersWidth = 51;
            orderDataGridView.RowTemplate.Height = 29;
            orderDataGridView.Size = new Size(358, 285);
            orderDataGridView.TabIndex = 1;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(1049, 756);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)proDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)order_quantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DataGridView proDataGridView;
        private DataGridView orderDataGridView;
        private Label label2;
        private Label label9;
        private Label proPrice_lable;
        private Label proName_lable;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private NumericUpDown order_quantity;
        private ComboBox order_proID;
        private ComboBox oder_cat;
        private Label label13;
        private Button orderAddBtn;
        private Button orderClearBtn;
        private Button orderRemoveBtn;
        private Button receiptBtn;
        private Button payOrderBtn;
        private TextBox textBox1;
        private Label label7;
    }
}
