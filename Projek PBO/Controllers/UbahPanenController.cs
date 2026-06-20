using Npgsql;
using System;
using System.Data;

namespace Projek_PBO.Controllers
{
    // Menyimpan detail satu data panen untuk ditampilkan/diedit di form
    public class PanenDetail
    {
        public int IdPanen { get; set; }
        public DateTime TanggalPanen { get; set; }
        public decimal BeratKg { get; set; }
        public string NamaBuah { get; set; } = "";
        public string NamaKebun { get; set; } = "";
        public decimal HargaPerKg { get; set; }
    }

    // Controller khusus untuk semua operasi database terkait tabel panen
    public class PanenController
    {
        private readonly string connString =
            "Host=localhost;Port=5432;Database=Projek PBO;Username=postgres;Password=Nay!130408";

        // Mengambil daftar panen untuk ditampilkan di ComboBox (id + label gabungan)
        public DataTable AmbilDaftarPanenUntukComboBox()
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            var da = new NpgsqlDataAdapter(
                @"SELECT p.id_panen,
                         'Panen #' || p.id_panen || ' - ' ||
                         TO_CHAR(p.tanggal_panen, 'DD-MM-YYYY') ||
                         ' (' || b.nama_buah || ')' AS label_panen
                  FROM panen p
                  JOIN buah b ON p.id_buah = b.id_buah
                  ORDER BY p.tanggal_panen DESC", conn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Mengambil detail satu panen (termasuk nama buah, kebun, dan harga per kg)
        public PanenDetail AmbilDetailPanen(int idPanen)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            var cmd = new NpgsqlCommand(
                @"SELECT p.tanggal_panen, p.berat_kg,
                         b.nama_buah, b.harga AS harga_per_kg,
                         k.nama_kebun
                  FROM panen p
                  JOIN buah b ON p.id_buah = b.id_buah
                  JOIN kebun k ON p.id_kebun = k.id_kebun
                  WHERE p.id_panen = @id", conn);
            cmd.Parameters.AddWithValue("@id", idPanen);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            var tanggalRaw = reader["tanggal_panen"];
            DateTime tanggal = (tanggalRaw is DateOnly d)
                ? d.ToDateTime(TimeOnly.MinValue)
                : Convert.ToDateTime(tanggalRaw);

            return new PanenDetail
            {
                IdPanen = idPanen,
                TanggalPanen = tanggal,
                BeratKg = Convert.ToDecimal(reader["berat_kg"]),
                NamaBuah = reader["nama_buah"].ToString(),
                NamaKebun = reader["nama_kebun"].ToString(),
                HargaPerKg = Convert.ToDecimal(reader["harga_per_kg"])
            };
        }

        // Mengubah data panen (tanggal, berat, dan estimasi pendapatan)
        public void UbahDataPanen(int idPanen, DateTime tanggalBaru, decimal beratBaru, decimal estimasiPendapatanBaru)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            var cmd = new NpgsqlCommand(
                @"UPDATE panen SET
                    tanggal_panen = @tgl,
                    berat_kg = @berat,
                    estimasi_pendapatan = @estimasi
                  WHERE id_panen = @id", conn);
            cmd.Parameters.AddWithValue("@tgl", DateOnly.FromDateTime(tanggalBaru));
            cmd.Parameters.AddWithValue("@berat", beratBaru);
            cmd.Parameters.AddWithValue("@estimasi", estimasiPendapatanBaru);
            cmd.Parameters.AddWithValue("@id", idPanen);
            cmd.ExecuteNonQuery();
        }
    }
}