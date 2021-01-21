namespace GeraXML {
    partial class EXEC_NFE {
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
            this.ARQUIVO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MD5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.REQ_FUNC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSIRA NOME DO ARQUIVO MD-5 E FUNÇÃO EXECUTADA";
            // 
            // ARQUIVO
            // 
            this.ARQUIVO.Location = new System.Drawing.Point(227, 67);
            this.ARQUIVO.Name = "ARQUIVO";
            this.ARQUIVO.Size = new System.Drawing.Size(298, 20);
            this.ARQUIVO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "MD-5";
            // 
            // MD5
            // 
            this.MD5.Location = new System.Drawing.Point(227, 93);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(298, 20);
            this.MD5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Função";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // REQ_FUNC
            // 
            this.REQ_FUNC.Location = new System.Drawing.Point(227, 119);
            this.REQ_FUNC.Name = "REQ_FUNC";
            this.REQ_FUNC.Size = new System.Drawing.Size(120, 20);
            this.REQ_FUNC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "ADICIONAR EXECUTÁVEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 48;
            this.button2.Text = "FINALISAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EXEC_NFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.REQ_FUNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MD5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ARQUIVO);
            this.Controls.Add(this.label1);
            this.Name = "EXEC_NFE";
            this.Text = "NFE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ARQUIVO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox REQ_FUNC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}