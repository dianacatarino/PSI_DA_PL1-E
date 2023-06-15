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
        public static void AdicionarSessao(Filme filme, Sala sala,DateTime datahora, float preco)
        {
			using (var db = new ApplicationContext())
			{
				// Verifica se o filme já existe na base de dados
				Filme filmeExistente = db.Filmes.FirstOrDefault(f => f.Id == filme.Id);

				if (filmeExistente != null)
				{
					// Atualiza a referência para o filme existente
					filme = filmeExistente;
				}

				// Verifica se a sala já existe na base de dados
				Sala salaExistente = db.Salas.FirstOrDefault(s => s.Id == sala.Id);

				if (salaExistente != null)
				{
					// Atualiza a referência para a sala existente
					sala = salaExistente;
				}

				var sessao = new Sessao { Filme = filme, Sala = sala, DataHora = datahora, Preco = preco };
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
				if (sessao.DataHora <= dataHoraAtual)
				{
					sessoesAtuais.Add(sessao);
				}
			}

			return sessoesAtuais;
		}

		public static void AlterarSessao(int sessaoId, Filme novoFilme, Sala novaSala,DateTime novaDataHora, float novoPreco)
		{
			using (var db = new ApplicationContext())
			{
				var sessao = db.Sessoes.Find(sessaoId);
				if (sessao != null)
				{
					// Verifica se o filme já existe na base de dados
					Filme filmeExistente = db.Filmes.FirstOrDefault(f => f.Id == novoFilme.Id);

					if (filmeExistente != null)
					{
						// Atualiza a referência para o filme existente
						sessao.Filme = filmeExistente;
					}
					else
					{
						sessao.Filme = novoFilme;
					}

					// Verifica se a sala já existe na base de dados
					Sala salaExistente = db.Salas.FirstOrDefault(s => s.Id == novaSala.Id);

					if (salaExistente != null)
					{
						// Atualiza a referência para a sala existente
						sessao.Sala = salaExistente;
					}
					else
					{
						sessao.Sala = novaSala;
					}

					sessao.DataHora = novaDataHora;
					sessao.Preco = novoPreco;
					db.SaveChanges();
				}
			}
		}

		public static void RemoverSessao(int sessaoId)
		{
			using (var db = new ApplicationContext())
			{
				var sessao = db.Sessoes.Find(sessaoId);
				if (sessao != null)
				{
					db.Sessoes.Remove(sessao);
					db.SaveChanges();
				}
			}
		}
	}
}
