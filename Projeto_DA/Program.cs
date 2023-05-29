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
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());

            using (var db = new Modelos.ApplicationContext())
            {
                var cliente = new Cliente { Nome = "Cliente1", NumFiscal = 123456789 };
                db.Clientes.Add(cliente);
                db.SaveChanges();

                var funcionario = new Funcionario { Nome = "Funcionario1", Salario = 123456789, Funcao = "Caixa" };
                db.Clientes.Add(cliente);
                db.SaveChanges();

                db.SaveChanges();
            }
        }
    }
}
