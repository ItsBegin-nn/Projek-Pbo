using Microsoft.EntityFrameworkCore;
using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class UbahPanenController
    {
        private readonly DatabaseHelpers _db;

        public UbahPanenController()
        {
            _db = new DatabaseHelpers();
        }

        public List<Panen> GetPanenByPetani(int idPetani)
        {
            return _db.Panens
                .Include(p => p.IdBuahNavigation)
                .Include(p => p.IdKebunNavigation)
                .Where(p => p.IdPetani == idPetani)
                .OrderByDescending(p => p.IdPanen)
                .ToList();
        }

        public Panen? GetById(int idPanen)
        {
            return _db.Panens
                .Include(p => p.IdBuahNavigation)
                .Include(p => p.IdKebunNavigation)
                .FirstOrDefault(p => p.IdPanen == idPanen);
        }

        public void UbahPanen(int idPanen, DateOnly tanggalBaru, decimal beratBaru)
        {
            var panen = _db.Panens.Find(idPanen);
            if (panen == null) return;

            decimal beratLama = panen.BeratKg;
            decimal selisih = beratBaru - beratLama;

            var buah = _db.Buahs.Find(panen.IdBuah);

            panen.TanggalPanen = tanggalBaru;
            panen.BeratKg = beratBaru;

            if (buah != null)
            {
                panen.EstimasiPendapatan = beratBaru * buah.Harga;
                buah.Stock += (int)selisih; 
            }

            _db.SaveChanges();
        }
    }
}