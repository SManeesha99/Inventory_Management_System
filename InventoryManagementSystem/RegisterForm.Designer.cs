namespace InventoryManagementSystem
{
    partial class RegisterForm
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
            button1 = new Button();
            panel1 = new Panel();
            register_cb = new CheckBox();
            register_cPassword = new TextBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            registerBtn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            domainUpDown1 = new DomainUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(735, 11);
            button1.Name = "button1";
            button1.Size = new Size(51, 30);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(register_cb);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(171, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 429);
            panel1.TabIndex = 2;
            // 
            // register_cb
            // 
            register_cb.AutoSize = true;
            register_cb.Location = new Point(229, 303);
            register_cb.Name = "register_cb";
            register_cb.Size = new Size(132, 24);
            register_cb.TabIndex = 11;
            register_cb.Text = "Show Password";
            register_cb.TextAlign = ContentAlignment.TopLeft;
            register_cb.UseVisualStyleBackColor = true;
            register_cb.CheckedChanged += register_cb_CheckedChanged;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(122, 257);
            register_cPassword.Multiline = true;
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(239, 32);
            register_cPassword.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.padlock_32;
            pictureBox4.Location = new Point(73, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 129);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 8;
            label2.Text = "Register Account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(262, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign in Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 380);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 6;
            label1.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(2, 122, 74);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            registerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(73, 341);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(288, 36);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(122, 212);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(239, 32);
            register_password.TabIndex = 4;
            // 
            // register_username
            // 
            register_username.Location = new Point(122, 169);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(239, 32);
            register_username.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock_32;
            pictureBox3.Location = new Point(73, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_32;
            pictureBox2.Location = new Point(73, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rb_5856_1_;
            pictureBox1.Location = new Point(171, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(26, 192);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(8, 27);
            domainUpDown1.TabIndex = 4;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 122, 87);
            ClientSize = new Size(800, 518);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button registerBtn;
        private TextBox register_password;
        private TextBox register_username;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox register_cPassword;
        private PictureBox pictureBox4;
        private CheckBox register_cb;
        private DomainUpDown domainUpDown1;
    }
}