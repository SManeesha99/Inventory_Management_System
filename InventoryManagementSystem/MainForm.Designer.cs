namespace InventoryManagementSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            closeBtn = new Button();
            panel2 = new Panel();
            logoutBtn = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            adminDashBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminCategoriesManage1 = new AdminCategoriesManage();
            userManage1 = new UserManage();
            adminDashboard1 = new AdminDashboard();
            adminAddProducts1 = new AdminAddProducts();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(closeBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 45);
            panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.DarkRed;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderColor = Color.Black;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(1275, 7);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(51, 30);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 122, 74);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(adminDashBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 756);
            panel2.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(12, 704);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(260, 40);
            logoutBtn.TabIndex = 8;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 448);
            button6.Name = "button6";
            button6.Size = new Size(260, 40);
            button6.TabIndex = 7;
            button6.Text = "Customers";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 402);
            button5.Name = "button5";
            button5.Size = new Size(260, 40);
            button5.TabIndex = 6;
            button5.Text = "Products";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 356);
            button4.Name = "button4";
            button4.Size = new Size(260, 40);
            button4.TabIndex = 5;
            button4.Text = "Categories";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 310);
            button3.Name = "button3";
            button3.Size = new Size(260, 40);
            button3.TabIndex = 4;
            button3.Text = "Users";
            button3.UseVisualStyleBackColor = true;
            // 
            // adminDashBtn
            // 
            adminDashBtn.FlatAppearance.BorderSize = 0;
            adminDashBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            adminDashBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            adminDashBtn.FlatStyle = FlatStyle.Flat;
            adminDashBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            adminDashBtn.ForeColor = Color.White;
            adminDashBtn.Location = new Point(12, 264);
            adminDashBtn.Name = "adminDashBtn";
            adminDashBtn.Size = new Size(260, 40);
            adminDashBtn.TabIndex = 3;
            adminDashBtn.Text = "Dashboard";
            adminDashBtn.UseVisualStyleBackColor = true;
            adminDashBtn.Click += adminDashBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 168);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 168);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 1;
            label1.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.administrator_128;
            pictureBox1.Location = new Point(80, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(adminCategoriesManage1);
            panel3.Controls.Add(userManage1);
            panel3.Controls.Add(adminDashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(286, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 756);
            panel3.TabIndex = 2;
            // 
            // adminCategoriesManage1
            // 
            adminCategoriesManage1.Location = new Point(0, 0);
            adminCategoriesManage1.Name = "adminCategoriesManage1";
            adminCategoriesManage1.Size = new Size(1311, 945);
            adminCategoriesManage1.TabIndex = 2;
            adminCategoriesManage1.Load += adminCategoriesManage1_Load;
            // 
            // userManage1
            // 
            userManage1.Location = new Point(0, 0);
            userManage1.Name = "userManage1";
            userManage1.Size = new Size(1311, 945);
            userManage1.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1311, 945);
            adminDashboard1.TabIndex = 0;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1311, 945);
            adminAddProducts1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 801);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button closeBtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button adminDashBtn;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button logoutBtn;
        private Panel panel3;
        private AdminDashboard adminDashboard1;
        private UserManage userManage1;
        private AdminCategoriesManage adminCategoriesManage1;
        private AdminAddProducts adminAddProducts1;
    }
}