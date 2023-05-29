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
            SessaoController.AdicionarSessao(textBoxFilmeSessoes.Text, textBoxSala.Text,
                DateTime.Parse(dateTimePickerInicio.Text), DateTime.Parse(dateTimePickerFim.Text));
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
