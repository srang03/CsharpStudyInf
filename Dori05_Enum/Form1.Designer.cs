namespace Dori05_Enum
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbx_Day = new System.Windows.Forms.ListBox();
            this.lbx_Time = new System.Windows.Forms.ListBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.btn_setTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 21);
            this.textBox1.TabIndex = 0;
            // 
            // lbx_Day
            // 
            this.lbx_Day.FormattingEnabled = true;
            this.lbx_Day.ItemHeight = 12;
            this.lbx_Day.Location = new System.Drawing.Point(21, 50);
            this.lbx_Day.Name = "lbx_Day";
            this.lbx_Day.Size = new System.Drawing.Size(133, 160);
            this.lbx_Day.TabIndex = 1;
            // 
            // lbx_Time
            // 
            this.lbx_Time.FormattingEnabled = true;
            this.lbx_Time.ItemHeight = 12;
            this.lbx_Time.Location = new System.Drawing.Point(160, 50);
            this.lbx_Time.Name = "lbx_Time";
            this.lbx_Time.Size = new System.Drawing.Size(134, 160);
            this.lbx_Time.TabIndex = 1;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(21, 212);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(134, 23);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "결과보기";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // txb_result
            // 
            this.txb_result.Enabled = false;
            this.txb_result.Location = new System.Drawing.Point(21, 241);
            this.txb_result.Multiline = true;
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(273, 83);
            this.txb_result.TabIndex = 0;
            // 
            // btn_setTime
            // 
            this.btn_setTime.Location = new System.Drawing.Point(160, 212);
            this.btn_setTime.Name = "btn_setTime";
            this.btn_setTime.Size = new System.Drawing.Size(134, 23);
            this.btn_setTime.TabIndex = 2;
            this.btn_setTime.Text = "button1";
            this.btn_setTime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 334);
            this.Controls.Add(this.btn_setTime);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.lbx_Time);
            this.Controls.Add(this.lbx_Day);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbx_Day;
        private System.Windows.Forms.ListBox lbx_Time;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Button btn_setTime;
    }
}

