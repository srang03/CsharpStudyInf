namespace Dori30_Lambda
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
            this.btn_callEvent = new System.Windows.Forms.Button();
            this.btn_callAnonymous = new System.Windows.Forms.Button();
            this.btn_callLambda = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_step = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_callEvent
            // 
            this.btn_callEvent.Location = new System.Drawing.Point(12, 12);
            this.btn_callEvent.Name = "btn_callEvent";
            this.btn_callEvent.Size = new System.Drawing.Size(107, 23);
            this.btn_callEvent.TabIndex = 0;
            this.btn_callEvent.Text = "Event 함수 호출";
            this.btn_callEvent.UseVisualStyleBackColor = true;
            // 
            // btn_callAnonymous
            // 
            this.btn_callAnonymous.Location = new System.Drawing.Point(12, 41);
            this.btn_callAnonymous.Name = "btn_callAnonymous";
            this.btn_callAnonymous.Size = new System.Drawing.Size(107, 23);
            this.btn_callAnonymous.TabIndex = 0;
            this.btn_callAnonymous.Text = "무명 메서드 함수 사용";
            this.btn_callAnonymous.UseVisualStyleBackColor = true;
            // 
            // btn_callLambda
            // 
            this.btn_callLambda.Location = new System.Drawing.Point(12, 70);
            this.btn_callLambda.Name = "btn_callLambda";
            this.btn_callLambda.Size = new System.Drawing.Size(107, 23);
            this.btn_callLambda.TabIndex = 0;
            this.btn_callLambda.Text = "람다식 사용";
            this.btn_callLambda.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 136);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_step
            // 
            this.lbl_step.AutoSize = true;
            this.lbl_step.Location = new System.Drawing.Point(12, 131);
            this.lbl_step.Name = "lbl_step";
            this.lbl_step.Size = new System.Drawing.Size(11, 12);
            this.lbl_step.TabIndex = 2;
            this.lbl_step.Text = "-";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(342, 117);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(107, 23);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "다음";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 294);
            this.Controls.Add(this.lbl_step);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_callLambda);
            this.Controls.Add(this.btn_callAnonymous);
            this.Controls.Add(this.btn_callEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_callEvent;
        private System.Windows.Forms.Button btn_callAnonymous;
        private System.Windows.Forms.Button btn_callLambda;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_step;
        private System.Windows.Forms.Button btn_next;
    }
}

