using Projek_PBO.Controllers;
using System;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class UbahPanen : BaseUserControl
    {
        // Semua akses database lewat Controller ini, tidak ada SQL di file UI
        private readonly PanenController panenController = new PanenController();

        // Pemetaan komponen (sesuai Designer):
        //   comboBox1       -> Pilih data panen yang diubah (value = id_panen)
        //   cbBuah          -> Nama buah (tampilan saja, tidak bisa diganti)
        //   cbKebun         -> Nama kebun (tampilan saja, tidak bisa diganti)
        //   dtpTanggalPanen -> Tanggal panen (bisa diedit)
        //   txtBerat        -> Berat (kg) (bisa diedit)
        //   txtHarga        -> Estimasi pendapatan = berat x harga per kg (otomatis, read-only)
        //   btnSave         -> Simpan perubahan
        //   btnCancel       -> Batal / kosongkan form

        private int idPanenDipilih = 0;
        private decimal hargaPerKgBuahTerpilih = 0;
        private bool sedangMemuatData = false;

        public UbahPanen(string namaPengguna)
            : base(namaPengguna)
        {
            InitializeComponent();

            cbBuah.Enabled = false;
            cbKebun.Enabled = false;
            txtHarga.ReadOnly = true;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            MuatData();
        }

        public override string GetJudulForm()
        {
            return "Ubah Panen";
        }

        public override void MuatData()
        {
            try
            {
                sedangMemuatData = true;

                var dt = panenController.AmbilDaftarPanenUntukComboBox();

                // Urutan WAJIB seperti ini: DataSource dulu, baru DisplayMember/ValueMember.
                // Kalau dibalik, SelectedValue akan mengembalikan DataRowView mentah,
                // bukan nilai kolom id_panen -> menyebabkan InvalidCastException.
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "label_panen";
                comboBox1.ValueMember = "id_panen";
                comboBox1.SelectedIndex = -1;

                sedangMemuatData = false;
            }
            catch (Exception ex)
            {
                sedangMemuatData = false;
                MessageBox.Show("Gagal memuat data panen: " + ex.Message);
            }

            KosongkanForm();
        }

        // ---- Pilihan ComboBox berubah -> isi field-field di bawah ----
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sedangMemuatData) return;
            if (comboBox1.SelectedIndex == -1) return;
            if (comboBox1.SelectedValue == null) return;
            if (!(comboBox1.SelectedValue is int)) return;

            idPanenDipilih = (int)comboBox1.SelectedValue;

            try
            {
                var detail = panenController.AmbilDetailPanen(idPanenDipilih);
                if (detail == null)
                {
                    MessageBox.Show("Data panen tidak ditemukan.");
                    return;
                }

                cbBuah.Text = detail.NamaBuah;
                cbKebun.Text = detail.NamaKebun;
                dtpTanggalPanen.Value = detail.TanggalPanen;
                txtBerat.Text = detail.BeratKg.ToString();

                hargaPerKgBuahTerpilih = detail.HargaPerKg;
                txtHarga.Text = (detail.BeratKg * hargaPerKgBuahTerpilih).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil detail panen: " + ex.Message);
            }
        }

        // ---- Saat berat diketik ulang, hitung ulang estimasi pendapatan ----
        private void txtBerat_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBerat.Text, out decimal beratBaru))
            {
                txtHarga.Text = (beratBaru * hargaPerKgBuahTerpilih).ToString("N2");
            }
        }

        // ===== BUTTON SAVE =====
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (idPanenDipilih == 0)
            {
                MessageBox.Show("Pilih data panen terlebih dahulu!");
                return;
            }

            if (!decimal.TryParse(txtBerat.Text, out decimal beratBaru))
            {
                MessageBox.Show("Berat (kg) harus berupa angka.");
                return;
            }

            decimal estimasiBaru = beratBaru * hargaPerKgBuahTerpilih;

            try
            {
                panenController.UbahDataPanen(
                    idPanenDipilih,
                    dtpTanggalPanen.Value,
                    beratBaru,
                    estimasiBaru);

                MessageBox.Show(
                    "Data panen berhasil diubah!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MuatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan perubahan: " + ex.Message);
            }
        }

        // ===== BUTTON CANCEL =====
        private void btnCancel_Click(object sender, EventArgs e)
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
            idPanenDipilih = 0;
            hargaPerKgBuahTerpilih = 0;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}