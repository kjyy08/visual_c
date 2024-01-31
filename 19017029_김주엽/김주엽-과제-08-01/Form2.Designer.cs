namespace 김주엽_과제_08_01
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
            this.txtBox_FWord = new System.Windows.Forms.TextBox();
            this.txtBox_CWord = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_FindNext = new System.Windows.Forms.Button();
            this.btn_ChangeAll = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 단어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "바꿀 단어";
            // 
            // txtBox_FWord
            // 
            this.txtBox_FWord.Location = new System.Drawing.Point(75, 24);
            this.txtBox_FWord.Name = "txtBox_FWord";
            this.txtBox_FWord.Size = new System.Drawing.Size(168, 21);
            this.txtBox_FWord.TabIndex = 2;
            // 
            // txtBox_CWord
            // 
            this.txtBox_CWord.Location = new System.Drawing.Point(75, 83);
            this.txtBox_CWord.Name = "txtBox_CWord";
            this.txtBox_CWord.Size = new System.Drawing.Size(168, 21);
            this.txtBox_CWord.TabIndex = 3;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(255, 23);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "바꾸기";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_FindNext
            // 
            this.btn_FindNext.Location = new System.Drawing.Point(255, 52);
            this.btn_FindNext.Name = "btn_FindNext";
            this.btn_FindNext.Size = new System.Drawing.Size(75, 23);
            this.btn_FindNext.TabIndex = 5;
            this.btn_FindNext.Text = "다음찾기";
            this.btn_FindNext.UseVisualStyleBackColor = true;
            this.btn_FindNext.Click += new System.EventHandler(this.btn_FindNext_Click);
            // 
            // btn_ChangeAll
            // 
            this.btn_ChangeAll.Location = new System.Drawing.Point(255, 81);
            this.btn_ChangeAll.Name = "btn_ChangeAll";
            this.btn_ChangeAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeAll.TabIndex = 6;
            this.btn_ChangeAll.Text = "모두바꾸기";
            this.btn_ChangeAll.UseVisualStyleBackColor = true;
            this.btn_ChangeAll.Click += new System.EventHandler(this.btn_ChangeAll_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(75, 138);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "닫기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.Font = new System.Drawing.Font("굴림", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Swap.Location = new System.Drawing.Point(30, 48);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(19, 30);
            this.btn_Swap.TabIndex = 8;
            this.btn_Swap.Text = "∧\r\n∨";
            this.btn_Swap.UseVisualStyleBackColor = true;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 173);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_ChangeAll);
            this.Controls.Add(this.btn_FindNext);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txtBox_CWord);
            this.Controls.Add(this.txtBox_FWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_FindNext;
        private System.Windows.Forms.Button btn_ChangeAll;
        private System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.TextBox txtBox_FWord;
        public System.Windows.Forms.TextBox txtBox_CWord;
        private System.Windows.Forms.Button btn_Swap;
    }
}