using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpMultiThreading
{
    // Thread는 프로그램의 실행 방법이다.
    // 동시에 다른 작업을 수행하기 위해 멀티 스레드를 사용할 수 있다.
    // 현재 스레드는 Main 스레드에서 동작한다.

    // Form UI는 메인 스레드로 동작
    internal class Program
    {
         static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Console.WriteLine(mainThread.Name);

            //Thread thread1 = new Thread(()=>CountDown("Timer 1"));
            //Thread thread2 = new Thread(()=>CountUp("Timer 2"));
            //thread1.Start(); 
            //thread2.Start();

            //thread1.Join(); thread2.Join();]
             CountUpAsync("Timer 1");
             CountDownAsync("Timer 2");
            Console.WriteLine(mainThread.Name + " is comepleted");
            Console.ReadLine();
        }

        public async static Task CountUpAsync(string name)
        {
            await Task.Run(delegate () { CountUp("Timer 2"); });
        }



        public static void CountUp(string name)
        {
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is completed.");
        }


        public async static Task CountDownAsync(string name)
        {
            await Task.Run(() =>
            {
                CountDown("Timer 1");
            });
        }

        public static void CountDown(string name)
        {
            for(int i =10; i > 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is completed.");
        }

    }
}
