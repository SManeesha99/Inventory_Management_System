namespace InventoryManagementSystem
{
    partial class AdminAddProducts
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
            panel2 = new Panel();
            pro_status = new ComboBox();
            proClearBtn = new Button();
            proRemoveBtn = new Button();
            proUpdateBtn = new Button();
            proAddBtn = new Button();
            proImgUploadBtn = new Button();
            panel3 = new Panel();
            proImg = new PictureBox();
            pro_cat = new ComboBox();
            pro_stock = new TextBox();
            pro_price = new TextBox();
            pro_name = new TextBox();
            pro_id = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            proDataGridView = new DataGridView();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proImg).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pro_status);
            panel2.Controls.Add(proClearBtn);
            panel2.Controls.Add(proRemoveBtn);
            panel2.Controls.Add(proUpdateBtn);
            panel2.Controls.Add(proAddBtn);
            panel2.Controls.Add(proImgUploadBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pro_cat);
            panel2.Controls.Add(pro_stock);
            panel2.Controls.Add(pro_price);
            panel2.Controls.Add(pro_name);
            panel2.Controls.Add(pro_id);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 458);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 269);
            panel2.TabIndex = 3;
            // 
            // pro_status
            // 
            pro_status.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_status.FormattingEnabled = true;
            pro_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            pro_status.Location = new Point(497, 116);
            pro_status.Name = "pro_status";
            pro_status.Size = new Size(220, 31);
            pro_status.TabIndex = 18;
            // 
            // proClearBtn
            // 
            proClearBtn.BackColor = Color.FromArgb(2, 122, 74);
            proClearBtn.FlatAppearance.BorderSize = 0;
            proClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            proClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            proClearBtn.FlatStyle = FlatStyle.Flat;
            proClearBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            proClearBtn.ForeColor = Color.White;
            proClearBtn.Location = new Point(640, 187);
            proClearBtn.Name = "proClearBtn";
            proClearBtn.RightToLeft = RightToLeft.No;
            proClearBtn.Size = new Size(103, 40);
            proClearBtn.TabIndex = 17;
            proClearBtn.Text = "Clear";
            proClearBtn.UseVisualStyleBackColor = false;
            // 
            // proRemoveBtn
            // 
            proRemoveBtn.BackColor = Color.FromArgb(2, 122, 74);
            proRemoveBtn.FlatAppearance.BorderSize = 0;
            proRemoveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            proRemoveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            proRemoveBtn.FlatStyle = FlatStyle.Flat;
            proRemoveBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            proRemoveBtn.ForeColor = Color.White;
            proRemoveBtn.Location = new Point(497, 187);
            proRemoveBtn.Name = "proRemoveBtn";
            proRemoveBtn.Size = new Size(103, 40);
            proRemoveBtn.TabIndex = 16;
            proRemoveBtn.Text = "Remove";
            proRemoveBtn.UseVisualStyleBackColor = false;
            // 
            // proUpdateBtn
            // 
            proUpdateBtn.BackColor = Color.FromArgb(2, 122, 74);
            proUpdateBtn.FlatAppearance.BorderSize = 0;
            proUpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            proUpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            proUpdateBtn.FlatStyle = FlatStyle.Flat;
            proUpdateBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            proUpdateBtn.ForeColor = Color.White;
            proUpdateBtn.Location = new Point(359, 187);
            proUpdateBtn.Name = "proUpdateBtn";
            proUpdateBtn.Size = new Size(103, 40);
            proUpdateBtn.TabIndex = 15;
            proUpdateBtn.Text = "Update";
            proUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // proAddBtn
            // 
            proAddBtn.BackColor = Color.FromArgb(2, 122, 74);
            proAddBtn.FlatAppearance.BorderSize = 0;
            proAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            proAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            proAddBtn.FlatStyle = FlatStyle.Flat;
            proAddBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            proAddBtn.ForeColor = Color.White;
            proAddBtn.Location = new Point(216, 187);
            proAddBtn.Name = "proAddBtn";
            proAddBtn.Size = new Size(103, 40);
            proAddBtn.TabIndex = 14;
            proAddBtn.Text = "Add";
            proAddBtn.UseVisualStyleBackColor = false;
            proAddBtn.Click += proAddBtn_Click;
            // 
            // proImgUploadBtn
            // 
            proImgUploadBtn.BackColor = Color.FromArgb(2, 122, 74);
            proImgUploadBtn.FlatAppearance.BorderSize = 0;
            proImgUploadBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            proImgUploadBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            proImgUploadBtn.FlatStyle = FlatStyle.Flat;
            proImgUploadBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            proImgUploadBtn.ForeColor = Color.White;
            proImgUploadBtn.Location = new Point(876, 153);
            proImgUploadBtn.Name = "proImgUploadBtn";
            proImgUploadBtn.Size = new Size(103, 40);
            proImgUploadBtn.TabIndex = 13;
            proImgUploadBtn.Text = "Upload";
            proImgUploadBtn.UseVisualStyleBackColor = false;
            proImgUploadBtn.Click += proImgUploadBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(proImg);
            panel3.Location = new Point(876, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 125);
            panel3.TabIndex = 12;
            // 
            // proImg
            // 
            proImg.BackColor = Color.Gainsboro;
            proImg.Location = new Point(0, 0);
            proImg.Name = "proImg";
            proImg.Size = new Size(103, 125);
            proImg.SizeMode = PictureBoxSizeMode.StretchImage;
            proImg.TabIndex = 0;
            proImg.TabStop = false;
            // 
            // pro_cat
            // 
            pro_cat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_cat.FormattingEnabled = true;
            pro_cat.Location = new Point(141, 116);
            pro_cat.Name = "pro_cat";
            pro_cat.Size = new Size(220, 31);
            pro_cat.TabIndex = 10;
            // 
            // pro_stock
            // 
            pro_stock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_stock.Location = new Point(497, 72);
            pro_stock.Name = "pro_stock";
            pro_stock.Size = new Size(220, 30);
            pro_stock.TabIndex = 9;
            // 
            // pro_price
            // 
            pro_price.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_price.Location = new Point(497, 33);
            pro_price.Name = "pro_price";
            pro_price.Size = new Size(220, 30);
            pro_price.TabIndex = 8;
            // 
            // pro_name
            // 
            pro_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_name.Location = new Point(141, 72);
            pro_name.Name = "pro_name";
            pro_name.Size = new Size(220, 30);
            pro_name.TabIndex = 7;
            // 
            // pro_id
            // 
            pro_id.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pro_id.Location = new Point(141, 33);
            pro_id.Name = "pro_id";
            pro_id.Size = new Size(125, 30);
            pro_id.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 82);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 5;
            label7.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 43);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 4;
            label6.Text = "Price (Rs.):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 127);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 3;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 127);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 82);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 1;
            label3.Text = "Products Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 43);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Products ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(proDataGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 417);
            panel1.TabIndex = 2;
            // 
            // proDataGridView
            // 
            proDataGridView.AllowUserToAddRows = false;
            proDataGridView.AllowUserToDeleteRows = false;
            proDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proDataGridView.Location = new Point(22, 55);
            proDataGridView.Name = "proDataGridView";
            proDataGridView.ReadOnly = true;
            proDataGridView.RowHeadersWidth = 51;
            proDataGridView.RowTemplate.Height = 29;
            proDataGridView.Size = new Size(957, 338);
            proDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 0;
            label1.Text = "All Products";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1049, 756);
            Load += AdminAddProducts_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)proImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)proDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox pro_status;
        private Button proClearBtn;
        private Button proRemoveBtn;
        private Button proUpdateBtn;
        private Button proAddBtn;
        private Button proImgUploadBtn;
        private Panel panel3;
        private PictureBox proImg;
        private ComboBox pro_cat;
        private TextBox pro_stock;
        private TextBox pro_price;
        private TextBox pro_name;
        private TextBox pro_id;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView proDataGridView;
        private Label label1;
    }
}
