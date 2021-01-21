using System;

using System.Windows.Forms;

namespace GeraXML {
    static class Program {
        public static uint qtd_retaguardas { get; set; }
        public static uint qtd_ped { get; set; }
        public static uint qtd_nfe { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            uint cont = 1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {


                Application.Run(new Form1());
                Application.Run(new Form2());
                Application.Run(new Form3());
                Application.Run(new Form4());
                Application.Run(new relacaoexe());
                Application.Run(new Form5());
                Application.Run(new Form6());
                Application.Run(new RETAGUARDA());

                if (qtd_retaguardas == 0)
                    XML.sem_ret_ou_ped("retaguarda");
                else {
                    while (cont <= qtd_retaguardas) {
                        Application.Run(new Form7());
                        Application.Run(new Form8());
                        cont++;
                    }
                    XML.fecha_tag();
                    cont = 1;
                }

                Application.Run(new N_PED());

                if (qtd_ped == 0)
                    XML.sem_ret_ou_ped("ped");
                else {
                    while (cont <= qtd_ped) {
                        Application.Run(new PED());
                        Application.Run(new EXEC_PED());
                        cont++;
                    }
                    cont = 1;
                }

                Application.Run(new NUM_NFE());

                while(cont <= qtd_nfe) {
                    Application.Run(new NFE());
                    Application.Run(new EXEC_NFE());
                    cont++;
                }

                Application.Run(new ECF("EcfAnaliseFuncional"));
                Application.Run(new ECF("MarcasModelosCompativeis"));
                Application.Run(new Form9());
                Application.Run(new Form10());
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                Application.Exit();
            }
            
        }
        
    }
}
