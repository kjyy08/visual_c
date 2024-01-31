using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 김주엽19017029_과제03
{
    class Program
    {
        static void Main(string[] args)
        {
            AddrCardManager addrCardManager = new AddrCardManager();

            do
            {
                ADDR_CARD addrCard = new ADDR_CARD();

                Console.Write("이름: "); addrCard.Name = Console.ReadLine();
                Console.Write("나이: "); addrCard.Age = Int32.Parse(Console.ReadLine());
                Console.Write("출신고: "); addrCard.HighSchool = Console.ReadLine();
                addrCardManager.AddCard(addrCard);

                Console.Write("계속 입력(y), 중지(n) : ");
            } while (Console.ReadLine() == "y");

            addrCardManager.PrintCard();
        }
    }
}
