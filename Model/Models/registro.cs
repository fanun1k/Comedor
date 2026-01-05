using System;
using System.Collections.Generic;

namespace Model;

public partial class registro
{
    public int id { get; set; }

    public int cliente { get; set; }

    public DateOnly fecha { get; set; }

    public TimeOnly hora { get; set; }

    public string turno { get; set; } = null!;

    public string cuenta { get; set; } = null!;

    public int cantidad { get; set; }

    public string tipo { get; set; } = null!;

    public string estado { get; set; } = null!;

    public virtual cliente clienteNavigation { get; set; } = null!;
}
