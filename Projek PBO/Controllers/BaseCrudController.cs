namespace Projek_PBO.Controllers
{
    // ===== KONSEP: ABSTRACT CLASS =====
    
    public abstract class BaseCrudController<T> : ICrudController<T>
    {
        
        public abstract List<T> GetAll();
        public abstract void Hapus(int id);

        
        public bool IsKosong(List<T> data)
        {
            return data == null || data.Count == 0;
        }

        public int Hitung(List<T> data)
        {
            return data?.Count ?? 0;
        }
    }
}