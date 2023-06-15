using Projeto_DA.Controladores;
using Projeto_DA.Modelos;
using Projeto_DA.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
	public partial class MenuForm : Form
	{
		private string funcionarioAutenticado;

		public MenuForm(string nomeFuncionario)
		{
			InitializeComponent();
			funcionarioAutenticado = nomeFuncionario;
			funcionarioToolStripMenuItem.Text = funcionarioAutenticado;
		}

		public void AtualizarNomeFuncionario(Funcionario funcionario)
		{
			funcionarioAutenticado = funcionario.Nome;
			funcionarioToolStripMenuItem.Text = funcionarioAutenticado;
		}

		private void btCinema_Click(object sender, EventArgs e)
		{
			CinemaForm cinemaform = new CinemaForm(funcionarioAutenticado);
			Hide();
			cinemaform.ShowDialog();
		}

		private void btFilmes_Click(object sender, EventArgs e)
		{
			FilmesForm filmesform = new FilmesForm(funcionarioAutenticado);
			Hide();
			filmesform.ShowDialog();
		}

		private void btSessoes_Click(object sender, EventArgs e)
		{
			SessoesForm sessoesform = new SessoesForm(funcionarioAutenticado);
			Hide();
			sessoesform.ShowDialog();
		}

		private void btClientes_Click(object sender, EventArgs e)
		{
			ClientesForm clientesForm = new ClientesForm(funcionarioAutenticado);
			Hide();
			clientesForm.ShowDialog();
		}

		private void btFuncionarios_Click(object sender, EventArgs e)
		{
			FuncionariosForm funcionariosform = new FuncionariosForm(funcionarioAutenticado);
			Hide();
			funcionariosform.ShowDialog();
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlterarForm alterarform = new AlterarForm(Program.FuncionarioAutenticado);
			Hide();
			alterarform.ShowDialog();
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{
			DateTime dataAtual = DateTime.Now.Date;
			List<Sessao> sessoesAtuais = SessaoController.GetSessoes().Where(sessao => sessao.DataHora.Date == dataAtual).ToList();
			listBoxSessoesAtuais.DataSource = sessoesAtuais;
			listBoxSessoesAtuais.DisplayMember = "ToString";
		}

		private void listBoxSessoesAtuais_Click(object sender, EventArgs e)
		{
			/*if (listBoxSessoesAtuais.SelectedItem != null)
			{
				Sessao sessaoSelecionada = (Sessao)listBoxSessoesAtuais.SelectedItem;
				AtendimentoForm atendimentoForm = new AtendimentoForm(funcionarioAutenticado, sessaoSelecionada);
				Hide();
				atendimentoForm.ShowDialog();
				Show();
			}*/
		}
	}
}
