using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto_DA
{
	internal static class Program
	{
		// Propriedade estática para armazenar o funcionário autenticado
		public static Funcionario FuncionarioAutenticado { get; set; }
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Defina o valor da propriedade FuncionarioAutenticado com base nas informações do funcionário autenticado
			string nomeFuncionario = "Funcionário";
			FuncionarioAutenticado = new Funcionario { Nome = nomeFuncionario };

			Application.Run(new MenuForm(nomeFuncionario));

			using (var db = new Modelos.ApplicationContext())
			{
				if (!db.Categorias.Any())
				{
					var categorias = new List<Categoria>
					{
						new Categoria { Id = 1, Nome = "Comédia", Ativa = false },
						new Categoria { Id = 2, Nome = "Sci-fi", Ativa = false },
						new Categoria { Id = 3, Nome = "Terror", Ativa = false },
						new Categoria { Id = 4, Nome = "Romance", Ativa = false },
						new Categoria { Id = 5, Nome = "Ação", Ativa = false },
						new Categoria { Id = 6, Nome = "Thriller", Ativa = false },
						new Categoria { Id = 7, Nome = "Drama", Ativa = false },
						new Categoria { Id = 8, Nome = "Mistério", Ativa = false },
						new Categoria { Id = 9, Nome = "Crime", Ativa = false },
						new Categoria { Id = 10, Nome = "Aventura", Ativa = false },
						new Categoria { Id = 11, Nome = "Fantasia", Ativa = false },
						new Categoria { Id = 12, Nome = "Animação", Ativa = false }
					};

					db.Categorias.AddRange(categorias);
					db.SaveChanges();
				}
			}
		}
	}
}
