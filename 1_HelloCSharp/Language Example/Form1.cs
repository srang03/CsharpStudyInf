using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Example
{
    public partial class Form1 : Form
    {
        StartView _startView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindView();
        }

        private void BindView()
        {
            _startView = new StartView();
            this.panel1.Controls.Add(_startView);
            _startView.Dock= DockStyle.Fill;
        }
    }
}
