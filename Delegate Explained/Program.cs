using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Explained
{
    internal class Program
    {
        delegate void MethodHerePtr();
        static void Main(string[] args)
        {
            //MethodHerePtr obj = new MethodHerePtr(MethodHere);
            //obj.Invoke();

            MyClass mc = new MyClass();
            mc.LongRunningMethod((i) => Console.WriteLine(i));
            mc.LongRunningMethod(delegate (int i) { Console.WriteLine(i); });
            mc.LongRunningMethod(callback);
        }

        static void callback(int i)
        {
            Console.WriteLine(i);
        }

        static void MethodHere()
        {
            Console.WriteLine("Method Called");
        }
    }

    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunningMethod(CallBack func)
        {
            for(int i= 0; i < 1_000; i++)
            { 
                // Doing Something here
                func(i);
            }
        }
    }
}
