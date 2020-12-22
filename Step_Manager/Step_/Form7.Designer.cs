namespace Step_
{
    partial class Form7
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
            this.btnapply = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnAble = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbSmallArea = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbBigArea = new System.Windows.Forms.TextBox();
            this.tbno = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(202, 381);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(171, 57);
            this.btnapply.TabIndex = 40;
            this.btnapply.Text = "축제수락";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Visible = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(667, 195);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(102, 23);
            this.btnDisable.TabIndex = 39;
            this.btnDisable.Text = "날짜고정하기";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnAble
            // 
            this.btnAble.Location = new System.Drawing.Point(549, 195);
            this.btnAble.Name = "btnAble";
            this.btnAble.Size = new System.Drawing.Size(102, 23);
            this.btnAble.TabIndex = 38;
            this.btnAble.Text = "날짜변경하기";
            this.btnAble.UseVisualStyleBackColor = true;
            this.btnAble.Click += new System.EventHandler(this.btnAble_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(624, 381);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(145, 57);
            this.btncancle.TabIndex = 37;
            this.btncancle.Text = "취소";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(467, 381);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 57);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "수정";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 57);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "TAG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "지역소분류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "지역대분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "축제명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "번호";
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(549, 224);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.ReadOnly = true;
            this.tbStartDate.Size = new System.Drawing.Size(220, 21);
            this.tbStartDate.TabIndex = 27;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(549, 251);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.ReadOnly = true;
            this.tbEndDate.Size = new System.Drawing.Size(220, 21);
            this.tbEndDate.TabIndex = 26;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(549, 31);
            this.monthCalendar1.MaxSelectionCount = 10000;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(149, 332);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(620, 21);
            this.tbURL.TabIndex = 24;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(149, 305);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(620, 21);
            this.tbLocation.TabIndex = 23;
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(149, 278);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(620, 21);
            this.tbTag.TabIndex = 22;
            // 
            // tbSmallArea
            // 
            this.tbSmallArea.Location = new System.Drawing.Point(467, 40);
            this.tbSmallArea.Name = "tbSmallArea";
            this.tbSmallArea.Size = new System.Drawing.Size(70, 21);
            this.tbSmallArea.TabIndex = 21;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(31, 67);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(506, 205);
            this.tbText.TabIndex = 20;
            // 
            // tbBigArea
            // 
            this.tbBigArea.Location = new System.Drawing.Point(389, 40);
            this.tbBigArea.Name = "tbBigArea";
            this.tbBigArea.Size = new System.Drawing.Size(72, 21);
            this.tbBigArea.TabIndex = 19;
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(79, 12);
            this.tbno.Name = "tbno";
            this.tbno.ReadOnly = true;
            this.tbno.Size = new System.Drawing.Size(71, 21);
            this.tbno.TabIndex = 18;
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(79, 39);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(294, 21);
            this.tbfname.TabIndex = 17;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnAble);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbSmallArea);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbBigArea);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.tbfname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(800, 300);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "축제 수락";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnAble;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbSmallArea;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbBigArea;
        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.TextBox tbfname;
    }
}