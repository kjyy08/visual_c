﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace 김주엽_실습_13_01
{
    public partial class Form1 : Form
    {
        [Serializable]
        class DrawData
        {
            public Rectangle rt { get; set; }
            public Color color { get; set; }
            public Point startPoint { get; set; }
            public Point endPoint { get; set; }
            public DRAWING_MODE mode { get; set; }

            public DrawData(Point startPoint, Point endPoint, DRAWING_MODE mode, Color color)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
                this.mode = mode;
                this.color = color;
            }

            public DrawData(Rectangle rt, DRAWING_MODE mode, Color color)
            {
                this.rt = rt;
                this.mode = mode;
                this.color = color;
            }

            public void Draw(Graphics g)
            {
                Pen pen = new Pen(color);

                switch (mode)
                {
                    case DRAWING_MODE.LINE:
                        g.DrawLine(pen, startPoint, endPoint);
                        break;
                    case DRAWING_MODE.RECTANGLE:
                        if (rt.Width < 0 && rt.Height < 0)
                            g.DrawRectangle(pen, rt.X + rt.Width, rt.Y + rt.Height, rt.Width * -1, rt.Height * -1);
                        else if (rt.Width < 0)
                            g.DrawRectangle(pen, rt.X + rt.Width, rt.Y, rt.Width * -1, rt.Height);
                        else if (rt.Height < 0)
                            g.DrawRectangle(pen, rt.X, rt.Y + rt.Height, rt.Width, rt.Height * -1);
                        else
                            g.DrawRectangle(pen, rt);
                        break;
                    case DRAWING_MODE.CIRCLE:
                        g.DrawEllipse(pen, rt);
                        break;
                }
            }
        }

        public enum DRAWING_MODE
        {
            LINE, RECTANGLE, CIRCLE, NONE
        }

        Pen pen;
        Color color;
        Point startPoint;
        Point endPoint;
        DRAWING_MODE dMode;
        Rectangle rt;
        ArrayList drawList;
        ArrayList redoItems;
        bool isDraw = false;
        bool isFix = false;

        public Form1()
        {
            InitializeComponent();

            color = new Color();
            pen = new Pen(Color.Black);
            startPoint = new Point();
            endPoint = new Point();
            drawList = new ArrayList();
            redoItems = new ArrayList();
            dMode = DRAWING_MODE.NONE;
        }

        private void menuItem_Line_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.LINE;
        }

        private void menuItem_Rectangle_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.RECTANGLE;
        }

        private void menuItem_Circle_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.CIRCLE;
        }

        private void menuItem_Read_Click(object sender, EventArgs e)
        {
            if (!(openFileDlg.ShowDialog() == DialogResult.OK))
                return;

            FileStream fstream = new FileStream(openFileDlg.FileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            drawList = (ArrayList)formatter.Deserialize(fstream);
            fstream.Close();
            Invalidate();
        }

        private void menuItem_Save_Click(object sender, EventArgs e)
        {
            FileStream fstream = new FileStream(saveFileDlg.FileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fstream, drawList);
            fstream.Close();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
        
            startPoint = e.Location;
            rt.Location = e.Location;
            isDraw = true;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (isDraw)
            {
                endPoint = e.Location;
                rt.Width = endPoint.X - startPoint.X;
                rt.Height = endPoint.Y - startPoint.Y;
                Invalidate();
            }
        }
        
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            endPoint = e.Location;
            rt.Width = endPoint.X - startPoint.X;
            rt.Height = endPoint.Y - startPoint.Y;
            
            if (dMode == DRAWING_MODE.LINE)
                drawList.Add(new DrawData(startPoint, endPoint, dMode, pen.Color));
            else
                drawList.Add(new DrawData(rt, dMode, pen.Color));

            Invalidate();
            isDraw = false;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            
            foreach (DrawData i in drawList)
                i.Draw(e.Graphics);

            if (!isFix)
            {
                switch (dMode)
                {
                    case DRAWING_MODE.LINE:
                        e.Graphics.DrawLine(pen, startPoint, endPoint);
                        break;
                    case DRAWING_MODE.RECTANGLE:
                        if (rt.Width < 0 && rt.Height < 0)
                            e.Graphics.DrawRectangle(pen, rt.X + rt.Width, rt.Y + rt.Height, rt.Width * -1, rt.Height * -1);
                        else if (rt.Width < 0)
                            e.Graphics.DrawRectangle(pen, rt.X + rt.Width, rt.Y, rt.Width * -1, rt.Height);
                        else if (rt.Height < 0)
                            e.Graphics.DrawRectangle(pen, rt.X, rt.Y + rt.Height, rt.Width, rt.Height * -1);
                        else
                            e.Graphics.DrawRectangle(pen, rt);
                        break;
                    case DRAWING_MODE.CIRCLE:
                        e.Graphics.DrawEllipse(pen, rt);
                        break;
                }
            }
            else
            {
                isFix = false;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            ResizeRedraw = true;
        }

        private void toolTipColor_Click(object sender, EventArgs e)
        {
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDlg.Color;
                color = colorDlg.Color;
            }

            else
            {
                pen.Color = Color.Black;
                color = Color.Black;
            }
        }

        private void toolTipDrawLine_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.LINE;
        }

        private void toolTipDrawCircle_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.CIRCLE;
        }

        private void toolTipDrawRectangle_Click(object sender, EventArgs e)
        {
            dMode = DRAWING_MODE.RECTANGLE;
        }

        private void toolTipUndo_Click(object sender, EventArgs e)  //  실행취소
        {
            if (drawList.Count - 1 < 0)
                return;

            redoItems.Add(drawList[drawList.Count - 1]);
            drawList.Remove(drawList[drawList.Count - 1]);
            isFix = true;
            Invalidate();
        }

        private void toolTipRedo_Click(object sender, EventArgs e)
        {
            if (redoItems.Count - 1 < 0)
                return;

            DrawData data = (DrawData)redoItems[redoItems.Count - 1];
            drawList.Add(data);
            redoItems.Remove(data);
            isFix = true;
            Invalidate();
        }
    }
}
