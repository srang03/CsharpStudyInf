namespace Dori36_LinkedList
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
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(18, 18);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 0;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendar_DateChanged);
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(18, 192);
            this.txb_input.Multiline = true;
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(220, 186);
            this.txb_input.TabIndex = 1;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(18, 384);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(220, 33);
            this.btn_enroll.TabIndex = 2;
            this.btn_enroll.Text = "Enroll";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 12;
            this.lbx_list.Location = new System.Drawing.Point(250, 18);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(293, 400);
            this.lbx_list.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 434);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.mCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.ListBox lbx_list;
    }
}

