using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace 김주엽_실습_10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp;
            int char_Count = 0;
            int line_Count = 1;
            FileInfo file = new FileInfo(args[0]);
            FileStream fstream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fstream);
            
            while(true)
            {
                if (reader.Peek() != -1)
                {
                    temp = (Char)reader.Read();
                    char_Count++;
                    if (temp == '\n')
                        line_Count++;
                    Console.Write(temp);
                }
                else
                    break;
            }

            Console.WriteLine("폴더이름 : {0}", file.Directory);
            Console.WriteLine("파일이름 : {0}", file.Name);
            Console.WriteLine("확장자 : {0}", file.Extension);
            Console.WriteLine("생성일 : {0}", file.CreationTime);
            Console.WriteLine("파일크기 : {0}", file.Length);
            Console.WriteLine("파일속성 : {0}", file.Attributes);
            Console.WriteLine("문자수 : {0}", char_Count);
            Console.WriteLine("라인수 : {0}", line_Count);
        }
    }
}
