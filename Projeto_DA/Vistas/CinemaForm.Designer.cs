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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar e Editar Cinema";
            // 
            // textBoxNomeCinema
            // 
            this.textBoxNomeCinema.Location = new System.Drawing.Point(410, 146);
            this.textBoxNomeCinema.Name = "textBoxNomeCinema";
            this.textBoxNomeCinema.Size = new System.Drawing.Size(165, 22);
            this.textBoxNomeCinema.TabIndex = 1;
            // 
            // textBoxMoradaCinema
            // 
            this.textBoxMoradaCinema.Location = new System.Drawing.Point(410, 184);
            this.textBoxMoradaCinema.Name = "textBoxMoradaCinema";
            this.textBoxMoradaCinema.Size = new System.Drawing.Size(165, 22);
            this.textBoxMoradaCinema.TabIndex = 2;
            // 
            // textBoxEmailCinema
            // 
            this.textBoxEmailCinema.Location = new System.Drawing.Point(410, 225);
            this.textBoxEmailCinema.Name = "textBoxEmailCinema";
            this.textBoxEmailCinema.Size = new System.Drawing.Size(165, 22);
            this.textBoxEmailCinema.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // btAdicionarCinema
            // 
            this.btAdicionarCinema.Location = new System.Drawing.Point(410, 277);
            this.btAdicionarCinema.Name = "btAdicionarCinema";
            this.btAdicionarCinema.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarCinema.TabIndex = 7;
            this.btAdicionarCinema.Text = "Adicionar";
            this.btAdicionarCinema.UseVisualStyleBackColor = true;
            this.btAdicionarCinema.Click += new System.EventHandler(this.btAdicionarCinema_Click);
            // 
            // btAlterarCinema
            // 
            this.btAlterarCinema.Location = new System.Drawing.Point(500, 277);
            this.btAlterarCinema.Name = "btAlterarCinema";
            this.btAlterarCinema.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCinema.TabIndex = 8;
            this.btAlterarCinema.Text = "Alterar";
            this.btAlterarCinema.UseVisualStyleBackColor = true;
            // 
            // listBoxCinema
            // 
            this.listBoxCinema.FormattingEnabled = true;
            this.listBoxCinema.ItemHeight = 16;
            this.listBoxCinema.Location = new System.Drawing.Point(168, 146);
            this.listBoxCinema.Name = "listBoxCinema";
            this.listBoxCinema.Size = new System.Drawing.Size(149, 116);
            this.listBoxCinema.TabIndex = 9;
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
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}