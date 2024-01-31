namespace 김주엽_실습_10_01
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
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBtn_Detail = new System.Windows.Forms.RadioButton();
            this.rdoBtn_Simple = new System.Windows.Forms.RadioButton();
            this.rdoBtn_S = new System.Windows.Forms.RadioButton();
            this.rdoBtn_L = new System.Windows.Forms.RadioButton();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.comboBox_Mail = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtn_Detail);
            this.groupBox1.Controls.Add(this.rdoBtn_Simple);
            this.groupBox1.Controls.Add(this.rdoBtn_S);
            this.groupBox1.Controls.Add(this.rdoBtn_L);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일";
            // 
            // rdoBtn_Detail
            // 
            this.rdoBtn_Detail.AutoSize = true;
            this.rdoBtn_Detail.Location = new System.Drawing.Point(394, 15);
            this.rdoBtn_Detail.Name = "rdoBtn_Detail";
            this.rdoBtn_Detail.Size = new System.Drawing.Size(59, 16);
            this.rdoBtn_Detail.TabIndex = 3;
            this.rdoBtn_Detail.TabStop = true;
            this.rdoBtn_Detail.Text = "자세히";
            this.rdoBtn_Detail.UseVisualStyleBackColor = true;
            this.rdoBtn_Detail.CheckedChanged += new System.EventHandler(this.rdoBtn_Detail_CheckedChanged);
            // 
            // rdoBtn_Simple
            // 
            this.rdoBtn_Simple.AutoSize = true;
            this.rdoBtn_Simple.Location = new System.Drawing.Point(272, 15);
            this.rdoBtn_Simple.Name = "rdoBtn_Simple";
            this.rdoBtn_Simple.Size = new System.Drawing.Size(59, 16);
            this.rdoBtn_Simple.TabIndex = 2;
            this.rdoBtn_Simple.TabStop = true;
            this.rdoBtn_Simple.Text = "간단히";
            this.rdoBtn_Simple.UseVisualStyleBackColor = true;
            this.rdoBtn_Simple.CheckedChanged += new System.EventHandler(this.rdoBtn_Simple_CheckedChanged);
            // 
            // rdoBtn_S
            // 
            this.rdoBtn_S.AutoSize = true;
            this.rdoBtn_S.Location = new System.Drawing.Point(129, 15);
            this.rdoBtn_S.Name = "rdoBtn_S";
            this.rdoBtn_S.Size = new System.Drawing.Size(83, 16);
            this.rdoBtn_S.TabIndex = 1;
            this.rdoBtn_S.TabStop = true;
            this.rdoBtn_S.Text = "작은아이콘";
            this.rdoBtn_S.UseVisualStyleBackColor = true;
            this.rdoBtn_S.CheckedChanged += new System.EventHandler(this.rdoBtn_S_CheckedChanged);
            // 
            // rdoBtn_L
            // 
            this.rdoBtn_L.AutoSize = true;
            this.rdoBtn_L.Location = new System.Drawing.Point(11, 15);
            this.rdoBtn_L.Name = "rdoBtn_L";
            this.rdoBtn_L.Size = new System.Drawing.Size(71, 16);
            this.rdoBtn_L.TabIndex = 0;
            this.rdoBtn_L.TabStop = true;
            this.rdoBtn_L.Text = "큰아이콘";
            this.rdoBtn_L.UseVisualStyleBackColor = true;
            this.rdoBtn_L.CheckedChanged += new System.EventHandler(this.rdoBtn_L_CheckedChanged);
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Main.HideSelection = false;
            this.listView_Main.LargeImageList = this.imageList1;
            this.listView_Main.Location = new System.Drawing.Point(12, 71);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(477, 220);
            this.listView_Main.SmallImageList = this.imageList2;
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "주소";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "전화번호";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "남/여";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "다운로드 (1).jpeg");
            this.imageList1.Images.SetKeyName(1, "다운로드.jpeg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "다운로드 (1).jpeg");
            this.imageList2.Images.SetKeyName(1, "다운로드.jpeg");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(617, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Save,
            this.menuItem_Open,
            this.menuItem_Exit});
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.저장ToolStripMenuItem.Text = "파일";
            // 
            // menuItem_Save
            // 
            this.menuItem_Save.Name = "menuItem_Save";
            this.menuItem_Save.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Save.Text = "저장";
            this.menuItem_Save.Click += new System.EventHandler(this.menuItem_Save_Click);
            // 
            // menuItem_Open
            // 
            this.menuItem_Open.Name = "menuItem_Open";
            this.menuItem_Open.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Open.Text = "열기";
            this.menuItem_Open.Click += new System.EventHandler(this.menuItem_Open_Click);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(98, 22);
            this.menuItem_Exit.Text = "종료";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "남/여";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(14, 352);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Name.TabIndex = 6;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(120, 352);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(123, 21);
            this.txtBox_Address.TabIndex = 7;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(249, 352);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(125, 21);
            this.txtBox_Tel.TabIndex = 8;
            // 
            // comboBox_Mail
            // 
            this.comboBox_Mail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mail.FormattingEnabled = true;
            this.comboBox_Mail.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBox_Mail.Location = new System.Drawing.Point(382, 352);
            this.comboBox_Mail.Name = "comboBox_Mail";
            this.comboBox_Mail.Size = new System.Drawing.Size(83, 20);
            this.comboBox_Mail.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(483, 351);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "items.bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 422);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comboBox_Mail);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Address);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtn_Detail;
        private System.Windows.Forms.RadioButton rdoBtn_Simple;
        private System.Windows.Forms.RadioButton rdoBtn_S;
        private System.Windows.Forms.RadioButton rdoBtn_L;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.ComboBox comboBox_Mail;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Exit;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}

