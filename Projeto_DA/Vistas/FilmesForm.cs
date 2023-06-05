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
		public FilmesForm()
        {
            InitializeComponent();
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
            Categoria categoria = CategoriaController.GetCategoria(comboBoxCategoria.Text);

			FilmeController.AdicionarFilme(textBoxNomeFilme.Text, TimeSpan.Parse(textBoxDuracao.Text), 
                categoria, checkBoxAtivo.Checked);
            FilmesRefresh();
        }

        private void FilmesRefresh()
        {
            var filme = FilmeController.GetFilmes();
            listBoxFilmes.DataSource = null;
            listBoxFilmes.DataSource = filme;
        }

        private void listBoxFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilmes.SelectedIndex == -1)
            {
                return;
            }

            Filme filme = (Filme)listBoxFilmes.SelectedItem;

            textBoxNomeFilme.Text = filme.Nome;
            textBoxDuracao.Text = filme.Duracao.ToString();

			Categoria categoriaSelecionada = filme.Categoria;

			if (categoriaSelecionada != null && comboBoxCategoria.Items.Contains(categoriaSelecionada))
			{
				comboBoxCategoria.SelectedItem = categoriaSelecionada;
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
			if (comboBoxCategoria.Items.Count == 0)
			{
				var categorias = CategoriaController.GetCategorias();

				comboBoxCategoria.Items.Clear();
				comboBoxCategoria.DisplayMember = "Nome";

				foreach (var categoria in categorias)
				{
					if (!comboBoxCategoria.Items.Contains(categoria))
					{
						comboBoxCategoria.Items.Add(categoria);
					}
				}
			}
		}
	}
}
