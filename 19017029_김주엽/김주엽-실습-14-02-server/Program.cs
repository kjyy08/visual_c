using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace 김주엽_실습_14_02_server
{
    class Program
    {
        public static Socket server;
        public static Socket client;

        static void Connect()
        {
            IPEndPoint endIP = new IPEndPoint(IPAddress.Any, 1000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(endIP);
            server.Listen(100);
            Console.WriteLine("서버 시작...클라이언트 접속 대기중...");

            client = server.Accept();
            NetworkStream ns = new NetworkStream(client);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint; // 클라이언트 주소
            Console.WriteLine("{0}클라이언트 주소, {1}포트 접속", ip.Address, ip.Port);
            string data = string.Format("접속되었습니다.");
            sw.WriteLine(data);
            sw.Flush();
        }

        static void SendData()
        {
            string data = "";
            NetworkStream ns = new NetworkStream(client);
            StreamWriter sw = new StreamWriter(ns);

            while (true)
            {

                data = Console.ReadLine();
                sw.WriteLine(data);
                sw.Flush();
                if (data == "Goodbye")
                    break;
            }
        }

        static void ReceiveData()
        {
            string data = "";
            NetworkStream ns = new NetworkStream(client);
            StreamReader sr = new StreamReader(ns);

            while (true)
            {
                data = sr.ReadLine();
                Console.WriteLine("[수신] " + data);
                if (data == "Goodbye")
                    break;
            }
        }

        static void Main(string[] args)
        {
            Connect();

            Thread send_th = new Thread(new ThreadStart(SendData));
            Thread receive_th = new Thread(new ThreadStart(ReceiveData));

            send_th.Start();
            receive_th.Start();

            send_th.Join();
            receive_th.Join();

            client.Close(); 
            server.Close(); 
            Console.WriteLine("서버 종료");
        }
    }
}
