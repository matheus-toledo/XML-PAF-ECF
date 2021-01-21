using System;
using System.Windows.Forms;
using System.Threading;

namespace GeraXML {
    public partial class ECF : Form {

        public ECF(string definicao) {
            InitializeComponent();
            XML.Insere_Campos_ECF_teste_ou_compativeis(definicao);

        }
      
        void Gera_tag_ECF() {
            string marca;

            foreach (Control ct in this.Controls) {
                var tab = ct as TabControl;
                if (tab != null)
                    foreach (Control pg in tab.Controls) {
                        if (pg != null && pg.Text == "DARUMA") {

                            marca = "DARUMA AUTOMACAO";

                            foreach (Control ct2 in pg.Controls) {
                                var cb = ct2 as CheckBox;
                                if (cb != null && cb.Checked == true) {
                                    XML.Insere_Campos_115_e_116(marca, cb.Text);
                                }
                            }
                        } else if (pg != null && pg.Text == "ELGIN") {
                            marca = "ELGIN (AMAZONIA)";
                            foreach (Control ct2 in pg.Controls) {
                                var cb = ct2 as CheckBox;
                                if (cb != null && cb.Checked == true) {
                                    XML.Insere_Campos_115_e_116(marca, cb.Text);
                                }
                            }
                        } else {
                            if (pg != null) {
                                marca = pg.Text;
                                foreach (Control ct2 in pg.Controls) {
                                    var cb = ct2 as CheckBox;
                                    if (cb != null && cb.Checked == true) {
                                       XML.Insere_Campos_115_e_116(marca, cb.Text);
                                   
                                    }
                                }
                            }
                        }

                    }
            }
            XML.fecha_tag();
        }

        private void Ger_Tag_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Todas as ECFs foram marcadas?", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                Gera_tag_ECF();
                
                this.Close();
            }
        }
    }
}
