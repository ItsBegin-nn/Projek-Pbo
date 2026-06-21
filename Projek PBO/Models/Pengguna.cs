using Projek_PBO.Models;

public partial class Pengguna
{
    public int IdPengguna { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? NamaLengkap { get; set; }
    public string Role { get; set; } = null!;

    public virtual ICollection<Panen> Panens { get; set; } = new List<Panen>();

    // ===== KONSEP: ENKAPSULASI =====
    // Password tidak dibandingkan langsung dari luar class, tapi lewat method ini
    public bool VerifikasiPassword(string inputPassword)
    {
        if (string.IsNullOrWhiteSpace(inputPassword)) return false;
        return Password == inputPassword;
    }

    public bool IsAdmin() => Role == "admin";
    public bool IsPetani() => Role == "petani";
}