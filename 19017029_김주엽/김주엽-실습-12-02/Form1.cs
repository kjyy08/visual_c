using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_실습_12_02
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
            table = new DataTable();

            table.Columns.Add(new DataColumn("M_NAME", typeof(string)));
            table.Columns.Add(new DataColumn("M_AGE", typeof(string)));
            table.Columns.Add(new DataColumn("M_TEL", typeof(string)));
            table.Columns.Add(new DataColumn("M_GENDER", typeof(string)));
            gridView.DataSource = table;
        }

        private void btn_Push_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();

            row["M_NAME"] = txtBox_Name.Text;
            row["M_AGE"] = txtBox_Age.Text;
            row["M_TEL"] = txtBox_Tel.Text;
            row["M_GENDER"] = txtBox_Gender.Text;
            table.Rows.Add(row);
            gridView.Update();
        }
    }
}
