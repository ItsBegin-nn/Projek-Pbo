using System;
using System.Collections.Generic;

namespace Projek_PBO.Models;

public partial class Buah
{
    public int IdBuah { get; set; }

    public string NamaBuah { get; set; } = null!;

    public string Satuan { get; set; } = null!;

    public int Harga { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<Panen> Panens { get; set; } = new List<Panen>();
}
