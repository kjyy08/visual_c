namespace FinalTestPrac
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
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그림ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_first = new System.Windows.Forms.TextBox();
            this.txtBox_Sec = new System.Windows.Forms.TextBox();
            this.btn_Func1 = new System.Windows.Forms.Button();
            this.btn_Func2 = new System.Windows.Forms.Button();
            this.btn_Func3 = new System.Windows.Forms.Button();
            this.listBox_Dirs = new System.Windows.Forms.ListBox();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다시실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Main = new System.Windows.Forms.DataGridView();
            this.gridView_Result = new System.Windows.Forms.DataGridView();
            this.btn_Func4 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집ToolStripMenuItem,
            this.그림ToolStripMenuItem,
            this.수정ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(549, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.열기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 그림ToolStripMenuItem
            // 
            this.그림ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선ToolStripMenuItem,
            this.사각형ToolStripMenuItem,
            this.원ToolStripMenuItem});
            this.그림ToolStripMenuItem.Name = "그림ToolStripMenuItem";
            this.그림ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.그림ToolStripMenuItem.Text = "그림";
            // 
            // 선ToolStripMenuItem
            // 
            this.선ToolStripMenuItem.Name = "선ToolStripMenuItem";
            this.선ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.선ToolStripMenuItem.Text = "선";
            this.선ToolStripMenuItem.Click += new System.EventHandler(this.선ToolStripMenuItem_Click);
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.사각형ToolStripMenuItem.Text = "사각형";
            this.사각형ToolStripMenuItem.Click += new System.EventHandler(this.사각형ToolStripMenuItem_Click);
            // 
            // 원ToolStripMenuItem
            // 
            this.원ToolStripMenuItem.Name = "원ToolStripMenuItem";
            this.원ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.원ToolStripMenuItem.Text = "원";
            this.원ToolStripMenuItem.Click += new System.EventHandler(this.원ToolStripMenuItem_Click);
            // 
            // txtBox_first
            // 
            this.txtBox_first.Location = new System.Drawing.Point(12, 399);
            this.txtBox_first.Name = "txtBox_first";
            this.txtBox_first.Size = new System.Drawing.Size(100, 21);
            this.txtBox_first.TabIndex = 2;
            // 
            // txtBox_Sec
            // 
            this.txtBox_Sec.Location = new System.Drawing.Point(129, 399);
            this.txtBox_Sec.Name = "txtBox_Sec";
            this.txtBox_Sec.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Sec.TabIndex = 3;
            // 
            // btn_Func1
            // 
            this.btn_Func1.Location = new System.Drawing.Point(257, 397);
            this.btn_Func1.Name = "btn_Func1";
            this.btn_Func1.Size = new System.Drawing.Size(75, 23);
            this.btn_Func1.TabIndex = 4;
            this.btn_Func1.Text = "기능1";
            this.btn_Func1.UseVisualStyleBackColor = true;
            this.btn_Func1.Click += new System.EventHandler(this.btn_Func1_Click);
            // 
            // btn_Func2
            // 
            this.btn_Func2.Location = new System.Drawing.Point(338, 397);
            this.btn_Func2.Name = "btn_Func2";
            this.btn_Func2.Size = new System.Drawing.Size(75, 23);
            this.btn_Func2.TabIndex = 5;
            this.btn_Func2.Text = "기능2";
            this.btn_Func2.UseVisualStyleBackColor = true;
            this.btn_Func2.Click += new System.EventHandler(this.btn_Func2_Click);
            // 
            // btn_Func3
            // 
            this.btn_Func3.Location = new System.Drawing.Point(419, 397);
            this.btn_Func3.Name = "btn_Func3";
            this.btn_Func3.Size = new System.Drawing.Size(75, 23);
            this.btn_Func3.TabIndex = 6;
            this.btn_Func3.Text = "기능3";
            this.btn_Func3.UseVisualStyleBackColor = true;
            this.btn_Func3.Click += new System.EventHandler(this.btn_Func3_Click);
            // 
            // listBox_Dirs
            // 
            this.listBox_Dirs.FormattingEnabled = true;
            this.listBox_Dirs.ItemHeight = 12;
            this.listBox_Dirs.Location = new System.Drawing.Point(12, 277);
            this.listBox_Dirs.Name = "listBox_Dirs";
            this.listBox_Dirs.Size = new System.Drawing.Size(217, 76);
            this.listBox_Dirs.TabIndex = 7;
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.ItemHeight = 12;
            this.listBox_Files.Location = new System.Drawing.Point(277, 277);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(217, 76);
            this.listBox_Files.TabIndex = 8;
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.다시실행ToolStripMenuItem});
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.수정ToolStripMenuItem.Text = "수정";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.실행취소ToolStripMenuItem.Text = "실행취소";
            this.실행취소ToolStripMenuItem.Click += new System.EventHandler(this.실행취소ToolStripMenuItem_Click);
            // 
            // 다시실행ToolStripMenuItem
            // 
            this.다시실행ToolStripMenuItem.Name = "다시실행ToolStripMenuItem";
            this.다시실행ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.다시실행ToolStripMenuItem.Text = "다시실행";
            this.다시실행ToolStripMenuItem.Click += new System.EventHandler(this.다시실행ToolStripMenuItem_Click);
            // 
            // gridView_Main
            // 
            this.gridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_Main.Location = new System.Drawing.Point(12, 93);
            this.gridView_Main.Name = "gridView_Main";
            this.gridView_Main.RowTemplate.Height = 23;
            this.gridView_Main.Size = new System.Drawing.Size(217, 157);
            this.gridView_Main.TabIndex = 9;
            // 
            // gridView_Result
            // 
            this.gridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_Result.Location = new System.Drawing.Point(277, 93);
            this.gridView_Result.Name = "gridView_Result";
            this.gridView_Result.RowTemplate.Height = 23;
            this.gridView_Result.Size = new System.Drawing.Size(217, 157);
            this.gridView_Result.TabIndex = 10;
            // 
            // btn_Func4
            // 
            this.btn_Func4.Location = new System.Drawing.Point(257, 426);
            this.btn_Func4.Name = "btn_Func4";
            this.btn_Func4.Size = new System.Drawing.Size(75, 23);
            this.btn_Func4.TabIndex = 11;
            this.btn_Func4.Text = "기능4";
            this.btn_Func4.UseVisualStyleBackColor = true;
            this.btn_Func4.Click += new System.EventHandler(this.btn_Func4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btn_Func4);
            this.Controls.Add(this.gridView_Result);
            this.Controls.Add(this.gridView_Main);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.listBox_Dirs);
            this.Controls.Add(this.btn_Func3);
            this.Controls.Add(this.btn_Func2);
            this.Controls.Add(this.btn_Func1);
            this.Controls.Add(this.txtBox_Sec);
            this.Controls.Add(this.txtBox_first);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox_first;
        private System.Windows.Forms.TextBox txtBox_Sec;
        private System.Windows.Forms.Button btn_Func1;
        private System.Windows.Forms.Button btn_Func2;
        private System.Windows.Forms.Button btn_Func3;
        private System.Windows.Forms.ListBox listBox_Dirs;
        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그림ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다시실행ToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridView_Main;
        private System.Windows.Forms.DataGridView gridView_Result;
        private System.Windows.Forms.Button btn_Func4;
    }
}

