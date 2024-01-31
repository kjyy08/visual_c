using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_12_01
{
    public partial class Form2 : Form
    {
        Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            Owner = form;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow row = mainForm.Info_Table.NewRow();

            row["M_NAME"] = txtBox_Name.Text;
            row["M_AGE"] = txtBox_Age.Text;
            row["M_TEL"] = txtBox_Tel.Text;
            row["M_GENDER"] = txtBox_Gender.Text;
            row["M_SCHOOL"] = txtBox_School.Text;
            mainForm.Info_Table.Rows.Add(row);
            mainForm.gridView_DB.Update();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
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
                Dispose();
                Close();
            }
        }
    }
}
