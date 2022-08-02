using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Delegate
{
    public partial class Form1 : Form
    {
        delegate int CalcPtr (int a, int b);
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            CalcPtr ptr1 = new CalcPtr(add); // 함수 포인터에 담기
            CalcPtr ptr2 = new CalcPtr(substract); // 함수 포인터에 담기
            
            CalcPtr ptr3 = ptr1; // 함수 포인터에 담기
            ptr3 += ptr2;


            // result = ptr3(10, 20);
            // Console.WriteLine($"Result : {result}");

            ptr3 -= ptr1;
            result = ptr3(10, 20);

          
            Console.WriteLine($"Result : {result}");

        }


        private int add(int a, int b)
        {
            Console.WriteLine("add");
            return a + b;
        }

        private int substract(int a, int b)
        {
            Console.WriteLine("substract");
            return a - b;
        }
    }
}
