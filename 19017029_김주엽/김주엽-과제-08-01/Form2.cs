using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_08_01
{
    public partial class Form2 : Form
    {
        Form1 form_Main;
        bool isSelected = false;
        int startIdx = -1;

        public Form2(Form1 main)
        {
            InitializeComponent();
            this.form_Main = main;
        }

        void SetStartIndex()
        {
            if (startIdx + txtBox_FWord.Text.Length >= form_Main.txtBox_Main.Text.Length)
                startIdx = form_Main.txtBox_Main.Text.IndexOf(txtBox_FWord.Text, startIdx);
            else
                startIdx = form_Main.txtBox_Main.Text.IndexOf(txtBox_FWord.Text, startIdx + txtBox_FWord.Text.Length);


            if (startIdx != -1)
            {
                form_Main.txtBox_Main.Focus();
                form_Main.txtBox_Main.Select(startIdx, txtBox_FWord.Text.Length);
            }

            else
            {
                startIdx = form_Main.txtBox_Main.Text.IndexOf(txtBox_FWord.Text, 0);
                
                if (startIdx == -1)
                {
                    MessageBox.Show("찾을 단어가 없습니다.");
                    isSelected = false;
                }

                else
                {
                    form_Main.txtBox_Main.Focus();
                    form_Main.txtBox_Main.Select(startIdx, txtBox_FWord.Text.Length);
                }
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (!isSelected)
                isSelected = true;

            else
            {
                StringBuilder buffer = new StringBuilder();

                buffer.Append(form_Main.txtBox_Main.Text);
                buffer.Remove(startIdx, txtBox_FWord.Text.Length);
                buffer.Insert(startIdx, txtBox_CWord.Text);
                form_Main.txtBox_Main.Text = buffer.ToString();
            }

            SetStartIndex();
        }

        private void btn_FindNext_Click(object sender, EventArgs e)
        {
            SetStartIndex();
            isSelected = true;
        }

        private void btn_ChangeAll_Click(object sender, EventArgs e)
        {
            if (txtBox_CWord.Text != "" && txtBox_FWord.Text != "")
            {
                StringBuilder buffer = new StringBuilder(form_Main.txtBox_Main.Text);

                buffer.Replace(txtBox_FWord.Text, txtBox_CWord.Text);
                form_Main.txtBox_Main.Text = buffer.ToString();
                isSelected = false;
                startIdx = -1;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            else
            {
                Dispose(true);
                Close();
            }
        }

        private void btn_Swap_Click(object sender, EventArgs e)
        {
            string temp = txtBox_FWord.Text;
            txtBox_FWord.Text = txtBox_CWord.Text;
            txtBox_CWord.Text = temp;
        }
    }
}
