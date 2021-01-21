namespace GeraXML {
    partial class Form10 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OUTRO = new System.Windows.Forms.RadioButton();
            this.GERENTE1 = new System.Windows.Forms.RadioButton();
            this.GERENTE2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GerNome = new System.Windows.Forms.TextBox();
            this.GerCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoorOutro = new System.Windows.Forms.RadioButton();
            this.COORDENADOR1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CoordCPF = new System.Windows.Forms.TextBox();
            this.CoordNome = new System.Windows.Forms.TextBox();
            this.DATA = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LOCAL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OUTRO);
            this.panel1.Controls.Add(this.GERENTE1);
            this.panel1.Controls.Add(this.GERENTE2);
            this.panel1.Location = new System.Drawing.Point(31, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 100);
            this.panel1.TabIndex = 0;
            // 
            // OUTRO
            // 
            this.OUTRO.AutoSize = true;
            this.OUTRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTRO.Location = new System.Drawing.Point(117, 3);
            this.OUTRO.Name = "OUTRO";
            this.OUTRO.Size = new System.Drawing.Size(67, 24);
            this.OUTRO.TabIndex = 4;
            this.OUTRO.TabStop = true;
            this.OUTRO.Text = "Outro";
            this.OUTRO.UseVisualStyleBackColor = true;
            this.OUTRO.Click += new System.EventHandler(this.marca_nome);
            // 
            // GERENTE 1
            // 
            this.GERENTE.AutoSize = true;
            this.GERENTE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GERENTE1.Location = new System.Drawing.Point(2, 39);
            this.GERENTE1.Name = "GERENTE1";
            this.GERENTE1.Size = new System.Drawing.Size(77, 24);
            this.GERENTE1.TabIndex = 3;
            this.GERENTE1.TabStop = true;
            this.GERENTE1.Text = "GERENTE1";
            this.GERENTE1.UseVisualStyleBackColor = true;
            this.GERENTE1.Click += new System.EventHandler(this.marca_nome);
            // 
            // GERENTE2
            // 
            this.GERENTE2.AutoSize = true;
            this.GERENTE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GERENTE2.Location = new System.Drawing.Point(3, 3);
            this.GERENTE2.Name = "GERENTE2";
            this.GERENTE2.Size = new System.Drawing.Size(89, 24);
            this.GERENTE2.TabIndex = 2;
            this.GERENTE2.TabStop = true;
            this.GERENTE2.Text = "GERENTE2";
            this.GERENTE2.UseVisualStyleBackColor = true;
            this.GERENTE2.Click += new System.EventHandler(this.marca_nome);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerente de Testes";
            // 
            // GerNome
            // 
            this.GerNome.Location = new System.Drawing.Point(325, 51);
            this.GerNome.Name = "GerNome";
            this.GerNome.Size = new System.Drawing.Size(252, 20);
            this.GerNome.TabIndex = 2;
            // 
            // GerCPF
            // 
            this.GerCPF.Location = new System.Drawing.Point(325, 88);
            this.GerCPF.Name = "GerCPF";
            this.GerCPF.Size = new System.Drawing.Size(149, 20);
            this.GerCPF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coordenador de Testes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CoorOutro);
            this.panel2.Controls.Add(this.COORDENADOR1);
            this.panel2.Location = new System.Drawing.Point(34, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 100);
            this.panel2.TabIndex = 6;
            // 
            // CoorOutro
            // 
            this.CoorOutro.AutoSize = true;
            this.CoorOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoorOutro.Location = new System.Drawing.Point(117, 3);
            this.CoorOutro.Name = "CoorOutro";
            this.CoorOutro.Size = new System.Drawing.Size(67, 24);
            this.CoorOutro.TabIndex = 4;
            this.CoorOutro.TabStop = true;
            this.CoorOutro.Text = "Outro";
            this.CoorOutro.UseVisualStyleBackColor = true;
            this.CoorOutro.Click += new System.EventHandler(this.marca_nome);
            // 
            // COORDENADOR1
            // 
            this.COORDENADOR1.AutoSize = true;
            this.COORDENADOR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COORDENADOR1.Location = new System.Drawing.Point(3, 3);
            this.COORDENADOR1.Name = "COORDENADOR1";
            this.COORDENADOR1.Size = new System.Drawing.Size(96, 24);
            this.COORDENADOR1.TabIndex = 2;
            this.COORDENADOR1.TabStop = true;
            this.COORDENADOR1.Text = "COORDENADOR1";
            this.COORDENADOR1.UseVisualStyleBackColor = true;
            this.COORDENADOR1.Click += new System.EventHandler(this.marca_nome);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF";
            // 
            // CoordCPF
            // 
            this.CoordCPF.Location = new System.Drawing.Point(303, 235);
            this.CoordCPF.Name = "CoordCPF";
            this.CoordCPF.Size = new System.Drawing.Size(149, 20);
            this.CoordCPF.TabIndex = 9;
            // 
            // CoordNome
            // 
            this.CoordNome.Location = new System.Drawing.Point(303, 198);
            this.CoordNome.Name = "CoordNome";
            this.CoordNome.Size = new System.Drawing.Size(252, 20);
            this.CoordNome.TabIndex = 8;
            // 
            // DATA
            // 
            this.DATA.Location = new System.Drawing.Point(250, 338);
            this.DATA.Mask = "0000-00-00";
            this.DATA.Name = "DATA";
            this.DATA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DATA.Size = new System.Drawing.Size(64, 20);
            this.DATA.TabIndex = 50;
            this.DATA.Click += new System.EventHandler(this.DATA_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Data da Finalização do Laudo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Local";
            // 
            // LOCAL
            // 
            this.LOCAL.Location = new System.Drawing.Point(462, 338);
            this.LOCAL.Name = "LOCAL";
            this.LOCAL.Size = new System.Drawing.Size(149, 20);
            this.LOCAL.TabIndex = 52;
            this.LOCAL.Text = "Goiânia, GO";
            this.LOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 54;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LOCAL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CoordCPF);
            this.Controls.Add(this.CoordNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GerCPF);
            this.Controls.Add(this.GerNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OUTRO;
        private System.Windows.Forms.RadioButton GERENTE1;
        private System.Windows.Forms.RadioButton GERENTE2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GerNome;
        private System.Windows.Forms.TextBox GerCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton CoorOutro;
        private System.Windows.Forms.RadioButton COORDENADOR1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CoordCPF;
        private System.Windows.Forms.TextBox CoordNome;
        private System.Windows.Forms.MaskedTextBox DATA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LOCAL;
        private System.Windows.Forms.Button button1;
    }
}