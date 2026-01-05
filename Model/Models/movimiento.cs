using System;
using System.Collections.Generic;

namespace Model;

public partial class movimiento
{
    public int id { get; set; }

    public DateOnly fecha { get; set; }

    public TimeOnly hora { get; set; }

    public string detalle { get; set; } = null!;

    public int usuario { get; set; }

    public string estado { get; set; } = null!;

    public virtual usuario usuarioNavigation { get; set; } = null!;
}
