using System;
using System.Collections.Generic;

namespace Projek_PBO.Models;

public partial class Pengguna
{
    public int IdPengguna { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? NamaLengkap { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<Panen> Panens { get; set; } = new List<Panen>();
}
