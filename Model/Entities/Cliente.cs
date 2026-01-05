using Microsoft.EntityFrameworkCore;
using Model.Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Cliente
    {
        private readonly AppDbContext _context;

        public Cliente(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene todos los clientes de la base de datos de forma asíncrona.
        /// </summary>
        public List<cliente> ObtenerTodos()
        {
            try
            {
                return _context.Cliente.AsNoTracking().Take(10).ToList();
            }
            catch (Exception)
            { 
                throw;
            }
           
        }
    }
}
