using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class FilmeController
    {
        public static void AdicionarFilme(string nome, TimeSpan duracao, string categoria, Boolean ativo)
        {
            using (var db = new ApplicationContext())
            {
				var categoriaObj = db.Categorias.FirstOrDefault(c => c.Nome == categoria);
                if (categoriaObj != null)
                {
                    return;
                }

				var filme = new Filme { Nome = nome, Duracao = duracao, Categoria = categoria, Ativo = ativo };
                db.Filmes.Add(filme);
                db.SaveChanges();
            }
        }

        public static List<Filme> GetFilmes()
        {
            using (var db = new ApplicationContext())
            {
                return db.Filmes.ToList();
            }
        }
    }
}
