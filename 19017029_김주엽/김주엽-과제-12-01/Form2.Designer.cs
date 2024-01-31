namespace 김주엽_과제_12_01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.txtBox_Gender = new System.Windows.Forms.TextBox();
            this.txtBox_School = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "출신고교";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(102, 12);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(194, 21);
            this.txtBox_Name.TabIndex = 5;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(102, 39);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(194, 21);
            this.txtBox_Age.TabIndex = 6;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(102, 66);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(194, 21);
            this.txtBox_Tel.TabIndex = 7;
            // 
            // txtBox_Gender
            // 
            this.txtBox_Gender.Location = new System.Drawing.Point(102, 93);
            this.txtBox_Gender.Name = "txtBox_Gender";
            this.txtBox_Gender.Size = new System.Drawing.Size(194, 21);
            this.txtBox_Gender.TabIndex = 8;
            // 
            // txtBox_School
            // 
            this.txtBox_School.Location = new System.Drawing.Point(102, 120);
            this.txtBox_School.Name = "txtBox_School";
            this.txtBox_School.Size = new System.Drawing.Size(194, 21);
            this.txtBox_School.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(43, 169);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(190, 169);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 210);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_School);
            this.Controls.Add(this.txtBox_Gender);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.TextBox txtBox_Gender;
        private System.Windows.Forms.TextBox txtBox_School;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Exit;
    }
}