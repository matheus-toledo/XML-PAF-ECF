using System;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form7 : Form {
        private string[] valores = new string[3];

        public Form7() {
            InitializeComponent();
        }
        
        public void Okbutton_Click(object sender, EventArgs e) {
            try {
                valores[0] = SISTEMA.Text;
                valores[1] = RSOCIAL.Text;
                valores[2] = CNPJ.Text;
                XML.Insere_Emp_Desenvol_Ret_PED_NFe("retaguarda", valores);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }


    }
}
