using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait220916
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인 함수 실행");
            Task.Run(() =>
            {
                Run();
            });
            Console.WriteLine("메인 함수 종료");
            Console.ReadKey();
        }
        public async static Task DoAsync()
        {
            using(var client = new HttpClient())
            {
                var res = await client.GetAsync("https://www.naver.com");
                var content = await res.Content.ReadAsStringAsync();


                Console.WriteLine(content.Length);
            }
        }

        public async static Task DoLoop()
        {
            for(int i=0; i<5; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine(i);
            }
        }


        public async static void Run()
        {
            await DoAsync();
            await DoLoop();
        }
    }
}
