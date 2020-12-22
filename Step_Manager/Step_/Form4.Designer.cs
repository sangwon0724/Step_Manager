namespace Step_
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.combobox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.listview = new System.Windows.Forms.ListView();
            this.communityNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityWriter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityTItle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communitySigndate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityLikenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityDislikenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.communityViews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAllBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축제관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리뷰관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코멘트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "작성자",
            "제목",
            "내용"});
            this.combobox.Location = new System.Drawing.Point(31, 41);
            this.combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(124, 25);
            this.combobox.TabIndex = 0;
            this.combobox.Text = "검색 항목";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(435, 85);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 46);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(31, 524);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 46);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("굴림", 20F);
            this.searchText.Location = new System.Drawing.Point(31, 85);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(363, 46);
            this.searchText.TabIndex = 4;
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.communityNo,
            this.communityWriter,
            this.communityTItle,
            this.communityContent,
            this.communitySigndate,
            this.communityLikenum,
            this.communityDislikenum,
            this.communityViews});
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(31, 150);
            this.listview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(1242, 353);
            this.listview.TabIndex = 5;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // communityNo
            // 
            this.communityNo.Text = "번호";
            this.communityNo.Width = 70;
            // 
            // communityWriter
            // 
            this.communityWriter.Text = "작성자";
            this.communityWriter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.communityWriter.Width = 120;
            // 
            // communityTItle
            // 
            this.communityTItle.Text = "제목";
            this.communityTItle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.communityTItle.Width = 190;
            // 
            // communityContent
            // 
            this.communityContent.Text = "내용";
            this.communityContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.communityContent.Width = 333;
            // 
            // communitySigndate
            // 
            this.communitySigndate.Text = "작성일";
            this.communitySigndate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.communitySigndate.Width = 150;
            // 
            // communityLikenum
            // 
            this.communityLikenum.Text = "좋아요";
            this.communityLikenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // communityDislikenum
            // 
            this.communityDislikenum.Text = "싫어요";
            this.communityDislikenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // communityViews
            // 
            this.communityViews.Text = "조회수";
            this.communityViews.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.communityViews.Width = 100;
            // 
            // listAllBtn
            // 
            this.listAllBtn.Location = new System.Drawing.Point(566, 85);
            this.listAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAllBtn.Name = "listAllBtn";
            this.listAllBtn.Size = new System.Drawing.Size(101, 46);
            this.listAllBtn.TabIndex = 6;
            this.listAllBtn.Text = "전체보기";
            this.listAllBtn.UseVisualStyleBackColor = true;
            this.listAllBtn.Click += new System.EventHandler(this.listAllBtn_Click);
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
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저관리ToolStripMenuItem,
            this.축제관리ToolStripMenuItem,
            this.리뷰관리ToolStripMenuItem,
            this.코멘트관리ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 유저관리ToolStripMenuItem
            // 
            this.유저관리ToolStripMenuItem.Name = "유저관리ToolStripMenuItem";
            this.유저관리ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.유저관리ToolStripMenuItem.Text = "유저 관리";
            this.유저관리ToolStripMenuItem.Click += new System.EventHandler(this.유저관리ToolStripMenuItem_Click);
            // 
            // 축제관리ToolStripMenuItem
            // 
            this.축제관리ToolStripMenuItem.Name = "축제관리ToolStripMenuItem";
            this.축제관리ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.축제관리ToolStripMenuItem.Text = "축제 관리";
            this.축제관리ToolStripMenuItem.Click += new System.EventHandler(this.축제관리ToolStripMenuItem_Click);
            // 
            // 리뷰관리ToolStripMenuItem
            // 
            this.리뷰관리ToolStripMenuItem.Name = "리뷰관리ToolStripMenuItem";
            this.리뷰관리ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.리뷰관리ToolStripMenuItem.Text = "리뷰 관리";
            this.리뷰관리ToolStripMenuItem.Click += new System.EventHandler(this.리뷰관리ToolStripMenuItem_Click);
            // 
            // 코멘트관리ToolStripMenuItem
            // 
            this.코멘트관리ToolStripMenuItem.Name = "코멘트관리ToolStripMenuItem";
            this.코멘트관리ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.코멘트관리ToolStripMenuItem.Text = "댓글 관리";
            this.코멘트관리ToolStripMenuItem.Click += new System.EventHandler(this.코멘트관리ToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 589);
            this.Controls.Add(this.listAllBtn);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "커뮤니티 관리";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader communityNo;
        private System.Windows.Forms.ColumnHeader communityWriter;
        private System.Windows.Forms.ColumnHeader communityTItle;
        private System.Windows.Forms.ColumnHeader communityContent;
        private System.Windows.Forms.ColumnHeader communitySigndate;
        private System.Windows.Forms.ColumnHeader communityLikenum;
        private System.Windows.Forms.ColumnHeader communityDislikenum;
        private System.Windows.Forms.ColumnHeader communityViews;
        private System.Windows.Forms.Button listAllBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유저관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축제관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리뷰관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코멘트관리ToolStripMenuItem;
    }
}