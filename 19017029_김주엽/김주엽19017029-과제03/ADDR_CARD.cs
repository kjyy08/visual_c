using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 김주엽19017029_과제03
{
    class ADDR_CARD
    {
        public ADDR_CARD() { }
        public ADDR_CARD(string name, int age, string highSchool)
        {
            Name = name;
            Age = age;
            HighSchool = highSchool;
        }

        public string Name { get; set; }
        public string HighSchool { get; set; }
        public int Age { get; set; }
    }

    class AddrCardManager
    {
        private List<ADDR_CARD> addrList = new List<ADDR_CARD>();

        public void AddCard(ADDR_CARD card)
        {
            addrList.Add(card);
        }

        public void PrintCard()
        {
            if (addrList.Count > 0)
            {
                Console.WriteLine("{0}\t{1}\t{2}", "이름", "나이", "출신교");

                foreach (ADDR_CARD i in addrList)
                {
                    Console.WriteLine("{0}\t {1}\t {2}", i.Name, i.Age, i.HighSchool);
                }
            }

            else
            {
                Console.WriteLine("입력된 정보가 없습니다.");
            }
        }
    }
}
