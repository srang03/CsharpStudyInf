namespace Dori09_For
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
            this.txb_result = new System.Windows.Forms.TextBox();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_foreach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(12, 12);
            this.txb_result.Multiline = true;
            this.txb_result.Name = "txb_result";
            this.txb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_result.Size = new System.Drawing.Size(317, 264);
            this.txb_result.TabIndex = 0;
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(335, 12);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(153, 45);
            this.btn_for.TabIndex = 1;
            this.btn_for.Text = "for 문";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_foreach
            // 
            this.btn_foreach.Location = new System.Drawing.Point(335, 63);
            this.btn_foreach.Name = "btn_foreach";
            this.btn_foreach.Size = new System.Drawing.Size(153, 45);
            this.btn_foreach.TabIndex = 1;
            this.btn_foreach.Text = "foreach 문";
            this.btn_foreach.UseVisualStyleBackColor = true;
            this.btn_foreach.Click += new System.EventHandler(this.btn_foreach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 284);
            this.Controls.Add(this.btn_foreach);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.txb_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_foreach;
    }
}

