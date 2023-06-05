using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_DA.Modelos
{
	[Serializable]
	public class Cliente: Pessoa
    {
        public int Id { get; set; }
        public int NumFiscal { get; set; }

        public List<Bilhete> Bilhetes { get; set; }

        public override string ToString()
        {
            return $"Nome: {base.Nome}, Morada: {base.Morada}, Nif: {NumFiscal}";
        }
    }
}
