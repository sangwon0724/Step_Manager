using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step_
{
    public partial class Form2 : Form
    {
        OracleConnection conn = null;
        OracleCommand cmd = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //아래 onj는 $ORACLE_HOME/network/admin에 있는 tnsnames.ora 파읷에 정의된 이름!
                //string conStr = "Provider=MSDAORA;data source=onj;User ID=scott;Password=tiger";
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);

                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jfuser";
                OracleDataReader rd = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (rd.Read())
                { //한줄씩
                    ListViewItem item = new ListViewItem();
                    item.Text = rd[0].ToString();
                    item.SubItems.Add(rd[1].ToString());
                    item.SubItems.Add(rd[2].ToString());
                    item.SubItems.Add(rd[3].ToString());
                    item.SubItems.Add(rd[4].ToString());
                    this.listView1.Items.Add(item);
                }
                //데이터셋
               
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection item = listView1.SelectedItems;
                ListViewItem Lvitem = item[0];

                string id = Lvitem.SubItems[0].Text;
                string pw = Lvitem.SubItems[1].Text;
                string name = Lvitem.SubItems[2].Text;
                string phone = Lvitem.SubItems[3].Text;

                txtID.Text = id;
                txtPW.Text = pw;
                txtName.Text = name;
                txtPhone.Text = phone;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtSearch.Text;

            foreach (ListViewItem lvi in listView1.Items)
            {
                if(searchId ==lvi.SubItems[0].Text)
                {
                    txtID.Text = searchId;
                    txtPW.Text = lvi.SubItems[1].Text;
                    txtName.Text = lvi.SubItems[2].Text;
                    txtPhone.Text = lvi.SubItems[3].Text;

                    return;

                }
            }

            MessageBox.Show("존재하지 않는 아이디 입니다.");
        }

        private void btnDelete_Click(object sender, EventArgs e) //삭제 부분
        {

            string deId = txtID.Text;
            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from jfuser Where id = :Sid";
                cmd.Parameters.Add(":Sid", OracleType.VarChar,20);
                cmd.Parameters[":Sid"].Value = deId;
                cmd.ExecuteNonQuery();

  
                conn.Dispose();
                conn.Close();

                if(listView1.SelectedIndices.Count > 0)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                }
                
                txtID.Text = "";
                txtPW.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtSearch.Text = "";

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

        private void btnInsert_Click(object sender, EventArgs e) //삽입
        {
            string inId = txtID.Text;
            string inPw = txtPW.Text;
            string inName = txtName.Text;
            string inPhone = txtPhone.Text;
            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into jfuser(id, password, name, phone) VALUES (:Sid, :Spw, :Sname, :Sphone)";

                cmd.Parameters.Add(":Sid", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Spw", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Sname", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Sphone", OracleType.VarChar, 24);

                cmd.Parameters[":Sid"].Value = inId;
                cmd.Parameters[":Spw"].Value = inPw;
                cmd.Parameters[":Sname"].Value = inName;
                cmd.Parameters[":Sphone"].Value = inPhone;

                cmd.ExecuteNonQuery();
                

                conn.Dispose();
                conn.Close();

                listView1.Items.Add(new ListViewItem(new string[]
                {
                   txtID.Text, txtPW.Text, txtName.Text, txtPhone.Text
                }));

                txtID.Text = "";
                txtPW.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtSearch.Text = "";
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

        //수정버튼
        private void btnUpdate_Click(object sender, EventArgs e) //아이디는 변경 불가능
        {
            string inId = txtID.Text;
            string inPw = txtPW.Text;
            string inName = txtName.Text;
            string inPhone = txtPhone.Text;
            try
            {
                String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";
                conn = new OracleConnection(strConn);
                conn.Open();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update jfuser set password=:Spw, name=:Sname, phone=:Sphone where id = :Sid";

                cmd.Parameters.Add(":Sid", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Spw", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Sname", OracleType.VarChar, 20);
                cmd.Parameters.Add(":Sphone", OracleType.VarChar, 24);

                cmd.Parameters[":Sid"].Value = inId;
                cmd.Parameters[":Spw"].Value = inPw;
                cmd.Parameters[":Sname"].Value = inName;
                cmd.Parameters[":Sphone"].Value = inPhone;

                cmd.ExecuteNonQuery();

                conn.Dispose();
                conn.Close();

                if (listView1.SelectedIndices.Count == 0)

                {
                    MessageBox.Show("수정할 위치를 선택해 주세요");
                    return;
                }
                // 1개만 선택하기 때문에 SelectedItems[0] 항상 [0] 이다.
                
                if(listView1.SelectedItems[0].SubItems[0].Text != txtID.Text)
                {
                    MessageBox.Show("아이디는 수정할수 없습니다.");
                    return;
                }
                else 
                { 
                    listView1.SelectedItems[0].SubItems[1].Text = txtPW.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = txtName.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = txtPhone.Text;
                }
                txtID.Text = "";
                txtPW.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtSearch.Text = "";

                listView1.Refresh();

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

        private void 축제관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3 = new Form3();
            frm3.Show(); //모달리스로 띄워줌
        }

        private void 커뮤니티관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show(); //모달리스로 띄워줌
        }

        private void 리뷰관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 frm5 = new Form5();
            frm5.Show(); //모달리스로 띄워줌
        }

        private void 코멘트관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 frm6 = new Form6();
            frm6.Show(); //모달리스로 띄워줌
        }

        private void 축제수락ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
