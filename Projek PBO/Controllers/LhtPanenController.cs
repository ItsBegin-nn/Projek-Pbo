using System;
using System.Data;
using Npgsql;

namespace Projek_PBO.Controllers
{
    public class LhtPanenController
    {
        string connString = "Host=localhost;Port=5432;Database=Projek PBO;Username=postgres;Password=FATH354";

        // ambil semua data panen buat ditampilin di tabel
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = @"SELECT 
                               p.id_panen,
                               p.tanggal_panen,
                               p.berat_kg,
                               p.estimasi_pendapatan,
                               b.nama_buah,
                               k.nama_kebun,
                               pg.nama_lengkap AS nama_petani
                           FROM panen p
                           JOIN buah b ON p.id_buah = b.id_buah
                           JOIN kebun k ON p.id_kebun = k.id_kebun
                           JOIN pengguna pg ON p.id_petani = pg.id_pengguna
                           ORDER BY p.id_panen ASC";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}