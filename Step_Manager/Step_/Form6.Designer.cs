namespace Step_
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listview = new System.Windows.Forms.ListView();
            this.fcommentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentFno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fcommentRdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.fcommentbtn = new System.Windows.Forms.Button();
            this.rcommentbtn = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listAllBtn = new System.Windows.Forms.Button();
            this.rcommentlistview = new System.Windows.Forms.ListView();
            this.rcommentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcommentRno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcommentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcommentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcommentText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcommentRdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축제관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커뮤니티관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리뷰관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ccommentbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fcommentNo,
            this.fcommentFno,
            this.fcommentID,
            this.fcommentName,
            this.fcommentText,
            this.fcommentGrade,
            this.fcommentRdate});
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(30, 159);
            this.listview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(1242, 353);
            this.listview.TabIndex = 5;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // fcommentNo
            // 
            this.fcommentNo.Text = "번호";
            // 
            // fcommentFno
            // 
            this.fcommentFno.Text = "게시글번호";
            this.fcommentFno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fcommentFno.Width = 99;
            // 
            // fcommentID
            // 
            this.fcommentID.Text = "작성자";
            this.fcommentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fcommentName
            // 
            this.fcommentName.Text = "작성자이름";
            this.fcommentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fcommentName.Width = 89;
            // 
            // fcommentText
            // 
            this.fcommentText.Text = "내용";
            this.fcommentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fcommentText.Width = 433;
            // 
            // fcommentGrade
            // 
            this.fcommentGrade.Text = "평점";
            this.fcommentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fcommentRdate
            // 
            this.fcommentRdate.Text = "등록일";
            this.fcommentRdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fcommentRdate.Width = 299;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(29, 532);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 46);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fcommentbtn
            // 
            this.fcommentbtn.Location = new System.Drawing.Point(936, 94);
            this.fcommentbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fcommentbtn.Name = "fcommentbtn";
            this.fcommentbtn.Size = new System.Drawing.Size(101, 46);
            this.fcommentbtn.TabIndex = 8;
            this.fcommentbtn.Text = "축제";
            this.fcommentbtn.UseVisualStyleBackColor = true;
            this.fcommentbtn.Click += new System.EventHandler(this.fcommentbtn_Click);
            // 
            // rcommentbtn
            // 
            this.rcommentbtn.Location = new System.Drawing.Point(1171, 94);
            this.rcommentbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcommentbtn.Name = "rcommentbtn";
            this.rcommentbtn.Size = new System.Drawing.Size(101, 46);
            this.rcommentbtn.TabIndex = 9;
            this.rcommentbtn.Text = "리뷰";
            this.rcommentbtn.UseVisualStyleBackColor = true;
            this.rcommentbtn.Click += new System.EventHandler(this.rcommentbtn_Click);
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("굴림", 10.2F);
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "게시글번호",
            "작성자",
            "내용"});
            this.combobox.Location = new System.Drawing.Point(29, 50);
            this.combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 25);
            this.combobox.TabIndex = 10;
            this.combobox.Text = "검색 항목";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("굴림", 20F);
            this.searchText.Location = new System.Drawing.Point(29, 94);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(363, 46);
            this.searchText.TabIndex = 11;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(433, 94);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 46);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listAllBtn
            // 
            this.listAllBtn.Location = new System.Drawing.Point(563, 94);
            this.listAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAllBtn.Name = "listAllBtn";
            this.listAllBtn.Size = new System.Drawing.Size(101, 46);
            this.listAllBtn.TabIndex = 13;
            this.listAllBtn.Text = "전체보기";
            this.listAllBtn.UseVisualStyleBackColor = true;
            this.listAllBtn.Click += new System.EventHandler(this.listAllBtn_Click);
            // 
            // rcommentlistview
            // 
            this.rcommentlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rcommentNo,
            this.rcommentRno,
            this.rcommentID,
            this.rcommentName,
            this.rcommentText,
            this.rcommentRdate});
            this.rcommentlistview.FullRowSelect = true;
            this.rcommentlistview.GridLines = true;
            this.rcommentlistview.HideSelection = false;
            this.rcommentlistview.Location = new System.Drawing.Point(29, 159);
            this.rcommentlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcommentlistview.Name = "rcommentlistview";
            this.rcommentlistview.Size = new System.Drawing.Size(1242, 353);
            this.rcommentlistview.TabIndex = 14;
            this.rcommentlistview.UseCompatibleStateImageBehavior = false;
            this.rcommentlistview.View = System.Windows.Forms.View.Details;
            this.rcommentlistview.Visible = false;
            // 
            // rcommentNo
            // 
            this.rcommentNo.Text = "번호";
            // 
            // rcommentRno
            // 
            this.rcommentRno.Text = "축제번호";
            this.rcommentRno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcommentRno.Width = 99;
            // 
            // rcommentID
            // 
            this.rcommentID.Text = "작성자";
            this.rcommentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rcommentName
            // 
            this.rcommentName.Text = "작성자이름";
            this.rcommentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcommentName.Width = 89;
            // 
            // rcommentText
            // 
            this.rcommentText.Text = "내용";
            this.rcommentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcommentText.Width = 433;
            // 
            // rcommentRdate
            // 
            this.rcommentRdate.Text = "등록일";
            this.rcommentRdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcommentRdate.Width = 373;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1325, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저관리ToolStripMenuItem,
            this.축제관리ToolStripMenuItem,
            this.커뮤니티관리ToolStripMenuItem,
            this.리뷰관리ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 유저관리ToolStripMenuItem
            // 
            this.유저관리ToolStripMenuItem.Name = "유저관리ToolStripMenuItem";
            this.유저관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.유저관리ToolStripMenuItem.Text = "유저 관리";
            this.유저관리ToolStripMenuItem.Click += new System.EventHandler(this.유저관리ToolStripMenuItem_Click);
            // 
            // 축제관리ToolStripMenuItem
            // 
            this.축제관리ToolStripMenuItem.Name = "축제관리ToolStripMenuItem";
            this.축제관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.축제관리ToolStripMenuItem.Text = "축제 관리";
            this.축제관리ToolStripMenuItem.Click += new System.EventHandler(this.축제관리ToolStripMenuItem_Click);
            // 
            // 커뮤니티관리ToolStripMenuItem
            // 
            this.커뮤니티관리ToolStripMenuItem.Name = "커뮤니티관리ToolStripMenuItem";
            this.커뮤니티관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.커뮤니티관리ToolStripMenuItem.Text = "커뮤니티 관리";
            this.커뮤니티관리ToolStripMenuItem.Click += new System.EventHandler(this.커뮤니티관리ToolStripMenuItem_Click);
            // 
            // 리뷰관리ToolStripMenuItem
            // 
            this.리뷰관리ToolStripMenuItem.Name = "리뷰관리ToolStripMenuItem";
            this.리뷰관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.리뷰관리ToolStripMenuItem.Text = "리뷰 관리";
            this.리뷰관리ToolStripMenuItem.Click += new System.EventHandler(this.리뷰관리ToolStripMenuItem_Click);
            // 
            // ccommentbtn
            // 
            this.ccommentbtn.Location = new System.Drawing.Point(1054, 94);
            this.ccommentbtn.Name = "ccommentbtn";
            this.ccommentbtn.Size = new System.Drawing.Size(101, 46);
            this.ccommentbtn.TabIndex = 16;
            this.ccommentbtn.Text = "커뮤니티";
            this.ccommentbtn.UseVisualStyleBackColor = true;
            this.ccommentbtn.Click += new System.EventHandler(this.ccommentbtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 595);
            this.Controls.Add(this.ccommentbtn);
            this.Controls.Add(this.rcommentlistview);
            this.Controls.Add(this.listAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.rcommentbtn);
            this.Controls.Add(this.fcommentbtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "코멘트 관리";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader fcommentNo;
        private System.Windows.Forms.ColumnHeader fcommentFno;
        private System.Windows.Forms.ColumnHeader fcommentID;
        private System.Windows.Forms.ColumnHeader fcommentName;
        private System.Windows.Forms.ColumnHeader fcommentText;
        private System.Windows.Forms.ColumnHeader fcommentGrade;
        private System.Windows.Forms.ColumnHeader fcommentRdate;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button fcommentbtn;
        private System.Windows.Forms.Button rcommentbtn;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button listAllBtn;
        private System.Windows.Forms.ListView rcommentlistview;
        private System.Windows.Forms.ColumnHeader rcommentNo;
        private System.Windows.Forms.ColumnHeader rcommentRno;
        private System.Windows.Forms.ColumnHeader rcommentID;
        private System.Windows.Forms.ColumnHeader rcommentName;
        private System.Windows.Forms.ColumnHeader rcommentText;
        private System.Windows.Forms.ColumnHeader rcommentRdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유저관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축제관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 커뮤니티관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리뷰관리ToolStripMenuItem;
        private System.Windows.Forms.Button ccommentbtn;
    }
}