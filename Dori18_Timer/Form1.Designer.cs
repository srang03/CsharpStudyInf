namespace Dori18_Timer
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
            this.groupbx_socre = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_tickPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_add50 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.groupbx_socre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbx_socre
            // 
            this.groupbx_socre.Controls.Add(this.lbl_total);
            this.groupbx_socre.Controls.Add(this.lbl_tickPoint);
            this.groupbx_socre.Controls.Add(this.label1);
            this.groupbx_socre.Location = new System.Drawing.Point(12, 12);
            this.groupbx_socre.Name = "groupbx_socre";
            this.groupbx_socre.Size = new System.Drawing.Size(422, 159);
            this.groupbx_socre.TabIndex = 0;
            this.groupbx_socre.TabStop = false;
            this.groupbx_socre.Text = "Score";
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_total.Location = new System.Drawing.Point(6, 53);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(410, 90);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tickPoint
            // 
            this.lbl_tickPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tickPoint.Location = new System.Drawing.Point(92, 17);
            this.lbl_tickPoint.Name = "lbl_tickPoint";
            this.lbl_tickPoint.Size = new System.Drawing.Size(324, 25);
            this.lbl_tickPoint.TabIndex = 1;
            this.lbl_tickPoint.Text = "0";
            this.lbl_tickPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker Point :";
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(20, 177);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(133, 56);
            this.btn_add1.TabIndex = 1;
            this.btn_add1.Text = "+1";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add3
            // 
            this.btn_add3.Location = new System.Drawing.Point(159, 177);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(133, 56);
            this.btn_add3.TabIndex = 1;
            this.btn_add3.Text = "+3";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add50
            // 
            this.btn_add50.Location = new System.Drawing.Point(298, 177);
            this.btn_add50.Name = "btn_add50";
            this.btn_add50.Size = new System.Drawing.Size(133, 56);
            this.btn_add50.TabIndex = 1;
            this.btn_add50.Text = "+50";
            this.btn_add50.UseVisualStyleBackColor = true;
            this.btn_add50.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "5000";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(20, 276);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(89, 52);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 340);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add50);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.groupbx_socre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbx_socre.ResumeLayout(false);
            this.groupbx_socre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbx_socre;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_tickPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Button btn_add50;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Start;
    }
}

