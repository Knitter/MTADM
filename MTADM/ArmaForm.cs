using System;
using System.Windows.Forms;

namespace MTADM {
    public partial class ArmaForm : Form {

        public Arma NovaArma { get; private set; }

        public ArmaForm() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            string nome = tbxNome.Text.Trim();
            if (nome.Length > 0) {
                NovaArma = new Arma();

                NovaArma.Nome = nome;
                NovaArma.Descricao = tbxDescricao.Text.Trim();
                NovaArma.Ataque = (int)udAtaque.Value;
                NovaArma.Defesa = (int)udDefesa.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
