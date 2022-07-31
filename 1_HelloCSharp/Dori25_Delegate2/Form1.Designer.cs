namespace Dori25_Delegate2
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
            this.radiobtn_ricigold = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbx_1 = new System.Windows.Forms.CheckBox();
            this.checkbx_2 = new System.Windows.Forms.CheckBox();
            this.checkbx_3 = new System.Windows.Forms.CheckBox();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn_thin);
            this.groupBox1.Controls.Add(this.radiobtn_original);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "도우";
            // 
            // radiobtn_original
            // 
            this.radiobtn_original.AutoSize = true;
            this.radiobtn_original.Location = new System.Drawing.Point(6, 48);
            this.radiobtn_original.Name = "radiobtn_original";
            this.radiobtn_original.Size = new System.Drawing.Size(115, 16);
            this.radiobtn_original.TabIndex = 1;
            this.radiobtn_original.TabStop = true;
            this.radiobtn_original.Text = "오리지널 (10000)";
            this.radiobtn_original.UseVisualStyleBackColor = true;
            // 
            // radiobtn_thin
            // 
            this.radiobtn_thin.AutoSize = true;
            this.radiobtn_thin.Location = new System.Drawing.Point(156, 48);
            this.radiobtn_thin.Name = "radiobtn_thin";
            this.radiobtn_thin.Size = new System.Drawing.Size(79, 16);
            this.radiobtn_thin.TabIndex = 1;
            this.radiobtn_thin.TabStop = true;
            this.radiobtn_thin.Text = "씬 (12000)";
            this.radiobtn_thin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_cheese);
            this.groupBox2.Controls.Add(this.radiobtn_ricigold);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // radiobtn_cheese
            // 
            this.radiobtn_cheese.AutoSize = true;
            this.radiobtn_cheese.Location = new System.Drawing.Point(156, 48);
            this.radiobtn_cheese.Name = "radiobtn_cheese";
            this.radiobtn_cheese.Size = new System.Drawing.Size(133, 16);
            this.radiobtn_cheese.TabIndex = 1;
            this.radiobtn_cheese.TabStop = true;
            this.radiobtn_cheese.Text = "치즈크러스트 (3000)";
            this.radiobtn_cheese.UseVisualStyleBackColor = true;
            // 
            // radiobtn_ricigold
            // 
            this.radiobtn_ricigold.AutoSize = true;
            this.radiobtn_ricigold.Location = new System.Drawing.Point(6, 48);
            this.radiobtn_ricigold.Name = "radiobtn_ricigold";
            this.radiobtn_ricigold.Size = new System.Drawing.Size(109, 16);
            this.radiobtn_ricigold.TabIndex = 1;
            this.radiobtn_ricigold.TabStop = true;
            this.radiobtn_ricigold.Text = "리치골드 (2000)";
            this.radiobtn_ricigold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "엣지";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.btn_purchase);
            this.groupBox3.Controls.Add(this.checkbx_3);
            this.groupBox3.Controls.Add(this.checkbx_2);
            this.groupBox3.Controls.Add(this.checkbx_1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(0, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 115);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "옵션";
            // 
            // checkbx_1
            // 
            this.checkbx_1.AutoSize = true;
            this.checkbx_1.Location = new System.Drawing.Point(9, 38);
            this.checkbx_1.Name = "checkbx_1";
            this.checkbx_1.Size = new System.Drawing.Size(124, 16);
            this.checkbx_1.TabIndex = 1;
            this.checkbx_1.Text = "소시지 (1EA 2000)";
            this.checkbx_1.UseVisualStyleBackColor = true;
            // 
            // checkbx_2
            // 
            this.checkbx_2.AutoSize = true;
            this.checkbx_2.Location = new System.Drawing.Point(9, 60);
            this.checkbx_2.Name = "checkbx_2";
            this.checkbx_2.Size = new System.Drawing.Size(106, 16);
            this.checkbx_2.TabIndex = 1;
            this.checkbx_2.Text = "감자 (1EA 500)";
            this.checkbx_2.UseVisualStyleBackColor = true;
            // 
            // checkbx_3
            // 
            this.checkbx_3.AutoSize = true;
            this.checkbx_3.Location = new System.Drawing.Point(9, 82);
            this.checkbx_3.Name = "checkbx_3";
            this.checkbx_3.Size = new System.Drawing.Size(112, 16);
            this.checkbx_3.TabIndex = 1;
            this.checkbx_3.Text = "치즈 (1EA 1000)";
            this.checkbx_3.UseVisualStyleBackColor = true;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(212, 73);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(75, 33);
            this.btn_purchase.TabIndex = 2;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(212, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(295, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 292);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_thin;
        private System.Windows.Forms.RadioButton radiobtn_original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtn_cheese;
        private System.Windows.Forms.RadioButton radiobtn_ricigold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.CheckBox checkbx_3;
        private System.Windows.Forms.CheckBox checkbx_2;
        private System.Windows.Forms.CheckBox checkbx_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

