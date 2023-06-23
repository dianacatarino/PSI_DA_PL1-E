using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_DA.Modelos
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }

        public Cinema Cinema { get; set; }
        public List<Sessao> Sessoes { get; set; }   

        public override string ToString()
        {
            return $"Sala {Id}: {Nome}, {Colunas}, {Filas}";
        }
    }
}
