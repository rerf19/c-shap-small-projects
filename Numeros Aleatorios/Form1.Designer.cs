namespace Numeros_Aleatorios
{
    partial class form_n_a
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lstb1 = new System.Windows.Forms.ListBox();
            this.lstb2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(97, 85);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(99, 78);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lstb1
            // 
            this.lstb1.FormattingEnabled = true;
            this.lstb1.Location = new System.Drawing.Point(316, 81);
            this.lstb1.Name = "lstb1";
            this.lstb1.Size = new System.Drawing.Size(326, 82);
            this.lstb1.TabIndex = 1;
            // 
            // lstb2
            // 
            this.lstb2.FormattingEnabled = true;
            this.lstb2.Location = new System.Drawing.Point(316, 207);
            this.lstb2.Name = "lstb2";
            this.lstb2.Size = new System.Drawing.Size(326, 199);
            this.lstb2.TabIndex = 2;
            // 
            // form_n_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstb2);
            this.Controls.Add(this.lstb1);
            this.Controls.Add(this.btnGerar);
            this.Name = "form_n_a";
            this.Text = "Numeros Aleatorios";
            this.Load += new System.EventHandler(this.form_n_a_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lstb1;
        private System.Windows.Forms.ListBox lstb2;
    }
}

