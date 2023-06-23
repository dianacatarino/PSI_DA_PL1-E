using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }

        public List<Sala> Salas { get; set; }

        public override string ToString()
        {
            return $"Cinema: {Nome}, {Morada}, {Email}";
        }
    }
}
