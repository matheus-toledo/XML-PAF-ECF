using System;
using System.Threading;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form5 : Form {
        string[] valores = new string[13];
        public Form5() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                valores[0] = this.LPROG.Text;

                valores[1] = this.SO.Text;

                valores[2] = this.BD1.Text;
                valores[3] = this.BD2.Text;
                valores[4] = this.BD3.Text;
                valores[5] = this.BD4.Text;
                valores[6] = this.BD5.Text;

                if (this.COMERCIALIZAVEL.Checked) {
                    valores[7] = this.COMERCIALIZAVEL.Text;
                } else if (this.EPROPRIO.Checked) {
                    valores[7] = this.EPROPRIO.Text;
                } else {
                    valores[7] = this.ETERC.Text;
                }

                if (this.STALONE.Checked) {
                    valores[8] = this.STALONE.Text;
                } else if (this.REDE.Checked) {
                    valores[8] = this.REDE.Text;
                } else {
                    valores[8] = this.PARAM.Text;
                }

                valores[9] = this.GER1.Text;
                valores[10] = this.GER2.Text;
                valores[11] = this.GER3.Text;

                if (this.RETAGUARDA.Checked) {
                    valores[12] = this.RETAGUARDA.Text;
                    //XML.tem_retaguarda = true;
                } else if (this.NINTEGRADO.Checked) {
                    valores[12] = this.NINTEGRADO.Text;
                } else {
                    valores[12] = this.AMBOS.Text;
                    XML.tem_retaguarda = true;
                    //XML.tem_ped = true;
                }

                XML.Insere_Campos_64_a_72(valores);

                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa:" + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
