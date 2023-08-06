namespace Tabuadas
{
    partial class FormTabuada
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
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.cboNumero = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.Location = new System.Drawing.Point(115, 150);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(237, 264);
            this.lstTabuada.TabIndex = 0;
            // 
            // cboNumero
            // 
            this.cboNumero.FormattingEnabled = true;
            this.cboNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboNumero.Location = new System.Drawing.Point(231, 81);
            this.cboNumero.Name = "cboNumero";
            this.cboNumero.Size = new System.Drawing.Size(121, 21);
            this.cboNumero.TabIndex = 1;
            this.cboNumero.SelectedIndexChanged += new System.EventHandler(this.cbNumero_SelectedIndexChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(112, 89);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Numero";
            // 
            // FormTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.cboNumero);
            this.Controls.Add(this.lstTabuada);
            this.Name = "FormTabuada";
            this.Text = "Tuabuadas";
            this.Load += new System.EventHandler(this.FormTabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTabuada;
        private System.Windows.Forms.ComboBox cboNumero;
        private System.Windows.Forms.Label lblNumber;
    }
}

