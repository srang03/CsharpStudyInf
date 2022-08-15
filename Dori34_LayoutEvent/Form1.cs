using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori34_LayoutEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1.
            // this.ucCMenu.OnColorSend += UcCMenu_OnColorSend;

            // 2.
            // this.ucCMenu.OnColorEventHandler += UcCMenu_OnColorEventHandler;

            // 3.
            this.ucCMenu.OnColorAction += UcCMenu_OnColorSend;
            this.ucPanelTop.eLabelDoubleClickHandler += ucLabel_DoubleClickHandler;
            this.ucPanelCenter2.eLabelDoubleClickHandler += ucLabel_DoubleClickHandler;
            this.ucPanelCetner1.eLabelDoubleClickHandler += ucLabel_DoubleClickHandler;
            this.ucPanelRight.eLabelDoubleClickHandler += ucLabel_DoubleClickHandler;
        }

        private void ucLabel_DoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucCMenu.fButtonColorChange(sender as ucPanel);
            this.listBox1.Items.Add(strResult);
        }

        //private void UcCMenu_OnColorEventHandler(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void UcCMenu_OnColorSend(Button sender, Color color)
        {
            string strPanelName = string.Empty;
            string strName = sender.Name;

            switch (strName)
            {
                case "btn_1":
                    this.ucPanelTop.BackColor = color;
                    strPanelName = this.ucPanelTop.Name;
                    break;
                case "btn_2":
                    this.ucPanelCetner1.BackColor = color;
                    strPanelName = this.ucPanelCetner1.Name;
                    break;
                case "btn_3":
                    this.ucPanelCenter2.BackColor = color;
                    strPanelName = this.ucPanelCenter2.Name;
                    break;
                case "btn_4":
                    this.ucPanelRight.BackColor = color;
                    strPanelName = this.ucPanelRight.Name;
                    break;
            }

            string strResult = $"버튼 : {sender.Text}, 적용 : {strPanelName}, 색상 : {color.ToString()}";
            this.listBox1.Items.Add(strResult);
            

        }
    }
}
