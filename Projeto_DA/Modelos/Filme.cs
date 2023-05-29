using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Modelos
{
    public class Filme: Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Boolean Ativo { get; set; }

        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Duracao: {Duracao}, Ativo: {Ativo}";
        }
    }
}
