using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori28_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // FormatException 발생
                if(int.TryParse(this.textBox1.Text, out int iNum))
                {
                    this.label1.Text = iNum.ToString();
                }
                else
                {
                    this.label1.Text = "DataFrom이 맞지 않습니다";
                }

                // ArgumentOutOfRangeException 발생
                List<string> ListStr = new List<string>();
                ListStr.Add("Test");
                
                
                for(int i = 0; i<2; i++)
                {
                    var strTest = ListStr[i];
                }

                // NullReference Exception 발생
                List<object> ListObj = null;
                var a = ListObj[0];

                // InvalidCastException 발생
                object oTest = "ff123";
                int iTest2 = (int)oTest;

                // 예외처리 방지 방법
                if (oTest is int)
                {
                    int iTest3 = (int)oTest;
                }
            }
            catch(FormatException ex)
            {
                this.label1.Text = ex.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                this.label1.Text = ex.ToString();
            }
            catch (NullReferenceException ex)
            {
                this.label1.Text = ex.ToString();
            }
            catch (InvalidCastException ex)
            {
                this.label1.Text = ex.ToString();
            }

            finally
            {

            }
        }
    }
}
