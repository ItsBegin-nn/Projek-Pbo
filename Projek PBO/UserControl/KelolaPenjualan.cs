using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class KelolaPenjualan : BaseUserControl
    {
        private readonly string connString =
            "Host=localhost;Port=5432;Database=Projek PBO;Username=postgres;Password=FATH354";

        private int idPenjualanTerpilih = 0;

        public KelolaPenjualan(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        public override string GetJudulForm() => "Kelola Penjualan";

        public override void MuatData()
        {
            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                var da = new NpgsqlDataAdapter(
                    @"SELECT id_panen,
                             'Panen #' || id_panen || ' - ' ||
                             TO_CHAR(tanggal_panen, 'DD-MM-YYYY') ||
                             ' (' || berat_kg || ' kg)' AS label_panen
                      FROM panen ORDER BY tanggal_panen DESC", conn);
                var dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "label_panen";
                comboBox1.ValueMember = "id_panen";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat panen: " + ex.Message); }

            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                var da = new NpgsqlDataAdapter(
                    @"SELECT id_penjualan, id_panen, tanggal_penjualan,
                             nama_pembeli, harga_jual, total_pendapatan
                      FROM penjualan ORDER BY id_penjualan ASC", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat riwayat: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Lengkapi semua data dulu.");
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal hargaPerKg))
            {
                MessageBox.Show("Harga jual harus angka.");
                return;
            }

            int idPanen = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmdKg = new NpgsqlCommand(
                    "SELECT COALESCE(berat_kg, 0) FROM panen WHERE id_panen = @id", conn);
                cmdKg.Parameters.AddWithValue("@id", idPanen);
                decimal jumlahKg = Convert.ToDecimal(cmdKg.ExecuteScalar());
                decimal total = hargaPerKg * jumlahKg;

                if (idPenjualanTerpilih == 0)
                {
                    var cmd = new NpgsqlCommand(
                        @"INSERT INTO penjualan
                          (id_panen, tanggal_penjualan, nama_pembeli, harga_jual, total_pendapatan)
                          VALUES (@panen, @tgl, @pembeli, @harga, @total)", conn);
                    cmd.Parameters.AddWithValue("@panen", idPanen);
                    cmd.Parameters.AddWithValue("@tgl", DateOnly.FromDateTime(dateTimePicker1.Value));
                    cmd.Parameters.AddWithValue("@pembeli", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", hargaPerKg);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    var cmd = new NpgsqlCommand(
                        @"UPDATE penjualan SET
                            id_panen = @panen,
                            tanggal_penjualan = @tgl,
                            nama_pembeli = @pembeli,
                            harga_jual = @harga,
                            total_pendapatan = @total
                          WHERE id_penjualan = @id", conn);
                    cmd.Parameters.AddWithValue("@panen", idPanen);
                    cmd.Parameters.AddWithValue("@tgl", DateOnly.FromDateTime(dateTimePicker1.Value));
                    cmd.Parameters.AddWithValue("@pembeli", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", hargaPerKg);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@id", idPenjualanTerpilih);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Data tersimpan. Total pendapatan: {total:N2}");
                MuatData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang mau dihapus dulu.");
                return;
            }

            int idPenjualan = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_penjualan"].Value);

            if (MessageBox.Show("Yakin hapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "DELETE FROM penjualan WHERE id_penjualan = @id", conn);
                cmd.Parameters.AddWithValue("@id", idPenjualan);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data dihapus.");
                MuatData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            idPenjualanTerpilih = Convert.ToInt32(row.Cells["id_penjualan"].Value);
            comboBox1.SelectedValue = row.Cells["id_panen"].Value;
            textBox1.Text = row.Cells["nama_pembeli"].Value?.ToString();
            textBox2.Text = row.Cells["harga_jual"].Value?.ToString();

            if (row.Cells["tanggal_penjualan"].Value != DBNull.Value)
            {
                var nilaiTgl = row.Cells["tanggal_penjualan"].Value;
                dateTimePicker1.Value = (nilaiTgl is DateOnly d)
                    ? d.ToDateTime(TimeOnly.MinValue)
                    : Convert.ToDateTime(nilaiTgl);
            }
        }

        private void ResetForm()
        {
            idPenjualanTerpilih = 0;
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}