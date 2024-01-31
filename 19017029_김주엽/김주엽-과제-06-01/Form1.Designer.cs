namespace 김주엽_과제_06_01
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
            this.menu_ListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cTxtMenuItem_Input = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_List = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_LIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_SIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_Simple = new System.Windows.Forms.ToolStripMenuItem();
            this.cTxtMenuItem_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.toolStrip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Input = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Simple = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList_LIcon = new System.Windows.Forms.ImageList(this.components);
            this.imgList_SIcon = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_Major = new System.Windows.Forms.ComboBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menu_ListView.SuspendLayout();
            this.menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_ListView
            // 
            this.menu_ListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTxtMenuItem_Input,
            this.cTxtMenuItem_Remove,
            this.cTxtMenuItem_Sort,
            this.cTxtMenuItem_List});
            this.menu_ListView.Name = "menu_ListView";
            this.menu_ListView.Size = new System.Drawing.Size(181, 114);
            // 
            // cTxtMenuItem_Input
            // 
            this.cTxtMenuItem_Input.Name = "cTxtMenuItem_Input";
            this.cTxtMenuItem_Input.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_Input.Text = "입력";
            this.cTxtMenuItem_Input.Click += new System.EventHandler(this.cTxtMenuItem_Input_Click);
            // 
            // cTxtMenuItem_Remove
            // 
            this.cTxtMenuItem_Remove.Name = "cTxtMenuItem_Remove";
            this.cTxtMenuItem_Remove.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_Remove.Text = "삭제";
            this.cTxtMenuItem_Remove.Click += new System.EventHandler(this.cTxtMenuItem_Remove_Click);
            // 
            // cTxtMenuItem_Sort
            // 
            this.cTxtMenuItem_Sort.Name = "cTxtMenuItem_Sort";
            this.cTxtMenuItem_Sort.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_Sort.Text = "정렬";
            this.cTxtMenuItem_Sort.Click += new System.EventHandler(this.cTxtMenuItem_Sort_Click);
            // 
            // cTxtMenuItem_List
            // 
            this.cTxtMenuItem_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTxtMenuItem_LIcon,
            this.cTxtMenuItem_SIcon,
            this.cTxtMenuItem_Simple,
            this.cTxtMenuItem_Detail});
            this.cTxtMenuItem_List.Name = "cTxtMenuItem_List";
            this.cTxtMenuItem_List.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_List.Text = "보기";
            // 
            // cTxtMenuItem_LIcon
            // 
            this.cTxtMenuItem_LIcon.Name = "cTxtMenuItem_LIcon";
            this.cTxtMenuItem_LIcon.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_LIcon.Text = "큰아이콘";
            this.cTxtMenuItem_LIcon.Click += new System.EventHandler(this.cTxtMenuItem_LIcon_Click);
            // 
            // cTxtMenuItem_SIcon
            // 
            this.cTxtMenuItem_SIcon.Name = "cTxtMenuItem_SIcon";
            this.cTxtMenuItem_SIcon.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_SIcon.Text = "아이콘";
            this.cTxtMenuItem_SIcon.Click += new System.EventHandler(this.cTxtMenuItem_SIcon_Click);
            // 
            // cTxtMenuItem_Simple
            // 
            this.cTxtMenuItem_Simple.Name = "cTxtMenuItem_Simple";
            this.cTxtMenuItem_Simple.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_Simple.Text = "간단히";
            this.cTxtMenuItem_Simple.Click += new System.EventHandler(this.cTxtMenuItem_Simple_Click);
            // 
            // cTxtMenuItem_Detail
            // 
            this.cTxtMenuItem_Detail.Name = "cTxtMenuItem_Detail";
            this.cTxtMenuItem_Detail.Size = new System.Drawing.Size(180, 22);
            this.cTxtMenuItem_Detail.Text = "자세히";
            this.cTxtMenuItem_Detail.Click += new System.EventHandler(this.cTxtMenuItem_Detail_Click);
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Menu});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(735, 24);
            this.menu_Main.TabIndex = 1;
            this.menu_Main.Text = "menuStrip1";
            // 
            // toolStrip_Menu
            // 
            this.toolStrip_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Input,
            this.menuItem_Remove,
            this.menuItem_Sort,
            this.menuItem_List});
            this.toolStrip_Menu.Name = "toolStrip_Menu";
            this.toolStrip_Menu.Size = new System.Drawing.Size(43, 20);
            this.toolStrip_Menu.Text = "메뉴";
            // 
            // menuItem_Input
            // 
            this.menuItem_Input.Name = "menuItem_Input";
            this.menuItem_Input.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Input.Text = "입력";
            this.menuItem_Input.Click += new System.EventHandler(this.menuItem_Input_Click);
            // 
            // menuItem_Remove
            // 
            this.menuItem_Remove.Name = "menuItem_Remove";
            this.menuItem_Remove.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Remove.Text = "삭제";
            this.menuItem_Remove.Click += new System.EventHandler(this.menuItem_Remove_Click);
            // 
            // menuItem_Sort
            // 
            this.menuItem_Sort.Name = "menuItem_Sort";
            this.menuItem_Sort.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Sort.Text = "정렬";
            this.menuItem_Sort.Click += new System.EventHandler(this.menuItem_Sort_Click);
            // 
            // menuItem_List
            // 
            this.menuItem_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_LIcon,
            this.menuItem_SIcon,
            this.menuItem_Simple,
            this.menuItem_Detail});
            this.menuItem_List.Name = "menuItem_List";
            this.menuItem_List.Size = new System.Drawing.Size(180, 22);
            this.menuItem_List.Text = "보기";
            // 
            // menuItem_LIcon
            // 
            this.menuItem_LIcon.Name = "menuItem_LIcon";
            this.menuItem_LIcon.Size = new System.Drawing.Size(180, 22);
            this.menuItem_LIcon.Text = "큰아이콘";
            this.menuItem_LIcon.Click += new System.EventHandler(this.menuItem_LIcon_Click);
            // 
            // menuItem_SIcon
            // 
            this.menuItem_SIcon.Name = "menuItem_SIcon";
            this.menuItem_SIcon.Size = new System.Drawing.Size(180, 22);
            this.menuItem_SIcon.Text = "아이콘";
            this.menuItem_SIcon.Click += new System.EventHandler(this.menuItem_SIcon_Click);
            // 
            // menuItem_Simple
            // 
            this.menuItem_Simple.Name = "menuItem_Simple";
            this.menuItem_Simple.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Simple.Text = "간단히";
            this.menuItem_Simple.Click += new System.EventHandler(this.menuItem_Simple_Click);
            // 
            // menuItem_Detail
            // 
            this.menuItem_Detail.Name = "menuItem_Detail";
            this.menuItem_Detail.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Detail.Text = "자세히";
            this.menuItem_Detail.Click += new System.EventHandler(this.menuItem_Detail_Click);
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_Major,
            this.col_Address,
            this.col_Tel});
            this.listView_Main.ContextMenuStrip = this.menu_ListView;
            this.listView_Main.HideSelection = false;
            this.listView_Main.LargeImageList = this.imgList_LIcon;
            this.listView_Main.Location = new System.Drawing.Point(12, 55);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(711, 299);
            this.listView_Main.SmallImageList = this.imgList_SIcon;
            this.listView_Main.TabIndex = 2;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            // 
            // col_Name
            // 
            this.col_Name.Text = "이름";
            this.col_Name.Width = 140;
            // 
            // col_Major
            // 
            this.col_Major.Text = "학과";
            this.col_Major.Width = 140;
            // 
            // col_Address
            // 
            this.col_Address.Text = "주소";
            this.col_Address.Width = 220;
            // 
            // col_Tel
            // 
            this.col_Tel.Text = "전화번호";
            this.col_Tel.Width = 180;
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
            // comboBox_Major
            // 
            this.comboBox_Major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Major.FormattingEnabled = true;
            this.comboBox_Major.Items.AddRange(new object[] {
            "컴퓨터SW",
            "미디어SW",
            "정보통신",
            "정보보호",
            "데이터과학"});
            this.comboBox_Major.Location = new System.Drawing.Point(150, 438);
            this.comboBox_Major.Name = "comboBox_Major";
            this.comboBox_Major.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Major.TabIndex = 3;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBox_Gender.Location = new System.Drawing.Point(626, 438);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(97, 20);
            this.comboBox_Gender.TabIndex = 4;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(12, 437);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(121, 21);
            this.txtBox_Name.TabIndex = 5;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(295, 438);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(138, 21);
            this.txtBox_Address.TabIndex = 6;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(451, 438);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(154, 21);
            this.txtBox_Tel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "학과";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Address);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.comboBox_Major);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.menu_Main);
            this.MainMenuStrip = this.menu_Main;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_ListView.ResumeLayout(false);
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menu_ListView;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_Input;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_Sort;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_List;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_LIcon;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_SIcon;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_Simple;
        private System.Windows.Forms.ToolStripMenuItem cTxtMenuItem_Detail;
        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Input;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Sort;
        private System.Windows.Forms.ToolStripMenuItem menuItem_List;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Simple;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Detail;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ImageList imgList_LIcon;
        private System.Windows.Forms.ImageList imgList_SIcon;
        private System.Windows.Forms.ComboBox comboBox_Major;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_Major;
        private System.Windows.Forms.ColumnHeader col_Address;
        private System.Windows.Forms.ColumnHeader col_Tel;
    }
}

