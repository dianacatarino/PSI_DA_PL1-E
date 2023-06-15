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
    public partial class SessoesForm : Form
    {
		private Projeto_DA.Modelos.ApplicationContext db;
		private string nomeFuncionario;
		public SessoesForm(string nomeFuncionario)
        {
            InitializeComponent();
			this.nomeFuncionario = nomeFuncionario;
			menuToolStripMenuItem.Text = nomeFuncionario;
			db = new Projeto_DA.Modelos.ApplicationContext();
			SessoesRefresh();
		}

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarSessoes_Click(object sender, EventArgs e)
        {
			Filme filme = FilmeController.GetFilme(comboBoxFilme.Text);
			Sala sala = SalaController.GetSala(comboBoxSala.Text);

			SessaoController.AdicionarSessao(filme, sala, DateTime.Parse(dateTimePickerInicio.Text), 
                DateTime.Parse(dateTimePickerFim.Text), float.Parse(textBoxPreco.Text));
            SessoesRefresh();
        }

        private void SessoesRefresh()
        {
            var sessao = SessaoController.GetSessoes();
            listBoxSessoes.DataSource = null;
            listBoxSessoes.DataSource = sessao;
        }

        private void listBoxSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (listBoxSessoes.SelectedIndex == -1)
			{
				return;
			}

			Sessao sessao = (Sessao)listBoxSessoes.SelectedItem;
			Filme filme = sessao.Filme;
			Sala sala = sessao.Sala;

			comboBoxFilme.Text = filme.Nome;
			comboBoxSala.Text = sala.Nome;
			dateTimePickerInicio.Text = sessao.DataHoraInicio.ToString();
			dateTimePickerFim.Text = sessao.DataHoraFim.ToString();
			textBoxPreco.Text = sessao.Preco.ToString();
		}
        private void btAlterarSessoes_Click(object sender, EventArgs e)
		{
			if (listBoxSessoes.SelectedItem == null)
			{
				MessageBox.Show("Selecione uma sessão para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Sessao sessaoSelecionada = (Sessao)listBoxSessoes.SelectedItem;

			Filme novoFilme = FilmeController.GetFilme(comboBoxFilme.Text);
			Sala novaSala = SalaController.GetSala(comboBoxSala.Text);
            string novaDataHoraInicio = dateTimePickerInicio.Text;
            string novaDataHoraFim = dateTimePickerFim.Text;
            string novoPreco = textBoxPreco.Text;

			SessaoController.AlterarSessao(sessaoSelecionada.Id, novoFilme, novaSala, DateTime.Parse(novaDataHoraInicio),
                DateTime.Parse(novaDataHoraFim), float.Parse(novoPreco));

			SessoesRefresh();
		}

		private void SessoesForm_Load(object sender, EventArgs e)
		{
			menuToolStripMenuItem.Text = nomeFuncionario;
			using (var db = new Projeto_DA.Modelos.ApplicationContext())
			{
				var filmes = db.Filmes.ToList();
                var salas = db.Salas.ToList();

				comboBoxFilme.Items.Clear();
				comboBoxFilme.DisplayMember = "Nome";

				foreach (var filme in filmes)
				{
					comboBoxFilme.Items.Add(filme);
				}

				comboBoxSala.Items.Clear();
				comboBoxSala.DisplayMember = "Nome";

				foreach (var sala in salas)
				{
					comboBoxSala.Items.Add(sala);
				}
			}
		}

		private void btRemoverSessao_Click(object sender, EventArgs e)
		{
			if (listBoxSessoes.SelectedItem == null)
			{
				MessageBox.Show("Selecione uma sessão para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Sessao sessaoSelecionado = (Sessao)listBoxSessoes.SelectedItem;

			DialogResult result = MessageBox.Show($"Tem certeza que deseja remover a sessão {sessaoSelecionado.Id}?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				SessaoController.RemoverSessao(sessaoSelecionado.Id);
				SessoesRefresh();
			}
		}
	}
}
