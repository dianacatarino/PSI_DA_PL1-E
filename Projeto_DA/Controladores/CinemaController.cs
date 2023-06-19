using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Modelos;

namespace Projeto_DA.Controladores
{
    internal class CinemaController
    {
        public static void AdicionarCinema(string nome, string morada, string email)
        {
            using(var db = new ApplicationContext())
            {
                var cinema = new Cinema {Nome = nome, Morada = morada, Email = email};
                db.Cinemas.Add(cinema);
                db.SaveChanges();
            }
        }

        public static List<Cinema> GetCinema()
        {
            using (var db = new ApplicationContext())
            {
                return db.Cinemas.ToList();
            }
        }

        public static void AlterarCinema(int cinemaId, string novoNome, string novaMorada, string novoEmail)
        {
            using (var db = new ApplicationContext())
            {
                var cinema = db.Cinemas.Find(cinemaId);
                if (cinema != null)
                {
                    cinema.Nome = novoNome;
                    cinema.Email = novoEmail;
                    cinema.Morada = novaMorada;
                    db.SaveChanges();
                }
            }
        }
    }
}
