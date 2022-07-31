namespace Dori24_Delegate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiobtn_original = new System.Windows.Forms.RadioButton();
            this.radiobtn_thin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_cheese = new System.Windows.Forms.RadioButton();
            this.radiobtn_richgold = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbx_option1 = new System.Windows.Forms.CheckBox();
            this.checkbx_option2 = new System.Windows.Forms.CheckBox();
            this.checkbx_option3 = new System.Windows.Forms.CheckBox();
            this.nud_count = new System.Windows.Forms.NumericUpDown();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.listbx_result = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn_thin);
            this.groupBox1.Controls.Add(this.radiobtn_original);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "도우";
            // 
            // radiobtn_original
            // 
            this.radiobtn_original.AutoSize = true;
            this.radiobtn_original.Location = new System.Drawing.Point(6, 44);
            this.radiobtn_original.Name = "radiobtn_original";
            this.radiobtn_original.Size = new System.Drawing.Size(111, 16);
            this.radiobtn_original.TabIndex = 1;
            this.radiobtn_original.TabStop = true;
            this.radiobtn_original.Text = "오리지널(10000)";
            this.radiobtn_original.UseVisualStyleBackColor = true;
            // 
            // radiobtn_thin
            // 
            this.radiobtn_thin.AutoSize = true;
            this.radiobtn_thin.Location = new System.Drawing.Point(165, 44);
            this.radiobtn_thin.Name = "radiobtn_thin";
            this.radiobtn_thin.Size = new System.Drawing.Size(75, 16);
            this.radiobtn_thin.TabIndex = 1;
            this.radiobtn_thin.TabStop = true;
            this.radiobtn_thin.Text = "씬(11000)";
            this.radiobtn_thin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_cheese);
            this.groupBox2.Controls.Add(this.radiobtn_richgold);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // radiobtn_cheese
            // 
            this.radiobtn_cheese.AutoSize = true;
            this.radiobtn_cheese.Location = new System.Drawing.Point(165, 44);
            this.radiobtn_cheese.Name = "radiobtn_cheese";
            this.radiobtn_cheese.Size = new System.Drawing.Size(129, 16);
            this.radiobtn_cheese.TabIndex = 1;
            this.radiobtn_cheese.TabStop = true;
            this.radiobtn_cheese.Text = "치즈크러스트(2000)";
            this.radiobtn_cheese.UseVisualStyleBackColor = true;
            // 
            // radiobtn_richgold
            // 
            this.radiobtn_richgold.AutoSize = true;
            this.radiobtn_richgold.Location = new System.Drawing.Point(6, 44);
            this.radiobtn_richgold.Name = "radiobtn_richgold";
            this.radiobtn_richgold.Size = new System.Drawing.Size(105, 16);
            this.radiobtn_richgold.TabIndex = 1;
            this.radiobtn_richgold.TabStop = true;
            this.radiobtn_richgold.Text = "리치골드(3000)";
            this.radiobtn_richgold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "엣지";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_count);
            this.groupBox3.Controls.Add(this.checkbx_option3);
            this.groupBox3.Controls.Add(this.checkbx_option2);
            this.groupBox3.Controls.Add(this.checkbx_option1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 130);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "토핑";
            // 
            // checkbx_option1
            // 
            this.checkbx_option1.AutoSize = true;
            this.checkbx_option1.Location = new System.Drawing.Point(6, 48);
            this.checkbx_option1.Name = "checkbx_option1";
            this.checkbx_option1.Size = new System.Drawing.Size(124, 16);
            this.checkbx_option1.TabIndex = 1;
            this.checkbx_option1.Text = "소세지 (1EA 1000)";
            this.checkbx_option1.UseVisualStyleBackColor = true;
            // 
            // checkbx_option2
            // 
            this.checkbx_option2.AutoSize = true;
            this.checkbx_option2.Location = new System.Drawing.Point(5, 70);
            this.checkbx_option2.Name = "checkbx_option2";
            this.checkbx_option2.Size = new System.Drawing.Size(106, 16);
            this.checkbx_option2.TabIndex = 1;
            this.checkbx_option2.Text = "감자 (1EA 800)";
            this.checkbx_option2.UseVisualStyleBackColor = true;
            // 
            // checkbx_option3
            // 
            this.checkbx_option3.AutoSize = true;
            this.checkbx_option3.Location = new System.Drawing.Point(5, 92);
            this.checkbx_option3.Name = "checkbx_option3";
            this.checkbx_option3.Size = new System.Drawing.Size(112, 16);
            this.checkbx_option3.TabIndex = 1;
            this.checkbx_option3.Text = "치즈 (1EA 2000)";
            this.checkbx_option3.UseVisualStyleBackColor = true;
            // 
            // nud_count
            // 
            this.nud_count.Location = new System.Drawing.Point(243, 87);
            this.nud_count.Name = "nud_count";
            this.nud_count.Size = new System.Drawing.Size(51, 21);
            this.nud_count.TabIndex = 2;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(12, 346);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(299, 47);
            this.btn_purchase.TabIndex = 1;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // listbx_result
            // 
            this.listbx_result.FormattingEnabled = true;
            this.listbx_result.ItemHeight = 12;
            this.listbx_result.Location = new System.Drawing.Point(322, 29);
            this.listbx_result.Name = "listbx_result";
            this.listbx_result.Size = new System.Drawing.Size(328, 364);
            this.listbx_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 406);
            this.Controls.Add(this.listbx_result);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_thin;
        private System.Windows.Forms.RadioButton radiobtn_original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtn_cheese;
        private System.Windows.Forms.RadioButton radiobtn_richgold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nud_count;
        private System.Windows.Forms.CheckBox checkbx_option3;
        private System.Windows.Forms.CheckBox checkbx_option2;
        private System.Windows.Forms.CheckBox checkbx_option1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.ListBox listbx_result;
    }
}

