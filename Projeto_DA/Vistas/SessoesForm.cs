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
        public SessoesForm()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.ShowDialog();
        }

        private void btAdicionarSessoes_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            Sala sala = new Sala();
            Sessao sessao = new Sessao();
            filme.Nome = textBoxFilmeSessoes.Text;
            sala.Nome = textBoxSala.Text;
            DateTime DataHoraInicio = DateTime.Parse(dateTimePickerInicio.Text);
            sessao.DataHoraInicio = DataHoraInicio;
            DateTime DataHoraFim = DateTime.Parse(dateTimePickerFim.Text);
            sessao.DataHoraFim = DataHoraFim;
        }

        private void listBoxSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSessoes.SelectedIndex == null)
            {
                return;
            }

            Filme filme = (Filme)listBoxSessoes.SelectedItem;
            Sala sala = (Sala)listBoxSessoes.SelectedItem;
            Sessao sessao = (Sessao)listBoxSessoes.SelectedValue;

            textBoxFilmeSessoes.Text = filme.Nome;
            textBoxSala.Text = sala.Nome;
            dateTimePickerInicio.Text = sessao.DataHoraInicio.ToString();
            dateTimePickerFim.Text = sessao.DataHoraFim.ToString();
        }
    }
}
