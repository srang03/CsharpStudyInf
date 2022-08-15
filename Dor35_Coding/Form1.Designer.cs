namespace Dor35_Coding
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
            this.txb_before = new System.Windows.Forms.TextBox();
            this.txb_after = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_before
            // 
            this.txb_before.Location = new System.Drawing.Point(12, 76);
            this.txb_before.Multiline = true;
            this.txb_before.Name = "txb_before";
            this.txb_before.Size = new System.Drawing.Size(297, 212);
            this.txb_before.TabIndex = 0;
            this.txb_before.Text = "1. 개똥도 약에 쓸려면 없다.\r\n2. 닭 쫓던 개 지붕 쳐다본다.\r\n3. 꿩 대신 닭\r\n4. 고양이한테 생선을 맡긴다.\r\n5. 꿩 먹고 알 먹기" +
    "";
            // 
            // txb_after
            // 
            this.txb_after.Location = new System.Drawing.Point(550, 76);
            this.txb_after.Multiline = true;
            this.txb_after.Name = "txb_after";
            this.txb_after.Size = new System.Drawing.Size(297, 212);
            this.txb_after.TabIndex = 0;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(376, 12);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(103, 42);
            this.btn_change.TabIndex = 1;
            this.btn_change.Text = "변환";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBefore,
            this.cAfter});
            this.dataGridView1.Location = new System.Drawing.Point(330, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(204, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // cBefore
            // 
            this.cBefore.HeaderText = "Before";
            this.cBefore.Name = "cBefore";
            this.cBefore.Width = 80;
            // 
            // cAfter
            // 
            this.cAfter.HeaderText = "After";
            this.cAfter.Name = "cAfter";
            this.cAfter.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 309);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txb_after);
            this.Controls.Add(this.txb_before);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_before;
        private System.Windows.Forms.TextBox txb_after;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAfter;
    }
}

