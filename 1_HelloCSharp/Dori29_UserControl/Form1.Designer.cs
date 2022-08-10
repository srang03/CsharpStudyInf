namespace Dori29_UserControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlP3 = new Dori29_UserControl.UserControlP();
            this.userControlP2 = new Dori29_UserControl.UserControlP();
            this.userControlP1 = new Dori29_UserControl.UserControlP();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.userControlP3);
            this.panel1.Controls.Add(this.userControlP2);
            this.panel1.Controls.Add(this.userControlP1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 247);
            this.panel1.TabIndex = 1;
            // 
            // userControlP3
            // 
            this.userControlP3.Location = new System.Drawing.Point(602, 3);
            this.userControlP3.Name = "userControlP3";
            this.userControlP3.Size = new System.Drawing.Size(290, 233);
            this.userControlP3.TabIndex = 0;
            this.userControlP3.UserCost = "1500";
            this.userControlP3.UserFace = global::Dori29_UserControl.Properties.Resources._984127_avatar_male_man_user_person_icon;
            this.userControlP3.UserName = "강";
            this.userControlP3.UserNo = "3";
            // 
            // userControlP2
            // 
            this.userControlP2.Location = new System.Drawing.Point(306, 3);
            this.userControlP2.Name = "userControlP2";
            this.userControlP2.Size = new System.Drawing.Size(290, 233);
            this.userControlP2.TabIndex = 0;
            this.userControlP2.UserCost = "3000";
            this.userControlP2.UserFace = global::Dori29_UserControl.Properties.Resources._984119_avatar_male_man_person_user_icon;
            this.userControlP2.UserName = "한";
            this.userControlP2.UserNo = "2";
            // 
            // userControlP1
            // 
            this.userControlP1.Location = new System.Drawing.Point(10, 3);
            this.userControlP1.Name = "userControlP1";
            this.userControlP1.Size = new System.Drawing.Size(290, 233);
            this.userControlP1.TabIndex = 0;
            this.userControlP1.UserCost = "2000";
            this.userControlP1.UserFace = global::Dori29_UserControl.Properties.Resources._984113_avatar_casual_female_girl_person_icon;
            this.userControlP1.UserName = "홍";
            this.userControlP1.UserNo = "1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(2, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(889, 112);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 373);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private int UserControlP1_eventIntObjStr(object sender, string strText)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ListBox listBox1;
        private UserControlP userControlP1;
        private UserControlP userControlP3;
        private UserControlP userControlP2;
    }
}

