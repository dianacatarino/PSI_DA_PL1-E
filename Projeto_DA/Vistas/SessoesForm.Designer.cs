namespace Projeto_DA
{
    partial class SessoesForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxSessoes = new System.Windows.Forms.ListBox();
			this.btAlterarSessoes = new System.Windows.Forms.Button();
			this.btAdicionarSessoes = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
			this.comboBoxFilme = new System.Windows.Forms.ComboBox();
			this.comboBoxSala = new System.Windows.Forms.ComboBox();
			this.textBoxHora = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
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
			// listBoxSessoes
			// 
			this.listBoxSessoes.FormattingEnabled = true;
			this.listBoxSessoes.ItemHeight = 16;
			this.listBoxSessoes.Location = new System.Drawing.Point(108, 61);
			this.listBoxSessoes.Name = "listBoxSessoes";
			this.listBoxSessoes.Size = new System.Drawing.Size(330, 308);
			this.listBoxSessoes.TabIndex = 19;
			this.listBoxSessoes.SelectedIndexChanged += new System.EventHandler(this.listBoxSessoes_SelectedIndexChanged);
			// 
			// btAlterarSessoes
			// 
			this.btAlterarSessoes.Location = new System.Drawing.Point(601, 325);
			this.btAlterarSessoes.Name = "btAlterarSessoes";
			this.btAlterarSessoes.Size = new System.Drawing.Size(75, 23);
			this.btAlterarSessoes.TabIndex = 18;
			this.btAlterarSessoes.Text = "Alterar";
			this.btAlterarSessoes.UseVisualStyleBackColor = true;
			this.btAlterarSessoes.Click += new System.EventHandler(this.btAlterarSessoes_Click);
			// 
			// btAdicionarSessoes
			// 
			this.btAdicionarSessoes.Location = new System.Drawing.Point(459, 325);
			this.btAdicionarSessoes.Name = "btAdicionarSessoes";
			this.btAdicionarSessoes.Size = new System.Drawing.Size(83, 23);
			this.btAdicionarSessoes.TabIndex = 17;
			this.btAdicionarSessoes.Text = "Adicionar";
			this.btAdicionarSessoes.UseVisualStyleBackColor = true;
			this.btAdicionarSessoes.Click += new System.EventHandler(this.btAdicionarSessoes_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(459, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Data e Hora:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(456, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Sala:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(456, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Filme:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(489, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Consultar e Editar Sessões";
			// 
			// dateTimePickerData
			// 
			this.dateTimePickerData.Location = new System.Drawing.Point(459, 246);
			this.dateTimePickerData.Name = "dateTimePickerData";
			this.dateTimePickerData.Size = new System.Drawing.Size(217, 22);
			this.dateTimePickerData.TabIndex = 20;
			// 
			// comboBoxFilme
			// 
			this.comboBoxFilme.FormattingEnabled = true;
			this.comboBoxFilme.Location = new System.Drawing.Point(505, 144);
			this.comboBoxFilme.Name = "comboBoxFilme";
			this.comboBoxFilme.Size = new System.Drawing.Size(171, 24);
			this.comboBoxFilme.TabIndex = 22;
			// 
			// comboBoxSala
			// 
			this.comboBoxSala.FormattingEnabled = true;
			this.comboBoxSala.Location = new System.Drawing.Point(505, 183);
			this.comboBoxSala.Name = "comboBoxSala";
			this.comboBoxSala.Size = new System.Drawing.Size(171, 24);
			this.comboBoxSala.TabIndex = 23;
			// 
			// textBoxHora
			// 
			this.textBoxHora.Location = new System.Drawing.Point(459, 285);
			this.textBoxHora.Name = "textBoxHora";
			this.textBoxHora.Size = new System.Drawing.Size(217, 22);
			this.textBoxHora.TabIndex = 24;
			// 
			// SessoesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxHora);
			this.Controls.Add(this.comboBoxSala);
			this.Controls.Add(this.comboBoxFilme);
			this.Controls.Add(this.dateTimePickerData);
			this.Controls.Add(this.listBoxSessoes);
			this.Controls.Add(this.btAlterarSessoes);
			this.Controls.Add(this.btAdicionarSessoes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SessoesForm";
			this.Text = "Sessões";
			this.Load += new System.EventHandler(this.SessoesForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSessoes;
        private System.Windows.Forms.Button btAlterarSessoes;
        private System.Windows.Forms.Button btAdicionarSessoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
		private System.Windows.Forms.ComboBox comboBoxFilme;
		private System.Windows.Forms.ComboBox comboBoxSala;
		private System.Windows.Forms.TextBox textBoxHora;
	}
}