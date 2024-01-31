using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_08_01
{
    public partial class Form1 : Form
    {
        Form2 subForm;

        public Form1()
        {
            InitializeComponent();
            subForm = new Form2(this);
            subForm.Owner = this;
        }

        private void menuItem_Cancel_Click(object sender, EventArgs e)
        {
            txtBox_Main.Undo();
        }

        private void menuItem_Copy_Click(object sender, EventArgs e)
        {
            txtBox_Main.Copy();
        }

        private void menuItem_Paste_Click(object sender, EventArgs e)
        {
            txtBox_Main.Paste();
        }

        private void menuItem_Cut_Click(object sender, EventArgs e)
        {
            txtBox_Main.Cut();
        }

        private void menuItem_SelectAll_Click(object sender, EventArgs e)
        {
            txtBox_Main.SelectAll();
        }

        private void menuItem_Change_Click(object sender, EventArgs e)
        {
            subForm.Show();
        }
    }
}
