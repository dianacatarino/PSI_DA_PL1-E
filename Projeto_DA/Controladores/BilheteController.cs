using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class BilheteController
    {
        public static void AdicionarBilhete(string lugar, string estado, Cliente cliente,
            Funcionario funcionario, Sessao sessao)
        {
            using (var db = new ApplicationContext())
            {
				// Verifica se o cliente já existe na base de dados
				Cliente clienteExistente = db.Clientes.FirstOrDefault(c => c.Id == cliente.Id);

				if (clienteExistente != null)
				{
					// Atualiza a referência para o cliente existente
					cliente = clienteExistente;
				}

				// Verificar se o funcionário já existe no banco de dados
				var funcionarioExistente = db.Funcionarios.FirstOrDefault(f => f.Id == funcionario.Id);
				if (funcionarioExistente != null)
				{
					funcionario = funcionarioExistente; // Utilizar o funcionário existente
				}

				// Verifica se a sessao já existe na base de dados
				Sessao sessaoExistente = db.Sessoes.FirstOrDefault(s => s.Id == sessao.Id);

				if (sessaoExistente != null)
				{
					// Atualiza a referência para a sessao existente
					sessao = sessaoExistente;
				}

				var bilhete = new Bilhete { Lugar = lugar, Estado = estado, Cliente = cliente,
                Funcionario = funcionario, Sessao = sessao};
                db.Bilhetes.Add(bilhete);
                db.SaveChanges();
            }
        }

        public static List<Bilhete> GetBilhetes()
        {
            using (var db = new ApplicationContext())
            {
                return db.Bilhetes.ToList();
            }
        }
    }
}
