namespace Projek_PBO.Models;

public partial class Pengguna
{
    public int IdPengguna { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!; // EF Core baca/tulis normal
    public string? NamaLengkap { get; set; }
    public string Role { get; set; } = null!;

    public virtual ICollection<Panen> Panens { get; set; } = new List<Panen>();

    // ===========================
    // ENKAPSULASI : lewat method
    // ===========================

    // Password tidak diakses langsung, tapi diverifikasi lewat method ini
    public bool VerifikasiPassword(string inputPassword)
    {
        if (string.IsNullOrWhiteSpace(inputPassword)) return false;
        return Password == inputPassword;
    }

    // Validasi role disembunyikan di dalam class
    public bool IsAdmin() => Role == "admin";
    public bool IsPetani() => Role == "petani";

    // Cek apakah pengguna valid (tidak perlu akses field satu-satu dari luar)
    public bool IsValid() =>
        !string.IsNullOrWhiteSpace(Username) &&
        !string.IsNullOrWhiteSpace(Password) &&
        (Role == "admin" || Role == "petani");
}