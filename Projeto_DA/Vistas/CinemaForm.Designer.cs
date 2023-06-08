namespace Projeto_DA
{
    partial class CinemaForm
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
			this.textBoxNomeCinema = new System.Windows.Forms.TextBox();
			this.textBoxMoradaCinema = new System.Windows.Forms.TextBox();
			this.textBoxEmailCinema = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btAdicionarCinema = new System.Windows.Forms.Button();
			this.btAlterarCinema = new System.Windows.Forms.Button();
			this.listBoxCinema = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNomeSala = new System.Windows.Forms.TextBox();
			this.textBoxColunas = new System.Windows.Forms.TextBox();
			this.textBoxFilas = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btAdicionarSala = new System.Windows.Forms.Button();
			this.btAlterarSala = new System.Windows.Forms.Button();
			this.listBoxSalas = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(319, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consultar e Editar Cinema";
			// 
			// textBoxNomeCinema
			// 
			this.textBoxNomeCinema.Location = new System.Drawing.Point(482, 70);
			this.textBoxNomeCinema.Name = "textBoxNomeCinema";
			this.textBoxNomeCinema.Size = new System.Drawing.Size(165, 22);
			this.textBoxNomeCinema.TabIndex = 1;
			// 
			// textBoxMoradaCinema
			// 
			this.textBoxMoradaCinema.Location = new System.Drawing.Point(482, 108);
			this.textBoxMoradaCinema.Name = "textBoxMoradaCinema";
			this.textBoxMoradaCinema.Size = new System.Drawing.Size(165, 22);
			this.textBoxMoradaCinema.TabIndex = 2;
			// 
			// textBoxEmailCinema
			// 
			this.textBoxEmailCinema.Location = new System.Drawing.Point(482, 149);
			this.textBoxEmailCinema.Name = "textBoxEmailCinema";
			this.textBoxEmailCinema.Size = new System.Drawing.Size(165, 22);
			this.textBoxEmailCinema.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(424, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(424, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Morada:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(427, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email:";
			// 
			// btAdicionarCinema
			// 
			this.btAdicionarCinema.Location = new System.Drawing.Point(483, 177);
			this.btAdicionarCinema.Name = "btAdicionarCinema";
			this.btAdicionarCinema.Size = new System.Drawing.Size(85, 23);
			this.btAdicionarCinema.TabIndex = 7;
			this.btAdicionarCinema.Text = "Adicionar Cinema";
			this.btAdicionarCinema.UseVisualStyleBackColor = true;
			this.btAdicionarCinema.Click += new System.EventHandler(this.btAdicionarCinema_Click);
			// 
			// btAlterarCinema
			// 
			this.btAlterarCinema.Location = new System.Drawing.Point(572, 177);
			this.btAlterarCinema.Name = "btAlterarCinema";
			this.btAlterarCinema.Size = new System.Drawing.Size(75, 23);
			this.btAlterarCinema.TabIndex = 8;
			this.btAlterarCinema.Text = "Alterar";
			this.btAlterarCinema.UseVisualStyleBackColor = true;
			this.btAlterarCinema.Click += new System.EventHandler(this.btAlterarCinema_Click);
			// 
			// listBoxCinema
			// 
			this.listBoxCinema.FormattingEnabled = true;
			this.listBoxCinema.ItemHeight = 16;
			this.listBoxCinema.Location = new System.Drawing.Point(129, 70);
			this.listBoxCinema.Name = "listBoxCinema";
			this.listBoxCinema.Size = new System.Drawing.Size(278, 36);
			this.listBoxCinema.TabIndex = 9;
			this.listBoxCinema.SelectedIndexChanged += new System.EventHandler(this.listBoxCinema_SelectedIndexChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 10;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(356, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Gestão das Salas";
			// 
			// textBoxNomeSala
			// 
			this.textBoxNomeSala.Location = new System.Drawing.Point(482, 267);
			this.textBoxNomeSala.Name = "textBoxNomeSala";
			this.textBoxNomeSala.Size = new System.Drawing.Size(165, 22);
			this.textBoxNomeSala.TabIndex = 12;
			// 
			// textBoxColunas
			// 
			this.textBoxColunas.Location = new System.Drawing.Point(482, 305);
			this.textBoxColunas.Name = "textBoxColunas";
			this.textBoxColunas.Size = new System.Drawing.Size(165, 22);
			this.textBoxColunas.TabIndex = 13;
			// 
			// textBoxFilas
			// 
			this.textBoxFilas.Location = new System.Drawing.Point(483, 349);
			this.textBoxFilas.Name = "textBoxFilas";
			this.textBoxFilas.Size = new System.Drawing.Size(165, 22);
			this.textBoxFilas.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(424, 267);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Nome:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(414, 308);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Colunas:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(424, 349);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Filas:";
			// 
			// btAdicionarSala
			// 
			this.btAdicionarSala.Location = new System.Drawing.Point(482, 377);
			this.btAdicionarSala.Name = "btAdicionarSala";
			this.btAdicionarSala.Size = new System.Drawing.Size(85, 23);
			this.btAdicionarSala.TabIndex = 18;
			this.btAdicionarSala.Text = "Adicionar Cinema";
			this.btAdicionarSala.UseVisualStyleBackColor = true;
			this.btAdicionarSala.Click += new System.EventHandler(this.btAdicionarSala_Click);
			// 
			// btAlterarSala
			// 
			this.btAlterarSala.Location = new System.Drawing.Point(572, 377);
			this.btAlterarSala.Name = "btAlterarSala";
			this.btAlterarSala.Size = new System.Drawing.Size(75, 23);
			this.btAlterarSala.TabIndex = 19;
			this.btAlterarSala.Text = "Alterar";
			this.btAlterarSala.UseVisualStyleBackColor = true;
			this.btAlterarSala.Click += new System.EventHandler(this.btAlterarSala_Click);
			// 
			// listBoxSalas
			// 
			this.listBoxSalas.FormattingEnabled = true;
			this.listBoxSalas.ItemHeight = 16;
			this.listBoxSalas.Location = new System.Drawing.Point(129, 253);
			this.listBoxSalas.Name = "listBoxSalas";
			this.listBoxSalas.Size = new System.Drawing.Size(278, 148);
			this.listBoxSalas.TabIndex = 20;
			this.listBoxSalas.SelectedIndexChanged += new System.EventHandler(this.listBoxSalas_SelectedIndexChanged);
			// 
			// CinemaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBoxSalas);
			this.Controls.Add(this.btAlterarSala);
			this.Controls.Add(this.btAdicionarSala);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxFilas);
			this.Controls.Add(this.textBoxColunas);
			this.Controls.Add(this.textBoxNomeSala);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBoxCinema);
			this.Controls.Add(this.btAlterarCinema);
			this.Controls.Add(this.btAdicionarCinema);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxEmailCinema);
			this.Controls.Add(this.textBoxMoradaCinema);
			this.Controls.Add(this.textBoxNomeCinema);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CinemaForm";
			this.Text = "Cinema";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeCinema;
        private System.Windows.Forms.TextBox textBoxMoradaCinema;
        private System.Windows.Forms.TextBox textBoxEmailCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionarCinema;
        private System.Windows.Forms.Button btAlterarCinema;
        private System.Windows.Forms.ListBox listBoxCinema;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNomeSala;
		private System.Windows.Forms.TextBox textBoxColunas;
		private System.Windows.Forms.TextBox textBoxFilas;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btAdicionarSala;
		private System.Windows.Forms.Button btAlterarSala;
		private System.Windows.Forms.ListBox listBoxSalas;
	}
}