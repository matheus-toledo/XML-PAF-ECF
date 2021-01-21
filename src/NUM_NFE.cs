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
    public partial class NUM_NFE : Form {
        public NUM_NFE() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Program.qtd_nfe = uint.Parse(this.maskedTextBox1.Text);
            this.Close();
        }
    }
}
