
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using Model.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public partial class Item
    {

        private readonly AppDbContext _context;

        public Item(AppDbContext context)
        {
            _context = context;
        }

        public byte[] Imagen { get; set; }
        

        public List<item> GetByAll()
        {
            string estado = Estado.ACTIVO.ToString();

            return _context.Item.AsNoTracking().Take(10).ToList();
        }
    }
}
