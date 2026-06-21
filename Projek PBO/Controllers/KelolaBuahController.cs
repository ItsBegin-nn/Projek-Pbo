using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    // ===== KONSEP: INHERITANCE =====
    public class KelolaBuahController : BaseCrudController<Buah>
    {
        private readonly DatabaseHelpers _db;

        public KelolaBuahController()
        {
            _db = new DatabaseHelpers();
        }

        // ===== KONSEP: OVERRIDING =====
        public override List<Buah> GetAll()
        {
            return _db.Buahs.OrderBy(b => b.IdBuah).ToList();
        }

        // ===== KONSEP: OVERLOADING =====
        public List<Buah> GetAll(string keyword)
        {
            return _db.Buahs
                .Where(b => b.NamaBuah.Contains(keyword))
                .OrderBy(b => b.IdBuah)
                .ToList();
        }

        public void Tambah(string nama, string satuan, int harga)
        {
            _db.Buahs.Add(new Buah
            {
                NamaBuah = nama,
                Satuan = satuan,
                Harga = harga,
                Stock = 0
            });
            _db.SaveChanges();
        }

        public void Update(int id, string nama, string satuan, int harga)
        {
            var b = _db.Buahs.Find(id);
            if (b == null) return;
            b.NamaBuah = nama;
            b.Satuan = satuan;
            b.Harga = harga;
            _db.SaveChanges();
        }

        // ===== KONSEP: OVERRIDING =====
        public override void Hapus(int id)
        {
            var b = _db.Buahs.Find(id);
            if (b != null)
            {
                _db.Buahs.Remove(b);
                _db.SaveChanges();
            }
        }
    }
}