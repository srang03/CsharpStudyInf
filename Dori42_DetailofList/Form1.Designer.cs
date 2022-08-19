namespace Dori42_DetailofList
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
            this.txb_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_position = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.list_number = new System.Windows.Forms.ListBox();
            this.list_box1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_modify = new System.Windows.Forms.TextBox();
            this.list_box2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_ListDetail = new System.Windows.Forms.TextBox();
            this.txb_changeListDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_position)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // txb_value
            // 
            this.txb_value.Location = new System.Drawing.Point(68, 19);
            this.txb_value.Name = "txb_value";
            this.txb_value.Size = new System.Drawing.Size(113, 21);
            this.txb_value.TabIndex = 1;
            this.txb_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_value_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position";
            // 
            // nud_position
            // 
            this.nud_position.Location = new System.Drawing.Point(68, 53);
            this.nud_position.Name = "nud_position";
            this.nud_position.Size = new System.Drawing.Size(113, 21);
            this.nud_position.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_number
            // 
            this.list_number.Enabled = false;
            this.list_number.FormattingEnabled = true;
            this.list_number.ItemHeight = 12;
            this.list_number.Location = new System.Drawing.Point(14, 133);
            this.list_number.Name = "list_number";
            this.list_number.Size = new System.Drawing.Size(24, 304);
            this.list_number.TabIndex = 4;
            // 
            // list_box1
            // 
            this.list_box1.FormattingEnabled = true;
            this.list_box1.ItemHeight = 12;
            this.list_box1.Location = new System.Drawing.Point(44, 134);
            this.list_box1.Name = "list_box1";
            this.list_box1.Size = new System.Drawing.Size(137, 304);
            this.list_box1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "검색";
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(274, 23);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(100, 21);
            this.txb_search.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "수정";
            // 
            // txb_modify
            // 
            this.txb_modify.Location = new System.Drawing.Point(274, 56);
            this.txb_modify.Name = "txb_modify";
            this.txb_modify.Size = new System.Drawing.Size(100, 21);
            this.txb_modify.TabIndex = 1;
            // 
            // list_box2
            // 
            this.list_box2.FormattingEnabled = true;
            this.list_box2.ItemHeight = 12;
            this.list_box2.Location = new System.Drawing.Point(237, 134);
            this.list_box2.Name = "list_box2";
            this.list_box2.Size = new System.Drawing.Size(137, 304);
            this.list_box2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "변경";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "List Detail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "ChangeList Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "List 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "List 2";
            // 
            // txb_ListDetail
            // 
            this.txb_ListDetail.Enabled = false;
            this.txb_ListDetail.Location = new System.Drawing.Point(422, 50);
            this.txb_ListDetail.Multiline = true;
            this.txb_ListDetail.Name = "txb_ListDetail";
            this.txb_ListDetail.Size = new System.Drawing.Size(203, 175);
            this.txb_ListDetail.TabIndex = 5;
            // 
            // txb_changeListDetail
            // 
            this.txb_changeListDetail.Enabled = false;
            this.txb_changeListDetail.Location = new System.Drawing.Point(422, 262);
            this.txb_changeListDetail.Multiline = true;
            this.txb_changeListDetail.Name = "txb_changeListDetail";
            this.txb_changeListDetail.Size = new System.Drawing.Size(203, 175);
            this.txb_changeListDetail.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 455);
            this.Controls.Add(this.txb_changeListDetail);
            this.Controls.Add(this.txb_ListDetail);
            this.Controls.Add(this.list_box2);
            this.Controls.Add(this.list_box1);
            this.Controls.Add(this.list_number);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nud_position);
            this.Controls.Add(this.txb_modify);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox list_number;
        private System.Windows.Forms.ListBox list_box1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_modify;
        private System.Windows.Forms.ListBox list_box2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_ListDetail;
        private System.Windows.Forms.TextBox txb_changeListDetail;
    }
}

