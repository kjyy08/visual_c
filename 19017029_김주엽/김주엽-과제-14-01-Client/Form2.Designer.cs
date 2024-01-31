namespace 김주엽_과제_14_01_Client
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
            this.txtBox_IP = new System.Windows.Forms.TextBox();
            this.txtBox_PortNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Location = new System.Drawing.Point(73, 23);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(163, 21);
            this.txtBox_IP.TabIndex = 0;
            // 
            // txtBox_PortNum
            // 
            this.txtBox_PortNum.Location = new System.Drawing.Point(73, 61);
            this.txtBox_PortNum.Name = "txtBox_PortNum";
            this.txtBox_PortNum.Size = new System.Drawing.Size(163, 21);
            this.txtBox_PortNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이피";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "포트번호";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(87, 108);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "연결";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 143);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_PortNum);
            this.Controls.Add(this.txtBox_IP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Connect;
        public System.Windows.Forms.TextBox txtBox_IP;
        public System.Windows.Forms.TextBox txtBox_PortNum;
    }
}