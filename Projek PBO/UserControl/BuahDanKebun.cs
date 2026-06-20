using System;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class BuahDanKebun : BaseUserControl
    {
        public BuahDanKebun(string namaPengguna)
            : base(namaPengguna)
        {
            InitializeComponent();
            MuatData();
        }

        public override string GetJudulForm()
        {
            return "Buah Dan Kebun";
        }

        public override void MuatData()
        {
            LoadDataKebun();
            LoadDataBuah();
        }

        private void LoadDataKebun()
        {
            dvgKebun.Rows.Clear();

            dvgKebun.Rows.Add(
                1,
                "Kebun Apel",
                "Malang",
                2.5
            );

            dvgKebun.Rows.Add(
                2,
                "Kebun Jeruk",
                "Batu",
                1.8
            );
        }

        private void LoadDataBuah()
        {
            dvgBuah.Rows.Clear();

            dvgBuah.Rows.Add(
                "Apel",
                "120 Kg",
                "20/06/2026"
            );

            dvgBuah.Rows.Add(
                "Jeruk",
                "80 Kg",
                "18/06/2026"
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuatData();

            MessageBox.Show(
                "Data berhasil diperbarui!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dvgKebun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgBuah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbKebun_Enter(object sender, EventArgs e)
        {

        }

        private void gbBuah_Enter(object sender, EventArgs e)
        {

        }
    }
}