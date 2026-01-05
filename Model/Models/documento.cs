using System;
using System.Collections.Generic;

namespace Model;

public partial class documento
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public string estado { get; set; } = null!;

    public virtual ICollection<orden> ordens { get; set; } = new List<orden>();
}
