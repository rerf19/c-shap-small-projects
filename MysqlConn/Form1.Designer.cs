﻿namespace MysqlConn1
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.txtUltimoNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(488, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primeiro Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ultimo Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Morada:";
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Location = new System.Drawing.Point(235, 70);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(190, 20);
            this.txtPrimeiroNome.TabIndex = 5;
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.Location = new System.Drawing.Point(235, 111);
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Size = new System.Drawing.Size(190, 20);
            this.txtUltimoNome.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(235, 156);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(190, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(235, 200);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(190, 20);
            this.txtMorada.TabIndex = 8;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(472, 91);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtUltimoNome);
            this.Controls.Add(this.txtPrimeiroNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.TextBox txtUltimoNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Button btnInserir;
    }
}

