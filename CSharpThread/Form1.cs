using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpThread
{
    public class Restaurant
    {

        public string MakeFood()
        {
            return "밥을 짓다";
        }
    }
    public partial class Form1 : Form
    {
        ListBox lbx;
        public Form1()
        {
            InitializeComponent();
            lbx = new ListBox();
            this.Controls.Add(lbx);

            Restaurant restaurant = new Restaurant();
            lbx.Items.Add(restaurant.MakeFood());
        }
    }
}
