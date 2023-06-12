namespace Projeto_DA
{
    partial class ClientesForm
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
			this.listBoxClientes = new System.Windows.Forms.ListBox();
			this.btAlterarCliente = new System.Windows.Forms.Button();
			this.btAdicionarCliente = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNif = new System.Windows.Forms.TextBox();
			this.textBoxMorada = new System.Windows.Forms.TextBox();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNBilhetes = new System.Windows.Forms.TextBox();
			this.textBoxValorBilhetes = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
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
			this.voltarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.voltarToolStripMenuItem.Text = "Voltar";
			this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
			// 
			// listBoxClientes
			// 
			this.listBoxClientes.FormattingEnabled = true;
			this.listBoxClientes.ItemHeight = 16;
			this.listBoxClientes.Location = new System.Drawing.Point(108, 61);
			this.listBoxClientes.Name = "listBoxClientes";
			this.listBoxClientes.Size = new System.Drawing.Size(330, 308);
			this.listBoxClientes.TabIndex = 19;
			this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
			// 
			// btAlterarCliente
			// 
			this.btAlterarCliente.Location = new System.Drawing.Point(605, 335);
			this.btAlterarCliente.Name = "btAlterarCliente";
			this.btAlterarCliente.Size = new System.Drawing.Size(75, 23);
			this.btAlterarCliente.TabIndex = 18;
			this.btAlterarCliente.Text = "Alterar";
			this.btAlterarCliente.UseVisualStyleBackColor = true;
			this.btAlterarCliente.Click += new System.EventHandler(this.btAlterarCliente_Click);
			// 
			// btAdicionarCliente
			// 
			this.btAdicionarCliente.Location = new System.Drawing.Point(498, 335);
			this.btAdicionarCliente.Name = "btAdicionarCliente";
			this.btAdicionarCliente.Size = new System.Drawing.Size(92, 23);
			this.btAdicionarCliente.TabIndex = 17;
			this.btAdicionarCliente.Text = "Adicionar";
			this.btAdicionarCliente.UseVisualStyleBackColor = true;
			this.btAdicionarCliente.Click += new System.EventHandler(this.btAdicionarCliente_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(478, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Nif:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(457, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Morada:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(457, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Nome:";
			// 
			// textBoxNif
			// 
			this.textBoxNif.Location = new System.Drawing.Point(515, 202);
			this.textBoxNif.Name = "textBoxNif";
			this.textBoxNif.Size = new System.Drawing.Size(165, 22);
			this.textBoxNif.TabIndex = 13;
			// 
			// textBoxMorada
			// 
			this.textBoxMorada.Location = new System.Drawing.Point(515, 161);
			this.textBoxMorada.Name = "textBoxMorada";
			this.textBoxMorada.Size = new System.Drawing.Size(165, 22);
			this.textBoxMorada.TabIndex = 12;
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(515, 123);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(165, 22);
			this.textBoxNome.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(495, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Consultar e Editar Clientes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(457, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "Nº bilhetes:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(457, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 16);
			this.label6.TabIndex = 21;
			this.label6.Text = "Valor bilhetes:";
			// 
			// textBoxNBilhetes
			// 
			this.textBoxNBilhetes.Location = new System.Drawing.Point(538, 270);
			this.textBoxNBilhetes.Name = "textBoxNBilhetes";
			this.textBoxNBilhetes.Size = new System.Drawing.Size(52, 22);
			this.textBoxNBilhetes.TabIndex = 22;
			// 
			// textBoxValorBilhetes
			// 
			this.textBoxValorBilhetes.Location = new System.Drawing.Point(555, 302);
			this.textBoxValorBilhetes.Name = "textBoxValorBilhetes";
			this.textBoxValorBilhetes.Size = new System.Drawing.Size(55, 22);
			this.textBoxValorBilhetes.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(523, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 16);
			this.label7.TabIndex = 24;
			this.label7.Text = "Bilhetes Adquiridos";
			// 
			// ClientesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxValorBilhetes);
			this.Controls.Add(this.textBoxNBilhetes);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBoxClientes);
			this.Controls.Add(this.btAlterarCliente);
			this.Controls.Add(this.btAdicionarCliente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNif);
			this.Controls.Add(this.textBoxMorada);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ClientesForm";
			this.Text = "Clientes";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button btAlterarCliente;
        private System.Windows.Forms.Button btAdicionarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNBilhetes;
        private System.Windows.Forms.TextBox textBoxValorBilhetes;
        private System.Windows.Forms.Label label7;
	}
}