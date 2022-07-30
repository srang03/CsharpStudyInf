namespace Dori16_StreamReaderReivew
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
            this.btn_set = new System.Windows.Forms.Button();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_path = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.checkbx_validation = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_directory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(12, 356);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(146, 42);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // txb_result
            // 
            this.txb_result.BackColor = System.Drawing.Color.DarkGray;
            this.txb_result.Enabled = false;
            this.txb_result.ForeColor = System.Drawing.Color.White;
            this.txb_result.Location = new System.Drawing.Point(12, 38);
            this.txb_result.Multiline = true;
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(300, 125);
            this.txb_result.TabIndex = 1;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(88, 169);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(224, 21);
            this.txb_name.TabIndex = 2;
            // 
            // txb_path
            // 
            this.txb_path.Location = new System.Drawing.Point(88, 198);
            this.txb_path.Name = "txb_path";
            this.txb_path.Size = new System.Drawing.Size(224, 21);
            this.txb_path.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(166, 356);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(146, 42);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // checkbx_validation
            // 
            this.checkbx_validation.AutoSize = true;
            this.checkbx_validation.Location = new System.Drawing.Point(88, 319);
            this.checkbx_validation.Name = "checkbx_validation";
            this.checkbx_validation.Size = new System.Drawing.Size(77, 16);
            this.checkbx_validation.TabIndex = 6;
            this.checkbx_validation.Text = "validation";
            this.checkbx_validation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Directory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Set:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manager Configuration";
            // 
            // txb_directory
            // 
            this.txb_directory.Location = new System.Drawing.Point(88, 225);
            this.txb_directory.Multiline = true;
            this.txb_directory.Name = "txb_directory";
            this.txb_directory.Size = new System.Drawing.Size(224, 88);
            this.txb_directory.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 410);
            this.Controls.Add(this.txb_directory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbx_validation);
            this.Controls.Add(this.txb_path);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_path;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox checkbx_validation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_directory;
    }
}

