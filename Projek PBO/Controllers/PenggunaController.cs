using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class PenggunaController
    {
        private readonly DatabaseHelpers _db;

        public PenggunaController()
        {
            _db = new DatabaseHelpers();
        }

        public List<Pengguna> GetAll()
        {
            return _db.Penggunas.OrderBy(p => p.IdPengguna).ToList();
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

        public void Hapus(int id)
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