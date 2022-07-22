namespace Dori08_Conditional
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_num1 = new System.Windows.Forms.NumericUpDown();
            this.nud_num2 = new System.Windows.Forms.NumericUpDown();
            this.btn_result = new System.Windows.Forms.Button();
            this.txb_compareNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.txb_ExecuteDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num2";
            // 
            // nud_num1
            // 
            this.nud_num1.Location = new System.Drawing.Point(24, 52);
            this.nud_num1.Name = "nud_num1";
            this.nud_num1.Size = new System.Drawing.Size(89, 21);
            this.nud_num1.TabIndex = 1;
            // 
            // nud_num2
            // 
            this.nud_num2.Location = new System.Drawing.Point(142, 50);
            this.nud_num2.Name = "nud_num2";
            this.nud_num2.Size = new System.Drawing.Size(89, 21);
            this.nud_num2.TabIndex = 1;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(263, 49);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "비교";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // txb_compareNumber
            // 
            this.txb_compareNumber.Enabled = false;
            this.txb_compareNumber.Location = new System.Drawing.Point(24, 89);
            this.txb_compareNumber.Name = "txb_compareNumber";
            this.txb_compareNumber.Size = new System.Drawing.Size(207, 21);
            this.txb_compareNumber.TabIndex = 3;
            this.txb_compareNumber.Text = "-";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.comboBox1.Location = new System.Drawing.Point(24, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "월";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(156, 166);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 5;
            this.btn_execute.Text = "실행";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // txb_ExecuteDay
            // 
            this.txb_ExecuteDay.Enabled = false;
            this.txb_ExecuteDay.Location = new System.Drawing.Point(24, 204);
            this.txb_ExecuteDay.Name = "txb_ExecuteDay";
            this.txb_ExecuteDay.Size = new System.Drawing.Size(207, 21);
            this.txb_ExecuteDay.TabIndex = 3;
            this.txb_ExecuteDay.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txb_ExecuteDay);
            this.Controls.Add(this.txb_compareNumber);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.nud_num2);
            this.Controls.Add(this.nud_num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "월";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_num1;
        private System.Windows.Forms.NumericUpDown nud_num2;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox txb_compareNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.TextBox txb_ExecuteDay;
    }
}

