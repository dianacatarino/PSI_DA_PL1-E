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
		private Funcionario funcionarioSelecionado;

		public AlterarForm(Funcionario funcionario)
		{
			InitializeComponent();
			funcionarioSelecionado = funcionario;
		}

		private void AlterarForm_Load(object sender, EventArgs e)
		{
			// Carrega os funcionários existentes na ComboBox
			CarregarFuncionarios();

			// Seleciona o funcionário atual na ComboBox
			comboBoxFuncionario.SelectedItem = funcionarioSelecionado;
		}

		private void CarregarFuncionarios()
		{
			List<Funcionario> funcionarios = FuncionarioController.GetFuncionarios();

			comboBoxFuncionario.Items.Clear();
			comboBoxFuncionario.DisplayMember = "Nome";

			foreach (var funcionario in funcionarios)
			{
				comboBoxFuncionario.Items.Add(funcionario);
			}
		}

		private void comboBoxNome_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Obtém o funcionário selecionado na ComboBox
			funcionarioSelecionado = (Funcionario)comboBoxFuncionario.SelectedItem;
		}

		private void buttonEntrar_Click(object sender, EventArgs e)
		{
			string nomeFuncionario = comboBoxFuncionario.Text;

			// Verifica se o nome do funcionário está preenchido
			if (!string.IsNullOrEmpty(nomeFuncionario))
			{
				// Obtém o funcionário pelo nome
				Funcionario funcionario = FuncionarioController.GetFuncionarios()
					.FirstOrDefault(f => f.Nome.Equals(nomeFuncionario, StringComparison.OrdinalIgnoreCase));

				if (funcionario != null)
				{
					// Exibe uma mensagem de sucesso
					MessageBox.Show("Funcionário autenticado com sucesso!");

					// Cria uma instância do MenuForm
					MenuForm menuForm = new MenuForm();

					// Atualiza o nome do funcionário no MenuForm
					menuForm.AtualizarNomeFuncionario(funcionario);

					// Oculta o formulário atual
					Hide();

					// Exibe o MenuForm
					menuForm.Show();
				}
				else
				{
					// Exibe uma mensagem de erro se o funcionário não for encontrado
					MessageBox.Show("Funcionário não encontrado. Verifique o nome e tente novamente.");
				}
			}
			else
			{
				// Exibe uma mensagem de erro se o nome do funcionário estiver em branco
				MessageBox.Show("Por favor, informe o nome do funcionário.");
			}
		}
	}
}

