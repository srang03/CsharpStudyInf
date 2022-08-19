namespace Dori41_MenuControl
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공백제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.공백제거ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.클립보드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.programInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // 공백제거ToolStripMenuItem
            // 
            this.공백제거ToolStripMenuItem.Name = "공백제거ToolStripMenuItem";
            this.공백제거ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.공백제거ToolStripMenuItem.Text = "공백 제거";
            this.공백제거ToolStripMenuItem.Click += new System.EventHandler(this.공백제거ToolStripMenuItem_Click);
            // 
            // 모두삭제ToolStripMenuItem
            // 
            this.모두삭제ToolStripMenuItem.Name = "모두삭제ToolStripMenuItem";
            this.모두삭제ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모두삭제ToolStripMenuItem.Text = "모두 삭제";
            this.모두삭제ToolStripMenuItem.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem_Click);
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.programInfoToolStripMenuItem.Text = "Program Info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 220);
            this.listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem1,
            this.클립보드ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // 공백제거ToolStripMenuItem1
            // 
            this.공백제거ToolStripMenuItem1.Name = "공백제거ToolStripMenuItem1";
            this.공백제거ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.공백제거ToolStripMenuItem1.Text = "공백제거";
            this.공백제거ToolStripMenuItem1.Click += new System.EventHandler(this.공백제거ToolStripMenuItem1_Click);
            // 
            // 클립보드ToolStripMenuItem
            // 
            this.클립보드ToolStripMenuItem.Name = "클립보드ToolStripMenuItem";
            this.클립보드ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.클립보드ToolStripMenuItem.Text = "클립보드";
            this.클립보드ToolStripMenuItem.Click += new System.EventHandler(this.클립보드ToolStripMenuItem_Click);
            // 
            // 모두삭제ToolStripMenuItem1
            // 
            this.모두삭제ToolStripMenuItem1.Name = "모두삭제ToolStripMenuItem1";
            this.모두삭제ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.모두삭제ToolStripMenuItem1.Text = "모두삭제";
            this.모두삭제ToolStripMenuItem1.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem1_Click);
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(12, 253);
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(351, 21);
            this.txb_input.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(369, 253);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 301);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInfoToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 클립보드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem1;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.Button btn_add;
    }
}

