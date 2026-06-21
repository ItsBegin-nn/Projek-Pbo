using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class dashboard_admin : Form
    {
        protected string NamaPengguna { get; set; }
        private Panel panelKonten;

        public dashboard_admin()
        {
            InitializeComponent();

        }

        public dashboard_admin(string namaPengguna) : this()
        {
            NamaPengguna = namaPengguna;
        }

        protected void dashboard_admin_Load(object sender, EventArgs e)
        {
            panelKonten = new Panel
            {
                Location = new Point(175, 0),
                Size = new Size(this.ClientSize.Width - 175, this.ClientSize.Height),
                BackColor = Color.Transparent
            };
            this.Controls.Add(panelKonten);
            panelKonten.BringToFront();
            
            AktifkanTombol(BtnDasbor);
            
            MuatKonten(new DasborAdmin(NamaPengguna), BtnDasbor);
        }

        public virtual void MuatData() { }
        public virtual string GetJudulForm() => "Dashboard Admin";

        private void AktifkanTombol(Button tombolAktif)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                    btn.Region = null;
                }
            }
            tombolAktif.BackColor = Color.White;
            tombolAktif.ForeColor = Color.Black;
            tombolAktif.Region = new Region(GetRoundedRect(tombolAktif.ClientRectangle, 20));
        }

        protected GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected void MuatKonten(BaseUserControl konten, Button tombolAktif)
        {
            panelKonten.Controls.Clear();
            konten.Dock = DockStyle.Fill;
            konten.MuatData();
            panelKonten.Controls.Add(konten);
            AktifkanTombol(tombolAktif);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            MuatKonten(new DasborAdmin(NamaPengguna), BtnDasbor);
        }

        protected void BtnKelolaUser_Click(object sender, EventArgs e)
        {
            MuatKonten(new KelolaPengguna(NamaPengguna), BtnKelolaUser);
        }

        protected void BtnKelolaBuah_Click(object sender, EventArgs e)
        {
            MuatKonten(new KelolaBuah(NamaPengguna), BtnKelolaBuah);
        }

        protected void BtnKelolaPenjualan_Click(object sender, EventArgs e)
        {
            MuatKonten(new KelolaPenjualan(NamaPengguna), BtnKelolaPenjualan);
        }

        protected void BtnKelolaKebun_Click(object sender, EventArgs e)
        {
            MuatKonten(new KelolaKebun(NamaPengguna), BtnKelolaKebun);
        }

        protected void BtnLihatPanen_Click(object sender, EventArgs e)
        {
            MuatKonten(new LihatPanen(NamaPengguna), BtnLihatPanen);
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}