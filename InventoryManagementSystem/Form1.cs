namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 741)
            {
                timer1.Stop();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}