namespace Dori21_ListStruct
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_menu4_count = new System.Windows.Forms.Label();
            this.lbl_menu3_count = new System.Windows.Forms.Label();
            this.lbl_menu2_count = new System.Windows.Forms.Label();
            this.lbl_menu1_count = new System.Windows.Forms.Label();
            this.lbl_menu4 = new System.Windows.Forms.Label();
            this.lbl_menu3 = new System.Windows.Forms.Label();
            this.lbl_menu2 = new System.Windows.Forms.Label();
            this.lbl_menu1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu4_count, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu3_count, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu2_count, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu1_count, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_menu1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_menu4_count
            // 
            this.lbl_menu4_count.AutoSize = true;
            this.lbl_menu4_count.BackColor = System.Drawing.Color.White;
            this.lbl_menu4_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu4_count.Location = new System.Drawing.Point(298, 79);
            this.lbl_menu4_count.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu4_count.Name = "lbl_menu4_count";
            this.lbl_menu4_count.Size = new System.Drawing.Size(100, 18);
            this.lbl_menu4_count.TabIndex = 7;
            this.lbl_menu4_count.Text = "0";
            this.lbl_menu4_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_menu3_count
            // 
            this.lbl_menu3_count.AutoSize = true;
            this.lbl_menu3_count.BackColor = System.Drawing.Color.White;
            this.lbl_menu3_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu3_count.Location = new System.Drawing.Point(199, 79);
            this.lbl_menu3_count.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu3_count.Name = "lbl_menu3_count";
            this.lbl_menu3_count.Size = new System.Drawing.Size(97, 18);
            this.lbl_menu3_count.TabIndex = 6;
            this.lbl_menu3_count.Text = "0";
            this.lbl_menu3_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_menu2_count
            // 
            this.lbl_menu2_count.AutoSize = true;
            this.lbl_menu2_count.BackColor = System.Drawing.Color.White;
            this.lbl_menu2_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu2_count.Location = new System.Drawing.Point(100, 79);
            this.lbl_menu2_count.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu2_count.Name = "lbl_menu2_count";
            this.lbl_menu2_count.Size = new System.Drawing.Size(97, 18);
            this.lbl_menu2_count.TabIndex = 5;
            this.lbl_menu2_count.Text = "0";
            this.lbl_menu2_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_menu1_count
            // 
            this.lbl_menu1_count.AutoSize = true;
            this.lbl_menu1_count.BackColor = System.Drawing.Color.White;
            this.lbl_menu1_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu1_count.Location = new System.Drawing.Point(1, 79);
            this.lbl_menu1_count.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu1_count.Name = "lbl_menu1_count";
            this.lbl_menu1_count.Size = new System.Drawing.Size(97, 18);
            this.lbl_menu1_count.TabIndex = 4;
            this.lbl_menu1_count.Text = "0";
            this.lbl_menu1_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_menu4
            // 
            this.lbl_menu4.AutoSize = true;
            this.lbl_menu4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_menu4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu4.Location = new System.Drawing.Point(298, 1);
            this.lbl_menu4.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu4.Name = "lbl_menu4";
            this.lbl_menu4.Size = new System.Drawing.Size(100, 76);
            this.lbl_menu4.TabIndex = 3;
            this.lbl_menu4.Text = "Menu4";
            this.lbl_menu4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_menu4.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // lbl_menu3
            // 
            this.lbl_menu3.AutoSize = true;
            this.lbl_menu3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_menu3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu3.Location = new System.Drawing.Point(199, 1);
            this.lbl_menu3.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu3.Name = "lbl_menu3";
            this.lbl_menu3.Size = new System.Drawing.Size(97, 76);
            this.lbl_menu3.TabIndex = 2;
            this.lbl_menu3.Text = "Menu3";
            this.lbl_menu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_menu3.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // lbl_menu2
            // 
            this.lbl_menu2.AutoSize = true;
            this.lbl_menu2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_menu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu2.Location = new System.Drawing.Point(100, 1);
            this.lbl_menu2.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu2.Name = "lbl_menu2";
            this.lbl_menu2.Size = new System.Drawing.Size(97, 76);
            this.lbl_menu2.TabIndex = 1;
            this.lbl_menu2.Text = "Menu2";
            this.lbl_menu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_menu2.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // lbl_menu1
            // 
            this.lbl_menu1.AutoSize = true;
            this.lbl_menu1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_menu1.Location = new System.Drawing.Point(1, 1);
            this.lbl_menu1.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_menu1.Name = "lbl_menu1";
            this.lbl_menu1.Size = new System.Drawing.Size(97, 76);
            this.lbl_menu1.TabIndex = 0;
            this.lbl_menu1.Text = "Menu1";
            this.lbl_menu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_menu1.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Count :";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Location = new System.Drawing.Point(96, 158);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(11, 12);
            this.txt_total.TabIndex = 2;
            this.txt_total.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(397, 138);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Price :";
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Location = new System.Drawing.Point(96, 182);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(11, 12);
            this.lbl_total_price.TabIndex = 2;
            this.lbl_total_price.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_total_price);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_menu4_count;
        private System.Windows.Forms.Label lbl_menu3_count;
        private System.Windows.Forms.Label lbl_menu2_count;
        private System.Windows.Forms.Label lbl_menu1_count;
        private System.Windows.Forms.Label lbl_menu4;
        private System.Windows.Forms.Label lbl_menu3;
        private System.Windows.Forms.Label lbl_menu2;
        private System.Windows.Forms.Label lbl_menu1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total_price;
    }
}

