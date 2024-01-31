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

namespace FinalTestPrac
{
    public partial class Form1 : Form
    {
        public enum DRAW_MODE
        {
            LINE, CIRCLE, RECTANGLE,
        }

        [Serializable]
        public class PictureInfo
        {
            public Point startPoint;
            public Point endPoint;
            public DRAW_MODE mode;

            public PictureInfo(DRAW_MODE mode, Point startPoint, Point endPoint)
            {
                this.mode = mode;
                this.startPoint = startPoint;
                this.endPoint = endPoint;
            }
        }

        DirectoryInfo dirInfo;
        List<string> binDirectories;
        List<string> binFiles;

        Pen pen;
        Point startPoint;
        Point endPoint;
        bool isDraw = false;
        bool isFixed = false;
        DRAW_MODE mode = DRAW_MODE.LINE;
        List<PictureInfo> pictures;
        List<PictureInfo> tmpPictures;

        DataTable table;
        DataTable resultTable;


        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            ResizeRedraw = true;
            pen = new Pen(Color.Black);
            pictures = new List<PictureInfo>();
            tmpPictures = new List<PictureInfo>();

            table = new DataTable();
            table.Columns.Add(new DataColumn("M_NAME"));
            table.Columns.Add(new DataColumn("M_AGE"));
            gridView_Main.DataSource = table;

            resultTable = new DataTable();
            resultTable.Columns.Add(new DataColumn("M_NAME"));
            resultTable.Columns.Add(new DataColumn("M_AGE"));
            gridView_Result.DataSource = resultTable;
        }

        void GetSubDirectories(DirectoryInfo[] dirInfo)
        {
            listBox_Dirs.Items.Add("..");

            foreach (DirectoryInfo i in dirInfo)
            {
                listBox_Dirs.Items.Add(i.Name);
            }
        }

        void GetFiles(DirectoryInfo dirInfo)
        {
            FileInfo[] files = dirInfo.GetFiles();

            foreach (FileInfo i in files)
            {
                listBox_Files.Items.Add(i.Name);
            }
        }

        void LoadListBox()
        {
            listBox_Dirs.Items.Clear();
            listBox_Files.Items.Clear();

            GetSubDirectories(dirInfo.GetDirectories());
            GetFiles(dirInfo);
            Text = dirInfo.FullName;
        }

        private void btn_Func1_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDlg.FileName);

                dirInfo = file.Directory;
                LoadListBox();
            }
        }

        private void btn_Func2_Click(object sender, EventArgs e)
        {
            if (dirInfo.Parent != null)
                dirInfo = dirInfo.Parent;
            else
                return;

            LoadListBox();
        }

        private void btn_Func3_Click(object sender, EventArgs e)
        {
            pictures.Clear();
            Invalidate();
            Update();
            
            DataRow row = table.NewRow();

            row["M_NAME"] = txtBox_first.Text;
            row["M_AGE"] = Int32.Parse(txtBox_Sec.Text);

            table.Rows.Add(row);
            gridView_Main.Update();
        }

        private void btn_Func4_Click(object sender, EventArgs e)
        {
            resultTable.Rows.Clear();
            
            DataRow[] rows = table.Select(txtBox_first.Text);

            foreach(DataRow i in rows)
                resultTable.Rows.Add(i.ItemArray);

            gridView_Result.Update();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binDirectories = new List<string>();
            binFiles = new List<string>();

            foreach(string i in listBox_Dirs.Items)
            {
                binDirectories.Add(i);
            }

            foreach (string i in listBox_Files.Items)
            {
                binFiles.Add(i);
            }

            FileStream stream = new FileStream("dirs.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, binDirectories);
            stream.Close();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog();
            FileStream stream = new FileStream(openFileDlg.FileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            binDirectories = (List<string>)formatter.Deserialize(stream);

            foreach(string i in binDirectories)
            {
                listBox_Dirs.Items.Add(i);
            }

            stream.Close();
        }

        private void 선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = DRAW_MODE.LINE;
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = DRAW_MODE.RECTANGLE;
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = DRAW_MODE.CIRCLE;
        }

        void Draw(Graphics g)
        {
            foreach (PictureInfo i in pictures)
            {
                switch (i.mode)
                {
                    case DRAW_MODE.CIRCLE:
                        g.DrawEllipse(pen, i.startPoint.X, i.startPoint.Y, i.endPoint.X - i.startPoint.X, i.endPoint.Y - i.startPoint.Y);
                        break;

                    case DRAW_MODE.RECTANGLE:
                        Rectangle rect = new Rectangle(i.startPoint.X, i.startPoint.Y, i.endPoint.X - i.startPoint.X, i.endPoint.Y - i.startPoint.Y);

                        if (rect.Width < 0 && rect.Height < 0)
                            g.DrawRectangle(pen, i.endPoint.X, i.endPoint.Y, rect.Width * -1, rect.Height * -1);
                        else if (rect.Width < 0)
                            g.DrawRectangle(pen, i.endPoint.X, rect.Y, rect.Width * -1, rect.Height);
                        else if (rect.Height < 0)
                            g.DrawRectangle(pen, rect.X, i.endPoint.Y, rect.Width, rect.Height * -1);
                        else
                            g.DrawRectangle(pen, rect);

                        break;
                }
            }

            if (isFixed)
                return;

            switch (mode)
            {
                case DRAW_MODE.LINE:
                    g.DrawLine(pen, startPoint, endPoint);
                    break;

                case DRAW_MODE.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
                    break;

                case DRAW_MODE.RECTANGLE:
                    Rectangle rect = new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);

                    if (rect.Width < 0 && rect.Height < 0)
                        g.DrawRectangle(pen, endPoint.X, endPoint.Y, rect.Width * -1, rect.Height * -1);
                    else if (rect.Width < 0)
                        g.DrawRectangle(pen, endPoint.X, rect.Y, rect.Width * -1, rect.Height);
                    else if (rect.Height < 0)
                        g.DrawRectangle(pen, rect.X, endPoint.Y, rect.Width, rect.Height * -1);
                    else
                        g.DrawRectangle(pen, rect);

                    break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
                endPoint = new Point(e.X, e.Y);
                isDraw = true;
                isFixed = false;
                Invalidate();
                Update();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                if (mode == DRAW_MODE.LINE)
                {
                    startPoint = endPoint;
                    endPoint = new Point(e.X, e.Y);
                    Draw(this.CreateGraphics());
                }

                else
                {
                    endPoint = new Point(e.X, e.Y);
                    Invalidate();
                    Update();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                isDraw = false;

                if (mode != DRAW_MODE.LINE)
                    pictures.Add(new PictureInfo(mode, startPoint, endPoint));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isDraw || isFixed)
                Draw(e.Graphics);
        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictures.Count - 1 < 0)
                return;
            tmpPictures.Add(pictures[pictures.Count - 1]);
            pictures.RemoveAt(pictures.Count - 1);
            isFixed = true;
            Invalidate();
            Update();
        }

        private void 다시실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpPictures.Count - 1 < 0)
                return;
            pictures.Add(tmpPictures[tmpPictures.Count - 1]);
            tmpPictures.RemoveAt(tmpPictures.Count - 1);
            isFixed = true;
            Invalidate();
            Update();
        }
    }
}
