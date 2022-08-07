namespace Dori24_DelegateReview
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
            this.rdb_original = new System.Windows.Forms.RadioButton();
            this.rdb_thin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_order = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdb_richgold = new System.Windows.Forms.RadioButton();
            this.rdb_cheese = new System.Windows.Forms.RadioButton();
            this.checkbx_option1 = new System.Windows.Forms.CheckBox();
            this.checkbx_option3 = new System.Windows.Forms.CheckBox();
            this.checkbx_option2 = new System.Windows.Forms.CheckBox();
            this.nud_eacount = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_eacount)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_original
            // 
            this.rdb_original.AutoSize = true;
            this.rdb_original.Location = new System.Drawing.Point(19, 30);
            this.rdb_original.Name = "rdb_original";
            this.rdb_original.Size = new System.Drawing.Size(131, 16);
            this.rdb_original.TabIndex = 0;
            this.rdb_original.TabStop = true;
            this.rdb_original.Text = "오리지널 (10,000원)";
            this.rdb_original.UseVisualStyleBackColor = true;
            // 
            // rdb_thin
            // 
            this.rdb_thin.AutoSize = true;
            this.rdb_thin.Location = new System.Drawing.Point(165, 30);
            this.rdb_thin.Name = "rdb_thin";
            this.rdb_thin.Size = new System.Drawing.Size(95, 16);
            this.rdb_thin.TabIndex = 1;
            this.rdb_thin.TabStop = true;
            this.rdb_thin.Text = "씬 (11,000원)";
            this.rdb_thin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_thin);
            this.panel1.Controls.Add(this.rdb_original);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 75);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_cheese);
            this.panel2.Controls.Add(this.rdb_richgold);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 75);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nud_eacount);
            this.panel3.Controls.Add(this.checkbx_option3);
            this.panel3.Controls.Add(this.checkbx_option2);
            this.panel3.Controls.Add(this.checkbx_option1);
            this.panel3.Location = new System.Drawing.Point(12, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 134);
            this.panel3.TabIndex = 2;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(15, 313);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(323, 34);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "주문하기";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(358, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 340);
            this.listBox1.TabIndex = 4;
            // 
            // rdb_richgold
            // 
            this.rdb_richgold.AutoSize = true;
            this.rdb_richgold.Location = new System.Drawing.Point(19, 30);
            this.rdb_richgold.Name = "rdb_richgold";
            this.rdb_richgold.Size = new System.Drawing.Size(125, 16);
            this.rdb_richgold.TabIndex = 1;
            this.rdb_richgold.TabStop = true;
            this.rdb_richgold.Text = "리치골드 (1,000원)";
            this.rdb_richgold.UseVisualStyleBackColor = true;
            // 
            // rdb_cheese
            // 
            this.rdb_cheese.AutoSize = true;
            this.rdb_cheese.Location = new System.Drawing.Point(165, 30);
            this.rdb_cheese.Name = "rdb_cheese";
            this.rdb_cheese.Size = new System.Drawing.Size(149, 16);
            this.rdb_cheese.TabIndex = 1;
            this.rdb_cheese.TabStop = true;
            this.rdb_cheese.Text = "치즈크러스트 (2,000원)";
            this.rdb_cheese.UseVisualStyleBackColor = true;
            // 
            // checkbx_option1
            // 
            this.checkbx_option1.AutoSize = true;
            this.checkbx_option1.Location = new System.Drawing.Point(32, 28);
            this.checkbx_option1.Name = "checkbx_option1";
            this.checkbx_option1.Size = new System.Drawing.Size(104, 16);
            this.checkbx_option1.TabIndex = 0;
            this.checkbx_option1.Text = "소시지 (500원)";
            this.checkbx_option1.UseVisualStyleBackColor = true;
            // 
            // checkbx_option3
            // 
            this.checkbx_option3.AutoSize = true;
            this.checkbx_option3.Location = new System.Drawing.Point(32, 96);
            this.checkbx_option3.Name = "checkbx_option3";
            this.checkbx_option3.Size = new System.Drawing.Size(92, 16);
            this.checkbx_option3.TabIndex = 0;
            this.checkbx_option3.Text = "치즈 (300원)";
            this.checkbx_option3.UseVisualStyleBackColor = true;
            // 
            // checkbx_option2
            // 
            this.checkbx_option2.AutoSize = true;
            this.checkbx_option2.Location = new System.Drawing.Point(32, 61);
            this.checkbx_option2.Name = "checkbx_option2";
            this.checkbx_option2.Size = new System.Drawing.Size(92, 16);
            this.checkbx_option2.TabIndex = 0;
            this.checkbx_option2.Text = "감자 (200원)";
            this.checkbx_option2.UseVisualStyleBackColor = true;
            // 
            // nud_eacount
            // 
            this.nud_eacount.Location = new System.Drawing.Point(194, 78);
            this.nud_eacount.Name = "nud_eacount";
            this.nud_eacount.Size = new System.Drawing.Size(50, 21);
            this.nud_eacount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 359);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_eacount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_original;
        private System.Windows.Forms.RadioButton rdb_thin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdb_cheese;
        private System.Windows.Forms.RadioButton rdb_richgold;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nud_eacount;
        private System.Windows.Forms.CheckBox checkbx_option3;
        private System.Windows.Forms.CheckBox checkbx_option2;
        private System.Windows.Forms.CheckBox checkbx_option1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ListBox listBox1;
    }
}

