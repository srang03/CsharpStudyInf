namespace Dori16_StreamReader
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
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_number = new System.Windows.Forms.NumericUpDown();
            this.checkbx_value = new System.Windows.Forms.CheckBox();
            this.txb_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getConfig = new System.Windows.Forms.Button();
            this.btn_setConfig = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(12, 12);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(146, 23);
            this.btn_get.TabIndex = 0;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(174, 12);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(146, 23);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nud_number);
            this.panel1.Controls.Add(this.checkbx_value);
            this.panel1.Controls.Add(this.txb_text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 146);
            this.panel1.TabIndex = 2;
            // 
            // nud_number
            // 
            this.nud_number.Location = new System.Drawing.Point(96, 104);
            this.nud_number.Name = "nud_number";
            this.nud_number.Size = new System.Drawing.Size(120, 21);
            this.nud_number.TabIndex = 3;
            // 
            // checkbx_value
            // 
            this.checkbx_value.AutoSize = true;
            this.checkbx_value.Location = new System.Drawing.Point(96, 72);
            this.checkbx_value.Name = "checkbx_value";
            this.checkbx_value.Size = new System.Drawing.Size(86, 16);
            this.checkbx_value.TabIndex = 2;
            this.checkbx_value.Text = "checkBox1";
            this.checkbx_value.UseVisualStyleBackColor = true;
            // 
            // txb_text
            // 
            this.txb_text.Location = new System.Drawing.Point(96, 37);
            this.txb_text.Name = "txb_text";
            this.txb_text.Size = new System.Drawing.Size(120, 21);
            this.txb_text.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "CheckBox :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config";
            // 
            // btn_getConfig
            // 
            this.btn_getConfig.Location = new System.Drawing.Point(12, 335);
            this.btn_getConfig.Name = "btn_getConfig";
            this.btn_getConfig.Size = new System.Drawing.Size(146, 23);
            this.btn_getConfig.TabIndex = 0;
            this.btn_getConfig.Text = "Get Config";
            this.btn_getConfig.UseVisualStyleBackColor = true;
            this.btn_getConfig.Click += new System.EventHandler(this.btn_getConfig_Click);
            // 
            // btn_setConfig
            // 
            this.btn_setConfig.Location = new System.Drawing.Point(165, 335);
            this.btn_setConfig.Name = "btn_setConfig";
            this.btn_setConfig.Size = new System.Drawing.Size(146, 23);
            this.btn_setConfig.TabIndex = 0;
            this.btn_setConfig.Text = "Set Config";
            this.btn_setConfig.UseVisualStyleBackColor = true;
            this.btn_setConfig.Click += new System.EventHandler(this.btn_setConfig_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txb_result
            // 
            this.txb_result.BackColor = System.Drawing.Color.Gray;
            this.txb_result.Enabled = false;
            this.txb_result.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb_result.ForeColor = System.Drawing.Color.White;
            this.txb_result.Location = new System.Drawing.Point(12, 41);
            this.txb_result.Multiline = true;
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(299, 124);
            this.txb_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 370);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_setConfig);
            this.Controls.Add(this.btn_getConfig);
            this.Controls.Add(this.btn_get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_number;
        private System.Windows.Forms.CheckBox checkbx_value;
        private System.Windows.Forms.TextBox txb_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getConfig;
        private System.Windows.Forms.Button btn_setConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txb_result;
    }
}

