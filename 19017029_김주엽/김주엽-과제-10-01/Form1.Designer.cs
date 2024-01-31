namespace 김주엽_과제_10_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Major = new System.Windows.Forms.TextBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Read = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(311, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "학번";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "학과";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(80, 61);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(211, 21);
            this.txtBox_Name.TabIndex = 4;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Location = new System.Drawing.Point(80, 120);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(211, 21);
            this.txtBox_ID.TabIndex = 5;
            // 
            // txtBox_Major
            // 
            this.txtBox_Major.Location = new System.Drawing.Point(80, 177);
            this.txtBox_Major.Name = "txtBox_Major";
            this.txtBox_Major.Size = new System.Drawing.Size(211, 21);
            this.txtBox_Major.TabIndex = 6;
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(32, 248);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(49, 23);
            this.btn_Input.TabIndex = 7;
            this.btn_Input.Text = "입력";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(137, 247);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(49, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(240, 247);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(49, 23);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "다음";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
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
            this.menuItem_Read.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Read.Text = "읽기";
            this.menuItem_Read.Click += new System.EventHandler(this.menuItem_Read_Click);
            // 
            // menuItem_Save
            // 
            this.menuItem_Save.Name = "menuItem_Save";
            this.menuItem_Save.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Save.Text = "저장";
            this.menuItem_Save.Click += new System.EventHandler(this.menuItem_Save_Click);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Exit.Text = "종료";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "Items.bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 306);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.txtBox_Major);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_Major;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}

