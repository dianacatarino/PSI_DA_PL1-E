using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Funcionario: Pessoa
    {
        public int Id { get; set; }
        public float Salario { get; set; }
        public string Funcao { get; set; }

        public List<Bilhete> Bilhetes { get; set; }

		public override string ToString()
        {
            return $"Funcionário {Id}: {base.Nome}, {base.Morada}, {Salario}€, {Funcao}";
        }
    }
}
