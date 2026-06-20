using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class KelolaBuah : BaseUserControl
    {
        private readonly KelolaBuahController _controller;
        private int _selectedId = 0;

        public KelolaBuah(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new KelolaBuahController();

            dgvBuah.AutoGenerateColumns = false;
            dgvBuah.CellClick += DgvBuah_CellClick;
            btnTambah.Click += BtnTambah_Click;

            colId.DataPropertyName = "IdBuah";
            colNama.DataPropertyName = "NamaBuah";
            ColSatuan.DataPropertyName = "Satuan";
            ColHarga.DataPropertyName = "Harga";

            this.Load += (s, e) => MuatData();
        }

        public override void MuatData()
        {
            dgvBuah.DataSource = _controller.GetAll();
        }

        public override string GetJudulForm() => "Kelola Buah";

        private void DgvBuah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBuah.Rows[e.RowIndex];

            _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
            txtNamaBuah.Text = row.Cells["colNama"].Value?.ToString();
            txtSatuan.Text = row.Cells["ColSatuan"].Value?.ToString();
            txtHarga.Text = row.Cells["ColHarga"].Value?.ToString();

            btnTambah.Text = "Update";
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaBuah.Text) ||
                string.IsNullOrWhiteSpace(txtSatuan.Text))
            {
                MessageBox.Show("Nama buah dan satuan wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHarga.Text, out int harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedId == 0)
                {
                    _controller.Tambah(txtNamaBuah.Text, txtSatuan.Text, harga);
                    MessageBox.Show("Buah berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controller.Update(_selectedId, txtNamaBuah.Text, txtSatuan.Text, harga);
                    MessageBox.Show("Buah berhasil diupdate!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Bersihkan();
                MuatData();
            }
            catch (Exception ex)
            {
                string pesan = ex.Message;
                if (ex.InnerException != null)
                    pesan += "\n\nDetail: " + ex.InnerException.Message;

                MessageBox.Show("Error: " + pesan, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void Bersihkan()
        {
            _selectedId = 0;
            txtNamaBuah.Clear();
            txtSatuan.Clear();
            txtHarga.Clear();
            btnTambah.Text = "Tambah";
        }

        private void lblNamaBuah_Click(object sender, EventArgs e) { }
    }
}