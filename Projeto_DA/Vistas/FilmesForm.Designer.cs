namespace Projeto_DA
{
    partial class FilmesForm
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
			this.btAlterarFilme = new System.Windows.Forms.Button();
			this.btAdicionarFilme = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCategoria = new System.Windows.Forms.TextBox();
			this.textBoxDuracao = new System.Windows.Forms.TextBox();
			this.textBoxNomeFilme = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxFilmes = new System.Windows.Forms.ListBox();
			this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btAlterarFilme
			// 
			this.btAlterarFilme.Location = new System.Drawing.Point(609, 267);
			this.btAlterarFilme.Name = "btAlterarFilme";
			this.btAlterarFilme.Size = new System.Drawing.Size(75, 23);
			this.btAlterarFilme.TabIndex = 17;
			this.btAlterarFilme.Text = "Alterar";
			this.btAlterarFilme.UseVisualStyleBackColor = true;
			// 
			// btAdicionarFilme
			// 
			this.btAdicionarFilme.Location = new System.Drawing.Point(522, 267);
			this.btAdicionarFilme.Name = "btAdicionarFilme";
			this.btAdicionarFilme.Size = new System.Drawing.Size(81, 23);
			this.btAdicionarFilme.TabIndex = 16;
			this.btAdicionarFilme.Text = "Adicionar";
			this.btAdicionarFilme.UseVisualStyleBackColor = true;
			this.btAdicionarFilme.Click += new System.EventHandler(this.btAdicionarFilme_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(454, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Categoria:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(454, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Duração:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(461, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nome:";
			// 
			// textBoxCategoria
			// 
			this.textBoxCategoria.Location = new System.Drawing.Point(522, 232);
			this.textBoxCategoria.Name = "textBoxCategoria";
			this.textBoxCategoria.Size = new System.Drawing.Size(165, 22);
			this.textBoxCategoria.TabIndex = 12;
			// 
			// textBoxDuracao
			// 
			this.textBoxDuracao.Location = new System.Drawing.Point(522, 191);
			this.textBoxDuracao.Name = "textBoxDuracao";
			this.textBoxDuracao.Size = new System.Drawing.Size(165, 22);
			this.textBoxDuracao.TabIndex = 11;
			// 
			// textBoxNomeFilme
			// 
			this.textBoxNomeFilme.Location = new System.Drawing.Point(522, 153);
			this.textBoxNomeFilme.Name = "textBoxNomeFilme";
			this.textBoxNomeFilme.Size = new System.Drawing.Size(165, 22);
			this.textBoxNomeFilme.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(461, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Consultar e Editar Filmes";
			// 
			// listBoxFilmes
			// 
			this.listBoxFilmes.FormattingEnabled = true;
			this.listBoxFilmes.ItemHeight = 16;
			this.listBoxFilmes.Location = new System.Drawing.Point(108, 61);
			this.listBoxFilmes.Name = "listBoxFilmes";
			this.listBoxFilmes.Size = new System.Drawing.Size(330, 308);
			this.listBoxFilmes.TabIndex = 18;
			this.listBoxFilmes.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmes_SelectedIndexChanged);
			// 
			// checkBoxAtivo
			// 
			this.checkBoxAtivo.AutoSize = true;
			this.checkBoxAtivo.Location = new System.Drawing.Point(457, 269);
			this.checkBoxAtivo.Name = "checkBoxAtivo";
			this.checkBoxAtivo.Size = new System.Drawing.Size(59, 20);
			this.checkBoxAtivo.TabIndex = 19;
			this.checkBoxAtivo.Text = "Ativo";
			this.checkBoxAtivo.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// voltarToolStripMenuItem
			// 
			this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
			this.voltarToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
			this.voltarToolStripMenuItem.Text = "Voltar";
			this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
			// 
			// FilmesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBoxAtivo);
			this.Controls.Add(this.listBoxFilmes);
			this.Controls.Add(this.btAlterarFilme);
			this.Controls.Add(this.btAdicionarFilme);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxCategoria);
			this.Controls.Add(this.textBoxDuracao);
			this.Controls.Add(this.textBoxNomeFilme);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FilmesForm";
			this.Text = "Filmes";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlterarFilme;
        private System.Windows.Forms.Button btAdicionarFilme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxDuracao;
        private System.Windows.Forms.TextBox textBoxNomeFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFilmes;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}