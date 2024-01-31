using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace 김주엽_실습_14_02_client
{
    class Program
    {
        public static Socket client;

        static void Connect()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(ipep); // 서버에 연결
            Console.WriteLine("서버에 접속...");
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

            client.Close(); // 통신 소켓 해제
            Console.WriteLine("클라이언트 종료");
        }
    }
}
