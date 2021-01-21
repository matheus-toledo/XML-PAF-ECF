using System;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form8 : Form {
        private string[] requisitos;

        public Form8() {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                requisitos = REQ_FUNC.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                XML.Insere_Arq_Executavel(ARQUIVO.Text, MD5.Text, requisitos);
                
                MessageBox.Show("Executável da retaguarda inserido com sucesso!");
            } catch (Exception ex) {
                MessageBox.Show("Falha interna do programa: " + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                XML.fecha_tag();
                XML.fecha_tag();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Falha interna do programa: " + ex.Message);
                XML.deleta_XML();
            }
        }
    }
}
