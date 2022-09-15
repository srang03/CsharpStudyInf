using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait220915
{
    public partial class Form1 : Form
    {
        Task t1;
        Task t2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = ReadDeviceAsync();
            t2 = ReadInternalStorageAync();
        }

        private async Task ReadInternalStorageAync()
        {
            throw new NotImplementedException();
        }

        private async Task ReadDeviceAsync()
        {
            throw new NotImplementedException();
        }
    }
}
