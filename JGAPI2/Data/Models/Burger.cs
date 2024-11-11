using System;
using System.Collections.Generic;

namespace JGAPI2.Data.Models;

public partial class Burger
{
    public int Burgerid { get; set; }

    public string Name { get; set; } = null!;

    public bool Withcheese { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
