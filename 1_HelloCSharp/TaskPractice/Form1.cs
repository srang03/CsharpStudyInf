using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Main start");
            Run();
   
            Console.WriteLine("Main End");
        }

        public void Run()
        {
            Console.WriteLine($"Thread Start" + Environment.NewLine); 
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {

                    Console.WriteLine($"{i}"); 
                }
            });

            task.Wait();

            Console.WriteLine($"End Start" + Environment.NewLine); 
        }

        public async Task RunAsync()
        {
            Console.WriteLine($"Thread Start" + Environment.NewLine);
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"{i}");
                }
            });
            Console.WriteLine($"End Start" + Environment.NewLine);
        }

        private void txb_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
