namespace 김주엽_과제_08_01
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
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_Main = new System.Windows.Forms.TextBox();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(485, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Cancel,
            this.menuItem_Copy,
            this.menuItem_Paste,
            this.menuItem_Cut,
            this.menuItem_SelectAll,
            this.menuItem_Change});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // menuItem_Cancel
            // 
            this.menuItem_Cancel.Name = "menuItem_Cancel";
            this.menuItem_Cancel.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Cancel.Text = "취소";
            this.menuItem_Cancel.Click += new System.EventHandler(this.menuItem_Cancel_Click);
            // 
            // menuItem_Copy
            // 
            this.menuItem_Copy.Name = "menuItem_Copy";
            this.menuItem_Copy.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Copy.Text = "복사";
            this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
            // 
            // menuItem_Paste
            // 
            this.menuItem_Paste.Name = "menuItem_Paste";
            this.menuItem_Paste.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Paste.Text = "붙이기";
            this.menuItem_Paste.Click += new System.EventHandler(this.menuItem_Paste_Click);
            // 
            // menuItem_Cut
            // 
            this.menuItem_Cut.Name = "menuItem_Cut";
            this.menuItem_Cut.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Cut.Text = "자르기";
            this.menuItem_Cut.Click += new System.EventHandler(this.menuItem_Cut_Click);
            // 
            // menuItem_SelectAll
            // 
            this.menuItem_SelectAll.Name = "menuItem_SelectAll";
            this.menuItem_SelectAll.Size = new System.Drawing.Size(180, 22);
            this.menuItem_SelectAll.Text = "모두선택";
            this.menuItem_SelectAll.Click += new System.EventHandler(this.menuItem_SelectAll_Click);
            // 
            // menuItem_Change
            // 
            this.menuItem_Change.Name = "menuItem_Change";
            this.menuItem_Change.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Change.Text = "찾아바꾸기";
            this.menuItem_Change.Click += new System.EventHandler(this.menuItem_Change_Click);
            // 
            // txtBox_Main
            // 
            this.txtBox_Main.Location = new System.Drawing.Point(12, 27);
            this.txtBox_Main.Multiline = true;
            this.txtBox_Main.Name = "txtBox_Main";
            this.txtBox_Main.Size = new System.Drawing.Size(461, 283);
            this.txtBox_Main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 322);
            this.Controls.Add(this.txtBox_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Cancel;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Change;
        public System.Windows.Forms.TextBox txtBox_Main;
    }
}

