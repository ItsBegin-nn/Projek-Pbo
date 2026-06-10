using System;
using System.Collections.Generic;
using System.Text;
using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class AuthController
    {
        private readonly DatabaseHelpers _db;

        public AuthController()
        {
            _db = new DatabaseHelpers();
        }

        public Pengguna? Login(string username, string password)
        {
            // cari dulu by username
            var pengguna = _db.Penggunas
                .FirstOrDefault(p => p.Username == username);

            if (pengguna == null) return null;

            // verifikasi password lewat method, bukan akses langsung
            return pengguna.VerifikasiPassword(password) ? pengguna : null;
        }
    }
}
