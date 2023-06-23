using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Boolean Ativa { get; set; }

		public override string ToString()
		{
			return Nome;
		}
	}
}
