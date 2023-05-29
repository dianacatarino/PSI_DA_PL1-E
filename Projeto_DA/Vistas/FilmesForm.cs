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
        public FilmesForm()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarFilme_Click(object sender, EventArgs e)
        {
            FilmeController.AdicionarFilme(textBoxNomeFilme.Text, TimeSpan.Parse(textBoxDuracao.Text), 
                textBoxCategoria.Text, Boolean.Parse(checkBoxAtivo.Text));
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
            if (listBoxFilmes.SelectedIndex == null)
            {
                return;
            }

            Filme filme = (Filme)listBoxFilmes.SelectedItem;
            Categoria categoria = (Categoria)listBoxFilmes.SelectedItem;

            textBoxNomeFilme.Text = filme.Nome;
            textBoxDuracao.Text = filme.Duracao.ToString();
            textBoxCategoria.Text = categoria.Nome;
            checkBoxAtivo.Checked = filme.Ativo;
        }
    }
}
