namespace Dori31_LINQ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sortLevel = new System.Windows.Forms.Button();
            this.btn_sortName = new System.Windows.Forms.Button();
            this.btn_sortAttribute = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.nud_start = new System.Windows.Forms.NumericUpDown();
            this.combobx_attrivute = new System.Windows.Forms.ComboBox();
            this.nud_end = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(389, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_sortLevel
            // 
            this.btn_sortLevel.Location = new System.Drawing.Point(423, 12);
            this.btn_sortLevel.Name = "btn_sortLevel";
            this.btn_sortLevel.Size = new System.Drawing.Size(134, 23);
            this.btn_sortLevel.TabIndex = 1;
            this.btn_sortLevel.Text = "Sort Level";
            this.btn_sortLevel.UseVisualStyleBackColor = true;
            this.btn_sortLevel.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_sortName
            // 
            this.btn_sortName.Location = new System.Drawing.Point(423, 41);
            this.btn_sortName.Name = "btn_sortName";
            this.btn_sortName.Size = new System.Drawing.Size(134, 23);
            this.btn_sortName.TabIndex = 1;
            this.btn_sortName.Text = "Sort Name";
            this.btn_sortName.UseVisualStyleBackColor = true;
            this.btn_sortName.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_sortAttribute
            // 
            this.btn_sortAttribute.Location = new System.Drawing.Point(423, 70);
            this.btn_sortAttribute.Name = "btn_sortAttribute";
            this.btn_sortAttribute.Size = new System.Drawing.Size(134, 23);
            this.btn_sortAttribute.TabIndex = 1;
            this.btn_sortAttribute.Text = "Sort Attribute";
            this.btn_sortAttribute.UseVisualStyleBackColor = true;
            this.btn_sortAttribute.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(423, 208);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(134, 23);
            this.btn_filter.TabIndex = 1;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(423, 237);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(134, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // nud_start
            // 
            this.nud_start.Location = new System.Drawing.Point(423, 162);
            this.nud_start.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_start.Name = "nud_start";
            this.nud_start.Size = new System.Drawing.Size(51, 21);
            this.nud_start.TabIndex = 2;
            this.nud_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combobx_attrivute
            // 
            this.combobx_attrivute.FormattingEnabled = true;
            this.combobx_attrivute.Location = new System.Drawing.Point(423, 136);
            this.combobx_attrivute.Name = "combobx_attrivute";
            this.combobx_attrivute.Size = new System.Drawing.Size(134, 20);
            this.combobx_attrivute.TabIndex = 3;
            // 
            // nud_end
            // 
            this.nud_end.Location = new System.Drawing.Point(506, 162);
            this.nud_end.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_end.Name = "nud_end";
            this.nud_end.Size = new System.Drawing.Size(51, 21);
            this.nud_end.TabIndex = 2;
            this.nud_end.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobx_attrivute);
            this.Controls.Add(this.nud_end);
            this.Controls.Add(this.nud_start);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_sortAttribute);
            this.Controls.Add(this.btn_sortName);
            this.Controls.Add(this.btn_sortLevel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sortLevel;
        private System.Windows.Forms.Button btn_sortName;
        private System.Windows.Forms.Button btn_sortAttribute;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.NumericUpDown nud_start;
        private System.Windows.Forms.ComboBox combobx_attrivute;
        private System.Windows.Forms.NumericUpDown nud_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

