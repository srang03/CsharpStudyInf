﻿namespace Dori39_User32.dll
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
            this.lbx_Test = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbx_Test
            // 
            this.lbx_Test.FormattingEnabled = true;
            this.lbx_Test.ItemHeight = 12;
            this.lbx_Test.Location = new System.Drawing.Point(12, 12);
            this.lbx_Test.Name = "lbx_Test";
            this.lbx_Test.Size = new System.Drawing.Size(462, 388);
            this.lbx_Test.TabIndex = 0;
            this.lbx_Test.SelectedIndexChanged += new System.EventHandler(this.lbx_Test_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 415);
            this.Controls.Add(this.lbx_Test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Test;
    }
}

