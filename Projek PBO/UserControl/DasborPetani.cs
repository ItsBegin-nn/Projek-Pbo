using System;
using System.Linq;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class DasborPetani : BaseUserControl
    {
        private readonly DasborPetaniController _controller;
        private readonly int _idPetani;

        public DasborPetani(string namaPengguna, int idPetani) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new DasborPetaniController();
            _idPetani = idPetani;
        }
        // POLYMORPHISM
        public override void MuatData()
        {
            label1.Text = _controller.GetTotalKebun(_idPetani).ToString();
            label2.Text = _controller.GetTotalBuah(_idPetani).ToString();
            label3.Text = _controller.GetPanenBulanIni(_idPetani).ToString("N0");

            var listPanen = _controller.GetPanenTerbaru(_idPetani);

            var dataTampil = listPanen.Select(p => new
            {
                Buah = p.IdBuahNavigation?.NamaBuah ?? "-",
                Kebun = p.IdKebunNavigation?.NamaKebun ?? "-",
                Tanggal = p.TanggalPanen,
                BeratKg = p.BeratKg
            }).ToList();

            dataGridView1.DataSource = dataTampil;
        }

        public override string GetJudulForm() => "Dasbor Petani";
    }
}