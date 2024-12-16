namespace InventoryManagementSystem
{
    partial class UserManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            userClearBtn = new Button();
            userRemoveBtn = new Button();
            userUpdateBtn = new Button();
            userAddBtn = new Button();
            user_status = new ComboBox();
            label4 = new Label();
            user_role = new ComboBox();
            label3 = new Label();
            user_password = new TextBox();
            label2 = new Label();
            user_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(userClearBtn);
            panel1.Controls.Add(userRemoveBtn);
            panel1.Controls.Add(userUpdateBtn);
            panel1.Controls.Add(userAddBtn);
            panel1.Controls.Add(user_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(user_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(user_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(user_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 723);
            panel1.TabIndex = 0;
            // 
            // userClearBtn
            // 
            userClearBtn.BackColor = Color.FromArgb(2, 122, 74);
            userClearBtn.FlatAppearance.BorderSize = 0;
            userClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            userClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            userClearBtn.FlatStyle = FlatStyle.Flat;
            userClearBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userClearBtn.ForeColor = Color.White;
            userClearBtn.Location = new Point(188, 452);
            userClearBtn.Name = "userClearBtn";
            userClearBtn.Size = new Size(119, 45);
            userClearBtn.TabIndex = 11;
            userClearBtn.Text = "Clear";
            userClearBtn.UseVisualStyleBackColor = false;
            userClearBtn.Click += userClearBtn_Click;
            // 
            // userRemoveBtn
            // 
            userRemoveBtn.BackColor = Color.FromArgb(2, 122, 74);
            userRemoveBtn.FlatAppearance.BorderSize = 0;
            userRemoveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            userRemoveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            userRemoveBtn.FlatStyle = FlatStyle.Flat;
            userRemoveBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userRemoveBtn.ForeColor = Color.White;
            userRemoveBtn.Location = new Point(19, 452);
            userRemoveBtn.Name = "userRemoveBtn";
            userRemoveBtn.Size = new Size(119, 45);
            userRemoveBtn.TabIndex = 10;
            userRemoveBtn.Text = "Remove";
            userRemoveBtn.UseVisualStyleBackColor = false;
            userRemoveBtn.Click += userRemoveBtn_Click;
            // 
            // userUpdateBtn
            // 
            userUpdateBtn.BackColor = Color.FromArgb(2, 122, 74);
            userUpdateBtn.FlatAppearance.BorderSize = 0;
            userUpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            userUpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            userUpdateBtn.FlatStyle = FlatStyle.Flat;
            userUpdateBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userUpdateBtn.ForeColor = Color.White;
            userUpdateBtn.Location = new Point(188, 386);
            userUpdateBtn.Name = "userUpdateBtn";
            userUpdateBtn.Size = new Size(119, 45);
            userUpdateBtn.TabIndex = 9;
            userUpdateBtn.Text = "Update";
            userUpdateBtn.UseVisualStyleBackColor = false;
            userUpdateBtn.Click += userUpdateBtn_Click;
            // 
            // userAddBtn
            // 
            userAddBtn.BackColor = Color.FromArgb(2, 122, 74);
            userAddBtn.FlatAppearance.BorderSize = 0;
            userAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            userAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            userAddBtn.FlatStyle = FlatStyle.Flat;
            userAddBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userAddBtn.ForeColor = Color.White;
            userAddBtn.Location = new Point(19, 386);
            userAddBtn.Name = "userAddBtn";
            userAddBtn.Size = new Size(119, 45);
            userAddBtn.TabIndex = 8;
            userAddBtn.Text = "Add";
            userAddBtn.UseVisualStyleBackColor = false;
            userAddBtn.Click += userAddBtn_Click;
            // 
            // user_status
            // 
            user_status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_status.FormattingEnabled = true;
            user_status.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            user_status.Location = new Point(19, 324);
            user_status.Name = "user_status";
            user_status.Size = new Size(288, 33);
            user_status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 299);
            label4.Name = "label4";
            label4.Size = new Size(49, 22);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // user_role
            // 
            user_role.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_role.FormattingEnabled = true;
            user_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            user_role.Location = new Point(19, 245);
            user_role.Name = "user_role";
            user_role.Size = new Size(288, 33);
            user_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 220);
            label3.Name = "label3";
            label3.Size = new Size(40, 22);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // user_password
            // 
            user_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_password.Location = new Point(19, 166);
            user_password.Name = "user_password";
            user_password.Size = new Size(288, 34);
            user_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // user_username
            // 
            user_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_username.Location = new Point(19, 88);
            user_username.Name = "user_username";
            user_username.Size = new Size(288, 34);
            user_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(350, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 723);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(1, 87, 52);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(641, 656);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(203, 27);
            label5.TabIndex = 12;
            label5.Text = "All User's Details";
            // 
            // UserManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserManage";
            Size = new Size(1049, 756);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox user_status;
        private Label label4;
        private ComboBox user_role;
        private Label label3;
        private TextBox user_password;
        private Label label2;
        private TextBox user_username;
        private Button userClearBtn;
        private Button userRemoveBtn;
        private Button userUpdateBtn;
        private Button userAddBtn;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
