using Projek_PBO.Controllers;
using Projek_PBO.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projek_PBO
{
    public partial class Login : Form
    {
        private readonly AuthController _authController;
        public Login()
        {
            InitializeComponent();
            TBpass.UseSystemPasswordChar = true;
            _authController = new AuthController();
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
                MessageBox.Show("Masukkan username dan password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var pengguna = _authController.Login(user, pass);

                if (pengguna == null)
                {
                    MessageBox.Show("Username atau password salah!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pengguna.IsAdmin())
                {
                    new dashboard_admin(pengguna.NamaLengkap ?? pengguna.Username).Show();
                    this.Hide();
                }
                else if (pengguna.IsPetani())
                {
                    new dashboard_petani(pengguna.NamaLengkap ?? pengguna.Username, pengguna.IdPengguna).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal konek database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
