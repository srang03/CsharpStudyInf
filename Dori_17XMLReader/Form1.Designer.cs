namespace Dori_17XMLReader
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
            this.btn_getConfig = new System.Windows.Forms.Button();
            this.btn_setConfig = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.nup_number = new System.Windows.Forms.NumericUpDown();
            this.checkbx_set = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_number)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getConfig
            // 
            this.btn_getConfig.Location = new System.Drawing.Point(12, 12);
            this.btn_getConfig.Name = "btn_getConfig";
            this.btn_getConfig.Size = new System.Drawing.Size(233, 38);
            this.btn_getConfig.TabIndex = 0;
            this.btn_getConfig.Text = "Get Config";
            this.btn_getConfig.UseVisualStyleBackColor = true;
            this.btn_getConfig.Click += new System.EventHandler(this.btn_getConfig_Click);
            // 
            // btn_setConfig
            // 
            this.btn_setConfig.Location = new System.Drawing.Point(12, 296);
            this.btn_setConfig.Name = "btn_setConfig";
            this.btn_setConfig.Size = new System.Drawing.Size(233, 38);
            this.btn_setConfig.TabIndex = 0;
            this.btn_setConfig.Text = "Set Config";
            this.btn_setConfig.UseVisualStyleBackColor = true;
            this.btn_setConfig.Click += new System.EventHandler(this.btn_setConfig_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 158);
            this.textBox1.TabIndex = 1;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(110, 220);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(135, 21);
            this.txb_name.TabIndex = 2;
            // 
            // nup_number
            // 
            this.nup_number.Location = new System.Drawing.Point(110, 247);
            this.nup_number.Name = "nup_number";
            this.nup_number.Size = new System.Drawing.Size(135, 21);
            this.nup_number.TabIndex = 3;
            // 
            // checkbx_set
            // 
            this.checkbx_set.AutoSize = true;
            this.checkbx_set.Location = new System.Drawing.Point(110, 274);
            this.checkbx_set.Name = "checkbx_set";
            this.checkbx_set.Size = new System.Drawing.Size(86, 16);
            this.checkbx_set.TabIndex = 4;
            this.checkbx_set.Text = "checkBox1";
            this.checkbx_set.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 354);
            this.Controls.Add(this.checkbx_set);
            this.Controls.Add(this.nup_number);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_setConfig);
            this.Controls.Add(this.btn_getConfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getConfig;
        private System.Windows.Forms.Button btn_setConfig;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.NumericUpDown nup_number;
        private System.Windows.Forms.CheckBox checkbx_set;
    }
}

