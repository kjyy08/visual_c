using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_14_01_Client
{
    public partial class Form2 : Form
    {
        Form1 mainForm;

        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Owner = mainForm;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
