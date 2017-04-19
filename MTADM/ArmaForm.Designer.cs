namespace MTADM {
    partial class ArmaForm {
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
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblDefesa = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.udAtaque = new System.Windows.Forms.NumericUpDown();
            this.udDefesa = new System.Windows.Forms.NumericUpDown();
            this.gbxDescricao = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.udAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDefesa)).BeginInit();
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
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Location = new System.Drawing.Point(12, 45);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(80, 25);
            this.lblAtaque.TabIndex = 2;
            this.lblAtaque.Text = "Ataque";
            // 
            // lblDefesa
            // 
            this.lblDefesa.AutoSize = true;
            this.lblDefesa.Location = new System.Drawing.Point(387, 47);
            this.lblDefesa.Name = "lblDefesa";
            this.lblDefesa.Size = new System.Drawing.Size(80, 25);
            this.lblDefesa.TabIndex = 3;
            this.lblDefesa.Text = "Defesa";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(154, 6);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(509, 31);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(6, 30);
            this.tbxDescricao.Multiline = true;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(634, 242);
            this.tbxDescricao.TabIndex = 7;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(361, 364);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(148, 46);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(515, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // udAtaque
            // 
            this.udAtaque.Location = new System.Drawing.Point(154, 43);
            this.udAtaque.Name = "udAtaque";
            this.udAtaque.Size = new System.Drawing.Size(120, 31);
            this.udAtaque.TabIndex = 10;
            // 
            // udDefesa
            // 
            this.udDefesa.Location = new System.Drawing.Point(543, 43);
            this.udDefesa.Name = "udDefesa";
            this.udDefesa.Size = new System.Drawing.Size(120, 31);
            this.udDefesa.TabIndex = 11;
            // 
            // gbxDescricao
            // 
            this.gbxDescricao.Controls.Add(this.tbxDescricao);
            this.gbxDescricao.Location = new System.Drawing.Point(17, 80);
            this.gbxDescricao.Name = "gbxDescricao";
            this.gbxDescricao.Size = new System.Drawing.Size(646, 278);
            this.gbxDescricao.TabIndex = 12;
            this.gbxDescricao.TabStop = false;
            this.gbxDescricao.Text = "Descrição";
            // 
            // ArmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.gbxDescricao);
            this.Controls.Add(this.udDefesa);
            this.Controls.Add(this.udAtaque);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblDefesa);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lblNome);
            this.Name = "ArmaForm";
            this.Text = "Inserir Arma";
            ((System.ComponentModel.ISupportInitialize)(this.udAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDefesa)).EndInit();
            this.gbxDescricao.ResumeLayout(false);
            this.gbxDescricao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblDefesa;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown udAtaque;
        private System.Windows.Forms.NumericUpDown udDefesa;
        private System.Windows.Forms.GroupBox gbxDescricao;
    }
}