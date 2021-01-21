using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace GeraXML {
    public partial class relacaoexe : Form {
        string[] valores = new string[4];
        public relacaoexe() {
            InitializeComponent();
            button2.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e) {
            if (AbreTXT.ShowDialog() == DialogResult.OK) {
                textBox1.Text = AbreTXT.FileName;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            FileStream fluxo = new FileStream(textBox1.Text, FileMode.Open);

            StreamReader reader = new StreamReader(fluxo,Encoding.UTF8);

            string nome, md5, linha;

            int cont = 1;
            try {
                while ((linha = reader.ReadLine()) != null) {
                    if (cont >= 5) {
                        nome = linha.Substring(34);
                        md5 = linha.Substring(0, 32);
                        XML.Insere_Campos_52_e_53(nome, md5);

                        reader.ReadLine();
                    } else {
                        cont++;
                    }
                }

                valores[0] = this.MARCA.Text;
                valores[1] = this.MODELO.Text;
                valores[2] = this.NUMERO.Text;
                valores[3] = this.PREQUISITOS.Text;

                XML.Insere_Campos_54_ao_63(valores, this.NRELACAOEXE.Text, MD5RELACAOEXE.Text);

                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                reader.Close();
                fluxo.Close();
                MessageBox.Show("fim do programa");
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {

        }
    }
}
