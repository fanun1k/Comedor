using System;
using System.Collections.Generic;

namespace Model;

public partial class orden_item
{
    public int orden { get; set; }

    public int item { get; set; }

    public double? precio { get; set; }

    public string estado { get; set; } = null!;

    public virtual item itemNavigation { get; set; } = null!;

    public virtual orden ordenNavigation { get; set; } = null!;
}
