using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 김주엽_과제_11_01
{
    class Account
    {
        int money;

        Random rnd = new Random();
        public Account(int money) { this.money = money; }

        int Deposit(int amount)
        {
            Monitor.Enter(this);

            Console.WriteLine("*** {0}님이 {1}원을 입금하려 합니다.",
            Thread.CurrentThread.Name, amount);
            Console.WriteLine("입금전 예금 잔액 : \\ " + money);
            Console.WriteLine("입금 금액 : \\ " + amount);
            money += amount;
            Console.WriteLine("금후 예금 잔액 : \\ " + money + "\n");

            Monitor.Exit(this);

            return amount;
        }

        int Withdraw(int amount)
        {
            int result = 0;

            if (money < 0)
            {
                throw new Exception("인출 가능한 잔액이 없습니다.");
            }

            Monitor.Enter(this);

            if (money >= amount)
            {
                Console.WriteLine("*** {0}님이 {1}원을 인출하려 합니다.",
                Thread.CurrentThread.Name, amount);
                Console.WriteLine("인출전 예금 잔액 : \\ " + money);
                Console.WriteLine("인출 금액 : \\ " + amount);
                money -= amount;
                Console.WriteLine("인출후 예금 잔액 : \\ " + money + "\n");
                result = amount;
            }
            else
            {
                result = 0; // 인출 금액이 계좌 잔액보다 많을 경우
            }

            Monitor.Exit(this);

            return result;
        }

        public void Trans()
        {
            // 입금과 인출을 수행하는 메서드(스레드)
            for (int i = 0; i < 3; i++)
            {
                // -20000~20000원 사이에 값 발생
                int money = rnd.Next(-20000, 20000);
                if (money > 0)
                { // 인출
                    if (Withdraw(money) == 0)
                    {
                        Console.WriteLine("## Err : 인출 금액이 계좌 잔액보다 많습니다.");
                    }
                }
                else
                { // 입금
                    Deposit(money * -1);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Thread[] th = new Thread[3]; // 스레드 객체 참조 배열 생성
                Account obj = new Account(10000); // 계좌 잔액을 만원으로 초기화
                for (int i = 0; i < 3; i++)
                { // 3개의 Trans 스레드 생성
                    th[i] = new Thread(new ThreadStart(obj.Trans));
                    // 스레드 Name 설정
                    th[i].Name = "고객[" + i + "]";
                }
                for (int i = 0; i < 3; i++)
                {
                    // 3개의 Trans 스레드 실행
                    th[i].Start();
                }
            }
        }
    }
}