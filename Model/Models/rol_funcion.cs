using System;
using System.Collections.Generic;

namespace Model;

public partial class rol_funcion
{
    public int rol { get; set; }

    public int funcion { get; set; }

    public string estado { get; set; } = null!;

    public virtual funcion funcionNavigation { get; set; } = null!;

    public virtual rol rolNavigation { get; set; } = null!;
}
