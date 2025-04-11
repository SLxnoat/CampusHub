namespace CampusHub
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbLoginUser.Text.Trim();
            string password = tbLoginPw.Text.Trim();

            if(username == "admin" && password == "admin123")
            {
                this.Hide();

                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
