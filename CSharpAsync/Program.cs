using System;
using System.Threading.Tasks;

namespace CSharpAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("[1] 동기, [2] 비동기");
            var str = Console.ReadLine();
            Cooking cook = new Cooking();
            switch (str)
            {
                case "1":
                    {
                        Cook(cook);
                    }
                    break;

                case "2":
                    {
                        await CookAsync(cook);
                    }
                    break;

                default:
                    break;
            }
        }
        static void Cook(Cooking cook)
        {
            DateTime dateTime = DateTime.Now;
            cook.MakeRice();
            cook.MakeSoup();
            cook.MakeEgg();
            Console.WriteLine($"소요시간: {(DateTime.Now - dateTime).TotalSeconds}");
        }
        static async Task CookAsync(Cooking cook) 
        {
            DateTime dateTime = DateTime.Now;
            await cook.MakeRiceAsync();
            await cook.MakeSoupAsync();
            await cook.MakeEggAsync();
            Console.WriteLine($"소요시간: {(DateTime.Now - dateTime).TotalSeconds}");
        }
        
    }
}
