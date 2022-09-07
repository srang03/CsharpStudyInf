namespace CSharpAsyncAswaitFromIAmTimCorey
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
            this.btn_sync = new System.Windows.Forms.Button();
            this.btn_async = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_paralleAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sync
            // 
            this.btn_sync.Location = new System.Drawing.Point(31, 31);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(164, 40);
            this.btn_sync.TabIndex = 0;
            this.btn_sync.Text = "Sync";
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.btn_sync_Click);
            // 
            // btn_async
            // 
            this.btn_async.Location = new System.Drawing.Point(31, 77);
            this.btn_async.Name = "btn_async";
            this.btn_async.Size = new System.Drawing.Size(164, 45);
            this.btn_async.TabIndex = 1;
            this.btn_async.Text = "Async";
            this.btn_async.UseVisualStyleBackColor = true;
            this.btn_async.Click += new System.EventHandler(this.btn_async_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(212, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 147);
            this.textBox1.TabIndex = 2;
            // 
            // btn_paralleAsync
            // 
            this.btn_paralleAsync.Location = new System.Drawing.Point(31, 128);
            this.btn_paralleAsync.Name = "btn_paralleAsync";
            this.btn_paralleAsync.Size = new System.Drawing.Size(164, 45);
            this.btn_paralleAsync.TabIndex = 1;
            this.btn_paralleAsync.Text = "ParalleAsync";
            this.btn_paralleAsync.UseVisualStyleBackColor = true;
            this.btn_paralleAsync.Click += new System.EventHandler(this.btn_paralleAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 190);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_paralleAsync);
            this.Controls.Add(this.btn_async);
            this.Controls.Add(this.btn_sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sync;
        private System.Windows.Forms.Button btn_async;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_paralleAsync;
    }
}

