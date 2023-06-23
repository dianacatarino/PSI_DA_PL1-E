using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class CategoriaController
    {
        public static void AdicionarCategoria(string nome, Boolean ativa)
        {
            using (var db = new ApplicationContext())
            {
                var categoria = new Categoria { Nome = nome, Ativa = ativa };
                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }

        public static List<Categoria> GetCategorias()
        {
            using (var db = new ApplicationContext())
            {
                return db.Categorias.ToList();
            }
        }

		public static Categoria GetCategoria(string categoria)
		{
			using (var db = new ApplicationContext())
			{
				return db.Categorias.Where(c => c.Nome == categoria).FirstOrDefault();
			}
		}
	}
}
