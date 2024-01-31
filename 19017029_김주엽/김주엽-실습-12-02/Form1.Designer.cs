namespace 김주엽_실습_12_02
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.txtBox_Gender = new System.Windows.Forms.TextBox();
            this.btn_Push = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 23;
            this.gridView.Size = new System.Drawing.Size(473, 250);
            this.gridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "성별";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(12, 303);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Name.TabIndex = 5;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(134, 303);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Age.TabIndex = 6;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(259, 303);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Tel.TabIndex = 7;
            // 
            // txtBox_Gender
            // 
            this.txtBox_Gender.Location = new System.Drawing.Point(385, 303);
            this.txtBox_Gender.Name = "txtBox_Gender";
            this.txtBox_Gender.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Gender.TabIndex = 8;
            // 
            // btn_Push
            // 
            this.btn_Push.Location = new System.Drawing.Point(207, 349);
            this.btn_Push.Name = "btn_Push";
            this.btn_Push.Size = new System.Drawing.Size(75, 23);
            this.btn_Push.TabIndex = 9;
            this.btn_Push.Text = "추가";
            this.btn_Push.UseVisualStyleBackColor = true;
            this.btn_Push.Click += new System.EventHandler(this.btn_Push_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 384);
            this.Controls.Add(this.btn_Push);
            this.Controls.Add(this.txtBox_Gender);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.TextBox txtBox_Gender;
        private System.Windows.Forms.Button btn_Push;
    }
}

