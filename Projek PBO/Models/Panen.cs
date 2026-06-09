using System;
using System.Collections.Generic;

namespace Projek_PBO.Models;

public partial class Panen
{
    public int IdPanen { get; set; }

    public int IdBuah { get; set; }

    public int IdKebun { get; set; }

    public int IdPetani { get; set; }

    public DateOnly TanggalPanen { get; set; }

    public decimal BeratKg { get; set; }

    public decimal? EstimasiPendapatan { get; set; }

    public virtual Buah IdBuahNavigation { get; set; } = null!;

    public virtual Kebun IdKebunNavigation { get; set; } = null!;

    public virtual Pengguna IdPetaniNavigation { get; set; } = null!;

    public virtual ICollection<Penjualan> Penjualans { get; set; } = new List<Penjualan>();
}
