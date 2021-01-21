namespace GeraXML {
    partial class Form9 {
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
            this.VERSAOER = new System.Windows.Forms.TextBox();
            this.MES = new System.Windows.Forms.MaskedTextBox();
            this.ANO = new System.Windows.Forms.MaskedTextBox();
            this.VERSAORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BD_SIM = new System.Windows.Forms.RadioButton();
            this.BD_NAO = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.COMENTARIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versão da ER-PAF";
            // 
            // VERSAOER
            // 
            this.VERSAOER.Location = new System.Drawing.Point(360, 114);
            this.VERSAOER.Name = "VERSAOER";
            this.VERSAOER.Size = new System.Drawing.Size(100, 20);
            this.VERSAOER.TabIndex = 1;
            this.VERSAOER.Text = "02.06";
            this.VERSAOER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MES
            // 
            this.MES.Location = new System.Drawing.Point(262, 186);
            this.MES.Mask = "00";
            this.MES.Name = "MES";
            this.MES.Size = new System.Drawing.Size(100, 20);
            this.MES.TabIndex = 2;
            this.MES.Click += new System.EventHandler(this.MES_Click);
            // 
            // ANO
            // 
            this.ANO.Location = new System.Drawing.Point(464, 186);
            this.ANO.Mask = "0000";
            this.ANO.Name = "ANO";
            this.ANO.Size = new System.Drawing.Size(100, 20);
            this.ANO.TabIndex = 3;
            this.ANO.Click += new System.EventHandler(this.ANO_Click);
            // 
            // VERSAORT
            // 
            this.VERSAORT.Location = new System.Drawing.Point(353, 251);
            this.VERSAORT.Name = "VERSAORT";
            this.VERSAORT.Size = new System.Drawing.Size(134, 20);
            this.VERSAORT.TabIndex = 4;
            this.VERSAORT.Text = "6.0 aplicável à 02.06";
            this.VERSAORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Versão do Roteiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mês do Roteiro (MM)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano do Roteiro (AAAA)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "A empresa apresentou declaração do banco de dados";
            // 
            // BD_SIM
            // 
            this.BD_SIM.AutoSize = true;
            this.BD_SIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BD_SIM.Location = new System.Drawing.Point(314, 358);
            this.BD_SIM.Name = "BD_SIM";
            this.BD_SIM.Size = new System.Drawing.Size(54, 24);
            this.BD_SIM.TabIndex = 9;
            this.BD_SIM.TabStop = true;
            this.BD_SIM.Text = "Sim";
            this.BD_SIM.UseVisualStyleBackColor = true;
            // 
            // BD_NAO
            // 
            this.BD_NAO.AutoSize = true;
            this.BD_NAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BD_NAO.Location = new System.Drawing.Point(469, 358);
            this.BD_NAO.Name = "BD_NAO";
            this.BD_NAO.Size = new System.Drawing.Size(56, 24);
            this.BD_NAO.TabIndex = 10;
            this.BD_NAO.TabStop = true;
            this.BD_NAO.Text = "Não";
            this.BD_NAO.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Informações do Laudo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(973, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.Location = new System.Drawing.Point(754, 80);
            this.COMENTARIO.Multiline = true;
            this.COMENTARIO.Name = "COMENTARIO";
            this.COMENTARIO.Size = new System.Drawing.Size(329, 230);
            this.COMENTARIO.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(750, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comentários do OTC";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.COMENTARIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BD_NAO);
            this.Controls.Add(this.BD_SIM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VERSAORT);
            this.Controls.Add(this.ANO);
            this.Controls.Add(this.MES);
            this.Controls.Add(this.VERSAOER);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VERSAOER;
        private System.Windows.Forms.MaskedTextBox MES;
        private System.Windows.Forms.MaskedTextBox ANO;
        private System.Windows.Forms.TextBox VERSAORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton BD_SIM;
        private System.Windows.Forms.RadioButton BD_NAO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox COMENTARIO;
        private System.Windows.Forms.Label label7;
    }
}