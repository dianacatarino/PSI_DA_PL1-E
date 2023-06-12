using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class FilmeController
    {
        public static void AdicionarFilme(string nome, TimeSpan duracao, Categoria categoria, Boolean ativo)
        {
			using (var db = new ApplicationContext())
			{
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

		public static Filme GetFilme(string filme)
		{
			using (var db = new ApplicationContext())
			{
				return db.Filmes.Where(c => c.Nome == filme).FirstOrDefault();
			}
		}

		public static void AlterarFilme(int filmeId, string novoNome, TimeSpan novaDuracao, Categoria novaCategoria, Boolean novoAtivo)
		{
			using (var db = new ApplicationContext())
			{
				var filme = db.Filmes.Find(filmeId);
				if (filme != null)
				{
					filme.Nome = novoNome;
					filme.Duracao = novaDuracao;
					filme.Categoria = novaCategoria;
					filme.Ativo = novoAtivo;
					db.SaveChanges();
				}
			}
		}
	}
}
