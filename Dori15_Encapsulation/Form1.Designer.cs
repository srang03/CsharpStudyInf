namespace Dori15_Encapsulation
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.cbx_sales = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_get = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_total = new System.Windows.Forms.TextBox();
            this.tbx_message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 220);
            this.listBox1.TabIndex = 0;
            // 
            // cbx_product
            // 
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(13, 24);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(121, 20);
            this.cbx_product.TabIndex = 1;
            // 
            // cbx_sales
            // 
            this.cbx_sales.FormattingEnabled = true;
            this.cbx_sales.Location = new System.Drawing.Point(13, 74);
            this.cbx_sales.Name = "cbx_sales";
            this.cbx_sales.Size = new System.Drawing.Size(121, 20);
            this.cbx_sales.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 123);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(13, 160);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(121, 57);
            this.btn_get.TabIndex = 4;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_get);
            this.panel1.Controls.Add(this.cbx_product);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.cbx_sales);
            this.panel1.Location = new System.Drawing.Point(331, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 220);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sales (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count";
            // 
            // txb_total
            // 
            this.txb_total.BackColor = System.Drawing.Color.Silver;
            this.txb_total.Enabled = false;
            this.txb_total.ForeColor = System.Drawing.Color.White;
            this.txb_total.Location = new System.Drawing.Point(85, 248);
            this.txb_total.Name = "txb_total";
            this.txb_total.Size = new System.Drawing.Size(240, 21);
            this.txb_total.TabIndex = 6;
            // 
            // tbx_message
            // 
            this.tbx_message.BackColor = System.Drawing.Color.Gray;
            this.tbx_message.Enabled = false;
            this.tbx_message.ForeColor = System.Drawing.Color.White;
            this.tbx_message.Location = new System.Drawing.Point(85, 277);
            this.tbx_message.Name = "tbx_message";
            this.tbx_message.Size = new System.Drawing.Size(240, 21);
            this.tbx_message.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_message);
            this.Controls.Add(this.txb_total);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.ComboBox cbx_sales;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_total;
        private System.Windows.Forms.TextBox tbx_message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

