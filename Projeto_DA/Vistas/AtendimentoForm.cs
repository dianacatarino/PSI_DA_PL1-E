using Projeto_DA.Controladores;
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
		private Projeto_DA.Modelos.ApplicationContext db;
		public AtendimentoForm()
        {
            InitializeComponent();
			db = new Projeto_DA.Modelos.ApplicationContext();
		}

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

		private void btCarregarCliente_Click(object sender, EventArgs e)
		{
			var clientes = ClienteController.GetClientes();

			listBoxClientes.Items.Clear();
			listBoxClientes.DisplayMember = "Nome";

			foreach (var cliente in clientes)
			{
				listBoxClientes.Items.Add(cliente);
			}
		}

		private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxClientes.SelectedIndex == -1)
			{
				return;
			}

			Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

			textBoxNome.Text = cliente.Nome;
			textBoxMorada.Text = cliente.Morada;
			int NumFiscal = cliente.NumFiscal;
			textBoxNif.Text = NumFiscal.ToString();
		}

		private void buttonCarregarSala_Click(object sender, EventArgs e)
		{
			string nomeSala = comboBoxSalas.Text;

			Sala sala = SalaController.GetSala(nomeSala);

			if (sala != null)
			{
				int colunas = sala.Colunas;
				int filas = sala.Filas;

				dataGridViewLugares.Rows.Clear();
				dataGridViewLugares.Columns.Clear();

				for (int i = 1; i <= colunas; i++)
				{
					dataGridViewLugares.Columns.Add($"Coluna{i}", $"Coluna {i}");
				}

				for (int j = 1; j <= filas; j++)
				{
					int rowIndex = dataGridViewLugares.Rows.Add();
					dataGridViewLugares.Rows[rowIndex].HeaderCell.Value = $"Fila {j}";

					for (int i = 1; i <= colunas; i++)
					{
						Image imagem = GerarImagem(sala, i, j);
						DataGridViewImageCell cell = new DataGridViewImageCell();
						cell.Value = imagem;
						dataGridViewLugares[i - 1, rowIndex] = cell;
					}
				}
			}
			else
			{
				MessageBox.Show("Sala não encontrada!");
			}
		}

		private Bitmap GerarImagem(Sala sala, int fila, int coluna)
		{
			string caminhoImagem = "E:\\PSI\\2º Semestre\\DA\\Projeto\\img\\greyiconcinema.png";
			Bitmap imagemOriginal = new Bitmap(caminhoImagem);

			int larguraDesejada = 35;
			int alturaDesejada = 35;

			Bitmap imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
			using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
			{
				graphics.DrawImage(imagemOriginal, 0, 0, larguraDesejada, alturaDesejada);
			}

			return imagemRedimensionada;
		}

		private void AtendimentoForm_Load(object sender, EventArgs e)
		{
			if (comboBoxSalas.Items.Count == 0)
			{
				var salas = SalaController.GetSalas();

				comboBoxSalas.Items.Clear();
				comboBoxSalas.DisplayMember = "Nome";

				foreach (var sala in salas)
				{
					if (!comboBoxSalas.Items.Contains(sala))
					{
						comboBoxSalas.Items.Add(sala);
					}
				}
			}
		}

		private void btCriarBilheteCliente_Click(object sender, EventArgs e)
		{
			
		}

		private void ExportarBilhete()
		{
			/*if (listBoxClientes.SelectedItem == null)
			{
				return;
			}
			Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

			string nomeFicheiro = cliente.Nome + "_" + cliente.Nif + ".txt";
			FileStream fs = new FileStream(nomeFicheiro, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);

			sw.WriteLine(cliente.Nome + " (" + cliente.Nif + ") ");
			sw.WriteLine("____________________________________________________________________");

			foreach (Compra compra in cliente.Compras)
			{
				sw.WriteLine("Efetuada a: " + compra.GetDataHora().ToString("dd/MMMM/yyyy HH:mm:ss"));

				foreach (LinhaCompra linha in compra.LinhasCompra)
				{
					sw.WriteLine("-" + linha.Valor + "€ " + linha.Descricao);

				}
				sw.WriteLine("Total: €" + compra.Total);
				sw.WriteLine("____________________________________________________________________");
			}
			sw.WriteLine("Total do Cliente: €" + cliente.Total);

			sw.Close();
			fs.Close();
			*/
		}

		private void dataGridViewLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
