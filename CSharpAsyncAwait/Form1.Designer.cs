namespace CSharpAsyncAwait
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
            this.btn_cooking = new System.Windows.Forms.Button();
            this.btn_watching = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.isAsync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_cooking
            // 
            this.btn_cooking.Location = new System.Drawing.Point(15, 63);
            this.btn_cooking.Name = "btn_cooking";
            this.btn_cooking.Size = new System.Drawing.Size(109, 46);
            this.btn_cooking.TabIndex = 0;
            this.btn_cooking.Text = "식사 준비";
            this.btn_cooking.UseVisualStyleBackColor = true;
            this.btn_cooking.Click += new System.EventHandler(this.btn_cooking_Click);
            // 
            // btn_watching
            // 
            this.btn_watching.Location = new System.Drawing.Point(438, 63);
            this.btn_watching.Name = "btn_watching";
            this.btn_watching.Size = new System.Drawing.Size(109, 46);
            this.btn_watching.TabIndex = 0;
            this.btn_watching.Text = "TV 보기";
            this.btn_watching.UseVisualStyleBackColor = true;
            this.btn_watching.Click += new System.EventHandler(this.btn_watching_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(15, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 112);
            this.listBox1.TabIndex = 1;
            // 
            // isAsync
            // 
            this.isAsync.AutoSize = true;
            this.isAsync.Location = new System.Drawing.Point(15, 115);
            this.isAsync.Name = "isAsync";
            this.isAsync.Size = new System.Drawing.Size(60, 16);
            this.isAsync.TabIndex = 2;
            this.isAsync.Text = "비동기";
            this.isAsync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.isAsync);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_watching);
            this.Controls.Add(this.btn_cooking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cooking;
        private System.Windows.Forms.Button btn_watching;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox isAsync;
    }
}

