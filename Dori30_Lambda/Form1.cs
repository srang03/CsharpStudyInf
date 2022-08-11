using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori30_Lambda
{

    public partial class Form1 : Form
    {
        Action _stepCheck;
        private int _iNowStep;
        enum enumLambda
        {
            식형식_람다식 = 0,
            문형식_람다식 = 1,
            제너릭_형태의_무명메서드_Func = 2,
            제너릭_형태의_무명메서드_Action = 3,
            제너릭_형태의_인자_반환_예제 = 4,
        }

        public Form1()
        {
            _iNowStep = 0;
            InitializeComponent();
            _stepCheck = () => lbl_step.Text = _iNowStep.ToString();
            
        }

        private void btn_callEvent_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonColorChange();

        }

        public delegate int delIntFunc(int a, int b);
        public delegate string delStringFunc();

       
        private void AddItems(string str)
        {
            this.listBox1.Items.Add(str);
        }

        private void LambaExpression(int iCase)
        {
            _stepCheck();
            switch (iCase)
            {
                case (int)enumLambda.식형식_람다식:
                    // 식형식 람다식
                    {
                        delIntFunc dint = (a, b) => a + b;
                        int iResult = dint(4, 5);
                        AddItems(iResult.ToString());

                        delStringFunc dString = () => "식형식 람다식";
                        string strResult = dString();
                        AddItems(strResult.ToString());
                        break;
                    }

                case (int)enumLambda.문형식_람다식:
                    {
                        delIntFunc dint = (a, b) =>
                        {
                            var result = a * b;
                            return result *= 2;
                        };
                        var intResult = dint(1, 3);
                        AddItems(intResult.ToString());

                        delStringFunc dString = () =>
                        {
                            return "문장형 람다식";
                        };
                  
                        string strResult = dString();
                        AddItems(strResult);

                        break;
                    }
                case (int)enumLambda.제너릭_형태의_무명메서드_Func:
                    {
                        Func<int, int, int> FuncInt = (a, b) => a + b;
                        var intResult = FuncInt(1, 3);
                        AddItems(intResult.ToString());
                    }
                    break;

                case (int)enumLambda.제너릭_형태의_무명메서드_Action:
                    {
                        Action<string, string> ActionString = (str1, str2) =>
                        {
                            AddItems(str1 + str2);
                        };
                        ActionString("하이", "반가워요");
                    }
                        break;
                case (int)enumLambda.제너릭_형태의_인자_반환_예제:
                    {
                        int[] iArray = { 1, 3, 5, 7, 9 };
                        int iCount = iArray.Sum(x => x*x);
                        AddItems(iCount.ToString());

                        string[] strArray = { "XXXX", "YY", "ZZZZ" };
                        int lengthSum = strArray.Sum(str => str.Length);
                        AddItems(lengthSum.ToString());
                    }


                    break;
                default:
                    break;
            }
        }

        private void ButtonColorChange()
        {
            // Event 함수에서 색상 변경
            this.btn_callEvent.Click += Btn_callEvent_Click;

            // 무명(익명)메서드
            this.btn_callAnonymous.Click += delegate (object sender, EventArgs e)
            {
                this.btn_callAnonymous.BackColor = Color.Orange;
            };

            // 람다식
            this.btn_callLambda.Click += (sender, e) =>
            {
                this.btn_callLambda.BackColor = Color.BlueViolet;
            };
        }

        // Event 등록
        private void Btn_callEvent_Click(object sender, EventArgs e)
        {
            this.btn_callEvent.BackColor = Color.Aqua;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            LambaExpression(_iNowStep);
            if(_iNowStep > 3)
            {
                _iNowStep = 0;
            }
            else
            {
                _iNowStep += 1;
            }
            
        }
    }
}
