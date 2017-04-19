namespace MTADM {
    partial class RacaForm {
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblEstamina = new System.Windows.Forms.Label();
            this.lblInteligencia = new System.Windows.Forms.Label();
            this.lblForca = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.udMana = new System.Windows.Forms.NumericUpDown();
            this.udEstamina = new System.Windows.Forms.NumericUpDown();
            this.udInteligencia = new System.Windows.Forms.NumericUpDown();
            this.udForca = new System.Windows.Forms.NumericUpDown();
            this.udDestreza = new System.Windows.Forms.NumericUpDown();
            this.gbxDescricao = new System.Windows.Forms.GroupBox();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEstamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInteligencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDestreza)).BeginInit();
            this.gbxDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(14, 119);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(66, 25);
            this.lblMana.TabIndex = 1;
            this.lblMana.Text = "Mana";
            // 
            // lblEstamina
            // 
            this.lblEstamina.AutoSize = true;
            this.lblEstamina.Location = new System.Drawing.Point(12, 45);
            this.lblEstamina.Name = "lblEstamina";
            this.lblEstamina.Size = new System.Drawing.Size(101, 25);
            this.lblEstamina.TabIndex = 2;
            this.lblEstamina.Text = "Estamina";
            // 
            // lblInteligencia
            // 
            this.lblInteligencia.AutoSize = true;
            this.lblInteligencia.Location = new System.Drawing.Point(387, 45);
            this.lblInteligencia.Name = "lblInteligencia";
            this.lblInteligencia.Size = new System.Drawing.Size(121, 25);
            this.lblInteligencia.TabIndex = 3;
            this.lblInteligencia.Text = "Inteligência";
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.Location = new System.Drawing.Point(13, 82);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(67, 25);
            this.lblForca.TabIndex = 4;
            this.lblForca.Text = "Força";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(387, 84);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(98, 25);
            this.lblDestreza.TabIndex = 5;
            this.lblDestreza.Text = "Destreza";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(154, 6);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(509, 31);
            this.tbxNome.TabIndex = 6;
            // 
            // udMana
            // 
            this.udMana.Location = new System.Drawing.Point(154, 117);
            this.udMana.Name = "udMana";
            this.udMana.Size = new System.Drawing.Size(120, 31);
            this.udMana.TabIndex = 7;
            // 
            // udEstamina
            // 
            this.udEstamina.Location = new System.Drawing.Point(154, 43);
            this.udEstamina.Name = "udEstamina";
            this.udEstamina.Size = new System.Drawing.Size(120, 31);
            this.udEstamina.TabIndex = 8;
            // 
            // udInteligencia
            // 
            this.udInteligencia.Location = new System.Drawing.Point(543, 43);
            this.udInteligencia.Name = "udInteligencia";
            this.udInteligencia.Size = new System.Drawing.Size(120, 31);
            this.udInteligencia.TabIndex = 9;
            // 
            // udForca
            // 
            this.udForca.Location = new System.Drawing.Point(154, 80);
            this.udForca.Name = "udForca";
            this.udForca.Size = new System.Drawing.Size(120, 31);
            this.udForca.TabIndex = 10;
            // 
            // udDestreza
            // 
            this.udDestreza.Location = new System.Drawing.Point(543, 82);
            this.udDestreza.Name = "udDestreza";
            this.udDestreza.Size = new System.Drawing.Size(120, 31);
            this.udDestreza.TabIndex = 11;
            // 
            // gbxDescricao
            // 
            this.gbxDescricao.Controls.Add(this.tbxDescricao);
            this.gbxDescricao.Location = new System.Drawing.Point(19, 154);
            this.gbxDescricao.Name = "gbxDescricao";
            this.gbxDescricao.Size = new System.Drawing.Size(644, 254);
            this.gbxDescricao.TabIndex = 12;
            this.gbxDescricao.TabStop = false;
            this.gbxDescricao.Text = "Descrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(7, 31);
            this.tbxDescricao.Multiline = true;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(631, 217);
            this.tbxDescricao.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(515, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 46);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(360, 414);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(148, 46);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // RacaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 469);
            this.Controls.Add(this.udEstamina);
            this.Controls.Add(this.lblEstamina);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDescricao);
            this.Controls.Add(this.udDestreza);
            this.Controls.Add(this.udForca);
            this.Controls.Add(this.udInteligencia);
            this.Controls.Add(this.udMana);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblDestreza);
            this.Controls.Add(this.lblForca);
            this.Controls.Add(this.lblInteligencia);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblNome);
            this.Name = "RacaForm";
            this.Text = "RacaForm";
            ((System.ComponentModel.ISupportInitialize)(this.udMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEstamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInteligencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDestreza)).EndInit();
            this.gbxDescricao.ResumeLayout(false);
            this.gbxDescricao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblEstamina;
        private System.Windows.Forms.Label lblInteligencia;
        private System.Windows.Forms.Label lblForca;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.NumericUpDown udMana;
        private System.Windows.Forms.NumericUpDown udEstamina;
        private System.Windows.Forms.NumericUpDown udInteligencia;
        private System.Windows.Forms.NumericUpDown udForca;
        private System.Windows.Forms.NumericUpDown udDestreza;
        private System.Windows.Forms.GroupBox gbxDescricao;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
    }
}