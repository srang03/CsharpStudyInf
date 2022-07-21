namespace Dori01_String
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_substring = new System.Windows.Forms.Label();
            this.lbl_tolower = new System.Windows.Forms.Label();
            this.lbl_toUpper = new System.Windows.Forms.Label();
            this.lbl_trim = new System.Windows.Forms.Label();
            this.lbl_contain = new System.Windows.Forms.Label();
            this.lbl_equals = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_replace = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.lbx_split = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Split";
            // 
            // lbl_substring
            // 
            this.lbl_substring.AutoSize = true;
            this.lbl_substring.Location = new System.Drawing.Point(336, 94);
            this.lbl_substring.Name = "lbl_substring";
            this.lbl_substring.Size = new System.Drawing.Size(11, 12);
            this.lbl_substring.TabIndex = 0;
            this.lbl_substring.Text = "-";
            // 
            // lbl_tolower
            // 
            this.lbl_tolower.AutoSize = true;
            this.lbl_tolower.Location = new System.Drawing.Point(336, 136);
            this.lbl_tolower.Name = "lbl_tolower";
            this.lbl_tolower.Size = new System.Drawing.Size(11, 12);
            this.lbl_tolower.TabIndex = 0;
            this.lbl_tolower.Text = "-";
            // 
            // lbl_toUpper
            // 
            this.lbl_toUpper.AutoSize = true;
            this.lbl_toUpper.Location = new System.Drawing.Point(336, 178);
            this.lbl_toUpper.Name = "lbl_toUpper";
            this.lbl_toUpper.Size = new System.Drawing.Size(11, 12);
            this.lbl_toUpper.TabIndex = 0;
            this.lbl_toUpper.Text = "-";
            this.lbl_toUpper.Click += new System.EventHandler(this.lbl_toUpper_Click);
            // 
            // lbl_trim
            // 
            this.lbl_trim.AutoSize = true;
            this.lbl_trim.Location = new System.Drawing.Point(336, 223);
            this.lbl_trim.Name = "lbl_trim";
            this.lbl_trim.Size = new System.Drawing.Size(11, 12);
            this.lbl_trim.TabIndex = 0;
            this.lbl_trim.Text = "-";
            // 
            // lbl_contain
            // 
            this.lbl_contain.AutoSize = true;
            this.lbl_contain.Location = new System.Drawing.Point(110, 94);
            this.lbl_contain.Name = "lbl_contain";
            this.lbl_contain.Size = new System.Drawing.Size(11, 12);
            this.lbl_contain.TabIndex = 0;
            this.lbl_contain.Text = "-";
            // 
            // lbl_equals
            // 
            this.lbl_equals.AutoSize = true;
            this.lbl_equals.Location = new System.Drawing.Point(110, 136);
            this.lbl_equals.Name = "lbl_equals";
            this.lbl_equals.Size = new System.Drawing.Size(11, 12);
            this.lbl_equals.TabIndex = 0;
            this.lbl_equals.Text = "-";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(110, 178);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(11, 12);
            this.lbl_length.TabIndex = 0;
            this.lbl_length.Text = "-";
            // 
            // lbl_replace
            // 
            this.lbl_replace.AutoSize = true;
            this.lbl_replace.Location = new System.Drawing.Point(110, 223);
            this.lbl_replace.Name = "lbl_replace";
            this.lbl_replace.Size = new System.Drawing.Size(11, 12);
            this.lbl_replace.TabIndex = 0;
            this.lbl_replace.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "ToUpper";
            this.label8.Click += new System.EventHandler(this.lbl_toUpper_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "ToLower";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Substring";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(23, 32);
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(229, 21);
            this.txb_input.TabIndex = 2;
            // 
            // lbx_split
            // 
            this.lbx_split.FormattingEnabled = true;
            this.lbx_split.ItemHeight = 12;
            this.lbx_split.Location = new System.Drawing.Point(105, 266);
            this.lbx_split.Name = "lbx_split";
            this.lbx_split.Size = new System.Drawing.Size(242, 88);
            this.lbx_split.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_split);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_trim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_toUpper);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_tolower);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_substring);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_replace);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.lbl_equals);
            this.Controls.Add(this.lbl_contain);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_substring;
        private System.Windows.Forms.Label lbl_tolower;
        private System.Windows.Forms.Label lbl_toUpper;
        private System.Windows.Forms.Label lbl_trim;
        private System.Windows.Forms.Label lbl_contain;
        private System.Windows.Forms.Label lbl_equals;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_replace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.ListBox lbx_split;
    }
}

