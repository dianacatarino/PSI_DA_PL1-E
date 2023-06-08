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
		private Funcionario funcionarioAutenticado;
		public static string NomeFuncionario { get; set; }
		public MenuForm()
        {
            InitializeComponent();
		}

		public void AtualizarNomeFuncionario(Funcionario funcionario)
		{
			funcionarioAutenticado = funcionario;
			funcionarioToolStripMenuItem.Text = funcionarioAutenticado.Nome;
		}

		private void btCinema_Click(object sender, EventArgs e)
        {
            CinemaForm cinemaform = new CinemaForm();
            Hide();
            cinemaform.ShowDialog();
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            FilmesForm filmesform = new FilmesForm();
            Hide();
            filmesform.ShowDialog();
        }

        private void btSessoes_Click(object sender, EventArgs e)
        {
            SessoesForm sessoesform = new SessoesForm();
            Hide();
            sessoesform.ShowDialog();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            Hide();
            clientesForm.ShowDialog();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionariosForm funcionariosform = new FuncionariosForm();
            Hide();
            funcionariosform.ShowDialog();
        }

        private void btCriarBilhete_Click(object sender, EventArgs e)
        {
            AtendimentoForm atendimentosform = new AtendimentoForm();
            Hide();
            atendimentosform.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarForm alterarform = new AlterarForm();
            Hide();
            alterarform.ShowDialog();
        }

        private void listBoxSessoesAtuais_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (listBoxSessoesAtuais.SelectedIndex != -1)
			{
				string sessaoSelecionada = listBoxSessoesAtuais.SelectedItem.ToString();

				AtendimentoForm atendimentosform = new AtendimentoForm();

				atendimentosform.Sessao = sessaoSelecionada;

				Hide();

				atendimentosform.ShowDialog();
			}
        }

		private void MenuForm_Load(object sender, EventArgs e)
		{
			/*using (var db = new Projeto_DA.Modelos.ApplicationContext())
			{
				var sessoes = db.Sessoes.ToList();

				listBoxSessoesAtuais.Items.Clear();

				listBoxSessoesAtuais.DisplayMember = "Nome";

				foreach (var sessao in sessoes)
				{
					listBoxSessoesAtuais.Items.Add(sessao);
				}
			}*/
		}
	}
}
