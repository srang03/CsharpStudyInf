using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dori16_StreamReaderReivew
{
    public partial class Form1 : Form
    {
        private ConfigData _data;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();


        }

        private void GetData()
        {
            string file_path = Application.StartupPath + "\\config.json";
            var json = File.ReadAllText(file_path);
            _data = JsonConvert.DeserializeObject<ConfigData>(json);

            
            foreach (var d in _data.GetConfigData())
            {
                this.txb_result.Text += d + Environment.NewLine;
            }
            this.txb_name.Text = _data.ConfigName;
            this.txb_path.Text = _data.ConfigPath;
            this.txb_directory.Text = String.Join(",", _data.Directory);
            this.checkbx_validation.Checked = _data.Set;


        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            string name = this.txb_name.Text;
            string path = this.txb_path.Text;
            var directory = this.txb_directory.Text.Split(',').ToList<string>();
            bool set = this.checkbx_validation.Checked;
            string date = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            _data = new ConfigData(name, path, directory, date, set);

            var json = JsonConvert.SerializeObject(_data, Formatting.Indented);

            string file_path = Application.StartupPath + "\\config.json";
            File.WriteAllText(file_path, json);
        }
    }
}
