namespace Dori34_LayoutEvent
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ucCMenu = new Dori34_LayoutEvent.ucColorMenu();
            this.ucPanelCenter2 = new Dori34_LayoutEvent.ucPanel();
            this.ucPanelCetner1 = new Dori34_LayoutEvent.ucPanel();
            this.ucPanelRight = new Dori34_LayoutEvent.ucPanel();
            this.ucPanelTop = new Dori34_LayoutEvent.ucPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucCMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucPanelCenter2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelCetner1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucPanelRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(342, 115);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(333, 218);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 108);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(672, 108);
            this.listBox1.TabIndex = 0;
            // 
            // ucCMenu
            // 
            this.ucCMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCMenu.Location = new System.Drawing.Point(0, 0);
            this.ucCMenu.Name = "ucCMenu";
            this.ucCMenu.Size = new System.Drawing.Size(120, 450);
            this.ucCMenu.TabIndex = 0;
            // 
            // ucPanelCenter2
            // 
            this.ucPanelCenter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucPanelCenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCenter2.Location = new System.Drawing.Point(3, 227);
            this.ucPanelCenter2.Name = "ucPanelCenter2";
            this.ucPanelCenter2.Size = new System.Drawing.Size(333, 106);
            this.ucPanelCenter2.TabIndex = 5;
            // 
            // ucPanelCetner1
            // 
            this.ucPanelCetner1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucPanelCetner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCetner1.Location = new System.Drawing.Point(3, 115);
            this.ucPanelCetner1.Name = "ucPanelCetner1";
            this.ucPanelCetner1.Size = new System.Drawing.Size(333, 106);
            this.ucPanelCetner1.TabIndex = 4;
            // 
            // ucPanelRight
            // 
            this.ucPanelRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelRight.Location = new System.Drawing.Point(0, 0);
            this.ucPanelRight.Name = "ucPanelRight";
            this.ucPanelRight.Size = new System.Drawing.Size(333, 218);
            this.ucPanelRight.TabIndex = 5;
            // 
            // ucPanelTop
            // 
            this.ucPanelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.ucPanelTop, 2);
            this.ucPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelTop.Location = new System.Drawing.Point(3, 3);
            this.ucPanelTop.Name = "ucPanelTop";
            this.ucPanelTop.Size = new System.Drawing.Size(672, 106);
            this.ucPanelTop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ucPanel ucPanelTop;
        private ucPanel ucPanelCetner1;
        private ucPanel ucPanelCenter2;
        private System.Windows.Forms.ListBox listBox1;
        private ucPanel ucPanelRight;
        private ucColorMenu ucCMenu;
    }
}

