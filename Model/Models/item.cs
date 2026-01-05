using System;
using System.Collections.Generic;

namespace Model;

public partial class item
{
    public int id { get; set; }

    public string nombre { get; set; } = null!;

    public string? descripcion { get; set; }

    public double precio { get; set; }

    public int categoria { get; set; }

    public int? stock { get; set; }

    public byte[]? imagen { get; set; }

    public string estado { get; set; } = null!;

    public virtual categorium categoriaNavigation { get; set; } = null!;

    public virtual ICollection<snack> snacks { get; set; } = new List<snack>();
}
