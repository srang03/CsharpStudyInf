namespace Dori29_UserControl
{
    partial class UserControlP
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbx_image = new System.Windows.Forms.PictureBox();
            this.btn_catch = new System.Windows.Forms.Button();
            this.btn_warn = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(9, 9);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(11, 12);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "금액:";
            // 
            // ptbx_image
            // 
            this.ptbx_image.BackColor = System.Drawing.Color.Silver;
            this.ptbx_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbx_image.Location = new System.Drawing.Point(82, 20);
            this.ptbx_image.Name = "ptbx_image";
            this.ptbx_image.Size = new System.Drawing.Size(101, 80);
            this.ptbx_image.TabIndex = 1;
            this.ptbx_image.TabStop = false;
            // 
            // btn_catch
            // 
            this.btn_catch.Location = new System.Drawing.Point(193, 187);
            this.btn_catch.Name = "btn_catch";
            this.btn_catch.Size = new System.Drawing.Size(75, 23);
            this.btn_catch.TabIndex = 2;
            this.btn_catch.Text = "잡힘";
            this.btn_catch.UseVisualStyleBackColor = true;
            this.btn_catch.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_warn
            // 
            this.btn_warn.Location = new System.Drawing.Point(9, 187);
            this.btn_warn.Name = "btn_warn";
            this.btn_warn.Size = new System.Drawing.Size(75, 23);
            this.btn_warn.TabIndex = 2;
            this.btn_warn.Text = "수배";
            this.btn_warn.UseVisualStyleBackColor = true;
            this.btn_warn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(100, 187);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "정지";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptbx_image);
            this.panel1.Controls.Add(this.lbl_number);
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_warn);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_catch);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 213);
            this.panel1.TabIndex = 3;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(92, 147);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(38, 12);
            this.lbl_cost.TabIndex = 0;
            this.lbl_cost.Text = "label1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(92, 117);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(23, 12);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "000";
            // 
            // UserControlP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlP";
            this.Size = new System.Drawing.Size(290, 233);
            this.Load += new System.EventHandler(this.UserControlP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbx_image;
        private System.Windows.Forms.Button btn_catch;
        private System.Windows.Forms.Button btn_warn;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_name;
    }
}
