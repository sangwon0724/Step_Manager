namespace Step_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblstate = new System.Windows.Forms.Label();
            this.btnapplyfestival = new System.Windows.Forms.Button();
            this.btntofestival = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.dgviewfst = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커뮤니티관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코멘트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리뷰관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewfst)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(218, 46);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(37, 15);
            this.lblstate.TabIndex = 20;
            this.lblstate.Text = "축제";
            // 
            // btnapplyfestival
            // 
            this.btnapplyfestival.Location = new System.Drawing.Point(106, 40);
            this.btnapplyfestival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnapplyfestival.Name = "btnapplyfestival";
            this.btnapplyfestival.Size = new System.Drawing.Size(86, 29);
            this.btnapplyfestival.TabIndex = 19;
            this.btnapplyfestival.Text = "신청축제";
            this.btnapplyfestival.UseVisualStyleBackColor = true;
            this.btnapplyfestival.Click += new System.EventHandler(this.btnapplyfestival_Click);
            // 
            // btntofestival
            // 
            this.btntofestival.Enabled = false;
            this.btntofestival.Location = new System.Drawing.Point(14, 40);
            this.btntofestival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntofestival.Name = "btntofestival";
            this.btntofestival.Size = new System.Drawing.Size(86, 29);
            this.btntofestival.TabIndex = 18;
            this.btntofestival.Text = "축제";
            this.btntofestival.UseVisualStyleBackColor = true;
            this.btntofestival.Click += new System.EventHandler(this.btntofestival_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(437, 74);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(86, 29);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.Text = "검색";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(106, 76);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(323, 25);
            this.tbsearch.TabIndex = 16;
            // 
            // cbsearch
            // 
            this.cbsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Items.AddRange(new object[] {
            "축제명",
            "축제설명",
            "대지역",
            "소지역",
            "태그"});
            this.cbsearch.Location = new System.Drawing.Point(14, 78);
            this.cbsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(85, 23);
            this.cbsearch.TabIndex = 15;
            // 
            // dgviewfst
            // 
            this.dgviewfst.AllowUserToAddRows = false;
            this.dgviewfst.AllowUserToDeleteRows = false;
            this.dgviewfst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewfst.Location = new System.Drawing.Point(14, 122);
            this.dgviewfst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgviewfst.MultiSelect = false;
            this.dgviewfst.Name = "dgviewfst";
            this.dgviewfst.ReadOnly = true;
            this.dgviewfst.RowHeadersWidth = 51;
            this.dgviewfst.RowTemplate.Height = 23;
            this.dgviewfst.Size = new System.Drawing.Size(1432, 394);
            this.dgviewfst.TabIndex = 14;
            this.dgviewfst.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewfst_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1465, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저관리ToolStripMenuItem,
            this.커뮤니티관리ToolStripMenuItem,
            this.코멘트관리ToolStripMenuItem,
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
            this.코멘트관리ToolStripMenuItem.Text = "리뷰 관리";
            this.코멘트관리ToolStripMenuItem.Click += new System.EventHandler(this.코멘트관리ToolStripMenuItem_Click);
            // 
            // 리뷰관리ToolStripMenuItem
            // 
            this.리뷰관리ToolStripMenuItem.Name = "리뷰관리ToolStripMenuItem";
            this.리뷰관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.리뷰관리ToolStripMenuItem.Text = "댓글 관리";
            this.리뷰관리ToolStripMenuItem.Click += new System.EventHandler(this.리뷰관리ToolStripMenuItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1360, 524);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 29);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 564);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.btnapplyfestival);
            this.Controls.Add(this.btntofestival);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.cbsearch);
            this.Controls.Add(this.dgviewfst);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "축제 관리";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewfst)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Button btnapplyfestival;
        private System.Windows.Forms.Button btntofestival;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.ComboBox cbsearch;
        private System.Windows.Forms.DataGridView dgviewfst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유저관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 커뮤니티관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코멘트관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리뷰관리ToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
    }
}