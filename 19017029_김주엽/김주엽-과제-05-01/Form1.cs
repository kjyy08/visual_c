using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 김주엽_과제_05_01
{
    public partial class form_Main : Form
    {
        InfoManager infoManager = new InfoManager();

        public form_Main()
        {
            InitializeComponent();
        }

        private void btn_SelectLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView_Info.View = View.LargeIcon;
        }

        private void btn_SelectSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView_Info.View = View.SmallIcon;
        }

        private void btn_Simple_CheckedChanged(object sender, EventArgs e)
        {
            listView_Info.View = View.List;
        }

        private void btn_Detail_CheckedChanged(object sender, EventArgs e)
        {
            listView_Info.View = View.Details;
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxIsEmpty())
            {
                MessageBox.Show("텍스트 입력 확인", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            infoManager.AddItem(CreateNewItem());
            
            
            LoadListView();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Stack<int> selectedIdx = new Stack<int>();
            bool isSorted = false;      //  정렬로 인한 삭제 오류 문제 방지
            
            foreach (int i in listView_Info.SelectedIndices)
            {
                selectedIdx.Push(i);
            }
            
            if (listView_Info.Sorting == SortOrder.Ascending)
            {
                isSorted = true;
                listView_Info.Sorting = SortOrder.None;
            }
            
            foreach (int i in selectedIdx)  //  인덱스 문제로 역순으로 제거할 것
            {
                infoManager.RemoveItem(i);
            }
            
            if (isSorted)
                listView_Info.Sorting = SortOrder.Ascending;
            
            LoadListView();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (listView_Info.Sorting == SortOrder.None)
                listView_Info.Sorting = SortOrder.Ascending;
            else
            {
                listView_Info.Sorting = SortOrder.None;
                LoadListView();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxIsEmpty())
            {
                MessageBox.Show("텍스트 입력 확인", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach(int i in listView_Info.SelectedIndices)
            {
                infoManager.ChangeItem(CreateNewItem(), i);
            }
            
            LoadListView();
        }

        private bool CheckTxtBoxIsEmpty()
        {
            if (txtBox_Name.Text == "")
                return true;

            if (txtBox_Place.Text == "")
                return true;

            if (txtBox_HeadCount.Text == "")
                return true;

            if (txtBox_Tel.Text == "")
                return true;

            if (txtBox_Img.Text == "")
                return true;

            return false;
        }

        private DepartmentInfo CreateNewItem()
        {
            return new DepartmentInfo(txtBox_Name.Text, 
                txtBox_Place.Text, 
                txtBox_Tel.Text, 
                Int32.Parse(txtBox_HeadCount.Text),
                Int32.Parse(txtBox_Img.Text));
        }

        private void LoadListView()
        {
            if (listView_Info.Items.Count > 0)
                listView_Info.Items.Clear();

            for (int i = 0; i < infoManager.GetCount(); i++)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = infoManager.GetItem(i).Name
                };

                item.SubItems.Add(infoManager.GetItem(i).Place);
                item.SubItems.Add(infoManager.GetItem(i).Tel);
                item.SubItems.Add(infoManager.GetItem(i).HeadCount.ToString());
                item.ImageIndex = infoManager.GetItem(i).ImgIndex;

                listView_Info.Items.Add(item);
            }
        }
    }

    public class DepartmentInfo
    {
        public DepartmentInfo() { }
        public DepartmentInfo(string name, string place, string tel, int count, int index)
        {
            Name = name;
            Place = place;
            Tel = tel;
            HeadCount = count;
            ImgIndex = index;
        }

        public string Name { get; set; }
        public string Place { get; set; }
        public string Tel { get; set; }
        public int HeadCount { get; set; }
        public int ImgIndex { get; set; }
    }

    public class InfoManager
    {
        private List<DepartmentInfo> departmentInfos = new List<DepartmentInfo>();

        public void AddItem(DepartmentInfo item)
        {
            departmentInfos.Add(item);
        }

        public void ChangeItem(DepartmentInfo item, int idx)
        {
            departmentInfos[idx] = item;
        }

        public void RemoveItem(string name)
        {
            departmentInfos.Remove(departmentInfos.Find(x=>x.Name == name));
        }

        public void RemoveItem(int idx)
        {
            departmentInfos.RemoveAt(idx);
        }

        public int GetCount()
        {
            return departmentInfos.Count;
        }

        public DepartmentInfo GetItem(int idx)
        {
            return departmentInfos[idx];
        }
    }
}
