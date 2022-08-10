namespace Dori28_Exception2
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.tb_alpha = new System.Windows.Forms.TrackBar();
            this.pColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_color = new System.Windows.Forms.ListBox();
            this.btn_colorSave = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cdl_colors = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_alpha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_text);
            this.groupBox1.Controls.Add(this.tb_alpha);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(55, 111);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(11, 12);
            this.lbl_text.TabIndex = 3;
            this.lbl_text.Text = "-";
            // 
            // tb_alpha
            // 
            this.tb_alpha.Location = new System.Drawing.Point(57, 55);
            this.tb_alpha.Maximum = 255;
            this.tb_alpha.Name = "tb_alpha";
            this.tb_alpha.Size = new System.Drawing.Size(175, 45);
            this.tb_alpha.TabIndex = 2;
            this.tb_alpha.Value = 255;
            this.tb_alpha.Scroll += new System.EventHandler(this.tb_alpha_Scroll);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(57, 30);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(18, 19);
            this.pColor.TabIndex = 1;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alpha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // lbx_color
            // 
            this.lbx_color.FormattingEnabled = true;
            this.lbx_color.ItemHeight = 12;
            this.lbx_color.Location = new System.Drawing.Point(2, 187);
            this.lbx_color.Name = "lbx_color";
            this.lbx_color.Size = new System.Drawing.Size(246, 160);
            this.lbx_color.TabIndex = 1;
            this.lbx_color.SelectedIndexChanged += new System.EventHandler(this.lbx_color_SelectedIndexChanged);
            // 
            // btn_colorSave
            // 
            this.btn_colorSave.Location = new System.Drawing.Point(90, 151);
            this.btn_colorSave.Name = "btn_colorSave";
            this.btn_colorSave.Size = new System.Drawing.Size(75, 23);
            this.btn_colorSave.TabIndex = 2;
            this.btn_colorSave.Text = "Save";
            this.btn_colorSave.UseVisualStyleBackColor = true;
            this.btn_colorSave.Click += new System.EventHandler(this.btn_colorSave_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(171, 151);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(252, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 335);
            this.panel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(232, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(86, 78);
            this.panel6.TabIndex = 1;
            this.panel6.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(218, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 129);
            this.panel5.TabIndex = 2;
            this.panel5.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(82, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 63);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(82, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 129);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(82, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 78);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 356);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_colorSave);
            this.Controls.Add(this.lbx_color);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_alpha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TrackBar tb_alpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_color;
        private System.Windows.Forms.Button btn_colorSave;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog cdl_colors;
    }
}

