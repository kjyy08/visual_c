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
    public partial class Form2 : Form
    {
        Form1 main;

        public Form2(Form1 main)
        {
            InitializeComponent();
            this.main = main;
            this.Owner = main;
        }

        public ListViewItem CreateItem()
        {
            ListViewItem item = new ListViewItem();

            item.Text = txtBox_Name.Text;
            item.SubItems.Add(txtBox_Address.Text);
            item.SubItems.Add(txtBox_Tel.Text);
            item.ImageIndex = Int32.Parse(txtBox_Idx.Text);

            return item;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            main.listView_Main.Items.Add(CreateItem());
        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
