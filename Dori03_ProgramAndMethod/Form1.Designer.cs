namespace Dori03_ProgramAndMethod
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
            this.txb_num1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.txb_num2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_result
            // 
            this.txb_result.Enabled = false;
            this.txb_result.Location = new System.Drawing.Point(12, 12);
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(286, 21);
            this.txb_result.TabIndex = 0;
            this.txb_result.Text = "0";
            this.txb_result.TextChanged += new System.EventHandler(this.txb_result_TextChanged);
            // 
            // txb_num1
            // 
            this.txb_num1.Location = new System.Drawing.Point(12, 39);
            this.txb_num1.Name = "txb_num1";
            this.txb_num1.Size = new System.Drawing.Size(140, 21);
            this.txb_num1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 80);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(67, 66);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(85, 80);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(67, 66);
            this.btn_sub.TabIndex = 1;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(158, 80);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(67, 66);
            this.btn_multi.TabIndex = 1;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(231, 80);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(67, 66);
            this.btn_divide.TabIndex = 1;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txb_num2
            // 
            this.txb_num2.Location = new System.Drawing.Point(158, 39);
            this.txb_num2.Name = "txb_num2";
            this.txb_num2.Size = new System.Drawing.Size(140, 21);
            this.txb_num2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 158);
            this.Controls.Add(this.txb_num2);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txb_num1);
            this.Controls.Add(this.txb_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.TextBox txb_num1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox txb_num2;
    }
}

