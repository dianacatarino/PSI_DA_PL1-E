using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Cliente: Pessoa
    {
        public int Id { get; set; }
        public int NumFiscal { get; set; }
    }
}
