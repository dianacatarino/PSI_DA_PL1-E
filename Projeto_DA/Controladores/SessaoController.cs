using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class SessaoController
    {
        public static void AdicionarSessao(Filme filme, Sala sala,DateTime datahorainicio, DateTime datahorafim, float preco)
        {
            using (var db = new ApplicationContext())
            {
                var sessao = new Sessao { Filme = filme, Sala = sala, DataHoraInicio = datahorainicio, DataHoraFim = datahorafim, Preco = preco};
                db.Sessoes.Add(sessao);
                db.SaveChanges();
            }
        }

        public static List<Sessao> GetSessoes()
        {
            using (var db = new ApplicationContext())
            {
                return db.Sessoes.ToList();
            }
        }

        public static List<Sessao> GetSessoesAtuais()
        {
			List<Sessao> sessoesAtuais = new List<Sessao>();

			DateTime dataHoraAtual = DateTime.Now;

			foreach (Sessao sessao in sessoesAtuais)
			{
				if (sessao.DataHoraInicio <= dataHoraAtual && sessao.DataHoraFim >= dataHoraAtual)
				{
					sessoesAtuais.Add(sessao);
				}
			}

			return sessoesAtuais;
		}

		public static void AlterarSessao(int sessaoId, Filme novoFilme, Sala novaSala,DateTime novaDataHoraInicio, DateTime novaDataHoraFim, float novoPreco)
		{
			using (var db = new ApplicationContext())
			{
				var sessao = db.Sessoes.Find(sessaoId);
				if (sessao != null)
				{
					sessao.Filme = novoFilme;
					sessao.Sala = novaSala;
					sessao.DataHoraInicio = novaDataHoraInicio;
					sessao.DataHoraFim = novaDataHoraFim;
                    sessao.Preco = novoPreco;
					db.SaveChanges();
				}
			}
		}
	}
}
