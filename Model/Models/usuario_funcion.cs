using System;
using System.Collections.Generic;

namespace Model;

public partial class usuario_funcion
{
    public int usuario { get; set; }

    public int funcion { get; set; }

    public string estado { get; set; } = null!;

    public virtual funcion funcionNavigation { get; set; } = null!;

    public virtual usuario usuarioNavigation { get; set; } = null!;
}
