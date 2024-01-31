namespace 김주엽_과제_12_01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ShowDlg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_DB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Filter = new System.Windows.Forms.TextBox();
            this.btn_ShowResult = new System.Windows.Forms.Button();
            this.gridView_Result = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ShowDlg,
            this.menuItem_Exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menuItem_ShowDlg
            // 
            this.menuItem_ShowDlg.Name = "menuItem_ShowDlg";
            this.menuItem_ShowDlg.Size = new System.Drawing.Size(122, 22);
            this.menuItem_ShowDlg.Text = "대화상자";
            this.menuItem_ShowDlg.Click += new System.EventHandler(this.menuItem_ShowDlg_Click);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(122, 22);
            this.menuItem_Exit.Text = "종료";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // gridView_DB
            // 
            this.gridView_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_DB.Location = new System.Drawing.Point(12, 50);
            this.gridView_DB.Name = "gridView_DB";
            this.gridView_DB.RowTemplate.Height = 23;
            this.gridView_DB.Size = new System.Drawing.Size(575, 180);
            this.gridView_DB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "필터식";
            // 
            // txtBox_Filter
            // 
            this.txtBox_Filter.Location = new System.Drawing.Point(84, 256);
            this.txtBox_Filter.Name = "txtBox_Filter";
            this.txtBox_Filter.Size = new System.Drawing.Size(208, 21);
            this.txtBox_Filter.TabIndex = 4;
            // 
            // btn_ShowResult
            // 
            this.btn_ShowResult.Location = new System.Drawing.Point(309, 256);
            this.btn_ShowResult.Name = "btn_ShowResult";
            this.btn_ShowResult.Size = new System.Drawing.Size(65, 21);
            this.btn_ShowResult.TabIndex = 5;
            this.btn_ShowResult.Text = "결과";
            this.btn_ShowResult.UseVisualStyleBackColor = true;
            this.btn_ShowResult.Click += new System.EventHandler(this.btn_ShowResult_Click);
            // 
            // gridView_Result
            // 
            this.gridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_Result.Location = new System.Drawing.Point(12, 297);
            this.gridView_Result.Name = "gridView_Result";
            this.gridView_Result.RowTemplate.Height = 23;
            this.gridView_Result.Size = new System.Drawing.Size(575, 180);
            this.gridView_Result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 489);
            this.Controls.Add(this.gridView_Result);
            this.Controls.Add(this.btn_ShowResult);
            this.Controls.Add(this.txtBox_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView_DB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ShowDlg;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Filter;
        private System.Windows.Forms.Button btn_ShowResult;
        public System.Windows.Forms.DataGridView gridView_DB;
        public System.Windows.Forms.DataGridView gridView_Result;
    }
}

