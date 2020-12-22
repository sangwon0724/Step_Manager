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
    public partial class Form7 : Form
    {

        OracleConnection conn = null;
        OracleCommand cmd = null;
        OracleDataAdapter adapter;
        string type;
        string num;
        string sql;
        string title_image;
        Form3 fm;

        public Form7(Form3 fm, string type, string num)
        {
            this.fm = fm;
            this.type = type;
            this.num = num;

            InitializeComponent();
        }


        private void update()
        {
            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;

                if (type == "festival")
                {
                    sql = "update " + type + " set  " +
                        " fname='" + tbfname.Text + "'," +
                        " text='" + tbText.Text + "'," +
                        " big_area='" + tbBigArea.Text + "'," +
                        " small_area='" + tbSmallArea.Text + "'," +
                       " sdate= to_date('" + tbStartDate.Text + "','YYYY-MM-DD')," +
                        " edate= to_date('" + tbEndDate.Text + "','YYYY-MM-DD')," +
                        " tag='" + tbTag.Text + "'," +
                        " location='" + tbLocation.Text + "'," +
                        " url='" + tbURL.Text + "'" +
                        "where fno = '" + tbno.Text + "'";
                }
                else if (type == "festival_apply")
                {
                    sql = "update " + type + " set  " +
                       " fname='" + tbfname.Text + "'," +
                       " text='" + tbText.Text + "'," +
                       " big_area='" + tbBigArea.Text + "'," +
                       " small_area='" + tbSmallArea.Text + "'," +
                      " sdate= to_date('" + tbStartDate.Text + "','YYYY-MM-DD')," +
                       " edate= to_date('" + tbEndDate.Text + "','YYYY-MM-DD')," +
                       " tag='" + tbTag.Text + "'" +
                       "where no = " + tbno.Text + "";

                }

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
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
        private void apply()
        {
            if (type == "festival_apply")
            {
                try
                {
                    String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                    conn = new OracleConnection(strConn);
                    conn.Open();

                    cmd = new OracleCommand();
                    cmd.Connection = conn;

                    sql = "insert " + " into festival(fno,fname,title_image,text,big_area,small_area,sdate,edate,tag) " +
                   " values(festival_seq.nextval,'" + tbfname.Text + "','" + title_image + "', '" + tbText.Text + "', '" + tbBigArea.Text + "','" + tbSmallArea.Text + "', " +
                   "to_date('" + tbStartDate.Text + "','YYYY-MM-DD')," + " to_date('" + tbEndDate.Text + "','YYYY-MM-DD')," + "' " + tbTag.Text + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    sql = "insert into festival_detail(fno,rdate)"
                     + " values(FESTIVAL_detail_SEQ.nextval,sysdate)";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    sql = "delete festival_apply where no="+int.Parse(tbno.Text);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    Form3 fesForm=new Form3();
                    fesForm.selectAll("festival_apply");

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
            else
            {


            }

        }



        private void select()
        {
            try
            {
                String strConn = " Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();
                string no = "";

                if (type == "festival")
                {
                    sql = "Select fno,fname,title_image,text,big_area,small_area,sdate,edate,tag,location,url from " + type + " where fno ='" + num + "'";
                }
                else if (type == "festival_apply")
                {
                    sql = "Select no,fname,title_image,text,big_area,small_area,sdate,edate,tag from " + type + " where no =" + num + "";
                }
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                OracleDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                { //한줄씩
                    tbno.Text = rd[0].ToString();
                    tbfname.Text = rd["fname"].ToString();
                    tbText.Text = rd["text"].ToString();
                    tbBigArea.Text = rd["big_area"].ToString();
                    tbSmallArea.Text = rd["small_area"].ToString();
                    tbTag.Text = rd["tag"].ToString();
                    title_image = rd["title_image"].ToString();
                    if (type == "festival")
                    {
                        tbLocation.Text = rd["location"].ToString();
                        tbURL.Text = rd["url"].ToString();
                    }
                    else if (type == "festival_apply")
                    {

                    }
                    monthCalendar1.SelectionStart = Convert.ToDateTime(rd["sdate"].ToString());
                    monthCalendar1.SelectionEnd = Convert.ToDateTime(rd["edate"].ToString());
                }

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

        private void delete()
        {
            string no = tbno.Text;
            if (type == "festival")
            {
                sql = "Delete from " + type + " Where fno = '" + no + "'";
            }
            else if (type == "festival_apply")
            {
                sql = "Delete from " + type + " Where no = " + no + "";
            }

            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

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



        private void Form7_Load(object sender, EventArgs e)
        {

            // 초기 선택 범위 지정
            this.Text = type + ": 번호:" + num + " ";
            if (type == "축제")
            {
                type = "festival";
            }
            else if (type == "축제 승인")
            {
                type = "festival_apply";
                btnapply.Visible = true;
                tbLocation.Enabled = false;
                tbURL.Enabled = false;

            }
            select();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
            this.Close();
        }
        private void btnapply_Click(object sender, EventArgs e)
        {
            apply();
            //delete(); 임시로 딜리트문은 삭제 실제 사용시 삭제 풀기
            this.Close();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.refresh();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbStartDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tbEndDate.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            this.Close();
        }

        private void btnAble_Click(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = false;
        }
    }
}
