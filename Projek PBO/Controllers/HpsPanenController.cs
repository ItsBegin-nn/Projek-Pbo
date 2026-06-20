using Microsoft.EntityFrameworkCore;
using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class HpsPanenController
    {
        private readonly DatabaseHelpers _db;

        public HpsPanenController()
        {
            _db = new DatabaseHelpers();
        }

        public List<Panen> GetAll()
        {
            return _db.Panens
                .Include(p => p.IdBuahNavigation)
                .Include(p => p.IdKebunNavigation)
                .Include(p => p.IdPetaniNavigation)
                .OrderBy(p => p.IdPanen)
                .ToList();
        }

        public void Hapus(int id)
        {
            var p = _db.Panens.Find(id);
            if (p != null)
            {
                _db.Panens.Remove(p);
                _db.SaveChanges();
            }
        }
    }
}