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
		private Projeto_DA.Modelos.ApplicationContext db;
		private string nomeFuncionario;
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
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarFilme_Click(object sender, EventArgs e)
        {
			string nomeCategoria = comboBoxCategoria.Text;
			Categoria categoria = CategoriaController.GetCategoria(nomeCategoria);

			if (categoria == null)
			{
				categoria = db.Categorias.FirstOrDefault(c => c.Nome == nomeCategoria);
			}

			FilmeController.AdicionarFilme(textBoxNomeFilme.Text, TimeSpan.Parse(textBoxDuracao.Text),
				categoria, checkBoxAtivo.Checked);
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

			if (categoria != null && comboBoxCategoria.Items.Contains(categoria))
			{
				comboBoxCategoria.SelectedItem = categoria;
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
			string novaDuracao = textBoxDuracao.Text;
			Categoria novaCategoria = CategoriaController.GetCategoria(comboBoxCategoria.Text);
			bool novoAtivo = checkBoxAtivo.Checked;

			FilmeController.AlterarFilme(filmeSelecionado.Id, novoNome, TimeSpan.Parse(novaDuracao), novaCategoria, novoAtivo);

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
			var categorias = db.Categorias.ToList();
			comboBoxCategoria.DataSource = categorias;
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
