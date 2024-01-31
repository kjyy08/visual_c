using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_07_01
{
    public partial class Form1 : Form
    {
        Form2 subForm;

        public Form1()
        {
            InitializeComponent();
            subForm = new Form2(this);
        }

        void ChangeCheckedToolStripItem(ToolStripMenuItem target, string name)
        {
            foreach (ToolStripMenuItem i in target.DropDownItems)
            {
                if (i.Name == name)
                    i.Checked = true;
                else
                    i.Checked = false;
            }
        }
        
        private void menuItem_LIcon_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.LargeIcon;
            ChangeCheckedToolStripItem(menuItem_List, "menuItem_LIcon");
        }

        private void menuItem_SIcon_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.SmallIcon;
            ChangeCheckedToolStripItem(menuItem_List, "menuItem_SIcon");
        }

        private void menuItem_Simple_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.List;
            ChangeCheckedToolStripItem(menuItem_List, "menuItem_Simple");
        }

        private void menuItem_Detail_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.Details;
            ChangeCheckedToolStripItem(menuItem_List, "menuItem_Detail");
        }

        private void menuItem_Remove_Click(object sender, EventArgs e)
        {
            for(int i = listView_Main.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listView_Main.Items.RemoveAt(listView_Main.SelectedIndices[i]);
            }
        }

        private void menuItem_Input_Click(object sender, EventArgs e)
        {
            if (subForm == null)
                subForm = new Form2(this);
            subForm.Location = new Point(this.Location.X + this.Size.Width + 100, this.Location.Y);
            subForm.Show();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            if (subForm != null)
            {
                subForm.Dispose();
                subForm.Close();
                subForm = null;
            }
        }
    }
}
