namespace 김주엽_과제_09_01
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
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btn_Open = new System.Windows.Forms.Button();
            this.ctxtMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.ctxtMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Main.ContextMenuStrip = this.ctxtMenuStrip;
            this.listView_Main.HideSelection = false;
            this.listView_Main.LargeImageList = this.imgList;
            this.listView_Main.Location = new System.Drawing.Point(12, 12);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(586, 464);
            this.listView_Main.SmallImageList = this.imgList;
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.DoubleClick += new System.EventHandler(this.listView_Main_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "속성";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "크기";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "생성시간";
            this.columnHeader4.Width = 170;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "0.jpg");
            this.imgList.Images.SetKeyName(1, "1.jpg");
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(274, 496);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "열기";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // ctxtMenuStrip
            // 
            this.ctxtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Copy,
            this.menuItem_Paste,
            this.menuItem_Delete});
            this.ctxtMenuStrip.Name = "ctxtMenuStrip";
            this.ctxtMenuStrip.Size = new System.Drawing.Size(123, 70);
            // 
            // menuItem_Copy
            // 
            this.menuItem_Copy.Name = "menuItem_Copy";
            this.menuItem_Copy.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Copy.Text = "복사하기";
            this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
            // 
            // menuItem_Paste
            // 
            this.menuItem_Paste.Name = "menuItem_Paste";
            this.menuItem_Paste.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Paste.Text = "붙여넣기";
            this.menuItem_Paste.Click += new System.EventHandler(this.menuItem_Paste_Click);
            // 
            // menuItem_Delete
            // 
            this.menuItem_Delete.Name = "menuItem_Delete";
            this.menuItem_Delete.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Delete.Text = "지우기";
            this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 531);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.listView_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctxtMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Delete;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.OpenFileDialog fileDlg;
    }
}

