using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori32_AssemblyVersion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            string strAppName = Assembly.GetEntryAssembly().GetName().Name;
            this.Text = $"{strAppName} {oVersion.ToString()}";

            var result = GetBuildDateTime(oVersion);
        }

        public DateTime GetBuildDateTime(Version oVersion)
        {
            // 날짜 등록
            string strVersion = oVersion.ToString();
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refDate = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refDate.AddDays(iDays);

            // 초 등록
            int iSeconds = Convert.ToInt32(strVersion.Split('.')[3]);
            dtBuildDate.AddSeconds(iSeconds * 2);

            // 시차 조정
            

        }
    }
}
