namespace Dori34_LayoutEvent
{
    partial class ucPanel
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_ucPancel = new System.Windows.Forms.Panel();
            this.lbl_text = new System.Windows.Forms.Label();
            this.panel_ucPancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucPancel
            // 
            this.panel_ucPancel.Controls.Add(this.lbl_text);
            this.panel_ucPancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ucPancel.Location = new System.Drawing.Point(0, 0);
            this.panel_ucPancel.Name = "panel_ucPancel";
            this.panel_ucPancel.Size = new System.Drawing.Size(150, 150);
            this.panel_ucPancel.TabIndex = 0;
            this.panel_ucPancel.SizeChanged += new System.EventHandler(this.panel_ucPancel_SizeChanged);
            // 
            // lbl_text
            // 
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(150, 150);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "label1";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_ucPancel);
            this.Name = "ucPanel";
            this.panel_ucPancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucPancel;
        private System.Windows.Forms.Label lbl_text;
    }
}
