namespace LogProject
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
            this.btn_logA = new System.Windows.Forms.Button();
            this.btn_logB = new System.Windows.Forms.Button();
            this.btn_logC = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_logA
            // 
            this.btn_logA.Location = new System.Drawing.Point(12, 12);
            this.btn_logA.Name = "btn_logA";
            this.btn_logA.Size = new System.Drawing.Size(75, 23);
            this.btn_logA.TabIndex = 0;
            this.btn_logA.Text = "log A";
            this.btn_logA.UseVisualStyleBackColor = true;
            this.btn_logA.Click += new System.EventHandler(this.btn_logA_Click);
            // 
            // btn_logB
            // 
            this.btn_logB.Location = new System.Drawing.Point(12, 41);
            this.btn_logB.Name = "btn_logB";
            this.btn_logB.Size = new System.Drawing.Size(75, 23);
            this.btn_logB.TabIndex = 0;
            this.btn_logB.Text = "log B";
            this.btn_logB.UseVisualStyleBackColor = true;
            this.btn_logB.Click += new System.EventHandler(this.btn_logB_Click);
            // 
            // btn_logC
            // 
            this.btn_logC.Location = new System.Drawing.Point(12, 70);
            this.btn_logC.Name = "btn_logC";
            this.btn_logC.Size = new System.Drawing.Size(75, 23);
            this.btn_logC.TabIndex = 0;
            this.btn_logC.Text = "log C";
            this.btn_logC.UseVisualStyleBackColor = true;
            this.btn_logC.Click += new System.EventHandler(this.btn_logC_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(124, 12);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(11, 12);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 106);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_logC);
            this.Controls.Add(this.btn_logB);
            this.Controls.Add(this.btn_logA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logA;
        private System.Windows.Forms.Button btn_logB;
        private System.Windows.Forms.Button btn_logC;
        private System.Windows.Forms.Label lbl_result;
    }
}

