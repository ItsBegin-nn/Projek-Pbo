using System;
using System.Linq;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class UbahPanen : BaseUserControl
    {
        private readonly UbahPanenController _controller;
        private readonly int _idPetani;
        private int _idPanenDipilih = 0;
        private bool _sedangMemuatData = false;

        public UbahPanen(string namaPengguna, int idPetani) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new UbahPanenController();
            _idPetani = idPetani;


            txtHarga.ReadOnly = true;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            txtBerat.TextChanged += TxtBerat_TextChanged;

            this.Load += (s, e) =>
            {
                MuatData();
                MessageBox.Show(
                    $"idPetani: {_idPetani}\n" +
                    $"Jumlah data panen ditemukan: {comboBox1.Items.Count}\n" +
                    $"txtBerat.ReadOnly: {txtBerat.ReadOnly}\n" +
                    $"txtBerat.Enabled: {txtBerat.Enabled}\n" +
                    $"cbBuah.Enabled: {cbBuah.Enabled}");
            };
        }

        public override string GetJudulForm() => "Ubah Panen";

        public override void MuatData()
        {
            _sedangMemuatData = true;

            var listPanen = _controller.GetPanenByPetani(_idPetani);

            var dataTampil = listPanen.Select(p => new
            {
                IdPanen = p.IdPanen,
                Label = $"Panen #{p.IdPanen} - {p.TanggalPanen:dd-MM-yyyy} ({p.IdBuahNavigation?.NamaBuah})"
            }).ToList();

            comboBox1.DataSource = dataTampil;
            comboBox1.DisplayMember = "Label";
            comboBox1.ValueMember = "IdPanen";
            comboBox1.SelectedIndex = -1;

            _sedangMemuatData = false;
            KosongkanForm();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_sedangMemuatData) return;
            if (comboBox1.SelectedValue == null) return;

            _idPanenDipilih = Convert.ToInt32(comboBox1.SelectedValue);

            var panen = _controller.GetById(_idPanenDipilih);
            if (panen == null) return;

            cbBuah.Text = panen.IdBuahNavigation?.NamaBuah ?? "-";
            cbKebun.Text = panen.IdKebunNavigation?.NamaKebun ?? "-";
            dtpTanggalPanen.Value = panen.TanggalPanen.ToDateTime(TimeOnly.MinValue);
            txtBerat.Text = panen.BeratKg.ToString();
            txtHarga.Text = panen.EstimasiPendapatan?.ToString("N2") ?? "0";
        }

        private void TxtBerat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_idPanenDipilih == 0)
            {
                MessageBox.Show("Pilih data panen terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBerat.Text, out decimal beratBaru))
            {
                MessageBox.Show("Berat (kg) harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var tanggal = DateOnly.FromDateTime(dtpTanggalPanen.Value);
                _controller.UbahPanen(_idPanenDipilih, tanggal, beratBaru);

                MessageBox.Show("Data panen berhasil diubah!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            KosongkanForm();
        }

        private void KosongkanForm()
        {
            cbBuah.Text = "";
            cbKebun.Text = "";
            txtBerat.Clear();
            txtHarga.Clear();
            dtpTanggalPanen.Value = DateTime.Now;
            _idPanenDipilih = 0;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}