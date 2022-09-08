using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyWayToUnderstandAsyncMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Task.Run(() =>
            {
                Metthod();
            });
            Console.WriteLine("End");
            Console.ReadLine();

        }
        public static async void Metthod()
        {
            var result = await CookEggsAsync();
            CookBaconsAsync();
            ToastBreadAsync();  
        }

        public static void CookEggs()
        {
            Thread.Sleep(2000);
            Console.WriteLine("eggs cooked");
        }

        public static void CookBacons()
        {
            Thread.Sleep(2000);
            Console.WriteLine("bacons cooked");
        }

        public async static Task<bool> CookEggsAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("eggs cooked");
            });
            return true;
        }

        public async static void CookBaconsAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("bacons cooked");
            }); 
        }

        public async static void ToastBreadAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("ToastBread cooked");
            });
        }
    }
}
