namespace OperacoesBasicas
{
    partial class OprBasicas
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtAnwser = new System.Windows.Forms.TextBox();
            this.rdSoma = new System.Windows.Forms.RadioButton();
            this.rdSubtrair = new System.Windows.Forms.RadioButton();
            this.rdMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdDividir = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(302, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Opercoes Basicas com 2 Valores";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumber1.Location = new System.Drawing.Point(117, 157);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(56, 13);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number 1:";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumber2.Location = new System.Drawing.Point(117, 214);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(56, 13);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "Number 2:";
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnwser.Location = new System.Drawing.Point(117, 283);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(45, 13);
            this.lblAnwser.TabIndex = 3;
            this.lblAnwser.Text = "Anwser:";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(278, 150);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(278, 207);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 5;
            // 
            // txtAnwser
            // 
            this.txtAnwser.Location = new System.Drawing.Point(278, 283);
            this.txtAnwser.Name = "txtAnwser";
            this.txtAnwser.Size = new System.Drawing.Size(100, 20);
            this.txtAnwser.TabIndex = 6;
            // 
            // rdSoma
            // 
            this.rdSoma.AutoSize = true;
            this.rdSoma.Checked = true;
            this.rdSoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSoma.Location = new System.Drawing.Point(577, 150);
            this.rdSoma.Name = "rdSoma";
            this.rdSoma.Size = new System.Drawing.Size(52, 17);
            this.rdSoma.TabIndex = 7;
            this.rdSoma.TabStop = true;
            this.rdSoma.Text = "Soma";
            this.rdSoma.UseVisualStyleBackColor = true;
            // 
            // rdSubtrair
            // 
            this.rdSubtrair.AutoSize = true;
            this.rdSubtrair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSubtrair.Location = new System.Drawing.Point(577, 195);
            this.rdSubtrair.Name = "rdSubtrair";
            this.rdSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdSubtrair.TabIndex = 8;
            this.rdSubtrair.TabStop = true;
            this.rdSubtrair.Text = "Subtrair";
            this.rdSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdMultiplicar
            // 
            this.rdMultiplicar.AutoSize = true;
            this.rdMultiplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdMultiplicar.Location = new System.Drawing.Point(577, 237);
            this.rdMultiplicar.Name = "rdMultiplicar";
            this.rdMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdMultiplicar.TabIndex = 9;
            this.rdMultiplicar.TabStop = true;
            this.rdMultiplicar.Text = "Multiplicar";
            this.rdMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdDividir
            // 
            this.rdDividir.AutoSize = true;
            this.rdDividir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdDividir.Location = new System.Drawing.Point(577, 284);
            this.rdDividir.Name = "rdDividir";
            this.rdDividir.Size = new System.Drawing.Size(54, 17);
            this.rdDividir.TabIndex = 10;
            this.rdDividir.TabStop = true;
            this.rdDividir.Text = "Dividir";
            this.rdDividir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(213, 358);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(345, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(487, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // OprBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdDividir);
            this.Controls.Add(this.rdMultiplicar);
            this.Controls.Add(this.rdSubtrair);
            this.Controls.Add(this.rdSoma);
            this.Controls.Add(this.txtAnwser);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblTitle);
            this.Name = "OprBasicas";
            this.Text = "Operacoens Basicas";
            this.Load += new System.EventHandler(this.OprBasicas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtAnwser;
        private System.Windows.Forms.RadioButton rdSoma;
        private System.Windows.Forms.RadioButton rdSubtrair;
        private System.Windows.Forms.RadioButton rdMultiplicar;
        private System.Windows.Forms.RadioButton rdDividir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

