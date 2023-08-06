namespace drag_and_drop
{
    partial class dragDrop
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
            this.lstbDrag = new System.Windows.Forms.ListBox();
            this.lstbDrop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(344, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Drag and Drop";
            // 
            // lstbDrag
            // 
            this.lstbDrag.FormattingEnabled = true;
            this.lstbDrag.Items.AddRange(new object[] {
            "Maria",
            "Pedro",
            "Joao"});
            this.lstbDrag.Location = new System.Drawing.Point(137, 195);
            this.lstbDrag.Name = "lstbDrag";
            this.lstbDrag.Size = new System.Drawing.Size(161, 147);
            this.lstbDrag.TabIndex = 1;
            this.lstbDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstbDrag.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstbDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstbDrop
            // 
            this.lstbDrop.FormattingEnabled = true;
            this.lstbDrop.Location = new System.Drawing.Point(479, 195);
            this.lstbDrop.Name = "lstbDrop";
            this.lstbDrop.Size = new System.Drawing.Size(161, 147);
            this.lstbDrop.TabIndex = 2;
            this.lstbDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstbDrop.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstbDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // dragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbDrop);
            this.Controls.Add(this.lstbDrag);
            this.Controls.Add(this.lblTitle);
            this.Name = "dragDrop";
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.dragDrop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstbDrag;
        private System.Windows.Forms.ListBox lstbDrop;
    }
}

