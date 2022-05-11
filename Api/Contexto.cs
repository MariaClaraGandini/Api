using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.Entidades;

namespace Api
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> options)
            //herança Contextp herda de DdContext
            : base(options) { }
        public DbSet<Categoria> CATEGORIAS { get; set; }
            //identifica categoria como entidade
    }
}
