using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeraXML {
    public partial class PED : Form {
        private string[] valores = new string[3];

        public PED() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                valores[0] = SISTEMA.Text;
                valores[1] = RSOCIAL.Text;
                valores[2] = CNPJ.Text;
                XML.Insere_Emp_Desenvol_Ret_PED_NFe("ped", valores);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }
    }
}
