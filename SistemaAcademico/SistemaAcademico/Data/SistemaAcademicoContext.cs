using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistema.Models;

namespace SistemaAcademico.Models
{
    public class SistemaAcademicoContext : DbContext
    {
        public SistemaAcademicoContext (DbContextOptions<SistemaAcademicoContext> options)
            : base(options)
        {
        }

        public DbSet<sistema.Models.Categoria> Categoria { get; set; }
    }
}
