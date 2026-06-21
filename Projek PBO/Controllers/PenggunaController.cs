using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    // ===== KONSEP: INHERITANCE =====
    // Mewarisi BaseCrudController, otomatis juga memenuhi ICrudController<Pengguna>
    public class PenggunaController : BaseCrudController<Pengguna>
    {
        private readonly DatabaseHelpers _db;

        public PenggunaController()
        {
            _db = new DatabaseHelpers();
        }

        // ===== KONSEP: OVERRIDING =====
        // Wajib diisi karena GetAll() abstract di BaseCrudController
        public override List<Pengguna> GetAll()
        {
            return _db.Penggunas.OrderBy(p => p.IdPengguna).ToList();
        }

        // ===== KONSEP: OVERLOADING =====
        // Nama method sama (GetAll), parameter beda (ada keyword pencarian)
        public List<Pengguna> GetAll(string keyword)
        {
            return _db.Penggunas
                .Where(p => p.Username.Contains(keyword) ||
                            (p.NamaLengkap != null && p.NamaLengkap.Contains(keyword)))
                .OrderBy(p => p.IdPengguna)
                .ToList();
        }

        public void Tambah(string nama, string username, string password, string role)
        {
            _db.Penggunas.Add(new Pengguna
            {
                NamaLengkap = nama,
                Username = username,
                Password = password,
                Role = role
            });
            _db.SaveChanges();
        }

        public void Update(int id, string nama, string username, string password, string role)
        {
            var p = _db.Penggunas.Find(id);
            if (p == null) return;
            p.NamaLengkap = nama;
            p.Username = username;
            p.Password = password;
            p.Role = role;
            _db.SaveChanges();
        }

        // ===== KONSEP: OVERRIDING =====
        public override void Hapus(int id)
        {
            var p = _db.Penggunas.Find(id);
            if (p != null)
            {
                _db.Penggunas.Remove(p);
                _db.SaveChanges();
            }
        }
    }
}