namespace GeraXML {
    partial class Form5 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.LPROG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BD1 = new System.Windows.Forms.ComboBox();
            this.COMERCIALIZAVEL = new System.Windows.Forms.RadioButton();
            this.EPROPRIO = new System.Windows.Forms.RadioButton();
            this.ETERC = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.STALONE = new System.Windows.Forms.RadioButton();
            this.PARAM = new System.Windows.Forms.RadioButton();
            this.REDE = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AMBOS = new System.Windows.Forms.RadioButton();
            this.RETAGUARDA = new System.Windows.Forms.RadioButton();
            this.NINTEGRADO = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.GER1 = new System.Windows.Forms.ComboBox();
            this.GER2 = new System.Windows.Forms.ComboBox();
            this.GER3 = new System.Windows.Forms.ComboBox();
            this.BD2 = new System.Windows.Forms.ComboBox();
            this.BD4 = new System.Windows.Forms.ComboBox();
            this.BD3 = new System.Windows.Forms.ComboBox();
            this.BD5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Características do PAF-ECF";
            // 
            // LPROG
            // 
            this.LPROG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LPROG.FormattingEnabled = true;
            this.LPROG.Items.AddRange(new object[] {
            "AdvPL",
            "4GL/4Js",
            "C",
            "C++",
            "C#",
            "Clarion",
            "Cobol",
            "DataFlex",
            "Delphi",
            "FlagShip",
            "Harbour",
            "Java",
            "Node.js",
            "Proprietária",
            "Object Pascal",
            "Objective C",
            "Pascal",
            "PL/SQL",
            "PHP",
            "PowerBuilder",
            "Progress",
            "Python",
            "uniPaaS",
            "Visual Basic",
            "Visual Basic .NET",
            "Visual FoxPro",
            "xHarbour",
            "WLanguage",
            "ZIM"});
            this.LPROG.Location = new System.Drawing.Point(40, 101);
            this.LPROG.Name = "LPROG";
            this.LPROG.Size = new System.Drawing.Size(205, 21);
            this.LPROG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linguagem de Programação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema Operacional";
            // 
            // SO
            // 
            this.SO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SO.FormattingEnabled = true;
            this.SO.Items.AddRange(new object[] {
            "MS-DOS",
            "Windows",
            "Linux"});
            this.SO.Location = new System.Drawing.Point(40, 160);
            this.SO.Name = "SO";
            this.SO.Size = new System.Drawing.Size(152, 21);
            this.SO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Banco de Dados";
            // 
            // BD1
            // 
            this.BD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD1.FormattingEnabled = true;
            this.BD1.Items.AddRange(new object[] {
            "Access",
            "Advantage Database Server",
            "Arquivo plano",
            "ASE",
            "Caché",
            "C-ISAM",
            "c-treeRTG",
            "DataFlex",
            "dBase",
            "DB2",
            "DBISAM",
            "Derby",
            "Firebird",
            "FlagShip",
            "FoxPro",
            "H2",
            "HFSQL",
            "Informix",
            "InterBase",
            "MariaDB",
            "MongoDB",
            "MySQL",
            "NexusDB",
            "OpenEdge",
            "Oracle",
            "Paradox",
            "PostgreSQL",
            "Progress",
            "Proprietário",
            "SQL Anywhere",
            "SQL Server",
            "SQLite",
            "TopSpeed",
            "XML",
            "ZIM"});
            this.BD1.Location = new System.Drawing.Point(40, 218);
            this.BD1.Name = "BD1";
            this.BD1.Size = new System.Drawing.Size(124, 21);
            this.BD1.TabIndex = 5;
            // 
            // COMERCIALIZAVEL
            // 
            this.COMERCIALIZAVEL.AutoSize = true;
            this.COMERCIALIZAVEL.Location = new System.Drawing.Point(14, 7);
            this.COMERCIALIZAVEL.Name = "COMERCIALIZAVEL";
            this.COMERCIALIZAVEL.Size = new System.Drawing.Size(98, 17);
            this.COMERCIALIZAVEL.TabIndex = 11;
            this.COMERCIALIZAVEL.TabStop = true;
            this.COMERCIALIZAVEL.Text = "Comercializável";
            this.COMERCIALIZAVEL.UseVisualStyleBackColor = true;
            // 
            // EPROPRIO
            // 
            this.EPROPRIO.AutoSize = true;
            this.EPROPRIO.Location = new System.Drawing.Point(14, 30);
            this.EPROPRIO.Name = "EPROPRIO";
            this.EPROPRIO.Size = new System.Drawing.Size(105, 17);
            this.EPROPRIO.TabIndex = 12;
            this.EPROPRIO.TabStop = true;
            this.EPROPRIO.Text = "Exclusivo próprio";
            this.EPROPRIO.UseVisualStyleBackColor = true;
            // 
            // ETERC
            // 
            this.ETERC.AutoSize = true;
            this.ETERC.Location = new System.Drawing.Point(14, 53);
            this.ETERC.Name = "ETERC";
            this.ETERC.Size = new System.Drawing.Size(127, 17);
            this.ETERC.TabIndex = 13;
            this.ETERC.TabStop = true;
            this.ETERC.Text = "Exclusivo terceirizado";
            this.ETERC.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.COMERCIALIZAVEL);
            this.panel1.Controls.Add(this.ETERC);
            this.panel1.Controls.Add(this.EPROPRIO);
            this.panel1.Location = new System.Drawing.Point(292, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de desenvolvimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo de funcionamento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.STALONE);
            this.panel2.Controls.Add(this.PARAM);
            this.panel2.Controls.Add(this.REDE);
            this.panel2.Location = new System.Drawing.Point(510, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 17;
            // 
            // STALONE
            // 
            this.STALONE.AutoSize = true;
            this.STALONE.Location = new System.Drawing.Point(14, 7);
            this.STALONE.Name = "STALONE";
            this.STALONE.Size = new System.Drawing.Size(157, 17);
            this.STALONE.TabIndex = 11;
            this.STALONE.TabStop = true;
            this.STALONE.Text = "Exclusivamente stand alone";
            this.STALONE.UseVisualStyleBackColor = true;
            // 
            // PARAM
            // 
            this.PARAM.AutoSize = true;
            this.PARAM.Location = new System.Drawing.Point(14, 53);
            this.PARAM.Name = "PARAM";
            this.PARAM.Size = new System.Drawing.Size(94, 17);
            this.PARAM.TabIndex = 13;
            this.PARAM.TabStop = true;
            this.PARAM.Text = "Parametrizável";
            this.PARAM.UseVisualStyleBackColor = true;
            // 
            // REDE
            // 
            this.REDE.AutoSize = true;
            this.REDE.Location = new System.Drawing.Point(14, 30);
            this.REDE.Name = "REDE";
            this.REDE.Size = new System.Drawing.Size(64, 17);
            this.REDE.TabIndex = 12;
            this.REDE.TabStop = true;
            this.REDE.Text = "Em rede";
            this.REDE.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Integração do PAF-ECF";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AMBOS);
            this.panel3.Controls.Add(this.RETAGUARDA);
            this.panel3.Controls.Add(this.NINTEGRADO);
            this.panel3.Location = new System.Drawing.Point(292, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 100);
            this.panel3.TabIndex = 19;
            // 
            // AMBOS
            // 
            this.AMBOS.AutoSize = true;
            this.AMBOS.Location = new System.Drawing.Point(14, 53);
            this.AMBOS.Name = "AMBOS";
            this.AMBOS.Size = new System.Drawing.Size(80, 17);
            this.AMBOS.TabIndex = 14;
            this.AMBOS.TabStop = true;
            this.AMBOS.Text = "Com ambos";
            this.AMBOS.UseVisualStyleBackColor = true;
            // 
            // RETAGUARDA
            // 
            this.RETAGUARDA.AutoSize = true;
            this.RETAGUARDA.Location = new System.Drawing.Point(14, 7);
            this.RETAGUARDA.Name = "RETAGUARDA";
            this.RETAGUARDA.Size = new System.Drawing.Size(203, 17);
            this.RETAGUARDA.TabIndex = 11;
            this.RETAGUARDA.TabStop = true;
            this.RETAGUARDA.Text = "Com sistema de gestão ou retaguarda";
            this.RETAGUARDA.UseVisualStyleBackColor = true;
            // 
            // NINTEGRADO
            // 
            this.NINTEGRADO.AutoSize = true;
            this.NINTEGRADO.Location = new System.Drawing.Point(14, 30);
            this.NINTEGRADO.Name = "NINTEGRADO";
            this.NINTEGRADO.Size = new System.Drawing.Size(92, 17);
            this.NINTEGRADO.TabIndex = 13;
            this.NINTEGRADO.TabStop = true;
            this.NINTEGRADO.Text = "Não integrado";
            this.NINTEGRADO.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Meio de geração";
            // 
            // GER1
            // 
            this.GER1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GER1.FormattingEnabled = true;
            this.GER1.Items.AddRange(new object[] {
            "Pelo PAF-ECF",
            "Pelo sistema de retaguarda",
            "Pelo sistema PED ou EFD"});
            this.GER1.Location = new System.Drawing.Point(535, 227);
            this.GER1.Name = "GER1";
            this.GER1.Size = new System.Drawing.Size(124, 21);
            this.GER1.TabIndex = 21;
            // 
            // GER2
            // 
            this.GER2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GER2.FormattingEnabled = true;
            this.GER2.Items.AddRange(new object[] {
            "Pelo PAF-ECF",
            "Pelo sistema de retaguarda",
            "Pelo sistema PED ou EFD"});
            this.GER2.Location = new System.Drawing.Point(535, 254);
            this.GER2.Name = "GER2";
            this.GER2.Size = new System.Drawing.Size(124, 21);
            this.GER2.TabIndex = 22;
            // 
            // GER3
            // 
            this.GER3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GER3.FormattingEnabled = true;
            this.GER3.Items.AddRange(new object[] {
            "Pelo PAF-ECF",
            "Pelo sistema de retaguarda",
            "Pelo sistema PED ou EFD"});
            this.GER3.Location = new System.Drawing.Point(535, 281);
            this.GER3.Name = "GER3";
            this.GER3.Size = new System.Drawing.Size(124, 21);
            this.GER3.TabIndex = 23;
            // 
            // BD2
            // 
            this.BD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD2.FormattingEnabled = true;
            this.BD2.Items.AddRange(new object[] {
            "Access",
            "Advantage Database Server",
            "Arquivo plano",
            "ASE",
            "Caché",
            "C-ISAM",
            "c-treeRTG",
            "DataFlex",
            "dBase",
            "DB2",
            "DBISAM",
            "Derby",
            "Firebird",
            "FlagShip",
            "FoxPro",
            "H2",
            "HFSQL",
            "Informix",
            "InterBase",
            "MariaDB",
            "MongoDB",
            "MySQL",
            "NexusDB",
            "OpenEdge",
            "Oracle",
            "Paradox",
            "PostgreSQL",
            "Progress",
            "Proprietário",
            "SQL Anywhere",
            "SQL Server",
            "SQLite",
            "TopSpeed",
            "XML",
            "ZIM"});
            this.BD2.Location = new System.Drawing.Point(40, 246);
            this.BD2.Name = "BD2";
            this.BD2.Size = new System.Drawing.Size(124, 21);
            this.BD2.TabIndex = 24;
            // 
            // BD4
            // 
            this.BD4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD4.FormattingEnabled = true;
            this.BD4.Items.AddRange(new object[] {
            "Access",
            "Advantage Database Server",
            "Arquivo plano",
            "ASE",
            "Caché",
            "C-ISAM",
            "c-treeRTG",
            "DataFlex",
            "dBase",
            "DB2",
            "DBISAM",
            "Derby",
            "Firebird",
            "FlagShip",
            "FoxPro",
            "H2",
            "HFSQL",
            "Informix",
            "InterBase",
            "MariaDB",
            "MongoDB",
            "MySQL",
            "NexusDB",
            "OpenEdge",
            "Oracle",
            "Paradox",
            "PostgreSQL",
            "Progress",
            "Proprietário",
            "SQL Anywhere",
            "SQL Server",
            "SQLite",
            "TopSpeed",
            "XML",
            "ZIM"});
            this.BD4.Location = new System.Drawing.Point(40, 301);
            this.BD4.Name = "BD4";
            this.BD4.Size = new System.Drawing.Size(124, 21);
            this.BD4.TabIndex = 26;
            // 
            // BD3
            // 
            this.BD3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD3.FormattingEnabled = true;
            this.BD3.Items.AddRange(new object[] {
            "Access",
            "Advantage Database Server",
            "Arquivo plano",
            "ASE",
            "Caché",
            "C-ISAM",
            "c-treeRTG",
            "DataFlex",
            "dBase",
            "DB2",
            "DBISAM",
            "Derby",
            "Firebird",
            "FlagShip",
            "FoxPro",
            "H2",
            "HFSQL",
            "Informix",
            "InterBase",
            "MariaDB",
            "MongoDB",
            "MySQL",
            "NexusDB",
            "OpenEdge",
            "Oracle",
            "Paradox",
            "PostgreSQL",
            "Progress",
            "Proprietário",
            "SQL Anywhere",
            "SQL Server",
            "SQLite",
            "TopSpeed",
            "XML",
            "ZIM"});
            this.BD3.Location = new System.Drawing.Point(40, 273);
            this.BD3.Name = "BD3";
            this.BD3.Size = new System.Drawing.Size(124, 21);
            this.BD3.TabIndex = 25;
            // 
            // BD5
            // 
            this.BD5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD5.FormattingEnabled = true;
            this.BD5.Items.AddRange(new object[] {
            "Access",
            "Advantage Database Server",
            "Arquivo plano",
            "ASE",
            "Caché",
            "C-ISAM",
            "c-treeRTG",
            "DataFlex",
            "dBase",
            "DB2",
            "DBISAM",
            "Derby",
            "Firebird",
            "FlagShip",
            "FoxPro",
            "H2",
            "HFSQL",
            "Informix",
            "InterBase",
            "MariaDB",
            "MongoDB",
            "MySQL",
            "NexusDB",
            "OpenEdge",
            "Oracle",
            "Paradox",
            "PostgreSQL",
            "Progress",
            "Proprietário",
            "SQL Anywhere",
            "SQL Server",
            "SQLite",
            "TopSpeed",
            "XML",
            "ZIM"});
            this.BD5.Location = new System.Drawing.Point(40, 328);
            this.BD5.Name = "BD5";
            this.BD5.Size = new System.Drawing.Size(124, 21);
            this.BD5.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BD5);
            this.Controls.Add(this.BD4);
            this.Controls.Add(this.BD3);
            this.Controls.Add(this.BD2);
            this.Controls.Add(this.GER3);
            this.Controls.Add(this.GER2);
            this.Controls.Add(this.GER1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BD1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LPROG);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LPROG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BD1;
        private System.Windows.Forms.RadioButton COMERCIALIZAVEL;
        private System.Windows.Forms.RadioButton EPROPRIO;
        private System.Windows.Forms.RadioButton ETERC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton STALONE;
        private System.Windows.Forms.RadioButton PARAM;
        private System.Windows.Forms.RadioButton REDE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RETAGUARDA;
        private System.Windows.Forms.RadioButton NINTEGRADO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GER1;
        private System.Windows.Forms.ComboBox GER2;
        private System.Windows.Forms.ComboBox GER3;
        private System.Windows.Forms.ComboBox BD2;
        private System.Windows.Forms.ComboBox BD4;
        private System.Windows.Forms.ComboBox BD3;
        private System.Windows.Forms.ComboBox BD5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton AMBOS;
    }
}