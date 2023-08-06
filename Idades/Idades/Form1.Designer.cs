namespace Idades
{
    partial class FormIdades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTDP = new System.Windows.Forms.TextBox();
            this.txtMDI = new System.Windows.Forms.TextBox();
            this.txtPMV = new System.Windows.Forms.TextBox();
            this.txtPMN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(226, 91);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(35, 96);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "IDADE";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(109, 93);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // txtTDP
            // 
            this.txtTDP.Location = new System.Drawing.Point(201, 169);
            this.txtTDP.Name = "txtTDP";
            this.txtTDP.Size = new System.Drawing.Size(100, 20);
            this.txtTDP.TabIndex = 3;
            // 
            // txtMDI
            // 
            this.txtMDI.Location = new System.Drawing.Point(201, 227);
            this.txtMDI.Name = "txtMDI";
            this.txtMDI.Size = new System.Drawing.Size(100, 20);
            this.txtMDI.TabIndex = 4;
            // 
            // txtPMV
            // 
            this.txtPMV.Location = new System.Drawing.Point(201, 278);
            this.txtPMV.Name = "txtPMV";
            this.txtPMV.Size = new System.Drawing.Size(100, 20);
            this.txtPMV.TabIndex = 5;
            // 
            // txtPMN
            // 
            this.txtPMN.Location = new System.Drawing.Point(201, 334);
            this.txtPMN.Name = "txtPMN";
            this.txtPMN.Size = new System.Drawing.Size(100, 20);
            this.txtPMN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PESSOA MAIS NOVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PESSOA MAIS VELHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MEDIA DAS IDADES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL DE PESSOAS";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(109, 387);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(129, 20);
            this.txtSaida.TabIndex = 11;
            // 
            // FormIdades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPMN);
            this.Controls.Add(this.txtPMV);
            this.Controls.Add(this.txtMDI);
            this.Controls.Add(this.txtTDP);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnInserir);
            this.Name = "FormIdades";
            this.Text = "Idades";
            this.Load += new System.EventHandler(this.FormIdades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTDP;
        private System.Windows.Forms.TextBox txtMDI;
        private System.Windows.Forms.TextBox txtPMV;
        private System.Windows.Forms.TextBox txtPMN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaida;
    }
}

