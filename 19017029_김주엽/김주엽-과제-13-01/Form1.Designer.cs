namespace 김주엽_과제_13_01
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Read = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.그리기ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(363, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Read,
            this.menuItem_Save,
            this.menuItem_Exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menuItem_Read
            // 
            this.menuItem_Read.Name = "menuItem_Read";
            this.menuItem_Read.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Read.Text = "읽기";
            this.menuItem_Read.Click += new System.EventHandler(this.menuItem_Read_Click);
            // 
            // menuItem_Save
            // 
            this.menuItem_Save.Name = "menuItem_Save";
            this.menuItem_Save.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Save.Text = "저장";
            this.menuItem_Save.Click += new System.EventHandler(this.menuItem_Save_Click);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Exit.Text = "종료";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // 그리기ToolStripMenuItem
            // 
            this.그리기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Line,
            this.menuItem_Rectangle,
            this.menuItem_Circle});
            this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
            this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.그리기ToolStripMenuItem.Text = "그리기";
            // 
            // menuItem_Line
            // 
            this.menuItem_Line.Name = "menuItem_Line";
            this.menuItem_Line.Size = new System.Drawing.Size(110, 22);
            this.menuItem_Line.Text = "선";
            this.menuItem_Line.Click += new System.EventHandler(this.menuItem_Line_Click);
            // 
            // menuItem_Rectangle
            // 
            this.menuItem_Rectangle.Name = "menuItem_Rectangle";
            this.menuItem_Rectangle.Size = new System.Drawing.Size(110, 22);
            this.menuItem_Rectangle.Text = "사각형";
            this.menuItem_Rectangle.Click += new System.EventHandler(this.menuItem_Rectangle_Click);
            // 
            // menuItem_Circle
            // 
            this.menuItem_Circle.Name = "menuItem_Circle";
            this.menuItem_Circle.Size = new System.Drawing.Size(110, 22);
            this.menuItem_Circle.Text = "원";
            this.menuItem_Circle.Click += new System.EventHandler(this.menuItem_Circle_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "items.bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 362);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Read;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Line;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Circle;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

