using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Bilhete
    {
        public int Id { get; set; }
        public string Lugar { get; set; }
        public string Estado { get; set; }

        public Sessao Sessao { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
