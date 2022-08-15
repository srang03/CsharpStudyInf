using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori34_LayoutEvent
{


    public partial class ucColorMenu : UserControl
    {
        // 1-1. delegate 생성
        public delegate void delColorSender(object sender, Color color);
        
        // 1-2. event 생성
        public event delColorSender OnColorSend;

        // 2. 기본 Event Handeler
        public event EventHandler OnColorEventHandler;

        // 3. Generic 형태의 delegate 사용
        public Action<Button, Color> OnColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dResult = cDialog_color.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                this.pColor.BackColor = this.cDialog_color.Color;
            }
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i=0; i<4; i++)
            {
                Button obtn = new Button();

                obtn.Name = $"btn_{i+1}";
                obtn.Text = $"p{i+1} 색상변경";
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 10, 10, 10);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                this.flowLayoutPanel1.Controls.Add(obtn);
                

            }


        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            // 1.
            // OnColorSend(sender, pColor.BackColor);

            // 2.
            // OnColorEventHandler(sender, e);

            // 3.
            OnColorAction(sender as Button, pColor.BackColor);
        }

        public string fButtonColorChange(ucPanel oPanel)
        {
            string strButtonName = string.Empty;
            switch (oPanel.Name)
            {
                case "ucPanelTop":
                    strButtonName = "btn_1";
                    break;
                case "ucPanelCetner1":
                    strButtonName = "btn_2";
                    break;
                case "ucPanelCenter2":
                    strButtonName = "btn_3";
                    break;
                case "ucPanelRight":
                    strButtonName = "btn_4";
                    break;
            }
            strButtonName = fBtnSearch(strButtonName, oPanel.BackColor, oPanel.Name);
            return strButtonName;

        }

        private string fBtnSearch(string strButtonName, Color color, string strPanelName)
        {
            string strResult = string.Empty;
            foreach(var item in this.flowLayoutPanel1.Controls)
            {
                if(item is Button)
                {
                    Button obtn = item as Button;

                    if(obtn.Name == strButtonName)
                    {
                        obtn.BackColor = color;
                        strResult =  $"[Panel] 버튼 : {obtn.Text}, 적용 : {strPanelName}, 색상 : {color.ToString()}";
                        break;
                    }
                }
            }
            return strResult;
        }
    }
}
