using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class KebunController
    {
        private readonly DatabaseHelpers _db;

        public KebunController()
        {
            _db = new DatabaseHelpers();
        }

        public List<Kebun> GetAll()
        {
            return _db.Kebuns.OrderBy(k => k.IdKebun).ToList();
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

        public void Hapus(int id)
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