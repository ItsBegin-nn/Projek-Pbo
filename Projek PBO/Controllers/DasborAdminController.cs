using Microsoft.EntityFrameworkCore;
using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class DasborAdminController
    {
        private readonly DatabaseHelpers _db;

        public DasborAdminController()
        {
            _db = new DatabaseHelpers();
        }

        // total pengguna
        public int GetTotalPengguna()
        {
            return _db.Penggunas.Count();
        }

        // total kebun
        public int GetTotalKebun()
        {
            return _db.Kebuns.Count();
        }

        // total jenis buah
        public int GetTotalBuah()
        {
            return _db.Buahs.Count();
        }

        // total penjualan bulan ini
        public decimal GetPenjualanBulanIni()
        {
            var bulanIni = DateTime.Now.Month;
            var tahunIni = DateTime.Now.Year;

            return _db.Penjualans
                .Where(p => p.TanggalPenjualan.Month == bulanIni &&
                            p.TanggalPenjualan.Year == tahunIni)
                .Sum(p => p.TotalPendapatan ?? 0);
        }

        // aktivitas panen terbaru (10 data terakhir)
        public List<Panen> GetPanenTerbaru()
        {
            return _db.Panens
                .Include(p => p.IdBuahNavigation)
                .Include(p => p.IdKebunNavigation)
                .Include(p => p.IdPetaniNavigation)
                .OrderByDescending(p => p.IdPanen)
                .Take(10)
                .ToList();
        }
    }
}