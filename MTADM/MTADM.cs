using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MTADM {
    public partial class MTADM : Form {

        //private List<Arma> armas;
        //private List<Raca> racas;
        //private SortedList<string, Personagem> personagens;
        private string ficheiro;

        private DiagramaEntidadesContainer container;

        public MTADM() {
            InitializeComponent();
            container = new DiagramaEntidadesContainer();

            ficheiro = null;
        }

        private void EventoAdicionarPersonagem(object sender, EventArgs e) {
            //PersonagemForm form = new PersonagemForm(this);
            //DialogResult resultado = form.ShowDialog();

            //if (resultado == DialogResult.OK) {
            //    AdicionarPersonagem(form.NovaPersonagem);
            //}
        }

        private void EventoAdicionarRaca(object sender, EventArgs e) {
            //RacaForm form = new RacaForm();
            //DialogResult resultado = form.ShowDialog();

            //if (resultado == DialogResult.OK) {
            //    AdicionarRaca(form.NovaRaca);
            //}
        }

        private void EventoAdicionarArma(object sender, EventArgs e) {
            //ArmaForm form = new ArmaForm();
            //DialogResult resultado = form.ShowDialog();

            //if (resultado == DialogResult.OK) {
            //    AdicionarArma(form.NovaArma);
            //}
        }

        private void EventoSair(object sender, EventArgs e) {
            Application.Exit();
        }

        private void EventoExportar(object sender, EventArgs e) {
            //if (exportDlg.ShowDialog() != DialogResult.OK) {
            //    stLblDados.Text = "Operação cancelada";
            //    return;
            //}

            //export(exportDlg.FileName);
        }

        private void AdicionarPersonagem(Personagem personagem) {
            //personagens.Add(personagem.Nome, personagem);
            //refreshListaPersonagens();
        }

        private void AdicionarArma(Arma arma) {
            //armas.Add(arma);
            //refreshListaArmas();
        }

        private void AdicionarRaca(Raca raca) {
            //racas.Add(raca);
            //refreshListaRacas();
        }

        public List<Raca> ListaRacas() {
            return null;// return racas;
        }

        public List<Arma> ListaArmas() {
            return null;//return armas;
        }

        private void refreshListaPersonagens() {
            //lbxPersonagens.Items.Clear();
            //foreach (Personagem p in personagens.Values) {
            //    lbxPersonagens.Items.Add(p);
            //}
        }

        private void refreshListaArmas() {
            //lbxArmas.Items.Clear();
            //lbxArmas.Items.AddRange(armas.ToArray());
        }

        private void refreshListaRacas() {
            //lbxRacas.Items.Clear();
            //lbxRacas.Items.AddRange(racas.ToArray());
        }

        private void export(string destino) {

            //try {
            //    StreamWriter writter = new StreamWriter(destino, false);
            //    writter.WriteLine("= Personagens Monstros Terra");
            //    writter.WriteLine("Detalhes das personagens existentes.");
            //    writter.WriteLine("");

            //    foreach (Personagem personagem in personagens.Values) {
            //        writter.WriteLine("== " + personagem.Nome);
            //        writter.WriteLine("Vida: " + personagem.Vida);
            //        writter.WriteLine("Mana: " + personagem.Mana);
            //        writter.WriteLine("Estamina: " + personagem.Estamina);
            //        writter.WriteLine("Força: " + personagem.Forca);
            //        writter.WriteLine("Inteligência: " + personagem.Inteligencia);
            //        writter.WriteLine("Destreza: " + personagem.Destreza);
            //        writter.WriteLine("Género: " + personagem.Genero);
            //        writter.WriteLine("Raça: " + (personagem.Raca != null ? personagem.Raca.Nome : ""));
            //        writter.WriteLine("Arma Principal: " + (personagem.ArmaPrincipal != null ? personagem.ArmaPrincipal.Nome : ""));
            //        writter.WriteLine("Arma Secundária: " + (personagem.ArmaSecundaria != null ? personagem.ArmaSecundaria.Nome : ""));
            //    }
            //    writter.Close();
            //    stLblDados.Text = "Exportação concluída!";
            //} catch (Exception ex) {
            //    MessageBox.Show("Não foi possível exportar os dados para o ficheiro selecionado. " + ex.Message,
            //        "Erro de exportação!", MessageBoxButtons.OK);
            //}
        }
    }
}
