using System;
using System.Linq;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class HapusPanen : BaseUserControl
    {
        private readonly HpsPanenController _controller;
        private int _selectedId = 0;

        public HapusPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new HpsPanenController();

            dataGridView1.CellClick += DataGridView1_CellClick;
            BtnHapus.Click += BtnHapus_Click;

            this.Load += (s, e) => MuatData();
        }

        public override void MuatData()
        {
            var listPanen = _controller.GetAll();

            var dataTampil = listPanen.Select(p => new
            {
                IdPanen = p.IdPanen,
                Buah = p.IdBuahNavigation?.NamaBuah ?? "-",
                Kebun = p.IdKebunNavigation?.NamaKebun ?? "-",
                Petani = p.IdPetaniNavigation?.NamaLengkap ?? "-",
                Tanggal = p.TanggalPanen,
                BeratKg = p.BeratKg,
                Estimasi = p.EstimasiPendapatan
            }).ToList();

            dataGridView1.DataSource = dataTampil;

            if (dataGridView1.Columns["IdPanen"] != null)
                dataGridView1.Columns["IdPanen"].Visible = false;
        }

        public override string GetJudulForm() => "Hapus Panen";

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["IdPanen"].Value);
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data panen yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data panen ini? Data tidak bisa dikembalikan.",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.Hapus(_selectedId);
                    MessageBox.Show("Data panen berhasil dihapus!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _selectedId = 0;
                    MuatData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}