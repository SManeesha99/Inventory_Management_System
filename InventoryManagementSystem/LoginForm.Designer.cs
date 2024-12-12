namespace InventoryManagementSystem
{
    partial class LoginForm
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
            login_cb = new CheckBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            loginBtn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(login_cb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(173, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 429);
            panel1.TabIndex = 0;
            // 
            // login_cb
            // 
            login_cb.AutoSize = true;
            login_cb.Location = new Point(229, 284);
            login_cb.Name = "login_cb";
            login_cb.Size = new Size(132, 24);
            login_cb.TabIndex = 12;
            login_cb.Text = "Show Password";
            login_cb.TextAlign = ContentAlignment.TopLeft;
            login_cb.UseVisualStyleBackColor = true;
            login_cb.CheckedChanged += login_cb_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(151, 156);
            label2.Name = "label2";
            label2.Size = new Size(146, 24);
            label2.TabIndex = 8;
            label2.Text = "Login Account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(244, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 380);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 6;
            label1.Text = "Have no account yet?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(2, 122, 74);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(73, 328);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(288, 36);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(122, 246);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(239, 32);
            login_password.TabIndex = 4;
            // 
            // login_username
            // 
            login_username.Location = new Point(122, 199);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(239, 32);
            login_username.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock_32;
            pictureBox3.Location = new Point(73, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_32;
            pictureBox2.Location = new Point(73, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rb_5856_1_;
            pictureBox1.Location = new Point(171, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(737, 12);
            button1.Name = "button1";
            button1.Size = new Size(51, 30);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 122, 74);
            ClientSize = new Size(800, 518);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox login_password;
        private TextBox login_username;
        private PictureBox pictureBox3;
        private Button button1;
        private Button loginBtn;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private CheckBox login_cb;
    }
}