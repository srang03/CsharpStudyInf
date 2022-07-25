namespace Dori13_Inheritance
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_step1 = new System.Windows.Forms.Button();
            this.btn_step2 = new System.Windows.Forms.Button();
            this.btn_step3 = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 301);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_step1
            // 
            this.btn_step1.Location = new System.Drawing.Point(175, 327);
            this.btn_step1.Name = "btn_step1";
            this.btn_step1.Size = new System.Drawing.Size(176, 35);
            this.btn_step1.TabIndex = 2;
            this.btn_step1.Text = "1단계";
            this.btn_step1.UseVisualStyleBackColor = true;
            this.btn_step1.Click += new System.EventHandler(this.btn_step1_Click);
            // 
            // btn_step2
            // 
            this.btn_step2.Location = new System.Drawing.Point(357, 327);
            this.btn_step2.Name = "btn_step2";
            this.btn_step2.Size = new System.Drawing.Size(176, 35);
            this.btn_step2.TabIndex = 2;
            this.btn_step2.Text = "2단계";
            this.btn_step2.UseVisualStyleBackColor = true;
            this.btn_step2.Click += new System.EventHandler(this.btn_step2_Click);
            // 
            // btn_step3
            // 
            this.btn_step3.Location = new System.Drawing.Point(539, 327);
            this.btn_step3.Name = "btn_step3";
            this.btn_step3.Size = new System.Drawing.Size(176, 35);
            this.btn_step3.TabIndex = 2;
            this.btn_step3.Text = "3단계";
            this.btn_step3.UseVisualStyleBackColor = true;
            this.btn_step3.Click += new System.EventHandler(this.btn_step3_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(357, 368);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(176, 35);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(539, 368);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(176, 35);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 408);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_step3);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_step2);
            this.Controls.Add(this.btn_step1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += Form1_KeyDown;
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_step1;
        private System.Windows.Forms.Button btn_step2;
        private System.Windows.Forms.Button btn_step3;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
    }
}

