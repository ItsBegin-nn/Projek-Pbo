using Projek_PBO.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projek_PBO
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
            username = "admin123";
            password = "admin123";
            TBpass.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TBuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TBuser.Text;
            string pass = TBpass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Boss Masukan user sama passnya ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (user == username && pass == password)
            {
                MessageBox.Show("Silahkan Masuk Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard_admin DbAdmin1 = new dashboard_admin();
                DbAdmin1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("salah pass ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
