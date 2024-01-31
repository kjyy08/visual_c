using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace 김주엽_실습_10_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem_Save_Click(object sender, EventArgs e)
        {
            FileStream fstream = new FileStream(saveFileDlg.FileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            ArrayList items = new ArrayList();

            foreach(ListViewItem i in listView_Main.Items)
            {
                items.Add(i);
            }

            formatter.Serialize(fstream, items);
            fstream.Close();
            listView_Main.Items.Clear();
            items.Clear();
        }

        private void menuItem_Open_Click(object sender, EventArgs e)
        {
            if (!(openFileDlg.ShowDialog() == DialogResult.OK))
                return;

            FileStream fstream = new FileStream(openFileDlg.FileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            ArrayList items = (ArrayList)formatter.Deserialize(fstream);

            foreach(ListViewItem i in items)
            {
                ListViewItem item = new ListViewItem();

                item.Text = i.Text;
                item.SubItems.Add(i.SubItems[1].Text);
                item.SubItems.Add(i.SubItems[2].Text);
                item.SubItems.Add(i.SubItems[3].Text);
                
                if (i.SubItems[3].Text == "남자")
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;
                
                listView_Main.Items.Add(item);
            }

            fstream.Close();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void rdoBtn_Simple_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn_Simple.Checked)
                listView_Main.View = View.List;
        }

        private void rdoBtn_S_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn_S.Checked)
                listView_Main.View = View.SmallIcon;
        }

        private void rdoBtn_L_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn_L.Checked)
                listView_Main.View = View.LargeIcon;
        }

        private void rdoBtn_Detail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn_Detail.Checked)
                listView_Main.View = View.Details;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            item.Text = txtBox_Name.Text;
            item.SubItems.Add(txtBox_Address.Text);
            item.SubItems.Add(txtBox_Tel.Text);
            item.SubItems.Add(comboBox_Mail.Text);

            if (comboBox_Mail.Text == "남자")
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            listView_Main.Items.Add(item);
        }
    }
}
