using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Models;
using SistemaAcademico.Models;

namespace SistemaAcademico.Data
{
    //crea la base de datos o inicializa
    public class DbInitializer
    {
        public static void Initialier(SistemaAcademicoContext context)
        {
            context.Database.EnsureCreated();//cre la base de datos
            //buscar si existen registros  en la tabla categoria
            if (context.Categoria.Any()) {//si hay categorias solo retorna eso y ya
                return; 
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programación",Descripcion="Cursos de Asp.-net",Estado=true},
                new Categoria{Nombre="Diseño",Descripcion="Diseño grafico",Estado=true},
                new Categoria{Nombre="Reparación ",Descripcion="Reparacion de celulares",Estado=true}
            };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
