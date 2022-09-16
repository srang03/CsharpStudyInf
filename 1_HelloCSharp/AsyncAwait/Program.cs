using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static async void Main()
        {
            await DoAsync();
        }

        static async Task DoAsync()
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync("https://www.naver.com");
                var content = await res.Content.ReadAsStringAsync();

                Console.WriteLine(content);
            }
        }
    }

}
