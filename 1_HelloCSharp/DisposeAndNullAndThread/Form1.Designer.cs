namespace DisposeAndNullAndThread
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_storageConnection = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 88);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(134, 47);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(161, 88);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(134, 47);
            this.btn_disconnect.TabIndex = 0;
            this.btn_disconnect.Text = "연결 해제";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "상태: ";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(55, 14);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(11, 12);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "-";
            // 
            // lbl_log
            // 
            this.lbl_log.FormattingEnabled = true;
            this.lbl_log.ItemHeight = 12;
            this.lbl_log.Location = new System.Drawing.Point(12, 198);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(288, 172);
            this.lbl_log.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(306, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 358);
            this.panel1.TabIndex = 4;
            // 
            // btn_storageConnection
            // 
            this.btn_storageConnection.Location = new System.Drawing.Point(14, 141);
            this.btn_storageConnection.Name = "btn_storageConnection";
            this.btn_storageConnection.Size = new System.Drawing.Size(281, 51);
            this.btn_storageConnection.TabIndex = 5;
            this.btn_storageConnection.Text = "StorageConnection";
            this.btn_storageConnection.UseVisualStyleBackColor = true;
            this.btn_storageConnection.Click += new System.EventHandler(this.btn_storageConnection_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(14, 40);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(281, 42);
            this.btn_init.TabIndex = 6;
            this.btn_init.Text = "초기 대기";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 382);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_storageConnection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.ListBox lbl_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_storageConnection;
        private System.Windows.Forms.Button btn_init;
    }
}

