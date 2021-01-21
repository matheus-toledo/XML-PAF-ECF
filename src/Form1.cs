using System;
using System.Threading;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                
                XML.nr_laudo = this.textBox1.Text;
                XML.Insere_Campos_1_a_6(this.textBox1.Text);
                this.Close();
            }catch(Exception ex) {
                MessageBox.Show("Falha interna do programa:" + ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
