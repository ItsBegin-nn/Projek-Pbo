using System;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class UbahPanen : BaseUserControl
    {
        private int idPanenDipilih = 0;

        public UbahPanen(string namaPengguna)
            : base(namaPengguna)
        {
            InitializeComponent();

            MuatData();
        }

        public override string GetJudulForm()
        {
            return "Ubah Panen";
        }

        public override void MuatData()
        {
            // Isi ComboBox Buah
            cbBuah.Items.Clear();
            cbBuah.Items.Add("Apel");
            cbBuah.Items.Add("Jeruk");
            cbBuah.Items.Add("Mangga");

            // Isi ComboBox Kebun
            cbKebun.Items.Clear();
            cbKebun.Items.Add("Kebun Apel");
            cbKebun.Items.Add("Kebun Jeruk");
            cbKebun.Items.Add("Kebun Mangga");

            // Isi DataGridView Data Panen
            dgvDataPanen.Rows.Clear();

            dgvDataPanen.Rows.Add(
                1,
                "Apel",
                "Kebun Apel",
                "20/06/2026",
                "120",
                "3000000"
            );

            dgvDataPanen.Rows.Add(
                2,
                "Jeruk",
                "Kebun Jeruk",
                "18/06/2026",
                "80",
                "1800000"
            );
        }

        private void dgvDataPanen_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvDataPanen.Rows[e.RowIndex];

                idPanenDipilih =
                    Convert.ToInt32(row.Cells[0].Value);

                cbBuah.Text =
                    row.Cells[1].Value?.ToString();

                cbKebun.Text =
                    row.Cells[2].Value?.ToString();

                dtpTanggalPanen.Value =
                    Convert.ToDateTime(row.Cells[3].Value);

                txtBerat.Text =
                    row.Cells[4].Value?.ToString();

                txtHarga.Text =
                    row.Cells[5].Value?.ToString();
            }
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (idPanenDipilih == 0)
            {
                MessageBox.Show(
                    "Pilih data panen terlebih dahulu!");
                return;
            }

            MessageBox.Show(
                "Data panen berhasil diubah!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            cbBuah.SelectedIndex = -1;
            cbKebun.SelectedIndex = -1;

            txtBerat.Clear();
            txtHarga.Clear();

            dtpTanggalPanen.Value =
                DateTime.Now;

            idPanenDipilih = 0;
        }

        // ==========================
        // TAMBAHKAN METHOD INI
        // ==========================
        private void comboBox2_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Kosongkan saja jika belum digunakan
        }
    }
}