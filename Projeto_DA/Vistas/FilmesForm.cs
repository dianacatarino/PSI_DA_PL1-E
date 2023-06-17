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
    public partial class FilmesForm : Form
    {
		public string NomeFuncionario { get; private set; }
		private string nomeFuncionario;
		public string Sessao;
		private Projeto_DA.Modelos.ApplicationContext db;
		public FilmesForm(string nomeFuncionario)
        {
            InitializeComponent();
			this.nomeFuncionario = nomeFuncionario;
			menuToolStripMenuItem.Text = nomeFuncionario;
			db = new Projeto_DA.Modelos.ApplicationContext();
			FilmesRefresh();
		}

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(nomeFuncionario);
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarFilme_Click(object sender, EventArgs e)
        {
			string nomeCategoria = comboBoxCategoria.Text;
			Categoria categoria = CategoriaController.GetCategoria(nomeCategoria);

			if (categoria == null || categoria.Id == 0)
			{
				MessageBox.Show("A categoria selecionada não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			FilmeController.AdicionarFilme(textBoxNomeFilme.Text, TimeSpan.Parse(textBoxDuracao.Text), categoria, false);
			FilmesRefresh();
		}

        private void FilmesRefresh()
        {
			var filmes = FilmeController.GetFilmes();
			listBoxFilmes.DataSource = null;
			listBoxFilmes.DataSource = filmes;
		}

        private void listBoxFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (listBoxFilmes.SelectedIndex == -1)
			{
				return;
			}

			Filme filme = (Filme)listBoxFilmes.SelectedItem;
			Categoria categoria = filme.Categoria;

			textBoxNomeFilme.Text = filme.Nome;
			textBoxDuracao.Text = filme.Duracao.ToString();

			if (categoria != null)
			{
				comboBoxCategoria.SelectedItem = categoria.Nome;
			}

			checkBoxAtivo.Checked = filme.Ativo;
		}

		private void btAlterarFilme_Click(object sender, EventArgs e)
		{
			if (listBoxFilmes.SelectedItem == null)
			{
				MessageBox.Show("Selecione um filme para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Filme filmeSelecionado = (Filme)listBoxFilmes.SelectedItem;

			string novoNome = textBoxNomeFilme.Text;
			TimeSpan novaDuracao = TimeSpan.Parse(textBoxDuracao.Text);
			Categoria novaCategoria = comboBoxCategoria.SelectedItem as Categoria;
			bool novoAtivo = checkBoxAtivo.Checked;

			FilmeController.AlterarFilme(filmeSelecionado.Id, novoNome, novaDuracao, novaCategoria, novoAtivo);

			FilmesRefresh();
		}

		private void FilmesForm_Load(object sender, EventArgs e)
		{
			menuToolStripMenuItem.Text = nomeFuncionario;
			comboBoxCategoria.DisplayMember = "Nome";
			CarregarCategorias();
		}

		private void CarregarCategorias()
		{
			var categorias = CategoriaController.GetCategorias();
			comboBoxCategoria.DataSource = categorias;
			comboBoxCategoria.DisplayMember = "Nome";
		}

		private void btRemoverFilme_Click(object sender, EventArgs e)
		{
			if (listBoxFilmes.SelectedItem == null)
			{
				MessageBox.Show("Selecione um filme para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Filme filmeSelecionado = (Filme)listBoxFilmes.SelectedItem;

			DialogResult result = MessageBox.Show($"Tem certeza que deseja remover o filme {filmeSelecionado.Nome}?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				FilmeController.RemoverFilme(filmeSelecionado.Id);
				FilmesRefresh();
			}
		}
	}
}
