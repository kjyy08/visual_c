using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pgm
{
    static class Constants
    {
        public const int MAX_COUNT = 10;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> nList = new List<int>();
            
            for (int i = 0; i < Constants.MAX_COUNT; i++)
            {
                Console.Write((i + 1) + "번째 값을 입력하시오. : ");
                nList.Add(Int32.Parse(Console.ReadLine()));
            }
            
            //Console.WriteLine("maximum =\t" + nList.Max() + ", " + "minimum =\t" + nList.Min());
            Console.WriteLine("maximum =\t{0}, minimum =\t{1}", nList.Max(), nList.Min());
        }
    }
}
