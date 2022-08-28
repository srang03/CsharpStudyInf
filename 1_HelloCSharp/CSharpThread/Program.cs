using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpThread
{
    class Restaurant
    {
        public void MakeFood()
        {
            Console.WriteLine("요리시작");
            DateTime startTime = DateTime.Now;
            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("계란 요리");
            }
            Thread t1 = new Thread(new ThreadStart(Egg));
            
            void Soup()
            {
                Thread.Sleep(2000);
                Console.WriteLine("국 요리");
            }
            Thread t2 = new Thread(new ThreadStart(Soup));
            
            void Steak()
            {
                Thread.Sleep(2000);
                Console.WriteLine("스테이크 요리");
            }
            Thread t3 = new Thread(new ThreadStart(Steak));
            t1.Start(); t2.Start(); t3.Start(); // async

            t1.Join(); t2.Join(); t3.Join(); // await

            Console.WriteLine("요리종료");
            DateTime EndTime = DateTime.Now;
            Console.WriteLine((EndTime - startTime).TotalSeconds);

            Console.WriteLine("식사 시작");
            //SinglePro();
            MultiPro();
            Console.WriteLine("식사 종료");

        }

        private void SinglePro()
        {
            for (int i = 0; i < 20_000; i++)
            {
                Console.WriteLine("수다...");
            }
        }
        private void MultiPro()
        {
            Parallel.For(0, 20_000, (i) => { global::System.Console.WriteLine($"수다 {i}"); });
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Restaurant().MakeFood();
        }
    }
}
