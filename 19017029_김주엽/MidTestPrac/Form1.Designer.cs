namespace MidTestPrac
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
            this.treeView_Main = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.txtBox_first = new System.Windows.Forms.TextBox();
            this.txtBox_Second = new System.Windows.Forms.TextBox();
            this.txtBox_Third = new System.Windows.Forms.TextBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.chkBox_First = new System.Windows.Forms.CheckBox();
            this.chkBox_Second = new System.Windows.Forms.CheckBox();
            this.chkBox_Third = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ExpandAll = new System.Windows.Forms.Button();
            this.btn_CollapseAll = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuItem_btn_t1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItem_btn_t2 = new System.Windows.Forms.ToolStripSplitButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Date = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_TabTest = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_Main
            // 
            this.treeView_Main.ImageIndex = 0;
            this.treeView_Main.ImageList = this.imgList;
            this.treeView_Main.Location = new System.Drawing.Point(12, 13);
            this.treeView_Main.Name = "treeView_Main";
            this.treeView_Main.SelectedImageIndex = 0;
            this.treeView_Main.Size = new System.Drawing.Size(396, 249);
            this.treeView_Main.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "0.jpg");
            this.imgList.Images.SetKeyName(1, "1.jpg");
            this.imgList.Images.SetKeyName(2, "2.jpg");
            this.imgList.Images.SetKeyName(3, "3.jpg");
            // 
            // txtBox_first
            // 
            this.txtBox_first.Location = new System.Drawing.Point(458, 30);
            this.txtBox_first.Name = "txtBox_first";
            this.txtBox_first.Size = new System.Drawing.Size(276, 21);
            this.txtBox_first.TabIndex = 1;
            // 
            // txtBox_Second
            // 
            this.txtBox_Second.Location = new System.Drawing.Point(458, 88);
            this.txtBox_Second.Name = "txtBox_Second";
            this.txtBox_Second.Size = new System.Drawing.Size(276, 21);
            this.txtBox_Second.TabIndex = 2;
            // 
            // txtBox_Third
            // 
            this.txtBox_Third.Location = new System.Drawing.Point(458, 147);
            this.txtBox_Third.Name = "txtBox_Third";
            this.txtBox_Third.Size = new System.Drawing.Size(276, 21);
            this.txtBox_Third.TabIndex = 3;
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(489, 175);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(75, 23);
            this.btn_Input.TabIndex = 4;
            this.btn_Input.Text = "input";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(489, 239);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // chkBox_First
            // 
            this.chkBox_First.AutoSize = true;
            this.chkBox_First.Location = new System.Drawing.Point(432, 33);
            this.chkBox_First.Name = "chkBox_First";
            this.chkBox_First.Size = new System.Drawing.Size(15, 14);
            this.chkBox_First.TabIndex = 7;
            this.chkBox_First.UseVisualStyleBackColor = true;
            // 
            // chkBox_Second
            // 
            this.chkBox_Second.AutoSize = true;
            this.chkBox_Second.Location = new System.Drawing.Point(432, 91);
            this.chkBox_Second.Name = "chkBox_Second";
            this.chkBox_Second.Size = new System.Drawing.Size(15, 14);
            this.chkBox_Second.TabIndex = 8;
            this.chkBox_Second.UseVisualStyleBackColor = true;
            // 
            // chkBox_Third
            // 
            this.chkBox_Third.AutoSize = true;
            this.chkBox_Third.Location = new System.Drawing.Point(432, 150);
            this.chkBox_Third.Name = "chkBox_Third";
            this.chkBox_Third.Size = new System.Drawing.Size(15, 14);
            this.chkBox_Third.TabIndex = 9;
            this.chkBox_Third.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(422, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(31, 169);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_ExpandAll
            // 
            this.btn_ExpandAll.Location = new System.Drawing.Point(622, 174);
            this.btn_ExpandAll.Name = "btn_ExpandAll";
            this.btn_ExpandAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ExpandAll.TabIndex = 11;
            this.btn_ExpandAll.Text = "expand";
            this.btn_ExpandAll.UseVisualStyleBackColor = true;
            this.btn_ExpandAll.Click += new System.EventHandler(this.btn_ExpandAll_Click);
            // 
            // btn_CollapseAll
            // 
            this.btn_CollapseAll.Location = new System.Drawing.Point(622, 238);
            this.btn_CollapseAll.Name = "btn_CollapseAll";
            this.btn_CollapseAll.Size = new System.Drawing.Size(75, 23);
            this.btn_CollapseAll.TabIndex = 12;
            this.btn_CollapseAll.Text = "collapse";
            this.btn_CollapseAll.UseVisualStyleBackColor = true;
            this.btn_CollapseAll.Click += new System.EventHandler(this.btn_CollapseAll_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.menuItem_btn_t1,
            this.menuItem_btn_t2});
            this.statusStrip.Location = new System.Drawing.Point(0, 524);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(1044, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "마우스 좌표";
            this.toolStripStatusLabel1.ToolTipText = "마우스의 좌표를 표시합니다.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "날짜";
            this.toolStripStatusLabel2.ToolTipText = "현재 날짜를 표시합니다.";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel3.Text = "시간";
            this.toolStripStatusLabel3.ToolTipText = "현재 시간을 표시합니다.";
            // 
            // menuItem_btn_t1
            // 
            this.menuItem_btn_t1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItem_btn_t1.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_btn_t1.Image")));
            this.menuItem_btn_t1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItem_btn_t1.Name = "menuItem_btn_t1";
            this.menuItem_btn_t1.Size = new System.Drawing.Size(29, 20);
            this.menuItem_btn_t1.Text = "toolStripDropDownButton1";
            // 
            // menuItem_btn_t2
            // 
            this.menuItem_btn_t2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItem_btn_t2.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_btn_t2.Image")));
            this.menuItem_btn_t2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItem_btn_t2.Name = "menuItem_btn_t2";
            this.menuItem_btn_t2.Size = new System.Drawing.Size(32, 20);
            this.menuItem_btn_t2.Text = "toolStripSplitButton2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(768, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxSelectionCount = 15;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2020, 10, 24, 0, 0, 0, 0), new System.DateTime(2020, 10, 30, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 268);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 253);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_Date);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(65, 191);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(0, 12);
            this.label_Date.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_TabTest
            // 
            this.btn_TabTest.Location = new System.Drawing.Point(458, 375);
            this.btn_TabTest.Name = "btn_TabTest";
            this.btn_TabTest.Size = new System.Drawing.Size(75, 23);
            this.btn_TabTest.TabIndex = 21;
            this.btn_TabTest.Text = "Tab";
            this.btn_TabTest.UseVisualStyleBackColor = true;
            this.btn_TabTest.Click += new System.EventHandler(this.btn_TabTest_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입력ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 입력ToolStripMenuItem
            // 
            this.입력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.입력ToolStripMenuItem.Name = "입력ToolStripMenuItem";
            this.입력ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.입력ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.입력ToolStripMenuItem.Text = "입력";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(736, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 546);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TabTest);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btn_CollapseAll);
            this.Controls.Add(this.btn_ExpandAll);
            this.Controls.Add(this.chkBox_Third);
            this.Controls.Add(this.chkBox_Second);
            this.Controls.Add(this.chkBox_First);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.txtBox_Third);
            this.Controls.Add(this.txtBox_Second);
            this.Controls.Add(this.txtBox_first);
            this.Controls.Add(this.treeView_Main);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Main;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TextBox txtBox_first;
        private System.Windows.Forms.TextBox txtBox_Second;
        private System.Windows.Forms.TextBox txtBox_Third;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.CheckBox chkBox_First;
        private System.Windows.Forms.CheckBox chkBox_Second;
        private System.Windows.Forms.CheckBox chkBox_Third;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ExpandAll;
        private System.Windows.Forms.Button btn_CollapseAll;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripDropDownButton menuItem_btn_t1;
        private System.Windows.Forms.ToolStripSplitButton menuItem_btn_t2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TabTest;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.TextBox textBox1;
    }
}

