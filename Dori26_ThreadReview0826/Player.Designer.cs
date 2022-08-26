namespace Dori26_ThreadReview0826
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(12, 9);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(79, 12);
            this.lbl_playerName.TabIndex = 0;
            this.lbl_playerName.Text = "Player Name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "진행상황 : 0%";
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(101, 5);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "정지";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 60);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pause;
    }
}