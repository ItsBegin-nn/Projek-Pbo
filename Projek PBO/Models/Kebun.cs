using System;
using System.Collections.Generic;

namespace Projek_PBO.Models;



public partial class Kebun
{
    public int IdKebun {  get; set; }

    public string NamaKebun { get; set; }

    public string? Lokasi {  get; set; }

    public decimal? Luas { get; set; }

    public virtual ICollection<Panen> Panens { get; set; } = new List<Panen>();
}
