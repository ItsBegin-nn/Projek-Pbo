using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class RiwayatPenjualan : BaseUserControl
    {
        RiwayatPenjualanController controller = new RiwayatPenjualanController();

        public RiwayatPenjualan(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData()
        {
            try
            {
                dataGridView1.DataSource = controller.GetRiwayat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat penjualan: " + ex.Message);
            }
        }

        public override string GetJudulForm() => "Riwayat Penjualan";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}