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
				// Verifica se a categoria já existe na base de dados
				Categoria categoriaExistente = db.Categorias.FirstOrDefault(c => c.Id == categoria.Id);

				if (categoriaExistente != null)
				{
					// Atualiza a referência para a categoria existente
					categoria = categoriaExistente;
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

		public static Filme GetFilme(string filme)
		{
			using (var db = new ApplicationContext())
			{
				return db.Filmes.Where(c => c.Nome == filme).FirstOrDefault();
			}
		}

		public static void AlterarFilme(int filmeId, string novoNome, TimeSpan novaDuracao, Categoria novaCategoria, bool novoAtivo)
		{
			using (var db = new ApplicationContext())
			{
				var filme = db.Filmes.Find(filmeId);

				if (filme != null)
				{
					// Verifica se a categoria já existe na base de dados
					Categoria categoriaExistente = db.Categorias.FirstOrDefault(c => c.Id == novaCategoria.Id);

					if (categoriaExistente != null)
					{
						// Atualiza a referência para a categoria existente
						filme.Categoria = categoriaExistente;
					}
					else
					{
						// Se a categoria não existir, carrega a categoria original do filme
						db.Entry(filme).Reference(f => f.Categoria).Load();
						filme.Categoria.Nome = novaCategoria.Nome;
					}

					// Atualiza os outros campos do filme
					filme.Nome = novoNome;
					filme.Duracao = novaDuracao;
					filme.Ativo = novoAtivo;

					db.SaveChanges();
				}
			}
		}

		public static void RemoverFilme(int filmeId)
		{
			using (var db = new ApplicationContext())
			{
				var filme = db.Filmes.Find(filmeId);
				if (filme != null)
				{
					db.Filmes.Remove(filme);
					db.SaveChanges();
				}
			}
		}
	}
}
