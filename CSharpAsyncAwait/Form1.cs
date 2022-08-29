using CSharpAsync;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_cooking_Click(object sender, EventArgs e)
        {
            AddToList("Start");
            if (this.isAsync.Checked)
            {
                await CookBreakfastAsync();
            }
            else
            {
                CookBreakfast();
            }
            AddToList("End");
        }

        private void CookBreakfast()
        {
            Cooking cooking = new Cooking();

            AddToList(cooking.MakeRice());
            AddToList(cooking.MakeSoup());
            AddToList(cooking.MakeEgg());
        }


        private async Task CookBreakfastAsync()
        {
         
            Cooking cooking = new Cooking();

            AddToList(await cooking.MakeRiceAsync());
            AddToList(await cooking.MakeSoupAsync());
            AddToList(await cooking.MakeEggAsync());
          
        }


        private void AddToList(string str)
        {
            this.listBox1.Items.Add(str);
        }

        private void btn_watching_Click(object sender, EventArgs e)
        {
            AddToList("TV 시청 중 ...");
        }
    }
}
