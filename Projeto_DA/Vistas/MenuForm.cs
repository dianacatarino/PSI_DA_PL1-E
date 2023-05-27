using Projeto_DA.Vistas;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
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
            ClientesForm clientesForm = new ClientesForm ();
            Hide();
            clientesForm.ShowDialog();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionariosForm funcionariosform = new FuncionariosForm();
            Hide();
            funcionariosform.ShowDialog();
        }
    }
}
