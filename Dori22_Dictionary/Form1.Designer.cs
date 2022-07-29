namespace Dori22_Dictionary
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_progressCounter = new System.Windows.Forms.Label();
            this.lbl_person1 = new System.Windows.Forms.Label();
            this.lbl_person2 = new System.Windows.Forms.Label();
            this.lbl_person3 = new System.Windows.Forms.Label();
            this.lbl_person4 = new System.Windows.Forms.Label();
            this.lbl_count1 = new System.Windows.Forms.Label();
            this.lbl_count2 = new System.Windows.Forms.Label();
            this.lbl_count3 = new System.Windows.Forms.Label();
            this.lbl_count4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "System";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_count4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_count3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_count2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_count1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_person4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_person3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_person2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_person1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 117);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voter:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(78, 169);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(11, 12);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Progress:";
            // 
            // lbl_progressCounter
            // 
            this.lbl_progressCounter.AutoSize = true;
            this.lbl_progressCounter.Location = new System.Drawing.Point(78, 198);
            this.lbl_progressCounter.Name = "lbl_progressCounter";
            this.lbl_progressCounter.Size = new System.Drawing.Size(35, 12);
            this.lbl_progressCounter.TabIndex = 3;
            this.lbl_progressCounter.Text = "0 / 0 ";
            // 
            // lbl_person1
            // 
            this.lbl_person1.AutoSize = true;
            this.lbl_person1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_person1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_person1.Location = new System.Drawing.Point(1, 1);
            this.lbl_person1.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_person1.Name = "lbl_person1";
            this.lbl_person1.Size = new System.Drawing.Size(109, 95);
            this.lbl_person1.TabIndex = 0;
            this.lbl_person1.Text = "Ho";
            this.lbl_person1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_person1.Click += new System.EventHandler(this.lbl_person1_Click);
            // 
            // lbl_person2
            // 
            this.lbl_person2.AutoSize = true;
            this.lbl_person2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_person2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_person2.Location = new System.Drawing.Point(112, 1);
            this.lbl_person2.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_person2.Name = "lbl_person2";
            this.lbl_person2.Size = new System.Drawing.Size(109, 95);
            this.lbl_person2.TabIndex = 1;
            this.lbl_person2.Text = "Ru";
            this.lbl_person2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_person2.Click += new System.EventHandler(this.lbl_person1_Click);
            // 
            // lbl_person3
            // 
            this.lbl_person3.AutoSize = true;
            this.lbl_person3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_person3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_person3.Location = new System.Drawing.Point(223, 1);
            this.lbl_person3.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_person3.Name = "lbl_person3";
            this.lbl_person3.Size = new System.Drawing.Size(109, 95);
            this.lbl_person3.TabIndex = 2;
            this.lbl_person3.Text = "Rang";
            this.lbl_person3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_person3.Click += new System.EventHandler(this.lbl_person1_Click);
            // 
            // lbl_person4
            // 
            this.lbl_person4.AutoSize = true;
            this.lbl_person4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_person4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_person4.Location = new System.Drawing.Point(334, 1);
            this.lbl_person4.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_person4.Name = "lbl_person4";
            this.lbl_person4.Size = new System.Drawing.Size(112, 95);
            this.lbl_person4.TabIndex = 3;
            this.lbl_person4.Text = "Ti";
            this.lbl_person4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_person4.Click += new System.EventHandler(this.lbl_person1_Click);
            // 
            // lbl_count1
            // 
            this.lbl_count1.AutoSize = true;
            this.lbl_count1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_count1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_count1.Location = new System.Drawing.Point(1, 98);
            this.lbl_count1.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_count1.Name = "lbl_count1";
            this.lbl_count1.Size = new System.Drawing.Size(109, 18);
            this.lbl_count1.TabIndex = 4;
            this.lbl_count1.Text = "0";
            this.lbl_count1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_count2
            // 
            this.lbl_count2.AutoSize = true;
            this.lbl_count2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_count2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_count2.Location = new System.Drawing.Point(112, 98);
            this.lbl_count2.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_count2.Name = "lbl_count2";
            this.lbl_count2.Size = new System.Drawing.Size(109, 18);
            this.lbl_count2.TabIndex = 5;
            this.lbl_count2.Text = "0";
            this.lbl_count2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_count3
            // 
            this.lbl_count3.AutoSize = true;
            this.lbl_count3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_count3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_count3.Location = new System.Drawing.Point(223, 98);
            this.lbl_count3.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_count3.Name = "lbl_count3";
            this.lbl_count3.Size = new System.Drawing.Size(109, 18);
            this.lbl_count3.TabIndex = 6;
            this.lbl_count3.Text = "0";
            this.lbl_count3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_count4
            // 
            this.lbl_count4.AutoSize = true;
            this.lbl_count4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_count4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_count4.Location = new System.Drawing.Point(334, 98);
            this.lbl_count4.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_count4.Name = "lbl_count4";
            this.lbl_count4.Size = new System.Drawing.Size(112, 18);
            this.lbl_count4.TabIndex = 7;
            this.lbl_count4.Text = "0";
            this.lbl_count4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(448, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_progressCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_count4;
        private System.Windows.Forms.Label lbl_count3;
        private System.Windows.Forms.Label lbl_count2;
        private System.Windows.Forms.Label lbl_count1;
        private System.Windows.Forms.Label lbl_person4;
        private System.Windows.Forms.Label lbl_person3;
        private System.Windows.Forms.Label lbl_person2;
        private System.Windows.Forms.Label lbl_person1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_progressCounter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

