using System;
using System.Text;
using System.Windows.Forms;

namespace Dori10_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_select_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txb_select.Text, out int num))
            {

                if(num < 0 || num > 100)
                {
                    MessageBox.Show("올바른 숫자 범위를 입력해주세요.");
                    return;
                }
                int iCount = 0;
                int iCheckNumber = 0;
                Random random = new Random();
                do
                {
                    iCheckNumber = random.Next(1, 101);
                    iCount++;
                }while (num != iCheckNumber);

                this.lbl_selectResult.Text = $"선택하신 번호 {num}는 {iCount}번 회차에 찾았습니다";

            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            ShowNumbers(Sorting(createNumbers()));

        }

        private int[] createNumbers()
        {
            int[] numbers = new int[6];
            int iCount = 0;

            Random random = new Random();

            while (Array.IndexOf(numbers, 0) != -1)
            {
                var temp = random.Next(1, 46);

                if (Array.IndexOf(numbers, temp) == -1)
                {
                    numbers[iCount] = temp;
                    iCount++;
                }
            }
            return numbers;
        }

        private int[] Sorting(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }
        private void ShowNumbers(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0; i < numbers.Length; i++)
            {
                if(i == numbers.Length - 1)
                {
                    sb.Append(numbers[i].ToString());
                }
                else
                {
                    sb.Append(numbers[i].ToString()+ ", ");
                }
                
            }
           
            this.lbx_list.Items.Add(sb.ToString());
            this.txb_result.Text = sb.ToString();
        }
    }

}
