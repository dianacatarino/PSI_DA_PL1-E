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
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();
            pessoa.Nome = textBoxNome.Text;
            pessoa.Morada = textBoxMorada.Text;
            int NumFiscal = int.Parse(textBoxNif.Text);
            cliente.NumFiscal = NumFiscal;

            listBoxClientes.Items.Add(cliente);
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedIndex == null)
            {
                return;
            }

            Pessoa pessoa = (Pessoa)listBoxClientes.SelectedItem;
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            textBoxNome.Text = pessoa.Nome;
            textBoxMorada.Text = pessoa.Morada;
            int NumFiscal = cliente.NumFiscal;
            textBoxNif.Text = NumFiscal;
        }
    }
}
