namespace 김주엽_과제_07_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.menuItem_ShowDlg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Simple = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList_LIcon = new System.Windows.Forms.ImageList(this.components);
            this.imgList_SIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuItem_Input = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            this.subMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ShowDlg,
            this.menuItem_List});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(502, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // menuItem_ShowDlg
            // 
            this.menuItem_ShowDlg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Input,
            this.menuItem_Exit});
            this.menuItem_ShowDlg.Name = "menuItem_ShowDlg";
            this.menuItem_ShowDlg.Size = new System.Drawing.Size(67, 20);
            this.menuItem_ShowDlg.Text = "대화상자";
            // 
            // menuItem_List
            // 
            this.menuItem_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_LIcon,
            this.menuItem_SIcon,
            this.menuItem_Simple,
            this.menuItem_Detail});
            this.menuItem_List.Name = "menuItem_List";
            this.menuItem_List.Size = new System.Drawing.Size(43, 20);
            this.menuItem_List.Text = "보기";
            // 
            // menuItem_LIcon
            // 
            this.menuItem_LIcon.Name = "menuItem_LIcon";
            this.menuItem_LIcon.Size = new System.Drawing.Size(122, 22);
            this.menuItem_LIcon.Text = "큰아이콘";
            this.menuItem_LIcon.Click += new System.EventHandler(this.menuItem_LIcon_Click);
            // 
            // menuItem_SIcon
            // 
            this.menuItem_SIcon.Name = "menuItem_SIcon";
            this.menuItem_SIcon.Size = new System.Drawing.Size(122, 22);
            this.menuItem_SIcon.Text = "아이콘";
            this.menuItem_SIcon.Click += new System.EventHandler(this.menuItem_SIcon_Click);
            // 
            // menuItem_Simple
            // 
            this.menuItem_Simple.Name = "menuItem_Simple";
            this.menuItem_Simple.Size = new System.Drawing.Size(122, 22);
            this.menuItem_Simple.Text = "간단히";
            this.menuItem_Simple.Click += new System.EventHandler(this.menuItem_Simple_Click);
            // 
            // menuItem_Detail
            // 
            this.menuItem_Detail.Checked = true;
            this.menuItem_Detail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItem_Detail.Name = "menuItem_Detail";
            this.menuItem_Detail.Size = new System.Drawing.Size(122, 22);
            this.menuItem_Detail.Text = "자세히";
            this.menuItem_Detail.Click += new System.EventHandler(this.menuItem_Detail_Click);
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Main.ContextMenuStrip = this.subMenuStrip;
            this.listView_Main.HideSelection = false;
            this.listView_Main.LargeImageList = this.imgList_LIcon;
            this.listView_Main.Location = new System.Drawing.Point(12, 27);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(478, 342);
            this.listView_Main.SmallImageList = this.imgList_SIcon;
            this.listView_Main.TabIndex = 1;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "주소";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "전화번호";
            this.columnHeader3.Width = 160;
            // 
            // subMenuStrip
            // 
            this.subMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Remove});
            this.subMenuStrip.Name = "subMenuStrip";
            this.subMenuStrip.ShowImageMargin = false;
            this.subMenuStrip.Size = new System.Drawing.Size(74, 26);
            // 
            // menuItem_Remove
            // 
            this.menuItem_Remove.Name = "menuItem_Remove";
            this.menuItem_Remove.Size = new System.Drawing.Size(73, 22);
            this.menuItem_Remove.Text = "삭제";
            this.menuItem_Remove.Click += new System.EventHandler(this.menuItem_Remove_Click);
            // 
            // imgList_LIcon
            // 
            this.imgList_LIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_LIcon.ImageStream")));
            this.imgList_LIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_LIcon.Images.SetKeyName(0, "0.jpg");
            this.imgList_LIcon.Images.SetKeyName(1, "1.jpg");
            // 
            // imgList_SIcon
            // 
            this.imgList_SIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_SIcon.ImageStream")));
            this.imgList_SIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_SIcon.Images.SetKeyName(0, "0.jpg");
            this.imgList_SIcon.Images.SetKeyName(1, "1.jpg");
            // 
            // menuItem_Input
            // 
            this.menuItem_Input.Name = "menuItem_Input";
            this.menuItem_Input.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Input.Text = "입력";
            this.menuItem_Input.Click += new System.EventHandler(this.menuItem_Input_Click);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Exit.Text = "종료";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 381);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.subMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ShowDlg;
        private System.Windows.Forms.ToolStripMenuItem menuItem_List;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Simple;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Detail;
        private System.Windows.Forms.ImageList imgList_LIcon;
        private System.Windows.Forms.ImageList imgList_SIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ContextMenuStrip subMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Input;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Exit;
    }
}

