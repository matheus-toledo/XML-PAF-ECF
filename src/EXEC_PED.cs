using System;
using System.Windows.Forms;

namespace GeraXML {
    public partial class EXEC_PED : Form {
        public EXEC_PED() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                XML.Insere_Arq_Executavel(ARQUIVO.Text, MD5.Text, REQ_FUNC.Text);

                MessageBox.Show("Executável PED inserido com sucesso!");
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
                XML.fecha_tag();
                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa: " + ex.Message);
                XML.deleta_XML();
            }

        }
    }
}
