using System;
using System.Threading;
using System.Windows.Forms;


namespace GeraXML {
    public partial class Form6 : Form {
        
        string[] f_impressao = new string[7];
        string[] tratamento = new string[3];
        string[] ap_esp = new string[15];
        public Form6() {
            InitializeComponent();
            
        }
        
        private void preenche_valores(string[] impressao, CheckBox[] checkBoxes) {
            uint x=0;
            foreach (CheckBox cb in checkBoxes) {
                if (cb.Checked)
                    impressao[x++]=cb.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                CheckBox[] cb_imp = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7 };
                CheckBox[] cb_tratamento = new CheckBox[] { checkBox8, checkBox9, checkBox10 };
                CheckBox[] cb_ap_esp = new CheckBox[] { checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25 };
                preenche_valores(f_impressao, cb_imp);
                preenche_valores(tratamento, cb_tratamento);
                preenche_valores(ap_esp, cb_ap_esp);

                XML.Isere_Campos_73_a_78(f_impressao, tratamento, ap_esp);
             
                this.Close();

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
