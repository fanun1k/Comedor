using System;
using System.Collections.Generic;

namespace Model;

public partial class menu
{
    public int id { get; set; }

    public DateOnly fecha { get; set; }

    public int? horario { get; set; }

    public string estado { get; set; } = null!;

    public virtual horario? horarioNavigation { get; set; }
}
