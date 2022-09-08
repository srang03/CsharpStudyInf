namespace AsyncAwaitExcerise0908
{
    partial class ListUp
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
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.gbx_list = new System.Windows.Forms.GroupBox();
            this.gbx_anomolyList = new System.Windows.Forms.GroupBox();
            this.lbx_anomolyList = new System.Windows.Forms.ListBox();
            this.lbl_listCount = new System.Windows.Forms.Label();
            this.lbl_listAnomoly = new System.Windows.Forms.Label();
            this.gbx_list.SuspendLayout();
            this.gbx_anomolyList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 12;
            this.lbx_list.Location = new System.Drawing.Point(6, 20);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(360, 328);
            this.lbx_list.TabIndex = 0;
            // 
            // gbx_list
            // 
            this.gbx_list.Controls.Add(this.lbl_listCount);
            this.gbx_list.Controls.Add(this.lbx_list);
            this.gbx_list.Location = new System.Drawing.Point(12, 12);
            this.gbx_list.Name = "gbx_list";
            this.gbx_list.Size = new System.Drawing.Size(372, 408);
            this.gbx_list.TabIndex = 1;
            this.gbx_list.TabStop = false;
            this.gbx_list.Text = "List";
            // 
            // gbx_anomolyList
            // 
            this.gbx_anomolyList.Controls.Add(this.lbl_listAnomoly);
            this.gbx_anomolyList.Controls.Add(this.lbx_anomolyList);
            this.gbx_anomolyList.Location = new System.Drawing.Point(390, 12);
            this.gbx_anomolyList.Name = "gbx_anomolyList";
            this.gbx_anomolyList.Size = new System.Drawing.Size(372, 408);
            this.gbx_anomolyList.TabIndex = 1;
            this.gbx_anomolyList.TabStop = false;
            this.gbx_anomolyList.Text = "Anomoly List";
            // 
            // lbx_anomolyList
            // 
            this.lbx_anomolyList.FormattingEnabled = true;
            this.lbx_anomolyList.ItemHeight = 12;
            this.lbx_anomolyList.Location = new System.Drawing.Point(6, 20);
            this.lbx_anomolyList.Name = "lbx_anomolyList";
            this.lbx_anomolyList.Size = new System.Drawing.Size(360, 328);
            this.lbx_anomolyList.TabIndex = 0;
            // 
            // lbl_listCount
            // 
            this.lbl_listCount.AutoSize = true;
            this.lbl_listCount.Location = new System.Drawing.Point(6, 351);
            this.lbl_listCount.Name = "lbl_listCount";
            this.lbl_listCount.Size = new System.Drawing.Size(11, 12);
            this.lbl_listCount.TabIndex = 1;
            this.lbl_listCount.Text = "-";
            // 
            // lbl_listAnomoly
            // 
            this.lbl_listAnomoly.AutoSize = true;
            this.lbl_listAnomoly.Location = new System.Drawing.Point(6, 351);
            this.lbl_listAnomoly.Name = "lbl_listAnomoly";
            this.lbl_listAnomoly.Size = new System.Drawing.Size(11, 12);
            this.lbl_listAnomoly.TabIndex = 1;
            this.lbl_listAnomoly.Text = "-";
            // 
            // ListUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 427);
            this.Controls.Add(this.gbx_anomolyList);
            this.Controls.Add(this.gbx_list);
            this.Name = "ListUp";
            this.Text = "ListUp";
            this.gbx_list.ResumeLayout(false);
            this.gbx_list.PerformLayout();
            this.gbx_anomolyList.ResumeLayout(false);
            this.gbx_anomolyList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.GroupBox gbx_list;
        private System.Windows.Forms.GroupBox gbx_anomolyList;
        private System.Windows.Forms.ListBox lbx_anomolyList;
        private System.Windows.Forms.Label lbl_listCount;
        private System.Windows.Forms.Label lbl_listAnomoly;
    }
}