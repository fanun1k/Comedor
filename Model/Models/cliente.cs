using System;
using System.Collections.Generic;

namespace Model;

public partial class cliente
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public string paterno { get; set; } = null!;

    public string? materno { get; set; }

    public string? documento { get; set; }

    public DateOnly fecha_ingreso { get; set; }

    public string codigo { get; set; } = null!;

    public byte[]? fotografia { get; set; }

    public string estado { get; set; } = null!;

    public int? tipo { get; set; }

    public virtual ICollection<orden> ordens { get; set; } = new List<orden>();

    public virtual ICollection<registro> registros { get; set; } = new List<registro>();

    public virtual ICollection<snack> snacks { get; set; } = new List<snack>();
}
