using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_실습_13_02
{
    public partial class Form1 : Form
    {
        public enum DRAWING_MODE
        {
            LINE, FREE, NONE
        }

        Pen pen;
        Pen backPen;
        Point startPoint;
        Point tmpPoint;
        DRAWING_MODE dMode;
        bool isDraw = false;

        public Form1()
        {
            InitializeComponent();
            
            pen = new Pen(Color.Black);
            backPen = new Pen(BackColor);
            startPoint = new Point();
            dMode = DRAWING_MODE.NONE;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                dMode = DRAWING_MODE.FREE;

            else
                dMode = DRAWING_MODE.LINE;

            Point nowPoint = new Point(e.X, e.Y); // 현재마우스의위치
            startPoint = nowPoint; // 선의시작점의위치를설정
            tmpPoint = nowPoint; // 바로전에그렸던선의끝점의위치를초기화
            isDraw = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                Point nowPoint = new Point(e.X, e.Y); // 현재마우스의위치
                Graphics g = this.CreateGraphics();
                Draw(g, nowPoint);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point nowPoint = new Point(e.X, e.Y);
            Graphics g = this.CreateGraphics();

            switch (dMode)
            {
                case DRAWING_MODE.LINE:
                    pen.Color = Color.Black;
                    g.DrawLine(pen, startPoint, nowPoint);
                    break;
                case DRAWING_MODE.FREE:
                    pen.Color = Color.Red;
                    g.DrawLine(pen, tmpPoint, nowPoint);
                    break;
            }
            isDraw = false;
        }

        void Draw(Graphics g, Point nowPoint)
        {
            switch (dMode)
            {
                case DRAWING_MODE.LINE:
                    pen.Color = Color.Black;
                    g.DrawLine(backPen, startPoint, tmpPoint);
                    g.DrawLine(pen, startPoint, nowPoint);
                    tmpPoint = nowPoint;
                    break;
                case DRAWING_MODE.FREE:
                    pen.Color = Color.Red;
                    g.DrawLine(pen, tmpPoint, nowPoint);
                    tmpPoint = nowPoint;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            ResizeRedraw = true;
        }
    }
}
