using System.Data;
using Npgsql;

namespace Projek_PBO.Controllers
{
    public class RiwayatPenjualanController
    {
        string connString = "Host=localhost;Port=5432;Database=Projek PBO;Username=postgres;Password=FATH354";

        public DataTable GetRiwayat()
        {
            DataTable dt = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = @"SELECT 
                               pj.id_penjualan,
                               pj.tanggal_penjualan,
                               pj.nama_pembeli,
                               b.nama_buah,
                               pn.berat_kg,
                               pj.harga_jual,
                               pj.total_pendapatan
                           FROM penjualan pj
                           JOIN panen pn ON pj.id_panen = pn.id_panen
                           JOIN buah b ON pn.id_buah = b.id_buah
                           ORDER BY pj.id_panen asc";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}