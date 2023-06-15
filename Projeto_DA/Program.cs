using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
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
		}
    }
}
