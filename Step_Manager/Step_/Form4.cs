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
    public partial class Form4 : Form
    {
        OracleConnection conn = null;
        OracleCommand cmd = null;
        OracleDataReader rd = null;

        String strConn = "Data Source = finalproject; User ID=FINALPROJECT; Password=1234";

        public Form4()
        {
            InitializeComponent();
        }

        /*프로그램 실행*/
        private void Form4_Load(object sender, EventArgs e)
        {
            listAllviewSetting();
        }//Form4_Load 종료

        private void listAllBtn_Click(object sender, EventArgs e)
        {
            //초기화
            this.searchText.Text = "";
            this.combobox.SelectedIndex = - 1;

            listAllviewSetting();
        }//listAllBtn_Click 종료

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String searchColumn = null;

            //에러 처리
            if (this.combobox.SelectedIndex == -1)
            {
                MessageBox.Show("검색할 항목을 선택해주세요.", "ERROR!!!");
                return;
            }
            else {
                if (this.searchText.Text == "") {
                    MessageBox.Show("검색할 내용을 입력해주세요.", "ERROR!!!");
                    return;
                }
            }

            //칼럼명 정의
            if (this.combobox.SelectedIndex == 0) {
                searchColumn = "id";//작성자 아이디
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                searchColumn = "title";//제목
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                searchColumn = "com";//내용
            }

            //검색 시작
            if (searchColumn != null) {
                listSearchviewSetting(searchColumn);
            }
            //검색 종료
        }//searchBtn_Click 종료

        //전체 목록 보여주기
        public void listAllviewSetting() {
            try
            {
                conn = new OracleConnection(strConn);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from community order by no desc";

                rd = cmd.ExecuteReader();
                this.listview.Items.Clear();

                while (rd.Read())
                { //한줄씩
                    ListViewItem item = new ListViewItem();
                    item.Text = rd[0].ToString();
                    item.SubItems.Add(rd[1].ToString());
                    item.SubItems.Add(rd[2].ToString());
                    item.SubItems.Add(rd[3].ToString());
                    item.SubItems.Add(rd[4].ToString());
                    item.SubItems.Add(rd[5].ToString());
                    item.SubItems.Add(rd[6].ToString());
                    item.SubItems.Add(rd[7].ToString());
                    this.listview.Items.Add(item);
                }
                //데이터셋

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "community Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }//listAllviewSetting 종료

        //검색 목록 보여주기
        public void listSearchviewSetting(String searchColumn)
        {
            try
            {
                conn = new OracleConnection(strConn);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from community where "+searchColumn
                    +" like '%"+ searchText.Text+"%' order by no desc";
                rd = cmd.ExecuteReader();
                this.listview.Items.Clear();

                while (rd.Read())
                { //한줄씩
                    ListViewItem item = new ListViewItem();
                    item.Text = rd[0].ToString();
                    item.SubItems.Add(rd[1].ToString());
                    item.SubItems.Add(rd[2].ToString());
                    item.SubItems.Add(rd[3].ToString());
                    item.SubItems.Add(rd[4].ToString());
                    item.SubItems.Add(rd[5].ToString());
                    item.SubItems.Add(rd[6].ToString());
                    item.SubItems.Add(rd[7].ToString());
                    this.listview.Items.Add(item);
                }
                //데이터셋

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "community Search Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }//listSearchviewSetting 종료

        //게시글 삭제
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int deleteNo=-1;

            //에러 처리
            if (this.listview.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택한 항목이 없습니다.", "Error!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "경고",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    deleteNo = int.Parse(this.listview.SelectedItems[0].SubItems[0].Text);

                    try
                    {
                        conn = new OracleConnection(strConn);
                        conn.Open();
                        cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "Delete from community Where no = " + deleteNo;
                        cmd.ExecuteNonQuery();

                        conn.Dispose();
                        conn.Close();

                        //리스트뷰에서 삭제
                        this.listview.Items.RemoveAt(this.listview.SelectedIndices[0]);

                        //초기화
                        this.searchText.Text = "";
                        this.combobox.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "community Delete Loading Error");
                    }
                    finally
                    {
                        conn.Close();
                    }

                    MessageBox.Show("삭제가 완료되었습니다.", "작업 결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제 작업을 취소합니다.", "작업 결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }//deleteBtn_Click 종료

        private void 유저관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show(); //모달리스로 띄워줌
        }

        private void 축제관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3 = new Form3();
            frm3.Show(); //모달리스로 띄워줌
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
    }//Form4 종료
}
