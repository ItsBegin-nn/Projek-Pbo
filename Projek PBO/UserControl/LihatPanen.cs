using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class LihatPanen : BaseUserControl
    {
        PanenController controller = new PanenController();

        public LihatPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData()
        {
            try
            {
                dataGridView1.DataSource = controller.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data panen: " + ex.Message);
            }
        }

        public override string GetJudulForm() => "Lihat Panen";
    }
}