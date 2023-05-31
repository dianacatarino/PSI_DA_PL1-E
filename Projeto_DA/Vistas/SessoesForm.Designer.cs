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
			this.textBoxSala = new System.Windows.Forms.TextBox();
			this.textBoxFilmeSessoes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
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
			this.btAlterarSessoes.Location = new System.Drawing.Point(601, 311);
			this.btAlterarSessoes.Name = "btAlterarSessoes";
			this.btAlterarSessoes.Size = new System.Drawing.Size(75, 23);
			this.btAlterarSessoes.TabIndex = 18;
			this.btAlterarSessoes.Text = "Alterar";
			this.btAlterarSessoes.UseVisualStyleBackColor = true;
			// 
			// btAdicionarSessoes
			// 
			this.btAdicionarSessoes.Location = new System.Drawing.Point(459, 311);
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
			// textBoxSala
			// 
			this.textBoxSala.Location = new System.Drawing.Point(514, 180);
			this.textBoxSala.Name = "textBoxSala";
			this.textBoxSala.Size = new System.Drawing.Size(165, 22);
			this.textBoxSala.TabIndex = 12;
			// 
			// textBoxFilmeSessoes
			// 
			this.textBoxFilmeSessoes.Location = new System.Drawing.Point(514, 142);
			this.textBoxFilmeSessoes.Name = "textBoxFilmeSessoes";
			this.textBoxFilmeSessoes.Size = new System.Drawing.Size(165, 22);
			this.textBoxFilmeSessoes.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(456, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Consultar e Editar Sessões";
			// 
			// dateTimePickerInicio
			// 
			this.dateTimePickerInicio.Location = new System.Drawing.Point(459, 246);
			this.dateTimePickerInicio.Name = "dateTimePickerInicio";
			this.dateTimePickerInicio.Size = new System.Drawing.Size(217, 22);
			this.dateTimePickerInicio.TabIndex = 20;
			// 
			// dateTimePickerFim
			// 
			this.dateTimePickerFim.Location = new System.Drawing.Point(459, 274);
			this.dateTimePickerFim.Name = "dateTimePickerFim";
			this.dateTimePickerFim.Size = new System.Drawing.Size(217, 22);
			this.dateTimePickerFim.TabIndex = 21;
			// 
			// SessoesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateTimePickerFim);
			this.Controls.Add(this.dateTimePickerInicio);
			this.Controls.Add(this.listBoxSessoes);
			this.Controls.Add(this.btAlterarSessoes);
			this.Controls.Add(this.btAdicionarSessoes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxSala);
			this.Controls.Add(this.textBoxFilmeSessoes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SessoesForm";
			this.Text = "Sessões";
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
        private System.Windows.Forms.TextBox textBoxSala;
        private System.Windows.Forms.TextBox textBoxFilmeSessoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
    }
}