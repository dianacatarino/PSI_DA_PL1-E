using Projeto_DA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class AtendimentoForm : Form
    {
		public string Sessao;
		public AtendimentoForm()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

		private void btCarregarCliente_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = "dados_clientes.bin";
			ofd.Filter = "Dados binários | *.bin";

			DialogResult dialogResult = ofd.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				CarregarDadosBinarios(ofd.FileName);
			}
		}

		private void CarregarDadosBinarios(string fileName)
		{
			if (File.Exists(fileName))
			{
				FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				BinaryFormatter bf = new BinaryFormatter();

				List<Cliente> listClientes = bf.Deserialize(fs) as List<Cliente>;
				fs.Close();

				listBoxClientes.DataSource = listClientes;
			}
		}
	}
}
