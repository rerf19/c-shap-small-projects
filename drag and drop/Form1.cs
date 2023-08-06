using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drag_and_drop
{
    public partial class dragDrop : Form
    {
        public dragDrop()
        {
            InitializeComponent();
        }

        private void dragDrop_Load(object sender, EventArgs e)
        {
            lstbDrag.AllowDrop = true;
            lstbDrop.AllowDrop = true;
        }
        private void listBox_DragOver(object sender ,DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lstbDrag = sender as ListBox;
            if (lstbDrag.SelectedItem != null)
                DoDragDrop(sender, DragDropEffects.Move);
        }
        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            var lstbDrag = e.Data.GetData(typeof(ListBox)) as ListBox;
            var lstbDrop = sender as ListBox;
            lstbDrop.Items.Add(lstbDrag.SelectedItem);
            lstbDrag.Items.Remove(lstbDrag.SelectedItem);
        }
    }
}
