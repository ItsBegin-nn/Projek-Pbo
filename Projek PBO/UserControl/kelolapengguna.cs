using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;
using Projek_PBO.Models;

namespace Projek_PBO.Views
{
    public partial class KelolaPengguna : BaseUserControl
    {
        private readonly PenggunaController _controller;
        private int _selectedId = 0;

        public KelolaPengguna(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new PenggunaController();

            comboBox1.Items.AddRange(new string[] { "admin", "petani" });
            comboBox1.SelectedIndex = 0;

            dataGridView1.CellClick += DataGridView1_CellClick;
            BtnSimpan.Click += BtnSimpan_Click;

            // pindah MuatData ke Load
            this.Load += (s, e) => MuatData();
        }

        // OVERRIDE — polymorphism
        public override void MuatData()
        {
            var list = _controller.GetAll();
            dataGridView1.DataSource = list;

            if (dataGridView1.Columns["Panens"] != null)
                dataGridView1.Columns["Panens"].Visible = false;

            // hapus kolom No lama kalau ada, biar tidak dobel
            if (dataGridView1.Columns["No"] != null)
                dataGridView1.Columns.Remove("No");

            // tambah kolom No baru di paling kiri
            dataGridView1.Columns.Insert(0, new DataGridViewTextBoxColumn
            {
                Name = "No",
                HeaderText = "No",
                Width = 50,
                ReadOnly = true
            });

            // isi nomor urut 1, 2, 3...
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["No"].Value = i + 1;
            }
            dataGridView1.RowHeadersVisible = false;
        }

        public override string GetJudulForm() => "Kelola Pengguna";

        // klik baris tabel — isi form input
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];

            _selectedId = Convert.ToInt32(row.Cells["IdPengguna"].Value);
            Tbnama.Text = row.Cells["NamaLengkap"].Value?.ToString();
            Tbpass.Text = row.Cells["Password"].Value?.ToString();
            Tbuser.Text = row.Cells["Username"].Value?.ToString();
            comboBox1.SelectedItem = row.Cells["Role"].Value?.ToString();

            // ganti teks tombol jadi Update
            BtnSimpan.Text = "Update";
        }

        // tombol Simpan/Update
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string nama = Tbnama.Text;
            string pass = Tbpass.Text;
            string user = Tbuser.Text;
            string role = comboBox1.SelectedItem?.ToString() ?? "petani";

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Username dan password wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedId == 0)
                {
                    _controller.Tambah(nama, user, pass, role);
                    MessageBox.Show("Pengguna berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controller.Update(_selectedId, nama, user, pass, role);
                    MessageBox.Show("Pengguna berhasil diupdate!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Bersihkan();
                MuatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersihkan()
        {
            _selectedId = 0;
            Tbnama.Clear();
            Tbpass.Clear();
            Tbuser.Clear();
            comboBox1.SelectedIndex = 0;
            BtnSimpan.Text = "Simpan";
        }

        // event kosong dari Designer
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void Lbpass_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void LbRole_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih pengguna yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus pengguna ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.Hapus(_selectedId);
                    MessageBox.Show("Pengguna berhasil dihapus!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bersihkan();
                    MuatData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}