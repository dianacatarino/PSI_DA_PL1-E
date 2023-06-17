namespace Projeto_DA
{
    partial class AtendimentoForm
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
			this.btCriarBilheteCliente = new System.Windows.Forms.Button();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxMorada = new System.Windows.Forms.TextBox();
			this.textBoxNif = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btCarregarCliente = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxClientes = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridViewLugares = new System.Windows.Forms.DataGridView();
			this.Linhas = new System.Windows.Forms.DataGridViewImageColumn();
			this.Colunas = new System.Windows.Forms.DataGridViewImageColumn();
			this.buttonCarregarSala = new System.Windows.Forms.Button();
			this.textBoxSala = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLugares)).BeginInit();
			this.SuspendLayout();
			// 
			// btCriarBilheteCliente
			// 
			this.btCriarBilheteCliente.Location = new System.Drawing.Point(170, 227);
			this.btCriarBilheteCliente.Name = "btCriarBilheteCliente";
			this.btCriarBilheteCliente.Size = new System.Drawing.Size(100, 23);
			this.btCriarBilheteCliente.TabIndex = 1;
			this.btCriarBilheteCliente.Text = "Criar Bilhete";
			this.btCriarBilheteCliente.UseVisualStyleBackColor = true;
			this.btCriarBilheteCliente.Click += new System.EventHandler(this.btCriarBilheteCliente_Click);
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(102, 92);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(177, 22);
			this.textBoxNome.TabIndex = 32;
			// 
			// textBoxMorada
			// 
			this.textBoxMorada.Location = new System.Drawing.Point(102, 139);
			this.textBoxMorada.Name = "textBoxMorada";
			this.textBoxMorada.Size = new System.Drawing.Size(177, 22);
			this.textBoxMorada.TabIndex = 33;
			// 
			// textBoxNif
			// 
			this.textBoxNif.Location = new System.Drawing.Point(102, 186);
			this.textBoxNif.Name = "textBoxNif";
			this.textBoxNif.Size = new System.Drawing.Size(177, 22);
			this.textBoxNif.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 36;
			this.label2.Text = "Morada:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "Nif:";
			// 
			// btCarregarCliente
			// 
			this.btCarregarCliente.Location = new System.Drawing.Point(43, 226);
			this.btCarregarCliente.Name = "btCarregarCliente";
			this.btCarregarCliente.Size = new System.Drawing.Size(121, 24);
			this.btCarregarCliente.TabIndex = 38;
			this.btCarregarCliente.Text = "Carregar Cliente";
			this.btCarregarCliente.UseVisualStyleBackColor = true;
			this.btCarregarCliente.Click += new System.EventHandler(this.btCarregarCliente_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(118, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 16);
			this.label4.TabIndex = 39;
			this.label4.Text = "Dados do Cliente";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 40;
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
			// listBoxClientes
			// 
			this.listBoxClientes.FormattingEnabled = true;
			this.listBoxClientes.ItemHeight = 16;
			this.listBoxClientes.Location = new System.Drawing.Point(37, 265);
			this.listBoxClientes.Name = "listBoxClientes";
			this.listBoxClientes.Size = new System.Drawing.Size(242, 164);
			this.listBoxClientes.TabIndex = 41;
			this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(402, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 16);
			this.label5.TabIndex = 43;
			this.label5.Text = "Sala:";
			// 
			// dataGridViewLugares
			// 
			this.dataGridViewLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLugares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linhas,
            this.Colunas});
			this.dataGridViewLugares.Location = new System.Drawing.Point(324, 75);
			this.dataGridViewLugares.Name = "dataGridViewLugares";
			this.dataGridViewLugares.RowHeadersWidth = 51;
			this.dataGridViewLugares.RowTemplate.Height = 24;
			this.dataGridViewLugares.Size = new System.Drawing.Size(453, 354);
			this.dataGridViewLugares.TabIndex = 44;
			// 
			// Linhas
			// 
			this.Linhas.HeaderText = "Colunas";
			this.Linhas.MinimumWidth = 6;
			this.Linhas.Name = "Linhas";
			this.Linhas.Width = 125;
			// 
			// Colunas
			// 
			this.Colunas.HeaderText = "Linhas";
			this.Colunas.MinimumWidth = 6;
			this.Colunas.Name = "Colunas";
			this.Colunas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Colunas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Colunas.Width = 125;
			// 
			// buttonCarregarSala
			// 
			this.buttonCarregarSala.Location = new System.Drawing.Point(618, 30);
			this.buttonCarregarSala.Name = "buttonCarregarSala";
			this.buttonCarregarSala.Size = new System.Drawing.Size(125, 24);
			this.buttonCarregarSala.TabIndex = 45;
			this.buttonCarregarSala.Text = "Carregar Sala";
			this.buttonCarregarSala.UseVisualStyleBackColor = true;
			this.buttonCarregarSala.Click += new System.EventHandler(this.buttonCarregarSala_Click);
			// 
			// textBoxSala
			// 
			this.textBoxSala.Location = new System.Drawing.Point(446, 31);
			this.textBoxSala.Name = "textBoxSala";
			this.textBoxSala.Size = new System.Drawing.Size(166, 22);
			this.textBoxSala.TabIndex = 46;
			// 
			// AtendimentoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 504);
			this.Controls.Add(this.textBoxSala);
			this.Controls.Add(this.buttonCarregarSala);
			this.Controls.Add(this.dataGridViewLugares);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBoxClientes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btCarregarCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxNif);
			this.Controls.Add(this.textBoxMorada);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.btCriarBilheteCliente);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AtendimentoForm";
			this.Text = "Atendimento";
			this.Load += new System.EventHandler(this.AtendimentoForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLugares)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCriarBilheteCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCarregarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
		private System.Windows.Forms.ListBox listBoxClientes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridViewLugares;
		private System.Windows.Forms.Button buttonCarregarSala;
		private System.Windows.Forms.DataGridViewImageColumn Linhas;
		private System.Windows.Forms.DataGridViewImageColumn Colunas;
		private System.Windows.Forms.TextBox textBoxSala;
	}
}