using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controladores
{
    internal class ClienteController
    {
        public static void AdicionarCliente(string nome, string morada, int nif)
        {
            using (var db = new ApplicationContext())
            {
                var cliente = new Cliente { Nome = nome, Morada = morada, NumFiscal = nif };
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public static List<Cliente> GetClientes()
        {
            using (var db = new ApplicationContext())
            {
                return db.Clientes.ToList();
            }
        }
    }
}
