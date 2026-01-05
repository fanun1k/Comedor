using System;
using System.Collections.Generic;

namespace Model;

public partial class snack
{
    public int id { get; set; }

    public int? usuario { get; set; }

    public int? cliente { get; set; }

    public int item { get; set; }

    public DateOnly fecha { get; set; }

    public TimeOnly hora { get; set; }

    public double precio { get; set; }

    public int cantidad { get; set; }

    public double total { get; set; }

    public string tipo { get; set; } = null!;

    public string estado { get; set; } = null!;

    public int? orden { get; set; }

    public bool contado { get; set; }

    public virtual cliente? clienteNavigation { get; set; }

    public virtual item itemNavigation { get; set; } = null!;

    public virtual orden? ordenNavigation { get; set; }

    public virtual usuario? usuarioNavigation { get; set; }
}
