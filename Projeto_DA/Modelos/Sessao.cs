using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Sessao
    {
        public int Id { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public float Preco { get; set; }
		public Filme Filme { get; set; }
        public Sala Sala { get; set; }
        public List<Bilhete> Bilhetes { get; set; }

        public override string ToString()
        {
            return $"{DataHoraInicio}, {DataHoraFim}, {Preco}";
        }
    }
}
