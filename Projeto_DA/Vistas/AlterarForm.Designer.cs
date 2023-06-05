namespace Projeto_DA.Vistas
{
	partial class AlterarForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonEntrar = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alterar Funcionário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome:";
			// 
			// buttonEntrar
			// 
			this.buttonEntrar.Location = new System.Drawing.Point(290, 86);
			this.buttonEntrar.Name = "buttonEntrar";
			this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
			this.buttonEntrar.TabIndex = 5;
			this.buttonEntrar.Text = "Entrar";
			this.buttonEntrar.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(134, 86);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(150, 24);
			this.comboBox1.TabIndex = 6;
			// 
			// AlterarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 178);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.buttonEntrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AlterarForm";
			this.Text = "AlterarForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonEntrar;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}