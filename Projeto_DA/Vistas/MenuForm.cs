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

		public MenuForm()
		{
			InitializeComponent();
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

		private void btCriarBilhete_Click(object sender, EventArgs e)
		{
			AtendimentoForm atendimentosform = new AtendimentoForm(funcionarioAutenticado);
			Hide();
			atendimentosform.ShowDialog();
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AlterarForm alterarform = new AlterarForm(Program.FuncionarioAutenticado);
			Hide();
			alterarform.ShowDialog();
		}

		private void dataGridViewSessoesAtuais_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			List<Sessao> sessoesAtuais = SessaoController.GetSessoesAtuais();

			dataGridViewSessoesAtuais.DataSource = sessoesAtuais;
			dataGridViewSessoesAtuais.Refresh();
		}
	}
}
