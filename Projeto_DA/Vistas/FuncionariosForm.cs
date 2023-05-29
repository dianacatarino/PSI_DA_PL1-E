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

namespace Projeto_DA.Vistas
{
    public partial class FuncionariosForm : Form
    {
        public FuncionariosForm()
        {
            InitializeComponent();
        }

        private void btAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioController.AdicionarFuncionario(textBoxNome.Text, textBoxMorada.Text, 
                float.Parse(textBoxSalario.Text),textBoxFuncao.Text);
            FuncionariosRefresh();
        }

        private void FuncionariosRefresh()
        {
            var funcionario = FuncionarioController.GetFuncionarios();
            listBoxFuncionarios.DataSource = null;
            listBoxFuncionarios.DataSource = funcionario;
        }
    }
}
