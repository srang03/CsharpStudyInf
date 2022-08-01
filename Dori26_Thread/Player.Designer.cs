namespace Dori26_Thread
{
    partial class Player
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
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_progressBar = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(12, 9);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(75, 12);
            this.lbl_playerName.TabIndex = 0;
            this.lbl_playerName.Text = "PlayerName";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // lbl_progressBar
            // 
            this.lbl_progressBar.AutoSize = true;
            this.lbl_progressBar.Location = new System.Drawing.Point(290, 34);
            this.lbl_progressBar.Name = "lbl_progressBar";
            this.lbl_progressBar.Size = new System.Drawing.Size(113, 12);
            this.lbl_progressBar.TabIndex = 0;
            this.lbl_progressBar.Text = "진행 상황 표시 : 0%";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(420, 49);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 90);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_progressBar);
            this.Controls.Add(this.lbl_playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_progressBar;
        private System.Windows.Forms.Button btn_stop;
    }
}