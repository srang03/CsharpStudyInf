namespace Dori11_Struct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_sun = new System.Windows.Forms.PictureBox();
            this.pbx_moon = new System.Windows.Forms.PictureBox();
            this.pbx_star = new System.Windows.Forms.PictureBox();
            this.pbx_none = new System.Windows.Forms.PictureBox();
            this.rbtn_player1 = new System.Windows.Forms.RadioButton();
            this.rbtn_player2 = new System.Windows.Forms.RadioButton();
            this.lbx_result1 = new System.Windows.Forms.ListBox();
            this.lbx_result2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_none)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player는 한번 씩 돌아가면서 그림을 선택합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "각 5회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리한다.";
            // 
            // pbx_sun
            // 
            this.pbx_sun.Image = ((System.Drawing.Image)(resources.GetObject("pbx_sun.Image")));
            this.pbx_sun.Location = new System.Drawing.Point(14, 70);
            this.pbx_sun.Name = "pbx_sun";
            this.pbx_sun.Size = new System.Drawing.Size(156, 181);
            this.pbx_sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_sun.TabIndex = 1;
            this.pbx_sun.TabStop = false;
            this.pbx_sun.Click += new System.EventHandler(this.pbx_sun_Click);
            // 
            // pbx_moon
            // 
            this.pbx_moon.Image = ((System.Drawing.Image)(resources.GetObject("pbx_moon.Image")));
            this.pbx_moon.Location = new System.Drawing.Point(176, 70);
            this.pbx_moon.Name = "pbx_moon";
            this.pbx_moon.Size = new System.Drawing.Size(156, 181);
            this.pbx_moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_moon.TabIndex = 1;
            this.pbx_moon.TabStop = false;
            this.pbx_moon.Click += new System.EventHandler(this.pbx_moon_Click);
            // 
            // pbx_star
            // 
            this.pbx_star.Image = ((System.Drawing.Image)(resources.GetObject("pbx_star.Image")));
            this.pbx_star.Location = new System.Drawing.Point(338, 70);
            this.pbx_star.Name = "pbx_star";
            this.pbx_star.Size = new System.Drawing.Size(156, 181);
            this.pbx_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_star.TabIndex = 1;
            this.pbx_star.TabStop = false;
            this.pbx_star.Click += new System.EventHandler(this.pbx_star_Click);
            // 
            // pbx_none
            // 
            this.pbx_none.BackColor = System.Drawing.Color.DarkGray;
            this.pbx_none.Location = new System.Drawing.Point(500, 70);
            this.pbx_none.Name = "pbx_none";
            this.pbx_none.Size = new System.Drawing.Size(156, 181);
            this.pbx_none.TabIndex = 1;
            this.pbx_none.TabStop = false;
            this.pbx_none.Click += new System.EventHandler(this.pbx_none_Click);
            // 
            // rbtn_player1
            // 
            this.rbtn_player1.AutoSize = true;
            this.rbtn_player1.Checked = true;
            this.rbtn_player1.Location = new System.Drawing.Point(14, 277);
            this.rbtn_player1.Name = "rbtn_player1";
            this.rbtn_player1.Size = new System.Drawing.Size(65, 16);
            this.rbtn_player1.TabIndex = 2;
            this.rbtn_player1.TabStop = true;
            this.rbtn_player1.Text = "Player1";
            this.rbtn_player1.UseVisualStyleBackColor = true;
            // 
            // rbtn_player2
            // 
            this.rbtn_player2.AutoSize = true;
            this.rbtn_player2.Location = new System.Drawing.Point(338, 277);
            this.rbtn_player2.Name = "rbtn_player2";
            this.rbtn_player2.Size = new System.Drawing.Size(65, 16);
            this.rbtn_player2.TabIndex = 2;
            this.rbtn_player2.Text = "Player2";
            this.rbtn_player2.UseVisualStyleBackColor = true;
            // 
            // lbx_result1
            // 
            this.lbx_result1.FormattingEnabled = true;
            this.lbx_result1.ItemHeight = 12;
            this.lbx_result1.Location = new System.Drawing.Point(14, 318);
            this.lbx_result1.Name = "lbx_result1";
            this.lbx_result1.Size = new System.Drawing.Size(318, 124);
            this.lbx_result1.TabIndex = 3;
            // 
            // lbx_result2
            // 
            this.lbx_result2.FormattingEnabled = true;
            this.lbx_result2.ItemHeight = 12;
            this.lbx_result2.Location = new System.Drawing.Point(338, 318);
            this.lbx_result2.Name = "lbx_result2";
            this.lbx_result2.Size = new System.Drawing.Size(318, 124);
            this.lbx_result2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 448);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(641, 124);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 589);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbx_result2);
            this.Controls.Add(this.lbx_result1);
            this.Controls.Add(this.rbtn_player2);
            this.Controls.Add(this.rbtn_player1);
            this.Controls.Add(this.pbx_none);
            this.Controls.Add(this.pbx_star);
            this.Controls.Add(this.pbx_moon);
            this.Controls.Add(this.pbx_sun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_none)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_sun;
        private System.Windows.Forms.PictureBox pbx_moon;
        private System.Windows.Forms.PictureBox pbx_star;
        private System.Windows.Forms.PictureBox pbx_none;
        private System.Windows.Forms.RadioButton rbtn_player1;
        private System.Windows.Forms.RadioButton rbtn_player2;
        private System.Windows.Forms.ListBox lbx_result1;
        private System.Windows.Forms.ListBox lbx_result2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

