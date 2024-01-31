using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 김주엽_과제_10_01
{
    public partial class Form1 : Form
    {
        ItemManager items;

        public Form1()
        {
            InitializeComponent();
            items = new ItemManager();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            items.Add(txtBox_Name.Text, txtBox_ID.Text, txtBox_Major.Text); 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ADDR_CARD item = items.GetItem(txtBox_Name.Text);

            if (item != null)
            {
                txtBox_ID.Text = item.id;
                txtBox_Major.Text = item.major;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int selectedIdx = items.GetSelectedIdx(txtBox_Name.Text);

            if (selectedIdx != -1)
            {
                if (selectedIdx + 1 >= items.items.Count)
                    selectedIdx = -1;

                ADDR_CARD item = items.GetItem(++selectedIdx);
                txtBox_Name.Text = item.name;
                txtBox_ID.Text = item.id;
                txtBox_Major.Text = item.major;
            }
        }

        private void menuItem_Read_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog();

            FileStream fStream = new FileStream(openFileDlg.FileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            items.items = (List<ADDR_CARD>)formatter.Deserialize(fStream);

            ADDR_CARD item = items.GetItem(0);
            txtBox_Name.Text = item.name;
            txtBox_ID.Text = item.id;
            txtBox_Major.Text = item.major;
        }

        private void menuItem_Save_Click(object sender, EventArgs e)
        {
            FileStream fStream = new FileStream(saveFileDlg.FileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fStream, items.items);
            fStream.Close();
            items.items.Clear();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
