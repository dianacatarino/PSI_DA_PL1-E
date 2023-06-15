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

namespace Projeto_DA.Vistas
{
    public partial class FuncionariosForm : Form
    {
		public string NomeFuncionario { get; private set; }
		private string nomeFuncionario;
		private Projeto_DA.Modelos.ApplicationContext db;

		public FuncionariosForm(string nomeFuncionario)
        {
            InitializeComponent();
			this.nomeFuncionario = nomeFuncionario;
			menuToolStripMenuItem.Text = nomeFuncionario;
			db = new Projeto_DA.Modelos.ApplicationContext();
			FuncionariosRefresh();
		}

		private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm(nomeFuncionario);
			Hide();
			menuForm.ShowDialog();
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
        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxFuncionarios.SelectedIndex == -1)
			{
				return;
			}

			Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

			textBoxNome.Text = funcionario.Nome;
			textBoxMorada.Text = funcionario.Morada;
			textBoxSalario.Text = funcionario.Salario.ToString();
            textBoxFuncao.Text = funcionario.Funcao;
		}

		private void btAlterarFuncionario_Click(object sender, EventArgs e)
		{
			if (listBoxFuncionarios.SelectedItem == null)
			{
				MessageBox.Show("Selecione um funcionário para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem;

			string novoNome = textBoxNome.Text;
			string novaMorada = textBoxMorada.Text;
			float novoSalario = float.Parse(textBoxSalario.Text);
			string novaFuncao = textBoxFuncao.Text;

			FuncionarioController.AlterarFuncionario(funcionarioSelecionado.Id, novoNome, novaMorada,
				novoSalario, novaFuncao);

			FuncionariosRefresh();
		}

		private void btRemoverFuncionario_Click(object sender, EventArgs e)
		{
			if (listBoxFuncionarios.SelectedItem == null)
			{
				MessageBox.Show("Selecione um funcionário para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem;

			DialogResult result = MessageBox.Show($"Tem certeza que deseja remover o funcionário {funcionarioSelecionado.Nome}?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				FuncionarioController.RemoverFuncionario(funcionarioSelecionado.Id);
				FuncionariosRefresh();
			}
		}

		private void FuncionariosForm_Load(object sender, EventArgs e)
		{
			menuToolStripMenuItem.Text = nomeFuncionario;
		}
	}
}
