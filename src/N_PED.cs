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
    public partial class N_PED : Form {
        public N_PED() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Program.qtd_ped = uint.Parse(this.maskedTextBox1.Text);
            this.Close();
        }
    }
}
