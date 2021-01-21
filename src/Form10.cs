using System;
using System.Windows.Forms;

namespace GeraXML {
    public partial class Form10 : Form {
        private string[] valores;
        
        public Form10() {
            InitializeComponent();
            CoordNome.Enabled = false;
            CoordCPF.Enabled = false;
        }

        private void DATA_Click(object sender, EventArgs e) {
            if (DATA.Text.Equals("    -  -"))
                DATA.Select(0, 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                valores = new string[] { DATA.Text, LOCAL.Text, GerNome.Text, "Gerente de Testes", GerCPF.Text, CoordNome.Text, "Coordenador de Testes", CoordCPF.Text };
                XML.Insere_Campos_133_a_143(valores);

                MessageBox.Show("XML criado com sucesso");

                this.Dispose();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                XML.deleta_XML();
                Environment.Exit(-1);
            }
        }

        private void marca_nome (object sender, EventArgs e) {
            var radio = sender as RadioButton;

            if (radio.Name == GERENTE2.Name) {
                GerNome.Text = "Gerente";
                GerCPF.Text = "11111111111";
                GerNome.Enabled = false;
                GerCPF.Enabled = false;

            } else if (radio.Name == GERENTE1.Name) {
                GerNome.Text = "GERENTE1";
                GerCPF.Text = "11111111111";
                GerNome.Enabled = false;
                GerCPF.Enabled = false;

            } else if (radio.Name == COORDENADOR1.Name) {
                CoordNome.Text = "COORDENADOR1";
                CoordCPF.Text = "11111111111";
                CoordNome.Enabled = false;
                CoordCPF.Enabled = false;

            } else if (radio.Name == OUTRO.Name) {
                GerNome.Enabled = true;
                GerCPF.Enabled = true;
                GerNome.Text = string.Empty;
                GerCPF.Text = string.Empty;

            } else {
                CoordNome.Enabled = true;
                CoordCPF.Enabled = true;
                CoordNome.Text = string.Empty;
                CoordCPF.Text = string.Empty;

            }

        }
    }
}
