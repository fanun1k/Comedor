using System;
using System.Collections.Generic;

namespace Model;

public partial class categorium
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public string estado { get; set; } = null!;

    public virtual ICollection<item> items { get; set; } = new List<item>();
}
