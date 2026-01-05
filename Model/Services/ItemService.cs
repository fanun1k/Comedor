
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using Model.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class ItemService
    {

        private readonly AppDbContext _context;

        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        public byte[] Imagen { get; set; } = Array.Empty<byte>();



        public List<item> GetByAll()
        {
            string estado = Estado.ACTIVO.ToString();

            // Trae todos los registros con estado "ACTIVO" y los ordena por nombre
            return _context.Item
                .AsNoTracking()                   // No tracking para consultas de solo lectura
                .Where(x => x.estado == estado)   // Filtra activos
                .OrderBy(x => x.nombre)           // Ordena por nombre
                .ToList();
        }
    }
}
