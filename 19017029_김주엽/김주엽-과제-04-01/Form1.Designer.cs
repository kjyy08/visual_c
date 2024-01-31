namespace 김주엽_과제_04_01
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_GotoFirst = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.listBox_Card = new System.Windows.Forms.ListBox();
            this.grpBox_Info = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Address, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Phone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_Address, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_Phone, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(3, 30);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 12);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "이름";
            // 
            // label_Address
            // 
            this.label_Address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(3, 103);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(29, 12);
            this.label_Address.TabIndex = 1;
            this.label_Address.Text = "주소";
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(3, 177);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(29, 12);
            this.label_Phone.TabIndex = 2;
            this.label_Phone.Text = "전화";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox_Name.Location = new System.Drawing.Point(76, 26);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(156, 21);
            this.txtBox_Name.TabIndex = 3;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox_Address.Location = new System.Drawing.Point(76, 99);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(156, 21);
            this.txtBox_Address.TabIndex = 4;
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox_Phone.Location = new System.Drawing.Point(76, 173);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(156, 21);
            this.txtBox_Phone.TabIndex = 5;
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(26, 253);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(53, 23);
            this.btn_Input.TabIndex = 1;
            this.btn_Input.Text = "입력";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(93, 253);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_GotoFirst
            // 
            this.btn_GotoFirst.Location = new System.Drawing.Point(163, 253);
            this.btn_GotoFirst.Name = "btn_GotoFirst";
            this.btn_GotoFirst.Size = new System.Drawing.Size(53, 23);
            this.btn_GotoFirst.TabIndex = 3;
            this.btn_GotoFirst.Text = "처음";
            this.btn_GotoFirst.UseVisualStyleBackColor = true;
            this.btn_GotoFirst.Click += new System.EventHandler(this.btn_GotoFirst_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(238, 253);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "클리어";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // listBox_Card
            // 
            this.listBox_Card.FormattingEnabled = true;
            this.listBox_Card.ItemHeight = 12;
            this.listBox_Card.Location = new System.Drawing.Point(318, 12);
            this.listBox_Card.Name = "listBox_Card";
            this.listBox_Card.Size = new System.Drawing.Size(150, 232);
            this.listBox_Card.TabIndex = 5;
            // 
            // grpBox_Info
            // 
            this.grpBox_Info.Location = new System.Drawing.Point(3, 4);
            this.grpBox_Info.Name = "grpBox_Info";
            this.grpBox_Info.Size = new System.Drawing.Size(310, 243);
            this.grpBox_Info.TabIndex = 6;
            this.grpBox_Info.TabStop = false;
            this.grpBox_Info.Text = "정보 입력";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 292);
            this.Controls.Add(this.listBox_Card);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_GotoFirst);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grpBox_Info);
            this.Name = "form_Main";
            this.Text = "주소록";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_GotoFirst;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ListBox listBox_Card;
        private System.Windows.Forms.GroupBox grpBox_Info;
    }
}

