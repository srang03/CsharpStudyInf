using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dori21_ListStruct
{
    public partial class Form1 : Form
    {
        List<Menu> menus;
        int [] menuCount;
        int totalPrice;

        public Form1()
        {
            InitializeComponent();
            totalPrice= 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            menus = new List<Menu>();
            menuCount = new int[4];
        }

        private void ShowDataBind()
        {
            int total = 0;
            this.lbl_menu1_count.Text = menuCount[0].ToString();
            this.lbl_menu2_count.Text = menuCount[1].ToString();
            this.lbl_menu3_count.Text = menuCount[2].ToString();
            this.lbl_menu4_count.Text = menuCount[3].ToString();

            this.lbl_total_price.Text = totalPrice.ToString();
            for(int i = 0; i < menuCount.Length; i++)
            {
                total += menuCount[i];
            }

            this.txt_total.Text = total.ToString();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = menus.Select(x => new { Id = x.Id, Name = x.Name, Price = x.Price }).ToList();
            this.dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            int id = menus.Count > 0 ? menus.Max(x => x.Id) + 1 : 1;
            Menu menu = new Menu()
            {
                Id = id,
                Name = button.Text,
            };
            switch (button.Name)
            {
                case "lbl_menu1":
                    menu.Price = 2000;
                    menuCount[0] += 1;
                    totalPrice += 2000;
                    break;
                case "lbl_menu2":
                    menu.Price = 5000;
                    menuCount[1] += 1;
                    totalPrice += 5000;
                    break;
                case "lbl_menu3":
                    menu.Price = 8000;
                    menuCount[2] += 1;
                    totalPrice += 8000;
                    break;
                case "lbl_menu4":
                    menu.Price = 10000;
                    menuCount[3] += 1;
                    totalPrice += 10000;
                    break;
                default:
                    return;
            }
            menus.Add(menu);
            ShowDataBind();
        }
    }
}
