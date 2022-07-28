using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Dori19_Encryption
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        string strPath = Application.StartupPath + "\\Setting.txt";

        uint iTotal=0;
        uint iTick=0;

        uint add1=1;
        uint add1_level=1;

        uint add3=0;
        uint add3_level=0;

        uint add50=0;
        uint add50_level=0;

        private void Init()
        {

            iTotal = 0;
            iTick = 0;

            add1 = 1;
            add1_level = 1;

            add3 = 0;
            add3_level = 0;

            add50 = 0;
            add50_level = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XMLData xdata = new XMLData();
            if (File.Exists(strPath))
            {
                _dData = xdata.XML_Reader(strPath);

                iTick = uint.Parse(_dData[XMLData._TICK]);
                iTotal = uint.Parse(_dData[XMLData._TOTAL]);
                add1_level = uint.Parse(_dData[XMLData._LEVEL_1]);
                add3_level = uint.Parse(_dData[XMLData._LEVEL_3]);
                add50_level = uint.Parse(_dData[XMLData._LEVEL_50]);

                add1 = add1_level * 1;
                add3 = add3_level * 3;
                add50 = add50_level * 50;
            }
            Timer timer = new Timer();

            timer.Enabled = true;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            XMLData xdata = new XMLData();
            _dData.Clear();

            _dData.Add(XMLData._TICK, iTick.ToString());
            _dData.Add(XMLData._TOTAL, iTotal.ToString());
            _dData.Add(XMLData._LEVEL_1, add1_level.ToString());
            _dData.Add(XMLData._LEVEL_3, add3_level.ToString());
            _dData.Add(XMLData._LEVEL_50, add50_level.ToString());

            xdata.XML_Writer(strPath, _dData);
        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
            iTick = add1 + add3 + add50;
            iTotal += iTick;

            this.lbl_tickPoint.Text = $"{iTick} (1:{add1_level}) (3:{add3_level}) (50:{add50_level}) ";
            this.lbl_total.Text = iTotal.ToString();
        }
         
        private void btn_add_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btn_add1":
                    if (iTotal > 100)
                    {
                        add1_level += 1;
                        add1 = 1 * add1_level;
                        iTotal -= 100;
                    }
                    break;
                case "btn_add3":
                    if (iTotal > 500)
                    {
                        add3_level += 1;
                        add3 = 3 * add3_level;
                        iTotal -= 500;
                    }
                    break;
                case "btn_add50":
                    if (iTotal > 5000)
                    {
                        add50_level += 1;
                        add50 = 50 * add50_level;
                        iTotal -= 5000;
                    }
                    break;
                case "btn_reset":         
                        Init();
                        break;
                    
                default:

                    break;
            }
        }
    }
}
