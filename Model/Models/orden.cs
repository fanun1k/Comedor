using System;
using System.Collections.Generic;

namespace Model;

public partial class orden
{
    public int id { get; set; }

    public DateOnly fecha { get; set; }

    public TimeOnly hora { get; set; }

    public double monto { get; set; }

    public double? descuento { get; set; }

    public int? documento { get; set; }

    public int cliente { get; set; }

    public int? usuario { get; set; }

    public string estado { get; set; } = null!;

    public virtual cliente clienteNavigation { get; set; } = null!;

    public virtual ICollection<despacho> despachos { get; set; } = new List<despacho>();

    public virtual documento? documentoNavigation { get; set; }

    public virtual ICollection<snack> snacks { get; set; } = new List<snack>();

    public virtual usuario? usuarioNavigation { get; set; }
}
