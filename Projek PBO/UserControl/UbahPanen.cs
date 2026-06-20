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
           

        }

        private void dgvDataPanen_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            
        }

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            
        }

        // ==========================
        
        private void comboBox2_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Kosongkan saja jika belum digunakan
        }
    }
}