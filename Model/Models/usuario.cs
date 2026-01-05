using System;
using System.Collections.Generic;

namespace Model;

public partial class usuario
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public string paterno { get; set; } = null!;

    public string? materno { get; set; }

    public string login { get; set; } = null!;

    public string password { get; set; } = null!;

    public string? documento { get; set; }

    public byte[]? fotografia { get; set; }

    public string estado { get; set; } = null!;

    public DateOnly? fecha_ingreso { get; set; }

    public DateOnly? fecha_nacimiento { get; set; }

    public string? cargo { get; set; }

    public virtual ICollection<asistencium> asistencia { get; set; } = new List<asistencium>();

    public virtual ICollection<despacho> despachos { get; set; } = new List<despacho>();

    public virtual ICollection<movimiento> movimientos { get; set; } = new List<movimiento>();

    public virtual ICollection<orden> ordens { get; set; } = new List<orden>();

    public virtual ICollection<planificador> planificadors { get; set; } = new List<planificador>();

    public virtual ICollection<snack> snacks { get; set; } = new List<snack>();
}
