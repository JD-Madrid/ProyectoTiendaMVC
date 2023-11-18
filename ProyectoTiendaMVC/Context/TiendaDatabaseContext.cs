using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoTiendaMVC.Models;

using System.Collections.Generic;
namespace ProyectoTiendaMVC.Context
{
    public class TiendaDatabaseContext : DbContext
    {
        public TiendaDatabaseContext(DbContextOptions<TiendaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
    }
}

