using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class SalaController
    {
        public static void AdicionarSala(string nome, int colunas, int filas)
        {
            using (var db = new ApplicationContext())
            {
                var sala = new Sala { Nome = nome, Colunas = colunas, Filas = filas};
                db.Salas.Add(sala);
                db.SaveChanges();
            }
        }

        public static List<Sala> GetSalas()
        {
            using (var db = new ApplicationContext())
            {
                return db.Salas.ToList();
            }
        }

		public static Sala GetSala(string sala)
		{
			using (var db = new ApplicationContext())
			{
				return db.Salas.Where(c => c.Nome == sala).FirstOrDefault();
			}
		}

		public static void AlterarSala(int salaId, string novoNome, int novaColunas, int novaFilas)
		{
			using (var db = new ApplicationContext())
			{
				var sala = db.Salas.Find(salaId);
				if (sala != null)
				{
					sala.Nome = novoNome;
					sala.Colunas = novaColunas;
					sala.Filas = novaFilas;
					db.SaveChanges();
				}
			}
		}
	}
}
