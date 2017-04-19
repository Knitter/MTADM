namespace MTADM {
    partial class MTADM {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbxPersonagens = new System.Windows.Forms.ListBox();
            this.gbxPersonagens = new System.Windows.Forms.GroupBox();
            this.gbxRacas = new System.Windows.Forms.GroupBox();
            this.lbxRacas = new System.Windows.Forms.ListBox();
            this.gbxArmas = new System.Windows.Forms.GroupBox();
            this.lbxArmas = new System.Windows.Forms.ListBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdicionarArma = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdicionarRaca = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miAdicionarPersonagem = new System.Windows.Forms.ToolStripMenuItem();
            this.stStatusBar = new System.Windows.Forms.StatusStrip();
            this.stLblDados = new System.Windows.Forms.ToolStripStatusLabel();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.exportDlg = new System.Windows.Forms.SaveFileDialog();
            this.gbxPersonagens.SuspendLayout();
            this.gbxRacas.SuspendLayout();
            this.gbxArmas.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.stStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPersonagens
            // 
            this.lbxPersonagens.FormattingEnabled = true;
            this.lbxPersonagens.ItemHeight = 25;
            this.lbxPersonagens.Location = new System.Drawing.Point(6, 30);
            this.lbxPersonagens.Name = "lbxPersonagens";
            this.lbxPersonagens.Size = new System.Drawing.Size(343, 604);
            this.lbxPersonagens.TabIndex = 4;
            // 
            // gbxPersonagens
            // 
            this.gbxPersonagens.Controls.Add(this.lbxPersonagens);
            this.gbxPersonagens.Location = new System.Drawing.Point(13, 61);
            this.gbxPersonagens.Name = "gbxPersonagens";
            this.gbxPersonagens.Size = new System.Drawing.Size(355, 640);
            this.gbxPersonagens.TabIndex = 5;
            this.gbxPersonagens.TabStop = false;
            this.gbxPersonagens.Text = "Lista de Personagens";
            // 
            // gbxRacas
            // 
            this.gbxRacas.Controls.Add(this.lbxRacas);
            this.gbxRacas.Location = new System.Drawing.Point(374, 61);
            this.gbxRacas.Name = "gbxRacas";
            this.gbxRacas.Size = new System.Drawing.Size(355, 640);
            this.gbxRacas.TabIndex = 6;
            this.gbxRacas.TabStop = false;
            this.gbxRacas.Text = "Lista de Raças";
            // 
            // lbxRacas
            // 
            this.lbxRacas.FormattingEnabled = true;
            this.lbxRacas.ItemHeight = 25;
            this.lbxRacas.Location = new System.Drawing.Point(6, 30);
            this.lbxRacas.Name = "lbxRacas";
            this.lbxRacas.Size = new System.Drawing.Size(343, 604);
            this.lbxRacas.TabIndex = 5;
            // 
            // gbxArmas
            // 
            this.gbxArmas.Controls.Add(this.lbxArmas);
            this.gbxArmas.Location = new System.Drawing.Point(735, 61);
            this.gbxArmas.Name = "gbxArmas";
            this.gbxArmas.Size = new System.Drawing.Size(355, 640);
            this.gbxArmas.TabIndex = 7;
            this.gbxArmas.TabStop = false;
            this.gbxArmas.Text = "Lista de Armas";
            // 
            // lbxArmas
            // 
            this.lbxArmas.FormattingEnabled = true;
            this.lbxArmas.ItemHeight = 25;
            this.lbxArmas.Location = new System.Drawing.Point(6, 30);
            this.lbxArmas.Name = "lbxArmas";
            this.lbxArmas.Size = new System.Drawing.Size(343, 604);
            this.lbxArmas.TabIndex = 6;
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.dadosToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1100, 40);
            this.msMenu.TabIndex = 8;
            this.msMenu.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.toolStripSeparator4,
            this.miSair});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(111, 38);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.exportarToolStripMenuItem.Text = "Exportar ...";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.EventoExportar);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(266, 6);
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            this.miSair.Size = new System.Drawing.Size(269, 38);
            this.miSair.Text = "Sair";
            this.miSair.Click += new System.EventHandler(this.EventoSair);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdicionarArma,
            this.miAdicionarRaca,
            this.toolStripSeparator1,
            this.miAdicionarPersonagem});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(94, 38);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // miAdicionarArma
            // 
            this.miAdicionarArma.Name = "miAdicionarArma";
            this.miAdicionarArma.Size = new System.Drawing.Size(355, 38);
            this.miAdicionarArma.Text = "Adicionar arma";
            this.miAdicionarArma.Click += new System.EventHandler(this.EventoAdicionarArma);
            // 
            // miAdicionarRaca
            // 
            this.miAdicionarRaca.Name = "miAdicionarRaca";
            this.miAdicionarRaca.Size = new System.Drawing.Size(355, 38);
            this.miAdicionarRaca.Text = "Adicionar raça";
            this.miAdicionarRaca.Click += new System.EventHandler(this.EventoAdicionarRaca);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(352, 6);
            // 
            // miAdicionarPersonagem
            // 
            this.miAdicionarPersonagem.Name = "miAdicionarPersonagem";
            this.miAdicionarPersonagem.Size = new System.Drawing.Size(355, 38);
            this.miAdicionarPersonagem.Text = "Adicionar personagem";
            this.miAdicionarPersonagem.Click += new System.EventHandler(this.EventoAdicionarPersonagem);
            // 
            // stStatusBar
            // 
            this.stStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLblDados});
            this.stStatusBar.Location = new System.Drawing.Point(0, 721);
            this.stStatusBar.Name = "stStatusBar";
            this.stStatusBar.Size = new System.Drawing.Size(1100, 22);
            this.stStatusBar.TabIndex = 9;
            this.stStatusBar.Text = "statusStrip1";
            // 
            // stLblDados
            // 
            this.stLblDados.Name = "stLblDados";
            this.stLblDados.Size = new System.Drawing.Size(0, 17);
            // 
            // openDlg
            // 
            this.openDlg.DefaultExt = "mtadm";
            this.openDlg.FileName = "mtadmdatabase";
            // 
            // saveDlg
            // 
            this.saveDlg.DefaultExt = "mtadm";
            // 
            // exportDlg
            // 
            this.exportDlg.DefaultExt = "md";
            // 
            // MTADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 743);
            this.Controls.Add(this.stStatusBar);
            this.Controls.Add(this.gbxArmas);
            this.Controls.Add(this.gbxRacas);
            this.Controls.Add(this.gbxPersonagens);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "MTADM";
            this.Text = "Monstros Terra ADM - ADO.Net";
            this.gbxPersonagens.ResumeLayout(false);
            this.gbxRacas.ResumeLayout(false);
            this.gbxArmas.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.stStatusBar.ResumeLayout(false);
            this.stStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxPersonagens;
        private System.Windows.Forms.GroupBox gbxPersonagens;
        private System.Windows.Forms.GroupBox gbxRacas;
        private System.Windows.Forms.ListBox lbxRacas;
        private System.Windows.Forms.GroupBox gbxArmas;
        private System.Windows.Forms.ListBox lbxArmas;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSair;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAdicionarArma;
        private System.Windows.Forms.ToolStripMenuItem miAdicionarRaca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miAdicionarPersonagem;
        private System.Windows.Forms.StatusStrip stStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel stLblDados;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.SaveFileDialog exportDlg;
    }
}

