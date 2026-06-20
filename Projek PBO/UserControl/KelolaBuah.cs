using System;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class KelolaBuah : BaseUserControl
    {
        public KelolaBuah(string namaPengguna)
            : base(namaPengguna)
        {
            InitializeComponent();
            MuatData();
        }

        public override string GetJudulForm()
        {
            return "Kelola Buah";
        }

        public override void MuatData()
        {
            dgvBuah.Rows.Clear();

            dgvBuah.Rows.Add(
                1,
                "Apel",
                "Kg",
                25000
            );

            dgvBuah.Rows.Add(
                2,
                "Jeruk",
                "Kg",
                18000
            );
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtNamaBuah.Text == "" ||
                txtSatuan.Text == "" ||
                txtHarga.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            dgvBuah.Rows.Add(
                dgvBuah.Rows.Count + 1,
                txtNamaBuah.Text,
                txtSatuan.Text,
                txtHarga.Text
            );

            MessageBox.Show("Data buah berhasil ditambahkan!");

            txtNamaBuah.Clear();
            txtSatuan.Clear();
            txtHarga.Clear();
        }

        private void dgvBuah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Tambahkan ini
        private void lblNamaBuah_Click(object sender, EventArgs e)
        {

        }
    }
}