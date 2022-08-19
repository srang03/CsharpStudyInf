using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori39_User32.dll
{
    
    public struct keyboardHookStruct
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtrainfo;
    }

    public partial class Form1 : Form
    {
        GlobalKeyBoard kbhook = new GlobalKeyBoard();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kbhook.hook();     
            kbhook.KeyUp += Kbhook_KeyUp;
            kbhook.KeyDown += Kbhook_KeyDown;
        }

        private void Kbhook_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
                this.lbx_Test.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
            
        }

        private void Kbhook_KeyUp(object d, KeyEventArgs e)
        {
            //Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, this.lbx_Test.SelectedItem.ToString());
        }

        private void lbx_Test_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbx_Test.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lbx_Test.SelectedItem.ToString());
            }
        }
    }
}
