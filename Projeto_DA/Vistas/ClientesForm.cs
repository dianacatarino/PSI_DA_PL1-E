using Projeto_DA.Controladores;
using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarCliente_Click(object sender, EventArgs e)
        {

            ClienteController.AdicionarCliente(textBoxNome.Text, textBoxMorada.Text, int.Parse(textBoxNif.Text));
            ClientesRefresh();
        }

        private void ClientesRefresh()
        {
            var cliente = ClienteController.GetClientes();
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = cliente;
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedIndex == null)
            {
                return;
            }

            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            textBoxNome.Text = cliente.Nome;
            textBoxMorada.Text = cliente.Morada;
            int NumFiscal = cliente.NumFiscal;
            textBoxNif.Text = NumFiscal.ToString();
        }

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem; 

            cliente.Nome = textBoxNome.Text;
            cliente.Morada = textBoxMorada.Text;
            int NumFiscal = int.Parse(textBoxNif.Text);
            cliente.NumFiscal = NumFiscal;

            try
            {
                var db = new Modelos.ApplicationContext();
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
