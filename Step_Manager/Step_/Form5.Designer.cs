namespace Step_
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.combobox = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listAllBtn = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.reviewNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewFno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewRdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewLikenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewDislikenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviewViews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축제관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커뮤니티관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코멘트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("굴림", 10.2F);
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "축제번호",
            "작성자",
            "제목",
            "내용"});
            this.combobox.Location = new System.Drawing.Point(29, 36);
            this.combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 25);
            this.combobox.TabIndex = 0;
            this.combobox.Text = "검색 항목";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("굴림", 20F);
            this.searchText.Location = new System.Drawing.Point(29, 80);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(363, 46);
            this.searchText.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(433, 80);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 46);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listAllBtn
            // 
            this.listAllBtn.Location = new System.Drawing.Point(563, 80);
            this.listAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAllBtn.Name = "listAllBtn";
            this.listAllBtn.Size = new System.Drawing.Size(101, 46);
            this.listAllBtn.TabIndex = 3;
            this.listAllBtn.Text = "전체보기";
            this.listAllBtn.UseVisualStyleBackColor = true;
            this.listAllBtn.Click += new System.EventHandler(this.listAllBtn_Click);
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reviewNo,
            this.reviewFno,
            this.reviewID,
            this.reviewTitle,
            this.reviewText,
            this.reviewGrade,
            this.reviewRdate,
            this.reviewLikenum,
            this.reviewDislikenum,
            this.reviewViews});
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(29, 145);
            this.listview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(1242, 353);
            this.listview.TabIndex = 4;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // reviewNo
            // 
            this.reviewNo.Text = "번호";
            // 
            // reviewFno
            // 
            this.reviewFno.Text = "축제번호";
            this.reviewFno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reviewID
            // 
            this.reviewID.Text = "작성자";
            this.reviewID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reviewTitle
            // 
            this.reviewTitle.Text = "제목";
            this.reviewTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reviewTitle.Width = 190;
            // 
            // reviewText
            // 
            this.reviewText.Text = "내용";
            this.reviewText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reviewText.Width = 353;
            // 
            // reviewGrade
            // 
            this.reviewGrade.Text = "평점";
            this.reviewGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reviewRdate
            // 
            this.reviewRdate.Text = "등록일";
            this.reviewRdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reviewRdate.Width = 120;
            // 
            // reviewLikenum
            // 
            this.reviewLikenum.Text = "좋아요";
            this.reviewLikenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reviewDislikenum
            // 
            this.reviewDislikenum.Text = "싫어요";
            this.reviewDislikenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reviewViews
            // 
            this.reviewViews.Text = "조회수";
            this.reviewViews.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(29, 519);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 46);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저관리ToolStripMenuItem,
            this.축제관리ToolStripMenuItem,
            this.커뮤니티관리ToolStripMenuItem,
            this.코멘트관리ToolStripMenuItem});
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
            // 코멘트관리ToolStripMenuItem
            // 
            this.코멘트관리ToolStripMenuItem.Name = "코멘트관리ToolStripMenuItem";
            this.코멘트관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.코멘트관리ToolStripMenuItem.Text = "댓글 관리";
            this.코멘트관리ToolStripMenuItem.Click += new System.EventHandler(this.코멘트관리ToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 586);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.listAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "리뷰 관리";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button listAllBtn;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ColumnHeader reviewNo;
        private System.Windows.Forms.ColumnHeader reviewFno;
        private System.Windows.Forms.ColumnHeader reviewID;
        private System.Windows.Forms.ColumnHeader reviewTitle;
        private System.Windows.Forms.ColumnHeader reviewText;
        private System.Windows.Forms.ColumnHeader reviewGrade;
        private System.Windows.Forms.ColumnHeader reviewRdate;
        private System.Windows.Forms.ColumnHeader reviewLikenum;
        private System.Windows.Forms.ColumnHeader reviewDislikenum;
        private System.Windows.Forms.ColumnHeader reviewViews;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유저관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축제관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 커뮤니티관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코멘트관리ToolStripMenuItem;
    }
}