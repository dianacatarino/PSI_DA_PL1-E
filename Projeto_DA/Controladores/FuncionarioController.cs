using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class FuncionarioController
    {
        public static void AdicionarFuncionario(string nome, string morada, float salario, string funcao)
        {
            using (var db = new ApplicationContext())
            {
                var funcionario = new Funcionario { Nome = nome, Morada = morada, Salario = salario, Funcao = funcao };
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }
        }

        public static List<Funcionario> GetFuncionarios()
        {
            using (var db = new ApplicationContext())
            {
                return db.Funcionarios.ToList();
            }
        }

        public static void AlterarFuncionario(int funcionarioId, string novoNome, string novaMorada, float novoSalario, string novaFuncao)
        {
			using (var db = new ApplicationContext())
            {
				var funcionario = db.Funcionarios.Find(funcionarioId);
				if (funcionario != null)
                {
					funcionario.Nome = novoNome;
					funcionario.Morada = novaMorada;
					funcionario.Salario = novoSalario;
					funcionario.Funcao = novaFuncao;
					db.SaveChanges();
				}
			}
		}   
    }
}
