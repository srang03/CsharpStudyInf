namespace Dori24_DelegateReview
{
    partial class frmPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_make = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_make
            // 
            this.lbx_make.FormattingEnabled = true;
            this.lbx_make.ItemHeight = 12;
            this.lbx_make.Location = new System.Drawing.Point(12, 12);
            this.lbx_make.Name = "lbx_make";
            this.lbx_make.Size = new System.Drawing.Size(300, 148);
            this.lbx_make.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 166);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(300, 47);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "창닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 220);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbx_make);
            this.Name = "frmPopup";
            this.Text = "frmPopup";
            this.Load += new System.EventHandler(this.frmPopup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_make;
        private System.Windows.Forms.Button btn_close;
    }
}