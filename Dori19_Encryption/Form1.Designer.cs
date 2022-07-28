namespace Dori19_Encryption
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tickPoint = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_add50 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(38, 12);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tick Point:";
            // 
            // lbl_tickPoint
            // 
            this.lbl_tickPoint.BackColor = System.Drawing.Color.White;
            this.lbl_tickPoint.Location = new System.Drawing.Point(83, 30);
            this.lbl_tickPoint.Name = "lbl_tickPoint";
            this.lbl_tickPoint.Size = new System.Drawing.Size(261, 28);
            this.lbl_tickPoint.TabIndex = 0;
            this.lbl_tickPoint.Text = "0";
            this.lbl_tickPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_total.Location = new System.Drawing.Point(12, 77);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(332, 106);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(14, 201);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(106, 47);
            this.btn_add1.TabIndex = 1;
            this.btn_add1.Text = "+1";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add3
            // 
            this.btn_add3.Location = new System.Drawing.Point(126, 201);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(106, 47);
            this.btn_add3.TabIndex = 1;
            this.btn_add3.Text = "+3";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add50
            // 
            this.btn_add50.Location = new System.Drawing.Point(238, 201);
            this.btn_add50.Name = "btn_add50";
            this.btn_add50.Size = new System.Drawing.Size(106, 47);
            this.btn_add50.TabIndex = 1;
            this.btn_add50.Text = "+50";
            this.btn_add50.UseVisualStyleBackColor = true;
            this.btn_add50.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "5000";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.IndianRed;
            this.btn_reset.Location = new System.Drawing.Point(14, 280);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(106, 45);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 337);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add50);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_tickPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += Form1_FormClosed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tickPoint;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Button btn_add50;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_reset;
    }
}

