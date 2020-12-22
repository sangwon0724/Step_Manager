namespace Step_
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축제관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커뮤니티관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리뷰관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코멘트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chPW,
            this.chName,
            this.chPhone,
            this.chAuth});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 303);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "아이디";
            this.chID.Width = 100;
            // 
            // chPW
            // 
            this.chPW.Text = "비밀번호";
            this.chPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPW.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 100;
            // 
            // chPhone
            // 
            this.chPhone.Text = "전화번호";
            this.chPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhone.Width = 120;
            // 
            // chAuth
            // 
            this.chAuth.Text = "비고";
            this.chAuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAuth.Width = 140;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 370);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(117, 25);
            this.txtID.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(79, 402);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(117, 25);
            this.txtPW.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 436);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 470);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(117, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "전화번호";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(341, 370);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 25);
            this.txtSearch.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "아이디";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(465, 368);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(465, 406);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(465, 442);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 29);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "삽입";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(465, 479);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(667, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.축제관리ToolStripMenuItem,
            this.커뮤니티관리ToolStripMenuItem,
            this.리뷰관리ToolStripMenuItem,
            this.코멘트관리ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 축제관리ToolStripMenuItem
            // 
            this.축제관리ToolStripMenuItem.Name = "축제관리ToolStripMenuItem";
            this.축제관리ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.축제관리ToolStripMenuItem.Text = "축제 관리";
            this.축제관리ToolStripMenuItem.Click += new System.EventHandler(this.축제관리ToolStripMenuItem_Click);
            // 
            // 커뮤니티관리ToolStripMenuItem
            // 
            this.커뮤니티관리ToolStripMenuItem.Name = "커뮤니티관리ToolStripMenuItem";
            this.커뮤니티관리ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.커뮤니티관리ToolStripMenuItem.Text = "커뮤니티 관리";
            this.커뮤니티관리ToolStripMenuItem.Click += new System.EventHandler(this.커뮤니티관리ToolStripMenuItem_Click);
            // 
            // 리뷰관리ToolStripMenuItem
            // 
            this.리뷰관리ToolStripMenuItem.Name = "리뷰관리ToolStripMenuItem";
            this.리뷰관리ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.리뷰관리ToolStripMenuItem.Text = "리뷰 관리";
            this.리뷰관리ToolStripMenuItem.Click += new System.EventHandler(this.리뷰관리ToolStripMenuItem_Click);
            // 
            // 코멘트관리ToolStripMenuItem
            // 
            this.코멘트관리ToolStripMenuItem.Name = "코멘트관리ToolStripMenuItem";
            this.코멘트관리ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.코멘트관리ToolStripMenuItem.Text = "댓글 관리";
            this.코멘트관리ToolStripMenuItem.Click += new System.EventHandler(this.코멘트관리ToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 576);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(800, 300);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유저 관리";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chPW;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chAuth;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축제관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 커뮤니티관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리뷰관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코멘트관리ToolStripMenuItem;
    }
}