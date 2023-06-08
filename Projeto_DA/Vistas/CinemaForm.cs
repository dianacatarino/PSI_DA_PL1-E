using Projeto_DA.Modelos;
using Projeto_DA.Controladores;
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
    public partial class CinemaForm : Form
    {
		private Projeto_DA.Modelos.ApplicationContext db;

		public CinemaForm()
        {
            InitializeComponent();
			db = new Projeto_DA.Modelos.ApplicationContext();
			CinemaRefresh();
            SalasRefresh();
		}

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarCinema_Click(object sender, EventArgs e)
        {
            CinemaController.AdicionarCinema(textBoxNomeCinema.Text,textBoxMoradaCinema.Text,textBoxEmailCinema.Text);
            CinemaRefresh();
        }

        private void CinemaRefresh()
        {
            var cinema = CinemaController.GetCinemas();
            listBoxCinema.DataSource = null;
            listBoxCinema.DataSource = cinema;
        }

        private void listBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCinema.SelectedIndex == -1)
            {
                return;
            }

            Cinema cinema = (Cinema)listBoxCinema.SelectedItem;

            textBoxNomeCinema.Text = cinema.Nome;
            textBoxMoradaCinema.Text = cinema.Morada;
            textBoxEmailCinema.Text = cinema.Email;
        }

        private void btAlterarCinema_Click(object sender, EventArgs e)
        {
			Cinema cinemaSelecionado = (Cinema)listBoxCinema.SelectedItem;

            string novoNome = textBoxNomeCinema.Text;
            string novoEmail = textBoxEmailCinema.Text;
            string novaMorada = textBoxMoradaCinema.Text;

            CinemaController.AlterarCinema(cinemaSelecionado.Id, novoNome, novoEmail, novaMorada);

            CinemaRefresh();
        }

		private void btAdicionarSala_Click(object sender, EventArgs e)
		{
			SalaController.AdicionarSala(textBoxNomeSala.Text, int.Parse(textBoxColunas.Text), int.Parse(textBoxFilas.Text));
			SalasRefresh();
		}

		private void SalasRefresh()
		{
			var sala = SalaController.GetSalas();
			listBoxSalas.DataSource = null;
			listBoxSalas.DataSource = sala;
		}

		private void listBoxSalas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxSalas.SelectedIndex == -1)
			{
				return;
			}

			Sala sala = (Sala)listBoxSalas.SelectedItem;

			textBoxNomeSala.Text = sala.Nome;
			textBoxColunas.Text = sala.Colunas.ToString();
			textBoxFilas.Text = sala.Filas.ToString();
		}

		private void btAlterarSala_Click(object sender, EventArgs e)
		{
			Sala salaSelecionada = (Sala)listBoxSalas.SelectedItem;

			string novoNome = textBoxNomeSala.Text;
			int novaColunas = int.Parse(textBoxColunas.Text);
			int novaFilas = int.Parse(textBoxFilas.Text);

			SalaController.AlterarSala(salaSelecionada.Id, novoNome, novaColunas, novaFilas);

			SalasRefresh();
		}
	}
}
