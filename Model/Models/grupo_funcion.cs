using System;
using System.Collections.Generic;

namespace Model;

public partial class grupo_funcion
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public bool visible { get; set; }

    public string estado { get; set; } = null!;

    public virtual ICollection<funcion> funcions { get; set; } = new List<funcion>();
}
