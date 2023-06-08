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
	public partial class AlterarForm : Form
	{
		public AlterarForm()
		{
			InitializeComponent();
		}

		private void AlterarForm_Load(object sender, EventArgs e)
		{
			var funcionarios = FuncionarioController.GetFuncionarios();

			comboBoxFuncionario.DataSource = funcionarios;
			comboBoxFuncionario.DisplayMember = "Nome";
		}

		private void buttonEntrar_Click(object sender, EventArgs e)
		{
			if (comboBoxFuncionario.SelectedItem != null)
			{
				Funcionario funcionarioSelecionado = (Funcionario)comboBoxFuncionario.SelectedItem;

				// Autentique o funcionário
				if (FuncionarioController.EntrarFuncionario(funcionarioSelecionado))
				{
					// Funcionário autenticado com sucesso, abra o formulário principal
					MenuForm menuForm = new MenuForm();
					menuForm.AtualizarNomeFuncionario(funcionarioSelecionado);
					menuForm.Show();

					this.Close();
				}
				else
				{
					MessageBox.Show("Funcionário não autenticado. Verifique suas credenciais.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
