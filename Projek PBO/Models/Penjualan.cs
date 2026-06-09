using System;
using System.Collections.Generic;

namespace Projek_PBO.Models;

public partial class Penjualan
{
    public int IdPenjualan { get; set; }

    public int IdPanen { get; set; }

    public DateOnly TanggalPenjualan { get; set; }

    public string? NamaPembeli { get; set; }

    public decimal HargaJual { get; set; }

    public decimal? TotalPendapatan { get; set; }

    public virtual Panen IdPanenNavigation { get; set; } = null!;
}
