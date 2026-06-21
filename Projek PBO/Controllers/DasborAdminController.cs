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

        public int GetTotalPengguna()
        {
            return _db.Penggunas.Count();
        }

      
        public int GetTotalKebun()
        {
            return _db.Kebuns.Count();
        }

        public int GetTotalBuah()
        {
            return _db.Buahs.Count();
        }

        public decimal GetPenjualanBulanIni()
        {
            var bulanIni = DateTime.Now.Month;
            var tahunIni = DateTime.Now.Year;

            return _db.Penjualans
                .Where(p => p.TanggalPenjualan.Month == bulanIni &&
                            p.TanggalPenjualan.Year == tahunIni)
                .Sum(p => p.TotalPendapatan ?? 0);
        }

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