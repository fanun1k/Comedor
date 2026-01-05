using System;
using System.Collections.Generic;

namespace Model;

public partial class planificador
{
    public int id { get; set; }

    public DateOnly fecha { get; set; }

    public bool ciclico { get; set; }

    public int usuario { get; set; }

    public string estado { get; set; } = null!;

    public virtual ICollection<horario> horarios { get; set; } = new List<horario>();

    public virtual usuario usuarioNavigation { get; set; } = null!;
}
