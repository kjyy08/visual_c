namespace 김주엽_과제_05_01
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.imgList_LInfo = new System.Windows.Forms.ImageList(this.components);
            this.listView_Info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList_SInfo = new System.Windows.Forms.ImageList(this.components);
            this.btn_SelectLargeIcon = new System.Windows.Forms.RadioButton();
            this.btn_SelectSmallIcon = new System.Windows.Forms.RadioButton();
            this.btn_Simple = new System.Windows.Forms.RadioButton();
            this.btn_Detail = new System.Windows.Forms.RadioButton();
            this.grpBox_Sample = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Place = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.txtBox_HeadCount = new System.Windows.Forms.TextBox();
            this.txtBox_Img = new System.Windows.Forms.TextBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpBox_Sample.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgList_LInfo
            // 
            this.imgList_LInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_LInfo.ImageStream")));
            this.imgList_LInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_LInfo.Images.SetKeyName(0, "1.jpg");
            this.imgList_LInfo.Images.SetKeyName(1, "2.jpg");
            this.imgList_LInfo.Images.SetKeyName(2, "3.jpg");
            this.imgList_LInfo.Images.SetKeyName(3, "DD-2EoSUwAE3e3B.jpg");
            this.imgList_LInfo.Images.SetKeyName(4, "i16593805573.jpg");
            // 
            // listView_Info
            // 
            this.listView_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Info.HideSelection = false;
            this.listView_Info.LargeImageList = this.imgList_LInfo;
            this.listView_Info.Location = new System.Drawing.Point(12, 107);
            this.listView_Info.Name = "listView_Info";
            this.listView_Info.Size = new System.Drawing.Size(556, 211);
            this.listView_Info.SmallImageList = this.imgList_SInfo;
            this.listView_Info.TabIndex = 0;
            this.listView_Info.UseCompatibleStateImageBehavior = false;
            this.listView_Info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "학과";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "위치";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "전화";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "정원";
            this.columnHeader4.Width = 140;
            // 
            // imgList_SInfo
            // 
            this.imgList_SInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_SInfo.ImageStream")));
            this.imgList_SInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_SInfo.Images.SetKeyName(0, "1.jpg");
            this.imgList_SInfo.Images.SetKeyName(1, "2.jpg");
            this.imgList_SInfo.Images.SetKeyName(2, "3.jpg");
            this.imgList_SInfo.Images.SetKeyName(3, "DD-2EoSUwAE3e3B.jpg");
            this.imgList_SInfo.Images.SetKeyName(4, "i16593805573.jpg");
            // 
            // btn_SelectLargeIcon
            // 
            this.btn_SelectLargeIcon.AutoSize = true;
            this.btn_SelectLargeIcon.Location = new System.Drawing.Point(23, 20);
            this.btn_SelectLargeIcon.Name = "btn_SelectLargeIcon";
            this.btn_SelectLargeIcon.Size = new System.Drawing.Size(71, 16);
            this.btn_SelectLargeIcon.TabIndex = 1;
            this.btn_SelectLargeIcon.TabStop = true;
            this.btn_SelectLargeIcon.Text = "큰아이콘";
            this.btn_SelectLargeIcon.UseVisualStyleBackColor = true;
            this.btn_SelectLargeIcon.CheckedChanged += new System.EventHandler(this.btn_SelectLargeIcon_CheckedChanged);
            // 
            // btn_SelectSmallIcon
            // 
            this.btn_SelectSmallIcon.AutoSize = true;
            this.btn_SelectSmallIcon.Location = new System.Drawing.Point(135, 20);
            this.btn_SelectSmallIcon.Name = "btn_SelectSmallIcon";
            this.btn_SelectSmallIcon.Size = new System.Drawing.Size(83, 16);
            this.btn_SelectSmallIcon.TabIndex = 2;
            this.btn_SelectSmallIcon.TabStop = true;
            this.btn_SelectSmallIcon.Text = "작은아이콘";
            this.btn_SelectSmallIcon.UseVisualStyleBackColor = true;
            this.btn_SelectSmallIcon.CheckedChanged += new System.EventHandler(this.btn_SelectSmallIcon_CheckedChanged);
            // 
            // btn_Simple
            // 
            this.btn_Simple.AutoSize = true;
            this.btn_Simple.Location = new System.Drawing.Point(262, 20);
            this.btn_Simple.Name = "btn_Simple";
            this.btn_Simple.Size = new System.Drawing.Size(59, 16);
            this.btn_Simple.TabIndex = 3;
            this.btn_Simple.TabStop = true;
            this.btn_Simple.Text = "간단히";
            this.btn_Simple.UseVisualStyleBackColor = true;
            this.btn_Simple.CheckedChanged += new System.EventHandler(this.btn_Simple_CheckedChanged);
            // 
            // btn_Detail
            // 
            this.btn_Detail.AutoSize = true;
            this.btn_Detail.Checked = true;
            this.btn_Detail.Location = new System.Drawing.Point(375, 20);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(59, 16);
            this.btn_Detail.TabIndex = 4;
            this.btn_Detail.TabStop = true;
            this.btn_Detail.Text = "자세히";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.CheckedChanged += new System.EventHandler(this.btn_Detail_CheckedChanged);
            // 
            // grpBox_Sample
            // 
            this.grpBox_Sample.Controls.Add(this.btn_Detail);
            this.grpBox_Sample.Controls.Add(this.btn_Simple);
            this.grpBox_Sample.Controls.Add(this.btn_SelectLargeIcon);
            this.grpBox_Sample.Controls.Add(this.btn_SelectSmallIcon);
            this.grpBox_Sample.Location = new System.Drawing.Point(12, 39);
            this.grpBox_Sample.Name = "grpBox_Sample";
            this.grpBox_Sample.Size = new System.Drawing.Size(464, 47);
            this.grpBox_Sample.TabIndex = 5;
            this.grpBox_Sample.TabStop = false;
            this.grpBox_Sample.Text = "보기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "메뉴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "학과명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "위치";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "전화";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "정원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "이미지";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(12, 350);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Name.TabIndex = 12;
            // 
            // txtBox_Place
            // 
            this.txtBox_Place.Location = new System.Drawing.Point(118, 350);
            this.txtBox_Place.Name = "txtBox_Place";
            this.txtBox_Place.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Place.TabIndex = 13;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(224, 350);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Tel.TabIndex = 14;
            // 
            // txtBox_HeadCount
            // 
            this.txtBox_HeadCount.Location = new System.Drawing.Point(330, 350);
            this.txtBox_HeadCount.Name = "txtBox_HeadCount";
            this.txtBox_HeadCount.Size = new System.Drawing.Size(100, 21);
            this.txtBox_HeadCount.TabIndex = 15;
            // 
            // txtBox_Img
            // 
            this.txtBox_Img.Location = new System.Drawing.Point(436, 350);
            this.txtBox_Img.Name = "txtBox_Img";
            this.txtBox_Img.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Img.TabIndex = 16;
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(30, 389);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(237, 23);
            this.btn_Input.TabIndex = 17;
            this.btn_Input.Text = "입력";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(299, 389);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(237, 23);
            this.btn_Remove.TabIndex = 18;
            this.btn_Remove.Text = "삭제";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(30, 418);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(237, 23);
            this.btn_Sort.TabIndex = 19;
            this.btn_Sort.Text = "정렬";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(299, 418);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(237, 23);
            this.btn_Change.TabIndex = 20;
            this.btn_Change.Text = "교환";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.txtBox_Img);
            this.Controls.Add(this.txtBox_HeadCount);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Place);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Info);
            this.Controls.Add(this.grpBox_Sample);
            this.Name = "form_Main";
            this.Text = "Form1";
            this.grpBox_Sample.ResumeLayout(false);
            this.grpBox_Sample.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgList_LInfo;
        private System.Windows.Forms.ListView listView_Info;
        private System.Windows.Forms.ImageList imgList_SInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton btn_SelectLargeIcon;
        private System.Windows.Forms.RadioButton btn_SelectSmallIcon;
        private System.Windows.Forms.RadioButton btn_Simple;
        private System.Windows.Forms.RadioButton btn_Detail;
        private System.Windows.Forms.GroupBox grpBox_Sample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Place;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.TextBox txtBox_HeadCount;
        private System.Windows.Forms.TextBox txtBox_Img;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ImageList imageList1;
    }
}

