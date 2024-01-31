namespace 김주엽_과제_07_01
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.txtBox_Idx = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "이미지인덱스";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(42, 260);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(106, 23);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "확인";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(212, 260);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(149, 22);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(163, 21);
            this.txtBox_Name.TabIndex = 1;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Location = new System.Drawing.Point(149, 167);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(163, 21);
            this.txtBox_Tel.TabIndex = 3;
            // 
            // txtBox_Idx
            // 
            this.txtBox_Idx.Location = new System.Drawing.Point(149, 220);
            this.txtBox_Idx.Name = "txtBox_Idx";
            this.txtBox_Idx.Size = new System.Drawing.Size(163, 21);
            this.txtBox_Idx.TabIndex = 4;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(149, 80);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(163, 46);
            this.txtBox_Address.TabIndex = 2;
            this.txtBox_Address.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 295);
            this.Controls.Add(this.txtBox_Address);
            this.Controls.Add(this.txtBox_Idx);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.TextBox txtBox_Idx;
        private System.Windows.Forms.RichTextBox txtBox_Address;
    }
}