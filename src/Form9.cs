using System;
using System.Threading;
using System.Windows.Forms;


namespace GeraXML {
    public partial class Form9 : Form {
        private string[] valores;
        private bool declaracao;
        public Form9() {
            InitializeComponent();
        }
        
        private void MES_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(MES.Text) || String.IsNullOrEmpty(MES.Text))
                MES.Select(0, 0);

        }

        private void ANO_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(ANO.Text) || String.IsNullOrEmpty(ANO.Text))
                ANO.Select(0, 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                COMENTARIO.Text = COMENTARIO.Text.Replace("\r\n","");
                valores = new string[] { VERSAOER.Text, VERSAORT.Text, MES.Text, ANO.Text, COMENTARIO.Text };
                if (BD_SIM.Checked)
                    declaracao = true;
                else
                    declaracao = false;

                XML.Insere_Campos_121_a_131(valores, declaracao);
                
                this.Close();
            } 
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }

        


    }
}
