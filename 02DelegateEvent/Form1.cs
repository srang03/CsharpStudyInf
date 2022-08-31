using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02DelegateEvent
{
    public partial class Form1 : Form
    {
        delegate int delFuncCalculate(int a, int b);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult;
            delFuncCalculate FuncCalculate1 = new delFuncCalculate(add);
            delFuncCalculate FuncCalculate2 = new delFuncCalculate(minus);

            delFuncCalculate FuncCalculate3 = FuncCalculate1;
            FuncCalculate3 += FuncCalculate2;
            iResult = FuncCalculate3(30, 20);
            Console.WriteLine(iResult);
        }

        private int add (int a, int b) 
        {
            Console.WriteLine("add");
            return a + b;
        }

        private int minus(int a, int b)
        {
            Console.WriteLine("minus");
            return a - b;
        }
    }
}
