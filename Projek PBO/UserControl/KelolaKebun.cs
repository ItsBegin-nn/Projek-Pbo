using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class KelolaKebun : BaseUserControl
    {
        private readonly KebunController _controller;
        private int _selectedId = 0;

        public KelolaKebun(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _controller = new KebunController();

            dataGridView1.CellClick += DataGridView1_CellClick;
            BtnSimpan.Click += BtnSimpan_Click;
            BtnHapus.Click += BtnHapus_Click;

            this.Load += (s, e) => MuatData();
        }

        public override void MuatData()
        {
            dataGridView1.DataSource = _controller.GetAll();

            if (dataGridView1.Columns["Panens"] != null)
                dataGridView1.Columns["Panens"].Visible = false;

            if (dataGridView1.Columns["No"] != null)
                dataGridView1.Columns.Remove("No");

            dataGridView1.Columns.Insert(0, new DataGridViewTextBoxColumn
            {
                Name = "No",
                HeaderText = "No",
                Width = 50,
                ReadOnly = true
            });

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells["No"].Value = i + 1;

            dataGridView1.RowHeadersVisible = false;
        }

        public override string GetJudulForm() => "Kelola Kebun";

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];

            _selectedId = Convert.ToInt32(row.Cells["IdKebun"].Value);
            TbNama.Text = row.Cells["NamaKebun"].Value?.ToString();
            TbLokasi.Text = row.Cells["Lokasi"].Value?.ToString();
            TbLuas.Text = row.Cells["Luas"].Value?.ToString();

            BtnSimpan.Text = "Update";
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbNama.Text))
            {
                MessageBox.Show("Nama kebun wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TbLuas.Text, out decimal luas))
            {
                MessageBox.Show("Luas kebun harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedId == 0)
                {
                    _controller.Tambah(TbNama.Text, TbLokasi.Text, luas);
                    MessageBox.Show("Kebun berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controller.Update(_selectedId, TbNama.Text, TbLokasi.Text, luas);
                    MessageBox.Show("Kebun berhasil diupdate!", "Sukses",
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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih kebun yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var konfirmasi = MessageBox.Show("Yakin ingin menghapus kebun ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.Hapus(_selectedId);
                    MessageBox.Show("Kebun berhasil dihapus!", "Sukses",
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

        private void Bersihkan()
        {
            _selectedId = 0;
            TbNama.Clear();
            TbLokasi.Clear();
            TbLuas.Clear();
            BtnSimpan.Text = "Simpan";
        }

        // event kosong dari Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void Petani_Click(object sender, EventArgs e) { }

        private void TbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnHapus_Click_1(object sender, EventArgs e)
        {

        }
    }
}