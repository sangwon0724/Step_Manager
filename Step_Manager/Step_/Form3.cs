using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Step_
{
    public partial class Form3 : Form
    {
        OracleConnection conn = null;
        OracleCommand cmd = null;
        OracleDataAdapter adapter;
        DataSet ds = null;
        string sql;

        public Form3()
        {
            InitializeComponent();
        }


        public void selectAll(string table)
        {
            try
            {
                String strConn = " Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();
                sql = "Select * from " + table + " ";
                adapter = new OracleDataAdapter(sql, conn);
                ds = new DataSet();
                adapter.Fill(ds);

                dgviewfst.DataSource = ds.Tables[0];

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "jfuser Table Loading Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void selectsearch(string table, string where, string value)
        {
            try
            {
                String strConn = " Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();
                sql = "Select * from " + table + " where 1=1 and " + " " + where + " like " + "'%" + value + "%'";
                adapter = new OracleDataAdapter(sql, conn);
                ds = new DataSet();
                adapter.Fill(ds);

                dgviewfst.DataSource = ds.Tables[0];

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "jfuser Table Loading Error");
            }
            finally
            {
                conn.Close();
            }

        }
        private string cbcheck()
        {
            int i = cbsearch.SelectedIndex;

            if (i == 0)
            {
                return "fname";
            }
            else if (i == 1)
            {
                return "text";
            }
            else if (i == 2)
            {
                return "big_area";
            }
            else if (i == 3)
            {
                return "small_area";
            }
            else if (i == 4)
            {
                return "tag";
            }
            else
            {
                return "2=2";

            }



        }

        public void refresh()
        {
            try
            {
                String strConn = " Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();
                adapter = new OracleDataAdapter(sql, conn);
                ds = new DataSet();
                adapter.Fill(ds);

                dgviewfst.DataSource = ds.Tables[0];

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "jfuser Table Loading Error");
            }
            finally
            {
                conn.Close();
            }

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            selectAll("festival");
            cbsearch.SelectedIndex = 0;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (lblstate.Text == "축제")
            {
                selectsearch("festival", cbcheck(), tbsearch.Text);
            }
            else if (lblstate.Text == "축제 승인")
            {
                selectsearch("festival_apply", cbcheck(), tbsearch.Text);
            }
        }

        private void btnapplyfestival_Click(object sender, EventArgs e)
        {
            this.Text = "축제 승인";
            btntofestival.Enabled = true;
            btnapplyfestival.Enabled = false;
            selectAll("festival_apply");
            lblstate.Text = "축제 승인";
        }

        private void btntofestival_Click(object sender, EventArgs e)
        {
            this.Text = "축제";
            btntofestival.Enabled = false;
            btnapplyfestival.Enabled = true;
            selectAll("festival");
            lblstate.Text = "축제";
        }

        private void dgviewfst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form7 udateform;
            udateform = new Form7(this, lblstate.Text, dgviewfst.CurrentRow.Cells[0].Value.ToString());

            udateform.ShowDialog();
        }

        private void 유저관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show(); //모달리스로 띄워줌
        }

        private void 커뮤니티관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show(); //모달리스로 띄워줌
        }

        private void 코멘트관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 frm5 = new Form5();
            frm5.Show(); //모달리스로 띄워줌
        }

        private void 리뷰관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 frm6 = new Form6();
            frm6.Show(); //모달리스로 띄워줌
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String delsql="";
            if (dgviewfst.SelectedCells.Count == 0)
            {
               
            }
            else {
                if (lblstate.Text == "축제")
                {
                    delsql = "Delete from festival Where fno = '" + dgviewfst.CurrentRow.Cells[0].Value.ToString() + "'";
                   
                }
                else if (lblstate.Text == "축제 승인")
                {
                    delsql = "Delete from festival_apply Where no = " + dgviewfst.CurrentRow.Cells[0].Value.ToString() + "";

                }
                else {
                    return;
                }
            } 
            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = delsql;
                cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
                refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "jfuser Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
