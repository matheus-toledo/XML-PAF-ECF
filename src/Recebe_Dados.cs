using System;
using System.Windows.Forms;

namespace GeraXML {
    public class Recebe_Dados : Form {
        #region Dispose
        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows controls and constructor

        private Label prompt;
        private Button OKbtn;
        private TextBox QTD_RET;
        private TextBox marca;
        private TextBox modelo;
        private bool isPed = false;
        private bool isRetaguarda = false;
        private Button adicionar;
        private Label label1;
        private Label label2;

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        public  Recebe_Dados(uint ret_ped_ou_nfe) {
            if (ret_ped_ou_nfe == 0)
                InitializeComponent0();
            else if (ret_ped_ou_nfe == 1)
                InitializeComponent1();
            else
                InitializeComponent2();
            
        }

        public Recebe_Dados() {
            InitializeComponent();
            XML.Insere_Campos_ECF_teste_ou_compativeis("EcfAnaliseFuncional");
        }

        #endregion
        private void InitializeComponent() {
            this.prompt = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.modelo = new System.Windows.Forms.TextBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.Location = new System.Drawing.Point(95, 9);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(288, 20);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Insira marca e modelo da ECF utilizada nos testes";
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(70, 55);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(122, 20);
            this.marca.TabIndex = 1;
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.Location = new System.Drawing.Point(303, 144);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(93, 45);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.Click += new System.EventHandler(this.fecha_ECF_teste);
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(313, 55);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(122, 20);
            this.modelo.TabIndex = 0;
            // 
            // adicionar
            // 
            this.adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.Location = new System.Drawing.Point(99, 144);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(93, 45);
            this.adicionar.TabIndex = 2;
            this.adicionar.Text = "Adicionar";
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Recebe_Dados
            // 
            this.ClientSize = new System.Drawing.Size(491, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.OKbtn);
            this.Name = "Recebe_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent0() {
            this.prompt = new System.Windows.Forms.Label();
            this.QTD_RET = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.Location = new System.Drawing.Point(38, 9);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(261, 20);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Insira a quantidade de retaguardas";
            // 
            // QTD_RET
            // 
            this.QTD_RET.Location = new System.Drawing.Point(38, 40);
            this.QTD_RET.Name = "QTD_RET";
            this.QTD_RET.Size = new System.Drawing.Size(261, 20);
            this.QTD_RET.TabIndex = 1;
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(140, 90);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(50, 45);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.Click += new EventHandler(this.OK_clic);
            // 
            // FormRetaguarda
            // 
            this.ClientSize = new System.Drawing.Size(334, 140);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.QTD_RET);
            this.Controls.Add(this.OKbtn);
            this.Name = "Recebe_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent1() {
            this.prompt = new System.Windows.Forms.Label();
            this.QTD_RET = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.Location = new System.Drawing.Point(38, 9);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(271, 20);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Insira a quantidade de sistemas PED";
            // 
            // QTD_RET
            // 
            this.QTD_RET.Location = new System.Drawing.Point(38, 40);
            this.QTD_RET.Name = "QTD_RET";
            this.QTD_RET.Size = new System.Drawing.Size(261, 20);
            this.QTD_RET.TabIndex = 1;
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.Location = new System.Drawing.Point(140, 90);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(50, 45);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.Click += new System.EventHandler(this.OK_clic);
            // 
            // FormRetaguarda
            // 
            this.ClientSize = new System.Drawing.Size(338, 140);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.QTD_RET);
            this.Controls.Add(this.OKbtn);
            this.Name = "Recebe_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent2() {
            this.prompt = new System.Windows.Forms.Label();
            this.QTD_RET = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.Location = new System.Drawing.Point(38, 9);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(287, 20);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Insira a quantidade de sistemas NF-e";
            // 
            // QTD_RET
            // 
            this.QTD_RET.Location = new System.Drawing.Point(38, 40);
            this.QTD_RET.Name = "QTD_RET";
            this.QTD_RET.Size = new System.Drawing.Size(261, 20);
            this.QTD_RET.TabIndex = 1;
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.Location = new System.Drawing.Point(140, 90);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(50, 45);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.Click += new System.EventHandler(this.OK_clic);
            // 
            // FormRetaguarda
            // 
            this.ClientSize = new System.Drawing.Size(338, 140);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.QTD_RET);
            this.Controls.Add(this.OKbtn);
            this.Name = "Recebe_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OK_clic (object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(this.QTD_RET.Text) && this.isRetaguarda)
                XML.qtd_retaguardas = uint.Parse(this.QTD_RET.Text);
            else if (!String.IsNullOrEmpty(this.QTD_RET.Text) && this.isPed)
                XML.qtd_ped = uint.Parse(this.QTD_RET.Text);
            else if (!String.IsNullOrEmpty(this.QTD_RET.Text) && this.isPed)
                XML.qtd_ped = uint.Parse(this.QTD_RET.Text);
            this.Close();

        }

        

        public void fechaDialog(bool disposing) {
            Dispose(disposing);
        }

        private void adicionar_Click(object sender, EventArgs e) {
            XML.Insere_Campos_115_e_116(this.marca.Text, this.modelo.Text);

        }

        private void fecha_ECF_teste(object sender, EventArgs e) {
            XML.fecha_tag();
            this.Close();
            this.Dispose(true);
        }

    }
}
