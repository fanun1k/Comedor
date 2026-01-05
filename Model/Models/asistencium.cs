using System;
using System.Collections.Generic;

namespace Model;

public partial class asistencium
{
    public int id { get; set; }

    public int usuario { get; set; }

    public DateOnly fecha_ingreso { get; set; }

    public TimeOnly hora_ingreso { get; set; }

    public DateOnly? fecha_salida { get; set; }

    public TimeOnly? hora_salida { get; set; }

    public string tipo { get; set; } = null!;

    public string estado { get; set; } = null!;

    public virtual usuario usuarioNavigation { get; set; } = null!;
}
