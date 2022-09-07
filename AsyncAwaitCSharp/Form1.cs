using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_async_Click(object sender, EventArgs e)
        {
            await DoAsync();
        }

        private void DoSync()
        {

        }
        private static  void DoAsyncMethod()
        {
            Console.WriteLine("버튼 클릭 함수 시작");
            PrintNumberAsync();
            Console.WriteLine("버튼 클릭 함수 종료");
        }
        private async Task DoAsync()
        {
            Console.WriteLine("버튼 클릭 함수 시작");
            //using (var client = new HttpClient())
            //{
            //    var response = await client.GetStringAsync("https://www.naver.com");
            //    Console.WriteLine(response.Length);
            //}

            Task t1 = PrintNumberAsync();
            Task t2 = PrintNumberAsync();

            await Task.WhenAll(t1, t2);
            Console.WriteLine("버튼 클릭 함수 종료");
        }

        private static async Task PrintNumberAsync()
        {
            Task task;
            task = new Task(delegate ()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Number: {i + 1}");
                    Thread.Sleep(1000);
                }
            });
          
            task.Start();
            await task;
            Console.WriteLine("PrintNumberAsync 함수 종료");
        }

        private void btn_sync_Click(object sender, EventArgs e)
        {
            DoAsyncMethod();
        }
    }
}
