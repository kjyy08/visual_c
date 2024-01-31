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
    public partial class Form1 : Form
    {
        public DataTable Info_Table;
        DataTable result_Table;
        Form2 subForm;

        public Form1()
        {
            InitializeComponent();
            subForm = new Form2(this);
            Info_Table = new DataTable();
            result_Table = new DataTable();

            Info_Table.Columns.Add(new DataColumn("M_NAME"));
            Info_Table.Columns.Add(new DataColumn("M_AGE"));
            Info_Table.Columns.Add(new DataColumn("M_TEL"));
            Info_Table.Columns.Add(new DataColumn("M_GENDER"));
            Info_Table.Columns.Add(new DataColumn("M_SCHOOL"));
            gridView_DB.DataSource = Info_Table;

            result_Table.Columns.Add(new DataColumn("M_NAME"));
            result_Table.Columns.Add(new DataColumn("M_AGE"));
            result_Table.Columns.Add(new DataColumn("M_TEL"));
            result_Table.Columns.Add(new DataColumn("M_GENDER"));
            result_Table.Columns.Add(new DataColumn("M_SCHOOL"));
            gridView_Result.DataSource = result_Table;
        }

        private void btn_ShowResult_Click(object sender, EventArgs e)
        {
            result_Table.Rows.Clear();

            DataRow[] rows = Info_Table.Select(txtBox_Filter.Text);

            foreach (DataRow i in rows)
                result_Table.Rows.Add(i.ItemArray);

            gridView_DB.Update();
        }

        private void menuItem_ShowDlg_Click(object sender, EventArgs e)
        {
            subForm.Show();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
