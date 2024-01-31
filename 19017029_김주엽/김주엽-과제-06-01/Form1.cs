using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_06_01
{
    public partial class Form1 : Form
    {
        private List<ListViewItem> beforeSortingItems = new List<ListViewItem>();

        public Form1()
        {
            InitializeComponent();
        }
        
        ListViewItem CreateItem()
        {
            ListViewItem item = new ListViewItem();

            item.Text = txtBox_Name.Text;
            item.SubItems.Add(comboBox_Major.Text);
            item.SubItems.Add(txtBox_Address.Text);
            item.SubItems.Add(txtBox_Tel.Text);

            if (comboBox_Gender.Text == "남자")
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            return item;
        }

        void AddItems()
        {
            if (listView_Main.Sorting == SortOrder.None)
                listView_Main.Items.Add(CreateItem());
            else
            {
                ListViewItem item = CreateItem();

                listView_Main.Items.Add(item);
                beforeSortingItems.Add(item);
            }
        }

        void RemoveItems()
        {
            if (listView_Main.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("항목을 선택하세요", "경고");
            }

            else
            {
                for (int i = listView_Main.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listView_Main.Items.RemoveAt(listView_Main.SelectedIndices[i]);
                }
            }
        }

        void SortItems()
        {
            if (listView_Main.Sorting == SortOrder.None)
            {
                foreach (ListViewItem i in listView_Main.Items)
                    beforeSortingItems.Add(i);

                listView_Main.Sorting = SortOrder.Ascending;
            }

            else
            {
                listView_Main.Items.Clear();
                listView_Main.Sorting = SortOrder.None;

                foreach (ListViewItem i in beforeSortingItems)
                    listView_Main.Items.Add(i);

                beforeSortingItems.Clear();
            }
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

        private void menuItem_Input_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void menuItem_Remove_Click(object sender, EventArgs e)
        {
            RemoveItems();
        }

        private void menuItem_Sort_Click(object sender, EventArgs e)
        {
            SortItems();
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

        private void cTxtMenuItem_Input_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void cTxtMenuItem_Remove_Click(object sender, EventArgs e)
        {
            RemoveItems();
        }

        private void cTxtMenuItem_Sort_Click(object sender, EventArgs e)
        {
            SortItems();
        }

        private void cTxtMenuItem_LIcon_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.LargeIcon;
            ChangeCheckedToolStripItem(cTxtMenuItem_List, "cTxtMenuItem_LIcon");
        }

        private void cTxtMenuItem_SIcon_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.SmallIcon;
            ChangeCheckedToolStripItem(cTxtMenuItem_List, "cTxtMenuItem_SIcon");
        }

        private void cTxtMenuItem_Simple_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.List;
            ChangeCheckedToolStripItem(cTxtMenuItem_List, "cTxtMenuItem_Simple");
        }

        private void cTxtMenuItem_Detail_Click(object sender, EventArgs e)
        {
            listView_Main.View = View.Details;
            ChangeCheckedToolStripItem(cTxtMenuItem_List, "cTxtMenuItem_Detail");
        }
    }
}
