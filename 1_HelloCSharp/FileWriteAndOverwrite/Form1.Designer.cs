namespace FileWriteAndOverwrite
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
            this.btn_overwrite = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_overwrite
            // 
            this.btn_overwrite.Location = new System.Drawing.Point(12, 39);
            this.btn_overwrite.Name = "btn_overwrite";
            this.btn_overwrite.Size = new System.Drawing.Size(129, 83);
            this.btn_overwrite.TabIndex = 0;
            this.btn_overwrite.Text = "Overwrite";
            this.btn_overwrite.UseVisualStyleBackColor = true;
            this.btn_overwrite.Click += new System.EventHandler(this.btn_overwrite_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(297, 12);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_selectFile.TabIndex = 2;
            this.btn_selectFile.Text = "Select";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(147, 39);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(129, 83);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(12, 128);
            this.txb_result.Multiline = true;
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(364, 89);
            this.txb_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 229);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_overwrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_overwrite;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox txb_result;
    }
}

