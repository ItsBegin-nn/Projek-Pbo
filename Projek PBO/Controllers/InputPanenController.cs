using Projek_PBO.Helpers;
using Projek_PBO.Models;

namespace Projek_PBO.Controllers
{
    public class InputPanenController
    {
        private readonly DatabaseHelpers _db;

        public InputPanenController()
        {
            _db = new DatabaseHelpers();
        }

        public List<Buah> GetAllBuah()
        {
            return _db.Buahs.OrderBy(b => b.NamaBuah).ToList();
        }

        public List<Kebun> GetAllKebun()
        {
            return _db.Kebuns.OrderBy(k => k.NamaKebun).ToList();
        }

        public void TambahPanen(int idBuah, int idKebun, int idPetani, DateOnly tanggal, decimal beratKg, decimal estimasi)
        {
            _db.Panens.Add(new Panen
            {
                IdBuah = idBuah,
                IdKebun = idKebun,
                IdPetani = idPetani,
                TanggalPanen = tanggal,
                BeratKg = beratKg,
                EstimasiPendapatan = estimasi
            });
            _db.SaveChanges();
        }
    }
}