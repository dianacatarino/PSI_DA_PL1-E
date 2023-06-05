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
        public static void AdicionarSessao(Filme filme, Sala sala,DateTime datahorainicio, DateTime datahorafim)
        {
            using (var db = new ApplicationContext())
            {
                var sessao = new Sessao { Filme = filme, Sala = sala, DataHoraInicio = datahorainicio, DataHoraFim = datahorafim};
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

		public static void AlterarSessao(int sessaoId, string novoFilme, string novaSala, TimeSpan novaDataHoraInicio, TimeSpan novaDataHoraFim)
		{
			/*using (var db = new ApplicationContext())
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
			}*/
		}
	}
}
