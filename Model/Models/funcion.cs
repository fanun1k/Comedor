using System;
using System.Collections.Generic;

namespace Model;

public partial class funcion
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public int grupo { get; set; }

    public string estado { get; set; } = null!;

    public virtual grupo_funcion grupoNavigation { get; set; } = null!;
}
