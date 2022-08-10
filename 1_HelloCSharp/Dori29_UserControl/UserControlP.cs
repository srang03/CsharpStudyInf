using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori29_UserControl
{
    public partial class UserControlP : UserControl
    {
        public delegate int delIntObj(object sender, string strText);
        public event delIntObj eventIntObjStr;

        [Category("UserProperty"), Description("image")]
        public Image UserFace
        {
            get
            {
                return this.ptbx_image.BackgroundImage;
            }
            set
            {
                this.ptbx_image.BackgroundImage = value;
            }
        }
        [Category("UserProperty"), Description("no")]
        public string UserNo
        {
            get
            {
                return this.lbl_number.Text;
            }
            set
            {
                this.lbl_number.Text = value;
            }

        }

        [Category("UserProperty"), Description("Name")]
        public string UserName
        {
            get
            {
                return this.lbl_name.Text;
            }
            set
            {
                this.lbl_name.Text = value;
            }
        }

        [Category("UserProperty"), Description("Cost")]
        public string UserCost
        {
            get
            {
                return this.lbl_cost.Text;
            }
            set
            {
                this.lbl_cost.Text = value;
            }
        }


        public UserControlP()
        {
            InitializeComponent();
        }

        private void UserControlP_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string str_message = $"이름: {this.Name} [{this.UserCost}]";
            switch (btn.Name)
            {
                case "btn_warn":
                    this.BackColor = Color.Orange;
                    str_message += " 수배 중입니다.";
                    break;
                case "btn_pause":
                    this.BackColor = Color.Blue ;
                    str_message += " 수배 중지입니다.";
                    break;
                case "btn_catch":
                    this.BackColor = Color.Green;
                    str_message += " 잡혔습니다.";
                    break;
                default:
                    break;
            }
            if(eventIntObjStr != null)
            {
                eventIntObjStr(this, str_message);
            }
        }

    }
}
