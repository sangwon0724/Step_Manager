using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(); //모달리스로 띄워줌
        }

        private void btnFes_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(); //모달리스로 띄워줌
        }

        private void btnCum_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show(); //모달리스로 띄워줌
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show(); //모달리스로 띄워줌
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show(); //모달리스로 띄워줌
        }
    }
}
