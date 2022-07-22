namespace Dori10_while
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
            this.txb_result = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.txb_select = new System.Windows.Forms.TextBox();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_selectResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_result
            // 
            this.txb_result.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txb_result.Enabled = false;
            this.txb_result.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb_result.ForeColor = System.Drawing.Color.White;
            this.txb_result.Location = new System.Drawing.Point(12, 15);
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(225, 26);
            this.txb_result.TabIndex = 0;
            this.txb_result.Text = "0, 0, 0, 0, 0, 0,";
            this.txb_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(243, 12);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 29);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txb_select
            // 
            this.txb_select.Location = new System.Drawing.Point(10, 43);
            this.txb_select.Name = "txb_select";
            this.txb_select.Size = new System.Drawing.Size(92, 21);
            this.txb_select.TabIndex = 2;
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 12;
            this.lbx_list.Location = new System.Drawing.Point(12, 51);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(306, 160);
            this.lbx_list.TabIndex = 3;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(115, 41);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_selectResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Controls.Add(this.txb_select);
            this.panel1.Location = new System.Drawing.Point(12, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 139);
            this.panel1.TabIndex = 5;
            // 
            // lbl_selectResult
            // 
            this.lbl_selectResult.AutoSize = true;
            this.lbl_selectResult.Location = new System.Drawing.Point(8, 95);
            this.lbl_selectResult.Name = "lbl_selectResult";
            this.lbl_selectResult.Size = new System.Drawing.Size(38, 12);
            this.lbl_selectResult.TabIndex = 5;
            this.lbl_selectResult.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1~100 안의 숫자를 입력해주세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 362);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txb_select;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_selectResult;
    }
}

