using System;
using System.Threading;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form3 : Form {
        string[] valores = new string[13];
        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                valores[0] = this.RSOCIAL.Text;
                valores[1] = this.CNPJ.Text;
                valores[2] = this.IESTADUAL.Text;
                valores[3] = this.RUA.Text;
                valores[4] = this.NUMERO.Text;
                valores[5] = this.COMPLEMENTO.Text;
                valores[6] = this.BAIRRO.Text;
                valores[7] = this.MUNICIPIO.Text;
                valores[8] = this.UF.Text;
                valores[9] = this.CEP.Text;
                valores[10] = this.IANALISE.Text;
                valores[11] = this.FANALISE.Text;
                valores[12] = this.ERPAF.Text;

                XML.Insere_Campos_25_a_40(valores);
                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa:" + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }

        private void IANALISE_MouseClick(object sender, MouseEventArgs e) {
            if (IANALISE.Text.Equals("    -  -"))
                IANALISE.Select(0, 0);
            
        }

        private void FANALISE_MouseClick(object sender, MouseEventArgs e) {
            if (FANALISE.Text.Equals("    -  -"))
                FANALISE.Select(0, 0);
        }

        
    }
}
