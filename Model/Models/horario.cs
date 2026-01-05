using System;
using System.Collections.Generic;

namespace Model;

public partial class horario
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public TimeOnly hora_inicio { get; set; }

    public TimeOnly hora_fin { get; set; }

    public int? planificador { get; set; }

    public string estado { get; set; } = null!;

    public virtual ICollection<menu> menus { get; set; } = new List<menu>();

    public virtual planificador? planificadorNavigation { get; set; }
}
