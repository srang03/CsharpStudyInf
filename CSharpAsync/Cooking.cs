using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAsync
{
    public class Cooking
    {
       public Rice MakeRice()
        {
            Console.WriteLine("밥 생성 중...");
            Thread.Sleep(1000);
            return new Rice();
        }
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성 중...");
            await Task.Run(() => Task.Delay(1000));

            return new Rice();
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성 중...");
            Thread.Sleep(2000);
            return new Soup();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성 중...");
            await Task.Run(()=> Task.Delay(2000));
            return new Soup();

        }

        public Egg MakeEgg()
        {
            Console.WriteLine("계란 후라이 생성 중...");
            Thread.Sleep(3000);
            return new Egg();
        }
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("계란 후라이 생성 중...");
            await Task.Run(() => Task.Delay(3000));
            return new Egg();
        }
    }
}
