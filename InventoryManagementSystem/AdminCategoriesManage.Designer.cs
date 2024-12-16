namespace InventoryManagementSystem
{
    partial class AdminCategoriesManage
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
            panel2 = new Panel();
            catDataGridView = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            catClearBtn = new Button();
            catRemoveBtn = new Button();
            catUpdateBtn = new Button();
            catAddBtn = new Button();
            category = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)catDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(catDataGridView);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(354, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 723);
            panel2.TabIndex = 3;
            // 
            // catDataGridView
            // 
            catDataGridView.AllowUserToAddRows = false;
            catDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(1, 87, 52);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            catDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            catDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            catDataGridView.Location = new Point(16, 54);
            catDataGridView.Name = "catDataGridView";
            catDataGridView.ReadOnly = true;
            catDataGridView.RowHeadersVisible = false;
            catDataGridView.RowHeadersWidth = 51;
            catDataGridView.RowTemplate.Height = 29;
            catDataGridView.Size = new Size(641, 656);
            catDataGridView.TabIndex = 13;
            catDataGridView.CellClick += catDataGridView_CellClick;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(catClearBtn);
            panel1.Controls.Add(catRemoveBtn);
            panel1.Controls.Add(catUpdateBtn);
            panel1.Controls.Add(catAddBtn);
            panel1.Controls.Add(category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 723);
            panel1.TabIndex = 2;
            // 
            // catClearBtn
            // 
            catClearBtn.BackColor = Color.FromArgb(2, 122, 74);
            catClearBtn.FlatAppearance.BorderSize = 0;
            catClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            catClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            catClearBtn.FlatStyle = FlatStyle.Flat;
            catClearBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            catClearBtn.ForeColor = Color.White;
            catClearBtn.Location = new Point(188, 220);
            catClearBtn.Name = "catClearBtn";
            catClearBtn.Size = new Size(119, 45);
            catClearBtn.TabIndex = 11;
            catClearBtn.Text = "Clear";
            catClearBtn.UseVisualStyleBackColor = false;
            catClearBtn.Click += catClearBtn_Click;
            // 
            // catRemoveBtn
            // 
            catRemoveBtn.BackColor = Color.FromArgb(2, 122, 74);
            catRemoveBtn.FlatAppearance.BorderSize = 0;
            catRemoveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            catRemoveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            catRemoveBtn.FlatStyle = FlatStyle.Flat;
            catRemoveBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            catRemoveBtn.ForeColor = Color.White;
            catRemoveBtn.Location = new Point(19, 220);
            catRemoveBtn.Name = "catRemoveBtn";
            catRemoveBtn.Size = new Size(119, 45);
            catRemoveBtn.TabIndex = 10;
            catRemoveBtn.Text = "Remove";
            catRemoveBtn.UseVisualStyleBackColor = false;
            catRemoveBtn.Click += catRemoveBtn_Click;
            // 
            // catUpdateBtn
            // 
            catUpdateBtn.BackColor = Color.FromArgb(2, 122, 74);
            catUpdateBtn.FlatAppearance.BorderSize = 0;
            catUpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            catUpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            catUpdateBtn.FlatStyle = FlatStyle.Flat;
            catUpdateBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            catUpdateBtn.ForeColor = Color.White;
            catUpdateBtn.Location = new Point(188, 154);
            catUpdateBtn.Name = "catUpdateBtn";
            catUpdateBtn.Size = new Size(119, 45);
            catUpdateBtn.TabIndex = 9;
            catUpdateBtn.Text = "Update";
            catUpdateBtn.UseVisualStyleBackColor = false;
            catUpdateBtn.Click += catUpdateBtn_Click;
            // 
            // catAddBtn
            // 
            catAddBtn.BackColor = Color.FromArgb(2, 122, 74);
            catAddBtn.FlatAppearance.BorderSize = 0;
            catAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 52);
            catAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 52);
            catAddBtn.FlatStyle = FlatStyle.Flat;
            catAddBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            catAddBtn.ForeColor = Color.White;
            catAddBtn.Location = new Point(19, 154);
            catAddBtn.Name = "catAddBtn";
            catAddBtn.Size = new Size(119, 45);
            catAddBtn.TabIndex = 8;
            catAddBtn.Text = "Add";
            catAddBtn.UseVisualStyleBackColor = false;
            catAddBtn.Click += catAddBtn_Click;
            // 
            // category
            // 
            category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            category.Location = new Point(19, 88);
            category.Name = "category";
            category.Size = new Size(288, 34);
            category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 63);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // AdminCategoriesManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminCategoriesManage";
            Size = new Size(1049, 756);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)catDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView catDataGridView;
        private Label label5;
        private Panel panel1;
        private Button catClearBtn;
        private Button catRemoveBtn;
        private Button catUpdateBtn;
        private Button catAddBtn;
        private TextBox category;
        private Label label1;
    }
}
