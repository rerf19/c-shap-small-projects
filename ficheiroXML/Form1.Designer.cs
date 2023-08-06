namespace ficheiroXMLinicio
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.xml_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(209, 91);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(67, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(209, 141);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 20);
            this.txt2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(154, 94);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Numero:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(154, 144);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Nome:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(400, 32);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 40);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "ADICIONAR";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(400, 78);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 40);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "LER";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(400, 124);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(112, 40);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xml_num,
            this.xml_name});
            this.dataGrid1.Location = new System.Drawing.Point(157, 222);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(262, 150);
            this.dataGrid1.TabIndex = 7;
            // 
            // xml_num
            // 
            this.xml_num.HeaderText = "Numero";
            this.xml_num.Name = "xml_num";
            // 
            // xml_name
            // 
            this.xml_name.HeaderText = "Nome";
            this.xml_name.Name = "xml_name";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(400, 170);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(112, 40);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "ALTERAR";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_name;
        private System.Windows.Forms.Button btn4;
    }
}

