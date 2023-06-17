using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Entity;

namespace Projeto_DA.Modelos
{
    public class ApplicationContext: DbContext
    {
            public DbSet<Cinema> Cinemas { get; set; }
            public DbSet<Sala> Salas { get; set; }
            public DbSet<Sessao> Sessoes { get; set; }
            public DbSet<Filme> Filmes { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Bilhete> Bilhetes { get; set; }
            public DbSet<Funcionario> Funcionarios { get; set; }
            public DbSet<Cliente> Clientes { get; set; }

            
    }
}
