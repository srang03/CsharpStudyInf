using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deviceId = "D324DFS";
            string tmp = "{0: yyyy년MM월dd일}" + deviceId;
            Console.WriteLine(string.Format(tmp, DateTime.Now));
            
            double temp = ((double)7 / 96 * 100);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
