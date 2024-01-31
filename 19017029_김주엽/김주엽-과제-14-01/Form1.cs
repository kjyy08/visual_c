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
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace 김주엽_과제_14_01
{
    public partial class Form1 : Form
    {
        enum SITE { none, black, white };
        SITE[,] m_Board = new SITE[19, 19]; // 바둑판에 돌이 놓인 상태를 보관
                                            // 다음 둘 차례(True : 백돌, FALSE : 흑돌)
        bool m_WhTurn; // 흑돌 : false, 백돌 : true
        private Pen pen; // 펜
        private Brush whitebrush, blackbrush;

        Socket server;
        Socket client;
        int receiveDataCnt = 0;
        bool exitFlag = false;
        Thread receive_th;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();

            m_WhTurn = false; // 흑돌 부터 시작
            pen = new Pen(Color.Black);
            whitebrush = new SolidBrush(Color.Yellow); // 흑돌 브러시
            blackbrush = new SolidBrush(Color.Black); // 백돌 브러시
            receive_th = new Thread(new ThreadStart(ReceiveData));
        }

        void CloseSocket()
        {
            exitFlag = true;

            if (ns != null)
                ns.Close();
            if (sr != null)
                sr.Close();
            if (sw != null)
                sw.Close();
            
            if (client != null && client.Connected)
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }

            if (server != null && server.Connected)
            {
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
        }
        
        void Connect()
        {
            try
            {
                IPEndPoint endIP = new IPEndPoint(IPAddress.Any, 1000);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(endIP);
                server.Listen(100);
                client = server.Accept();
                ns = new NetworkStream(client);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                exitFlag = false;
                receive_th.Start();
            }
            catch(Exception e)
            {
                CloseSocket();
                return;
            }
        }

        void ReceiveData()
        {
            int ax = 0, ay = 0;
            string data = "";

            while (!exitFlag)
            {
                try
                {
                    data = sr.ReadLine();

                    if (data == "NewGame")
                    {
                        data = "";
                        m_WhTurn = false;
                        NewGame();
                        receiveDataCnt = 0;
                    }

                    else if (data == "")
                    {
                        continue;
                    }
                    
                    else if (data == "Exit")
                    {
                        CloseSocket();
                        return;
                    }

                    else
                    {
                        if (receiveDataCnt == 0)
                        {
                            ax = Int32.Parse(data);
                            receiveDataCnt++;
                        }

                        else
                        {
                            ay = Int32.Parse(data);
                            receiveDataCnt = 0;
                            m_Board[ax, ay] = (m_WhTurn ? SITE.white : SITE.black);
                            DrawSite(ax, ay, m_Board[ax, ay]);
                            m_WhTurn = !m_WhTurn; // 차례 바꿈
                        }
                    }
                }
                catch
                {
                    CloseSocket();
                    return;
                }
            }
        }

        void DrawSite(int x, int y, SITE dol)
        {
            Graphics g = this.CreateGraphics();
            if (dol != SITE.none)
            {
                if (dol == SITE.black) // 검정색 돌은 검정색 브러시
                    g.FillEllipse(blackbrush, x * 20 + 2, y * 20 + 2, 16, 16);
                else // 백색 돌은 노란색 브러시
                    g.FillEllipse(whitebrush, x * 20 + 2, y * 20 + 2, 16, 16);
            }
        }

        void NewGame()
        {
            // 바둑돌 없음으로 초기화
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    m_Board[x, y] = SITE.none;
            m_WhTurn = false; // 흑돌 시작
            Invalidate(); // 바둑판 다시 그리기
        }

        private void menuItem_NewGame_Click(object sender, EventArgs e)
        {
            try
            {
                sw.WriteLine("NewGame");
                sw.Flush();
            }
            catch
            {
                CloseSocket();
                return;
            }

            NewGame();
        }

        private void menuItem_StartServer_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                sw.WriteLine("Exit");
                sw.Flush();
            }
            catch
            {
                CloseSocket();
            }

            Dispose();
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            else if (client == null)
                return;
            else if (m_WhTurn == false)
                return;

            int ax = e.X / 20;
            int ay = e.Y / 20;
            string data = "";

            if ((ax < 0) || (ax >= 19) || (ay < 0) || (ay >= 19))
                return;
            if (m_Board[ax, ay] != SITE.none)
                return;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    data = string.Format("{0}", ax);
                else
                    data = string.Format("{0}", ay);
                try
                {
                    sw.WriteLine(data);
                    sw.Flush();
                }
                catch
                {
                    CloseSocket();
                    return;
                }
            }

            m_Board[ax, ay] = (m_WhTurn ? SITE.white : SITE.black);
            DrawSite(ax, ay, m_Board[ax, ay]);  // 바둑돌을 그린다.
            m_WhTurn = !m_WhTurn; // 차례 바꿈
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSocket();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics(); // = e.Graphics;
            for (int x = 0; x < 19; x++)
                g.DrawLine(pen, 10, 34 + x * 20, 370, 34 + x * 20);
            for (int x = 0; x < 19; x++)
                g.DrawLine(pen, 10 + x * 20, 34, 10 + x * 20, 394);
        }
    }
}
