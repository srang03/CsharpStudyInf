using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_CalculationReview
{
    enum op
    {
        Add,
        Sub,
        Multi,
        div
    }
    public partial class Form1 : Form
    {
        op Operators;
        private long result;
        private bool _isNewNumber;
        public Form1()
        {
            InitializeComponent();
            result = 0;
            _isNewNumber = true;
            Operators = op.Add;
        }

        private void number1_Click(object sender, EventArgs e)
        {
        
            Button senderBtn = (Button)sender;
            SetNumber(senderBtn.Text);
        }

        private void SetNumber(string number)
        {
            if (_isNewNumber)
            {
                this.label1.Text = number;
                _isNewNumber = false;
                
            }
            else if (this.label1.Text == "0")
            {
                this.label1.Text = number;
            }
            else
            {
                this.label1.Text += number;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(this.label1.Text);
            Button opButton = (Button)sender;
            if (!_isNewNumber)
            {
                switch (Operators)
                {
                    case op.Add:
                        result += number;
                        break;
                    case op.Sub:
                        result -= number;
                        break;
                    case op.Multi:
                        result *= number;
                        break;
                    case op.div:
                        result = Convert.ToInt64(result / number);
                        break;
                }
            }

            switch (opButton.Text)
            {
                case "+":
                    Operators = op.Add;
                    break;
                case "-":
                    Operators = op.Sub;
                    break;
                case "*":
                    Operators = op.Multi;
                    break;
                case "/":
                    Operators = op.div;
                    break;
            }

            this.label1.Text = result.ToString();
            _isNewNumber = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            _isNewNumber = true;
            result = 0;
            Operators = op.Add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
