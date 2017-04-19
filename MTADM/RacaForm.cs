using System;
using System.Windows.Forms;

namespace MTADM {
    public partial class RacaForm : Form {

        public Raca NovaRaca { get; private set; }

        public RacaForm() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            string nome = tbxNome.Text.Trim();
            if (nome.Length > 0) {
                NovaRaca = new Raca();
                NovaRaca.Nome = nome;
                NovaRaca.Descricao = tbxDescricao.Text;
                NovaRaca.Mana = (int)udMana.Value;
                NovaRaca.Estamina = (int)udEstamina.Value;
                NovaRaca.Forca = (int)udForca.Value;
                NovaRaca.Inteligencia = (int)udInteligencia.Value;
                NovaRaca.Destreza = (int)udDestreza.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
