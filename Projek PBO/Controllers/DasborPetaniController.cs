using Microsoft.EntityFrameworkCore;
using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class DasborPetaniController
    {
        private readonly DatabaseHelpers _db;

        public DasborPetaniController()
        {
            _db = new DatabaseHelpers();
        }

        public int GetTotalKebun(int idPetani)
        {
            return _db.Panens
                .Where(p => p.IdPetani == idPetani)
                .Select(p => p.IdKebun)
                .Distinct()
                .Count();
        }

        public int GetTotalBuah(int idPetani)
        {
            return _db.Panens
                .Where(p => p.IdPetani == idPetani)
                .Select(p => p.IdBuah)
                .Distinct()
                .Count();
        }

        public decimal GetPanenBulanIni(int idPetani)
        {
            var bulanIni = DateTime.Now.Month;
            var tahunIni = DateTime.Now.Year;

            return _db.Panens
                .Where(p => p.IdPetani == idPetani &&
                            p.TanggalPanen.Month == bulanIni &&
                            p.TanggalPanen.Year == tahunIni)
                .Sum(p => p.BeratKg);
        }

        public List<Panen> GetPanenTerbaru(int idPetani)
        {
            return _db.Panens
                .Where(p => p.IdPetani == idPetani)
                .Include(p => p.IdBuahNavigation)
                .Include(p => p.IdKebunNavigation)
                .OrderByDescending(p => p.IdPanen)
                .Take(10)
                .ToList();
        }
    }
}