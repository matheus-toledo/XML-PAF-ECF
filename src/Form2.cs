using System;
using System.Windows.Forms;
using System.Threading;

namespace GeraXML {
    public partial class Form2 : Form {
        string[] valores = new string[15];
        public Form2() {
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
                valores[10] = this.NOME.Text;
                valores[11] = this.CPF.Text;
                valores[12] = this.TELEFONE.Text;
                valores[13] = this.EMAIL.Text;
                valores[14] = this.ACOMPTEST.Text;

                XML.Insere_Campos_7_a_24(valores);

                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa:" + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
