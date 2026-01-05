using System;
using System.Collections.Generic;

namespace Model;

public partial class despacho
{
    public int id { get; set; }

    public int orden { get; set; }

    public int usuario { get; set; }

    public TimeOnly hora { get; set; }

    public DateOnly fecha { get; set; }

    public string estado { get; set; } = null!;

    public virtual orden ordenNavigation { get; set; } = null!;

    public virtual usuario usuarioNavigation { get; set; } = null!;
}
