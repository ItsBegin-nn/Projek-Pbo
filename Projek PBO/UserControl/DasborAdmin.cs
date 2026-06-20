using System;
using System.Linq; 
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class DasborAdmin : BaseUserControl
    {
        private readonly DasborAdminController _controller;

        public DasborAdmin(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new DasborAdminController();
        }

        public override void MuatData()
        {
            LblPengguna.Text = _controller.GetTotalPengguna().ToString();
            Lblkebun.Text = _controller.GetTotalKebun().ToString();
            LblBuah.Text = _controller.GetTotalBuah().ToString();
            LblPenjualan.Text = _controller.GetPenjualanBulanIni().ToString("N0");

            var listPanen = _controller.GetPanenTerbaru();

            var dataTampil = listPanen.Select(p => new
            {
                Buah = p.IdBuahNavigation?.NamaBuah ?? "-",
                Kebun = p.IdKebunNavigation?.NamaKebun ?? "-",
                Petani = p.IdPetaniNavigation?.NamaLengkap ?? "-",
                Tanggal = p.TanggalPanen,
                Berat = p.BeratKg
            }).ToList();

            dataGridView1.DataSource = dataTampil;
        }


        public override string GetJudulForm() => "Dasbor";

        private void DasborAdmin_Load(object sender, EventArgs e)
        {
            MuatData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblPenjualan_Click(object sender, EventArgs e)
        {

        }

        
    }
}