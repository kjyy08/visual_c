namespace 김주엽19017029_과제01
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
            this.btn_msg = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_msg
            // 
            this.btn_msg.Location = new System.Drawing.Point(77, 75);
            this.btn_msg.Name = "btn_msg";
            this.btn_msg.Size = new System.Drawing.Size(123, 39);
            this.btn_msg.TabIndex = 0;
            this.btn_msg.Text = "메시지 버튼";
            this.btn_msg.UseVisualStyleBackColor = true;
            this.btn_msg.Click += new System.EventHandler(this.btn_msg_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(77, 160);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 39);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "종료 버튼";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 265);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_msg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_msg;
        private System.Windows.Forms.Button btn_exit;
    }
}

