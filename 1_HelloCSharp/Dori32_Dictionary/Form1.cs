using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using Dori32_AssemblyVersion;

namespace Dori32_Dictionary
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.Dictionary<string, Stack<CSize>> oDic = new System.Collections.Generic.Dictionary<string, Stack<CSize>>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ReadControlSize();
            PrintContorls();
        }
        private void PrintContorls()
        {
            Stack<CSize> sButton = oDic["Button"];
            Stack<CSize> sLabel = oDic["Label"];

            foreach(var item in sButton)
            {
                this.listBox1.Items.Add($"{item.Name} {item.Width}, {item.Height}");
            }
            foreach (var item in sLabel)
            {
                this.listBox1.Items.Add($"{item.Name} {item.Width}, {item.Height}");
            }
            
        }
        private void ReadControlSize()
        {
            oDic.Clear();

            // 버튼 등록
            Stack<CSize> sButton = new Stack<CSize>();
            Stack<CSize> sLabel = new Stack<CSize>();

            foreach (var item in this.groupBox1.Controls)
            {
                if(item is Button)
                {
                    Button oBtn = item as Button;

                    CSize osize = new CSize();
                    osize.Name = oBtn.Name;
                    osize.Width = oBtn.Width;
                    osize.Height = oBtn.Height;

                    sButton.Push(osize);
                }


                else if(item is Label)
                {
                    Label oLabel = item as Label;

                    CSize osize = new CSize();
                    osize.Name = oLabel.Name;
                    osize.Width = oLabel.Width;
                    osize.Height = oLabel.Height;

                    sLabel.Push(osize);
                     
                }
            }
            oDic.Add("Button", sButton);
            oDic.Add("Label", sLabel);
        }
    }
}
