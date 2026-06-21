using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    // ===== KONSEP: INHERITANCE =====
    public class KebunController : BaseCrudController<Kebun>
    {
        private readonly DatabaseHelpers _db;

        public KebunController()
        {
            _db = new DatabaseHelpers();
        }

        // ===== KONSEP: OVERRIDING =====
        public override List<Kebun> GetAll()
        {
            return _db.Kebuns.OrderBy(k => k.IdKebun).ToList();
        }

        // ===== KONSEP: OVERLOADING =====
        public List<Kebun> GetAll(string keyword)
        {
            return _db.Kebuns
                .Where(k => k.NamaKebun.Contains(keyword) ||
                            (k.Lokasi != null && k.Lokasi.Contains(keyword)))
                .OrderBy(k => k.IdKebun)
                .ToList();
        }

        public void Tambah(string nama, string lokasi, decimal luas)
        {
            _db.Kebuns.Add(new Kebun
            {
                NamaKebun = nama,
                Lokasi = lokasi,
                Luas = luas
            });
            _db.SaveChanges();
        }

        public void Update(int id, string nama, string lokasi, decimal luas)
        {
            var k = _db.Kebuns.Find(id);
            if (k == null) return;
            k.NamaKebun = nama;
            k.Lokasi = lokasi;
            k.Luas = luas;
            _db.SaveChanges();
        }

        // ===== KONSEP: OVERRIDING =====
        public override void Hapus(int id)
        {
            var k = _db.Kebuns.Find(id);
            if (k != null)
            {
                _db.Kebuns.Remove(k);
                _db.SaveChanges();
            }
        }
    }
}