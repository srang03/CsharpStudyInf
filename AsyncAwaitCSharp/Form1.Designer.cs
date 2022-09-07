namespace AsyncAwaitCSharp
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
            this.btn_async = new System.Windows.Forms.Button();
            this.btn_sync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_async
            // 
            this.btn_async.Location = new System.Drawing.Point(12, 66);
            this.btn_async.Name = "btn_async";
            this.btn_async.Size = new System.Drawing.Size(148, 38);
            this.btn_async.TabIndex = 0;
            this.btn_async.Text = "Async";
            this.btn_async.UseVisualStyleBackColor = true;
            this.btn_async.Click += new System.EventHandler(this.btn_async_Click);
            // 
            // btn_sync
            // 
            this.btn_sync.Location = new System.Drawing.Point(12, 12);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(148, 38);
            this.btn_sync.TabIndex = 0;
            this.btn_sync.Text = "Sync";
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.btn_sync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 117);
            this.Controls.Add(this.btn_sync);
            this.Controls.Add(this.btn_async);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_async;
        private System.Windows.Forms.Button btn_sync;
    }
}

