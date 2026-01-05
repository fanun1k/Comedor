using System;
using System.Collections.Generic;

namespace Model;

public partial class menu_item
{
    public int menu { get; set; }

    public int item { get; set; }

    public double? precio { get; set; }

    public string? descripcion { get; set; }

    public string estado { get; set; } = null!;

    public virtual item itemNavigation { get; set; } = null!;

    public virtual menu menuNavigation { get; set; } = null!;
}
