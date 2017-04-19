using System;
using System.Windows.Forms;

namespace MTADM {
    public partial class PersonagemForm : Form {

        public Personagem NovaPersonagem { get; private set; }

        public PersonagemForm(MTADM principal) {
            InitializeComponent();

            if (principal != null) {
                cbxMaoDireita.Items.AddRange(principal.ListaArmas().ToArray());
                cbxMaoEsquerda.Items.AddRange(principal.ListaArmas().ToArray());
                cbxRaca.Items.AddRange(principal.ListaRacas().ToArray());
            }
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            String nome = tbxNome.Text.Trim();
            if (nome.Length > 0) {
                string genero = "Feminino";
                if (cbxGenero.SelectedIndex > -1) {
                    genero = cbxGenero.SelectedItem.ToString();
                }

                Raca raca = null;
                Arma esquerda = null;
                Arma direita = null;

                if (cbxRaca.SelectedIndex > -1) {
                    raca = (Raca)cbxRaca.SelectedItem;
                }

                if (cbxMaoDireita.SelectedIndex > -1) {
                    direita = (Arma)cbxMaoDireita.SelectedItem;
                }

                if (cbxMaoEsquerda.SelectedIndex > -1) {
                    esquerda = (Arma)cbxMaoEsquerda.SelectedItem;
                }

                NovaPersonagem = new Personagem();
                NovaPersonagem.Nome = nome;
                NovaPersonagem.Vida = (int)udVida.Value;
                NovaPersonagem.Mana = (int)udMana.Value;
                NovaPersonagem.Estamina = (int)udEstamina.Value;
                NovaPersonagem.Moral = (int)udMoral.Value;
                NovaPersonagem.Forca = (int)udForca.Value;
                NovaPersonagem.Inteligencia = (int)udInteligencia.Value;
                NovaPersonagem.Destreza = (int)udDestreza.Value;
                NovaPersonagem.Genero = genero;
                NovaPersonagem.Raca = raca;
                NovaPersonagem.ArmaPrincipal = direita;
                NovaPersonagem.ArmaSecundaria = esquerda;

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
