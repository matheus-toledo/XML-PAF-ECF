using System;
using System.Threading;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form4 : Form {
        string[] valores = new string[6];
        public Form4() {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e) {
            try {
                valores[0] = this.NCOMERCIAL.Text;
                valores[1] = this.VERSÃO.Text;
                valores[2] = this.NOMEPEXEC.Text;
                valores[3] = this.MD5PEXEC.Text;
                valores[4] = this.LISTAARQ.Text;
                valores[5] = this.MD5LISTAARQ.Text;

                XML.Insere_Campos_41_a_51(valores);

                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa:" + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
