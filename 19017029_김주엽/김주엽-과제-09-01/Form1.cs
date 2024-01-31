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

namespace 김주엽_과제_09_01
{
    public partial class Form1 : Form
    {
        public class CopyInfo
        {
            public string filePath;
            public string fileName;
            public bool isFile;

            public CopyInfo() { filePath = ""; fileName = ""; isFile = false; }
        }

        private DirectoryInfo dirInfo;
        private CopyInfo copyInfo;
        private int dirCount = 0;

        public Form1()
        {
            InitializeComponent();
            copyInfo = new CopyInfo();
        }

        void GetSubDirectories(DirectoryInfo[] directories)
        {
            foreach (DirectoryInfo i in directories)
            {
                ListViewItem subDirItem = new ListViewItem(i.Name.ToString(), 0);
                subDirItem.SubItems.Add(i.Attributes.ToString());
                subDirItem.SubItems.Add("");
                subDirItem.SubItems.Add(i.CreationTime.ToString());
                listView_Main.Items.Add(subDirItem);
                dirCount++;
            }
        }

        void GetFiles(DirectoryInfo dirInfo)
        {
            FileInfo[] files = dirInfo.GetFiles();

            foreach (FileInfo f in files)
            {
                ListViewItem item1 = new ListViewItem(f.Name.ToString(), 1); //이름과이미지
                item1.SubItems.Add(f.Attributes.ToString());//속성
                item1.SubItems.Add(f.Length.ToString());//크기
                item1.SubItems.Add(f.CreationTime.ToString());//생성시간
                listView_Main.Items.Add(item1);
            }
        }

        void LoadListView()
        {
            ListViewItem parentItem = new ListViewItem("..", 0);
            
            dirCount = 0;
            listView_Main.Items.Clear();
            parentItem.SubItems.Add("");
            parentItem.SubItems.Add("");
            parentItem.SubItems.Add("");
            listView_Main.Items.Add(parentItem);

            GetSubDirectories(dirInfo.GetDirectories());
            GetFiles(dirInfo);

            Text = dirInfo.FullName.ToString();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(fileDlg.FileName);
                ListViewItem parentItem = new ListViewItem("..", 0);

                dirInfo = info.Directory;
                LoadListView();
            }
        }

        private void listView_Main_DoubleClick(object sender, EventArgs e)
        {
            int seletedIdx = listView_Main.SelectedIndices[0];
            
            if (seletedIdx > dirCount)
            {
                MessageBox.Show("파일을  선택했습니다.");
                return;
            }
            
            else if (seletedIdx == 0)
                dirInfo = dirInfo.Parent;

            else
                dirInfo = dirInfo.GetDirectories()[seletedIdx - 1];
            
            LoadListView();
        }

        private void menuItem_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                int seletedIdx = listView_Main.SelectedIndices[0];

                if (seletedIdx > dirCount)
                {
                    copyInfo.filePath = dirInfo.FullName + "\\";
                    copyInfo.fileName = listView_Main.Items[listView_Main.SelectedIndices[0]].Text;
                    copyInfo.isFile = true;
                }

                else
                {
                    MessageBox.Show("파일을 선택하세요.");
                    copyInfo.filePath = "";
                    copyInfo.fileName = "";
                    copyInfo.isFile = false;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException(msg, ex);
            }
        }

        private void menuItem_Paste_Click(object sender, EventArgs e)
        {
            if (copyInfo.isFile)
            {
                FileInfo file = new FileInfo(copyInfo.filePath + copyInfo.fileName);

                file.CopyTo(Text + "\\" + copyInfo.fileName, true);
                LoadListView();
            }
        }

        private void menuItem_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int seletedIdx = listView_Main.SelectedIndices[0];

                if (seletedIdx > dirCount)
                {
                    if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FileInfo file = new FileInfo(this.Text + "\\" + listView_Main.Items[listView_Main.SelectedIndices[0]].Text);

                        file.Delete();
                        LoadListView();
                    }
                }

                else
                    MessageBox.Show("파일을 선택하세요.");
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException(msg, ex);
            }
        }
    }
}
