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

namespace CSharpAsyncEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            Console.WriteLine("시작");
            Thread.Sleep(1000);
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Thread.Sleep(1000);

            form2.ChangeLabel("Hello");

            //for(int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(i);

            //    form2.printList(i.ToString());

            //    if(i % 2 == 0)
            //    {
            //        Thread.Sleep(1000);
            //        form2.printList2(i.ToString());
            //    }
            //}
            Console.WriteLine("종료");
        }
    }
}
