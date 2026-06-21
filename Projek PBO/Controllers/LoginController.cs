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
            var pengguna = _db.Penggunas
                .FirstOrDefault(p => p.Username == username);

            if (pengguna == null) return null;

            return pengguna.VerifikasiPassword(password) ? pengguna : null;
        }
    }
}
