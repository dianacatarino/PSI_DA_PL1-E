namespace Projeto_DA
{
    partial class MenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btCinema = new System.Windows.Forms.Button();
			this.btFilmes = new System.Windows.Forms.Button();
			this.btSessoes = new System.Windows.Forms.Button();
			this.btClientes = new System.Windows.Forms.Button();
			this.btFuncionarios = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxSessoesAtuais = new System.Windows.Forms.ListBox();
			this.btCriarBilhete = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btCinema
			// 
			this.btCinema.Location = new System.Drawing.Point(563, 121);
			this.btCinema.Name = "btCinema";
			this.btCinema.Size = new System.Drawing.Size(208, 23);
			this.btCinema.TabIndex = 0;
			this.btCinema.Text = "Cinema";
			this.btCinema.UseVisualStyleBackColor = true;
			this.btCinema.Click += new System.EventHandler(this.btCinema_Click);
			// 
			// btFilmes
			// 
			this.btFilmes.Location = new System.Drawing.Point(563, 164);
			this.btFilmes.Name = "btFilmes";
			this.btFilmes.Size = new System.Drawing.Size(208, 23);
			this.btFilmes.TabIndex = 1;
			this.btFilmes.Text = "Filmes";
			this.btFilmes.UseVisualStyleBackColor = true;
			this.btFilmes.Click += new System.EventHandler(this.btFilmes_Click);
			// 
			// btSessoes
			// 
			this.btSessoes.Location = new System.Drawing.Point(563, 212);
			this.btSessoes.Name = "btSessoes";
			this.btSessoes.Size = new System.Drawing.Size(208, 23);
			this.btSessoes.TabIndex = 2;
			this.btSessoes.Text = "Sessões";
			this.btSessoes.UseVisualStyleBackColor = true;
			this.btSessoes.Click += new System.EventHandler(this.btSessoes_Click);
			// 
			// btClientes
			// 
			this.btClientes.Location = new System.Drawing.Point(563, 257);
			this.btClientes.Name = "btClientes";
			this.btClientes.Size = new System.Drawing.Size(208, 23);
			this.btClientes.TabIndex = 3;
			this.btClientes.Text = "Clientes";
			this.btClientes.UseVisualStyleBackColor = true;
			this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
			// 
			// btFuncionarios
			// 
			this.btFuncionarios.Location = new System.Drawing.Point(563, 301);
			this.btFuncionarios.Name = "btFuncionarios";
			this.btFuncionarios.Size = new System.Drawing.Size(208, 23);
			this.btFuncionarios.TabIndex = 4;
			this.btFuncionarios.Text = "Funcionários";
			this.btFuncionarios.UseVisualStyleBackColor = true;
			this.btFuncionarios.Click += new System.EventHandler(this.btFuncionarios_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(617, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Menu Principal";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// funcionarioToolStripMenuItem
			// 
			this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem});
			this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
			this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
			this.funcionarioToolStripMenuItem.Text = "Funcionário";
			// 
			// alterarToolStripMenuItem
			// 
			this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
			this.alterarToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
			this.alterarToolStripMenuItem.Text = "Alterar";
			this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
			// 
			// listBoxSessoesAtuais
			// 
			this.listBoxSessoesAtuais.FormattingEnabled = true;
			this.listBoxSessoesAtuais.ItemHeight = 16;
			this.listBoxSessoesAtuais.Location = new System.Drawing.Point(200, 74);
			this.listBoxSessoesAtuais.Name = "listBoxSessoesAtuais";
			this.listBoxSessoesAtuais.Size = new System.Drawing.Size(344, 260);
			this.listBoxSessoesAtuais.TabIndex = 8;
			this.listBoxSessoesAtuais.SelectedIndexChanged += new System.EventHandler(this.listBoxSessoesAtuais_SelectedIndexChanged);
			// 
			// btCriarBilhete
			// 
			this.btCriarBilhete.Location = new System.Drawing.Point(318, 349);
			this.btCriarBilhete.Name = "btCriarBilhete";
			this.btCriarBilhete.Size = new System.Drawing.Size(120, 23);
			this.btCriarBilhete.TabIndex = 9;
			this.btCriarBilhete.Text = "Criar Bilhete";
			this.btCriarBilhete.UseVisualStyleBackColor = true;
			this.btCriarBilhete.Click += new System.EventHandler(this.btCriarBilhete_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btCriarBilhete);
			this.Controls.Add(this.listBoxSessoesAtuais);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btFuncionarios);
			this.Controls.Add(this.btClientes);
			this.Controls.Add(this.btSessoes);
			this.Controls.Add(this.btFilmes);
			this.Controls.Add(this.btCinema);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MenuForm";
			this.Text = "CineGest";
			this.Load += new System.EventHandler(this.MenuForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCinema;
        private System.Windows.Forms.Button btFilmes;
        private System.Windows.Forms.Button btSessoes;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
		private System.Windows.Forms.ListBox listBoxSessoesAtuais;
		private System.Windows.Forms.Button btCriarBilhete;
	}
}

