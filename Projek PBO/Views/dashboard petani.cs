using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class dashboard_petani : Form
    {
        protected string NamaPengguna { get; set; }
        protected int IdPengguna { get; set; }
        private Panel panelKonten;

        public dashboard_petani()
        {
            InitializeComponent();

            panelKonten = new Panel
            {
                Location = new Point(175, 0),
                Size = new Size(this.ClientSize.Width - 175, this.ClientSize.Height),
                BackColor = Color.Transparent
            };
            this.Controls.Add(panelKonten);
            panelKonten.BringToFront();
        }

        public dashboard_petani(string namaPengguna, int idPengguna) : this()
        {
            NamaPengguna = namaPengguna;
            IdPengguna = idPengguna;

            MuatKonten(new DasborPetani(NamaPengguna, IdPengguna), BtnDasbor);
        }

        protected void dashboard_admin_Load(object sender, EventArgs e)
        {
            AktifkanTombol(BtnDasbor);
        }

        public virtual void MuatData() { }
        public virtual string GetJudulForm() => "Dashboard Petani";

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

        protected void button1_Click(object sender, EventArgs e)
        {
            MuatKonten(new DasborPetani(NamaPengguna, IdPengguna), BtnDasbor);
        }

        protected void BtnBuken_Click(object sender, EventArgs e)
        {
            MuatKonten(new BuahDanKebun(NamaPengguna), BtnBuken);
        }

        protected void BtnInPan_Click(object sender, EventArgs e)
        {
            MuatKonten(new InputPanen(NamaPengguna, IdPengguna), BtnInPan);
        }

        protected void BtnBapan_Click(object sender, EventArgs e)
        {
            MuatKonten(new UbahPanen(NamaPengguna, IdPengguna), BtnBapan);
        }

        protected void BtnHapen_Click(object sender, EventArgs e)
        {
            MuatKonten(new HapusPanen(NamaPengguna), BtnHapen);
        }

        protected void BtnRipen_Click(object sender, EventArgs e)
        {
            MuatKonten(new RiwayatPenjualan(NamaPengguna), BtnRipen);
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}