using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAsyncAwait
{
    public class Cooking
    {
        public string MakeRice()
        {
            Thread.Sleep(3000);
            return "밥 생성 완료";
        }

        public async Task<string> MakeRiceAsync()
        {
            await Task.Delay(3000);
            return "밥 생성 완료";
        }

        public string MakeSoup()
        {
            Thread.Sleep(2000);
            return "국 생성 완료";
        }

        public async Task<string> MakeSoupAsync()
        {
            await Task.Delay(2000);
            return "국 생성 완료";
        }

        public string MakeEgg()
        {
            Thread.Sleep(1000);
            return "계란 생성 완료";
        }

        public async Task<string> MakeEggAsync()
        {
            await Task.Delay(1000);
            return "계란 생성 완료";
        }
    }
    
}
