using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTestPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();

            if (chkBox_First.Checked == true)
                node.Text = txtBox_first.Text;
            else if (chkBox_Second.Checked == true)
                node.Text = txtBox_Second.Text;
            else
                node.Text = txtBox_Third.Text;

            string test = textBox1.Text;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 1;

            if (treeView_Main.SelectedNode != null)
                treeView_Main.SelectedNode.Nodes.Add(node);
            else
                treeView_Main.Nodes.Add(node);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (treeView_Main.SelectedNode != null)
                treeView_Main.SelectedNode.Remove();
        }

        private void btn_ExpandAll_Click(object sender, EventArgs e)
        {
            treeView_Main.ExpandAll();
        }

        private void btn_CollapseAll_Click(object sender, EventArgs e)
        {
            treeView_Main.CollapseAll();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            toolStripStatusLabel2.Text = string.Format("{0}년{1}월{2}일", date.Year, date.Month, date.Day);
            toolStripStatusLabel3.Text = string.Format("{0}시{1}분{2}초", date.Hour, date.Minute, date.Second);
            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("x: {0}, y: {1}", e.X, e.Y);
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (statusStrip.Items.IndexOf(e.ClickedItem))
            {
                case 0:
                    toolStripStatusLabel1_Click(sender, e);
                    break;

                case 1:
                    break;

                case 2:
                    break;

            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void btn_TabTest_Click(object sender, EventArgs e)
        {
            if (tabIdx >= 3)
                tabIdx = 0;
            else
                tabIdx++;

            tabControl1.Alignment = (TabAlignment)tabIdx;

            label_Date.Text = string.Format("{0} ~ {1}", monthCalendar1.SelectionRange.Start.ToString(),
                                                         monthCalendar1.SelectionRange.End.ToString());
        }

        private int tabIdx = 0;
    }
}
