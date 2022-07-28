using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dori20_StackQueue
{
    public partial class Form1 : Form
    {
        Queue<int> _queue;
        Stack<int> _stack;
        public Form1()
        {
            _queue = new Queue<int>(10);
            _stack = new Stack<int>(10);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            InputData();
        }

        private void InputData()
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101);

            // [1] Queue 데이터 입력
            if (_queue.Count < 10)
            {
                _queue.Enqueue(iData);
                fQueueDataDisplay();
            }
            // Stack에 데이터 입력

            if (_stack.Count < 10)
            {
                _stack.Push(iData);
                fStackDataDisplay();
            }
        }

        private void OutputData()
        {
            if (_queue.Count > 0)
            {
                _queue.Dequeue();
                fQueueDataDisplay();
            }

            if (_stack.Count > 0)
            {
                _stack.Pop();
                fStackDataDisplay();
            }
        }


        private void fQueueDataDisplay()
        {
            int[] iArray = _queue.ToArray();
            Array.Resize(ref iArray, 10);

            this.lbl_queue1.Text = iArray[0].ToString();
            this.lbl_queue2.Text = iArray[1].ToString();
            this.lbl_queue3.Text = iArray[2].ToString();
            this.lbl_queue4.Text = iArray[3].ToString();
            this.lbl_queue5.Text = iArray[4].ToString();
            this.lbl_queue6.Text = iArray[5].ToString();
            this.lbl_queue7.Text = iArray[6].ToString();
            this.lbl_queue8.Text = iArray[7].ToString();
            this.lbl_queue9.Text = iArray[8].ToString();
            this.lbl_queue10.Text = iArray[9].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _stack.ToArray();
            Array.Resize(ref iArray, 10);

            this.lbl_stack1.Text = iArray[0].ToString();
            this.lbl_stack2.Text = iArray[1].ToString();
            this.lbl_stack3.Text = iArray[2].ToString();
            this.lbl_stack4.Text = iArray[3].ToString();
            this.lbl_stack5.Text = iArray[4].ToString();
            this.lbl_stack6.Text = iArray[5].ToString();
            this.lbl_stack7.Text = iArray[6].ToString();
            this.lbl_stack8.Text = iArray[7].ToString();
            this.lbl_stack9.Text = iArray[8].ToString();
            this.lbl_stack10.Text = iArray[9].ToString();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutputData();
        }

        private void btn_autoOut_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            OutputData();
        }
    }
}
