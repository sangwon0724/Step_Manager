namespace Step_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUser = new System.Windows.Forms.Button();
            this.btnFes = new System.Windows.Forms.Button();
            this.btnCum = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(80, 88);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "유저";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnFes
            // 
            this.btnFes.Location = new System.Drawing.Point(87, 0);
            this.btnFes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFes.Name = "btnFes";
            this.btnFes.Size = new System.Drawing.Size(80, 88);
            this.btnFes.TabIndex = 1;
            this.btnFes.Text = "축제";
            this.btnFes.UseVisualStyleBackColor = true;
            this.btnFes.Click += new System.EventHandler(this.btnFes_Click);
            // 
            // btnCum
            // 
            this.btnCum.Location = new System.Drawing.Point(174, 0);
            this.btnCum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCum.Name = "btnCum";
            this.btnCum.Size = new System.Drawing.Size(80, 88);
            this.btnCum.TabIndex = 2;
            this.btnCum.Text = "커뮤니티";
            this.btnCum.UseVisualStyleBackColor = true;
            this.btnCum.Click += new System.EventHandler(this.btnCum_Click);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(261, 0);
            this.btnRe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(80, 88);
            this.btnRe.TabIndex = 3;
            this.btnRe.Text = "리뷰";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(347, 0);
            this.btnCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(80, 88);
            this.btnCom.TabIndex = 4;
            this.btnCom.Text = "댓글";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 90);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnCum);
            this.Controls.Add(this.btnFes);
            this.Controls.Add(this.btnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnFes;
        private System.Windows.Forms.Button btnCum;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnCom;
    }
}

