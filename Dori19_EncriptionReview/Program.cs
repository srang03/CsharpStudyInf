using System;
using System.Text;

namespace Dori19_EncriptionReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC";
            var res = Func_Encoding(str, Encoding.UTF8);
            Console.WriteLine(res);
            res = Func_Decoding(res, Encoding.UTF8);
            Console.WriteLine(res);
        }


        static string Func_Encoding(string PlainText, Encoding type)
        {
            byte[] bytes = type.GetBytes(PlainText);
            string base64 = Convert.ToBase64String(bytes);

            return base64;
        }

        static string Func_Decoding(string base64, Encoding type)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            string plain = type.GetString(bytes);

            return plain;
        }
    }
}
