namespace Projek_PBO.Controllers
{
    // ===== KONSEP: INTERFACE =====
    public interface ICrudController<T>
    {
        List<T> GetAll();
        void Hapus(int id);
    }
}