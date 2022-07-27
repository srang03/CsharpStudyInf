using Dori17_StreamReaderReivew;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori_17XMLReader
{
    
    public partial class Form1 : Form
    {
        XMLClass _xml = new XMLClass();

        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_setConfig_Click(object sender, EventArgs e)
        {
            var file_path = Application.StartupPath + "\\config.xml";
            _dData.Clear();
            _dData.Add(XMLClass._TEXT_DATA, this.txb_name.Text);
            _dData.Add(XMLClass._NUMBERBOX_DATA, this.nup_number.Value.ToString());
            _dData.Add(XMLClass._CBOX_DATA, this.checkbx_set.Checked.ToString());

            _xml.XMLWriter(file_path, _dData);

        }

        private void btn_getConfig_Click(object sender, EventArgs e)
        {
            var file_path = Application.StartupPath + "\\config.xml";
            _dData.Clear();
            _dData = _xml.XMLReader(file_path);

            this.txb_name.Text = _dData[XMLClass._TEXT_DATA];
            this.nup_number.Value = Convert.ToInt32(_dData[XMLClass._NUMBERBOX_DATA]);
            this.checkbx_set.Checked = bool.Parse(_dData[XMLClass._CBOX_DATA]);
        }
    }
}
