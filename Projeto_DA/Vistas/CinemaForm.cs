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
    public partial class CinemaForm : Form
    {
        public CinemaForm()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarCinema_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
            cinema.Nome = textBoxNomeCinema.Text;
            cinema.Morada = textBoxMoradaCinema.Text;
            cinema.Email = textBoxEmailCinema.Text;
        }
    }
}
