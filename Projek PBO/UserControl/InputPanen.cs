using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class InputPanen : BaseUserControl
    {
        private readonly InputPanenController _controller;
        private readonly int _idPetani;

        public InputPanen(string namaPengguna, int idPetani) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new InputPanenController();
            _idPetani = idPetani;

            CbBuah.DataSource = _controller.GetAllBuah();
            CbBuah.DisplayMember = "NamaBuah";
            CbBuah.ValueMember = "IdBuah";
            CbBuah.SelectedIndex = -1;

            CbKebun.DataSource = _controller.GetAllKebun();
            CbKebun.DisplayMember = "NamaKebun";
            CbKebun.ValueMember = "IdKebun";
            CbKebun.SelectedIndex = -1;

            Tanggal.Value = DateTime.Now;

            BtnSimpan.Click += BtnSimpan_Click;
            TbBerat.TextChanged += HitungEstimasi;
            TbHarga.TextChanged += HitungEstimasi;

            // ← tambah ini — hanya boleh angka dan titik desimal
            TbBerat.KeyPress += HanyaAngka_KeyPress;
            TbHarga.KeyPress += HanyaAngka_KeyPress;
        }

        // validasi hanya angka dan satu titik desimal
        private void HanyaAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // izinkan angka, backspace, dan satu titik desimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // cegah lebih dari satu titik desimal
            if (e.KeyChar == '.' && tb.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Input Panen";

        private void HitungEstimasi(object sender, EventArgs e)
        {
            if (decimal.TryParse(TbBerat.Text, out decimal berat) &&
                decimal.TryParse(TbHarga.Text, out decimal harga))
            {
                decimal total = berat * harga;
                Lblestimasi.Text = total.ToString("N0");
            }
            else
            {
                Lblestimasi.Text = "0";
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (CbBuah.SelectedValue == null || CbKebun.SelectedValue == null)
            {
                MessageBox.Show("Pilih buah dan kebun terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbBerat.Text) || string.IsNullOrWhiteSpace(TbHarga.Text))
            {
                MessageBox.Show("Berat dan harga wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TbBerat.Text, out decimal berat) ||
                !decimal.TryParse(TbHarga.Text, out decimal harga))
            {
                MessageBox.Show("Berat dan harga harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idBuah = Convert.ToInt32(CbBuah.SelectedValue);
                int idKebun = Convert.ToInt32(CbKebun.SelectedValue);
                decimal estimasi = berat * harga;
                var tanggal = DateOnly.FromDateTime(Tanggal.Value);

                _controller.TambahPanen(idBuah, idKebun, _idPetani, tanggal, berat, estimasi);

                MessageBox.Show("Data panen berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersihkan()
        {
            CbBuah.SelectedIndex = -1;
            CbKebun.SelectedIndex = -1;
            TbBerat.Clear();
            TbHarga.Clear();
            Lblestimasi.Text = "0";
            Tanggal.Value = DateTime.Now;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void InputPanen_Load_1(object sender, EventArgs e) { }
    }
}