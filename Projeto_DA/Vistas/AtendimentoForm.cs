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
		public string NomeFuncionario { get; private set; }
		private string nomeFuncionario;
		private Sessao sessaoSelecionada;
		public Sala Sala { get; private set; }
		private Projeto_DA.Modelos.ApplicationContext db;
		
		public AtendimentoForm(string nomeFuncionario, Sessao sessao, Sala salaDaSessao)
        {
            InitializeComponent();
			this.nomeFuncionario = nomeFuncionario;
			this.sessaoSelecionada = sessao;
			menuToolStripMenuItem.Text = nomeFuncionario;
			db = new Projeto_DA.Modelos.ApplicationContext();
			Sala = salaDaSessao;
			textBoxSala.Text = Sala.Nome;
		}

		private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuForm menuForm = new MenuForm(nomeFuncionario);
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
			string nomeSala = textBoxSala.Text;

			Sala sala = SalaController.GetSala(nomeSala);

			if (sala != null)
			{
				ExibirSala(sala);
			}
			else
			{
				MessageBox.Show("Sala não encontrada!");
			}
		}

		private void ExibirSala(Sala sala)
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
					bool lugarDisponivel = VerificarLugarDisponivel(sala, i, j);
					Image imagem = GerarImagem(lugarDisponivel);
					DataGridViewImageCell cell = new DataGridViewImageCell();
					cell.Value = imagem;
					dataGridViewLugares[i - 1, rowIndex] = cell;
				}
			}
		}

		private Image GerarImagem(bool lugarDisponivel)
		{
			string caminhoImagem;

			if (lugarDisponivel)
			{
				caminhoImagem = "E:\\PSI\\2º Semestre\\DA\\Projeto\\Projeto_DA\\img\\greeniconcinema.png";
			}
			else
			{
				caminhoImagem = "E:\\PSI\\2º Semestre\\DA\\Projeto\\Projeto_DA\\img\\greyiconcinema.png";
			}

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

		private bool VerificarLugarDisponivel(Sala sala, int coluna, int fila)
		{
			// Verificar se as coordenadas estão dentro dos limites da sala
			if (coluna >= 1 && coluna <= sala.Colunas && fila >= 1 && fila <= sala.Filas)
			{
				// Obter a célula correspondente no DataGridView
				DataGridViewCell cell = dataGridViewLugares[coluna - 1, fila - 1];

				// Obter a imagem atual na célula
				Image imagemAtual = (Image)cell.Value;

				// Verificar se a imagem é cinza (ocupado)
				if (imagemAtual == ImagemOcupado())
				{
					// Lugar está ocupado
					return false;
				}
				else
				{
					// Lugar está disponível
					return true;
				}
			}

			// As coordenadas estão fora dos limites da sala, considerar como lugar indisponível
			return false;
		}

		private Image ImagemOcupado()
		{
			string caminhoImagemCinza = "E:\\PSI\\2º Semestre\\DA\\Projeto\\Projeto_DA\\img\\greyiconcinema.png";
			Image imagemCinza = Image.FromFile(caminhoImagemCinza);
			return imagemCinza;
		}

		private void AtendimentoForm_Load(object sender, EventArgs e)
		{
			menuToolStripMenuItem.Text = nomeFuncionario;
		}

		private void btCriarBilheteCliente_Click(object sender, EventArgs e)
		{
			Cliente cliente = null;

			if (listBoxClientes.SelectedItem != null)
			{
				cliente = (Cliente)listBoxClientes.SelectedItem;
			}
			else
			{
				string nomeCliente = textBoxNome.Text;

				// Verificar se o nome do cliente foi fornecido
				if (string.IsNullOrEmpty(nomeCliente))
				{
					MessageBox.Show("Digite o nome do cliente.");
					return;
				}

				string moradaCliente = textBoxMorada.Text;
				int nifCliente;

				// Verificar se o NIF é um número válido
				if (!int.TryParse(textBoxNif.Text, out nifCliente))
				{
					MessageBox.Show("Digite um número válido para o NIF.");
					return;
				}

				// Não adicionar o cliente anônimo à base de dados
				cliente = new Cliente();
			}

			// Verificar se um lugar está selecionado no DataGridView
			if (dataGridViewLugares.SelectedCells.Count == 0)
			{
				MessageBox.Show("Selecione um lugar válido.");
				return;
			}

			// Obter as informações do lugar selecionado
			DataGridViewCell selectedCell = dataGridViewLugares.SelectedCells[0];
			int coluna = selectedCell.ColumnIndex + 1;
			int fila = selectedCell.RowIndex + 1;

			// Verificar se o lugar está disponível
			Sala sala = SalaController.GetSala(textBoxSala.Text);
			bool lugarDisponivel = VerificarLugarDisponivel(sala, coluna, fila);
			if (!lugarDisponivel)
			{
				MessageBox.Show("O lugar selecionado está ocupado.");
				return;
			}

			// Criar o bilhete com as informações
			string lugar = coluna + "-" + fila;
			string estado = "Ativo";
			Funcionario funcionario = FuncionarioController.GetFuncionario(nomeFuncionario);
			Sessao sessao = sessaoSelecionada;

			// Adicionar o bilhete utilizando o BilheteController
			BilheteController.AdicionarBilhete(lugar, estado, cliente, funcionario, sessao);

			MessageBox.Show("Bilhete criado com sucesso.");

			// Atualizar a exibição da sala
			ExibirSala(sala);

			// Exportar bilhetes com base nos dados utilizados
			ExportarBilhete(cliente, funcionario, sessao);
		}

		private void ExportarBilhete(Cliente cliente, Funcionario funcionario, Sessao sessao)
		{
			string nomeFicheiro = cliente.Nome + "_" + cliente.NumFiscal + ".txt";

			using (StreamWriter sw = new StreamWriter(nomeFicheiro))
			{
				sw.WriteLine("Informações dos Bilhetes do Cliente: " + cliente.Nome + " (" + cliente.NumFiscal + ")");
				sw.WriteLine("____________________________________________________________________");
				sw.WriteLine();

				foreach (Bilhete bilhete in cliente.Bilhetes)
				{
					sw.WriteLine("Data e Hora da Compra: " + DateTime.Now.ToString("dd/MMMM/yyyy HH:mm:ss"));
					sw.WriteLine("Filme: " + bilhete.Sessao.Filme.Nome);
					sw.WriteLine("Data e Hora da Sessão: " + bilhete.Sessao.DataHora.ToString("dd/MMMM/yyyy HH:mm:ss"));
					sw.WriteLine("Sala: " + bilhete.Sessao.Sala.Nome);
					sw.WriteLine("Preço: " + bilhete.Sessao.Preco + "€");
					sw.WriteLine("Lugar: " + bilhete.Lugar);

					sw.WriteLine("Atendido por: " + funcionario.Nome);

					sw.WriteLine("____________________________________________________________________");
					sw.WriteLine();
				}

				int numBilhetes = cliente.Bilhetes.Count;
				float valorBilhetes = cliente.Bilhetes.Sum(bilhete => bilhete.Sessao.Preco);
				sw.WriteLine("Nº de Bilhetes: " + numBilhetes);
				sw.WriteLine("Valor Bilhetes Adquiridos: €" + valorBilhetes);
				sw.WriteLine();
			}

			MessageBox.Show("Bilhetes exportados com sucesso.");
		}
	}
}
