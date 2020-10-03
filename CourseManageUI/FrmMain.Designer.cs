namespace CourseManageUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditPwd = new System.Windows.Forms.Button();
            this.btnTeacherManage = new System.Windows.Forms.Button();
            this.btnCourseManage = new System.Windows.Forms.Button();
            this.btnAddCourseInfo = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 66);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(883, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrentUser.Image")));
            this.lblCurrentUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentUser.Location = new System.Drawing.Point(809, 30);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(62, 27);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "常老师";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.btnEditPwd);
            this.panel2.Controls.Add(this.btnTeacherManage);
            this.panel2.Controls.Add(this.btnCourseManage);
            this.panel2.Controls.Add(this.btnAddCourseInfo);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 471);
            this.panel2.TabIndex = 1;
            // 
            // btnEditPwd
            // 
            this.btnEditPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnEditPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPwd.ForeColor = System.Drawing.Color.White;
            this.btnEditPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPwd.Image")));
            this.btnEditPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPwd.Location = new System.Drawing.Point(51, 407);
            this.btnEditPwd.Name = "btnEditPwd";
            this.btnEditPwd.Size = new System.Drawing.Size(120, 33);
            this.btnEditPwd.TabIndex = 1;
            this.btnEditPwd.Text = "    修改登录密码";
            this.btnEditPwd.UseVisualStyleBackColor = false;
            this.btnEditPwd.Click += new System.EventHandler(this.btnEditPwd_Click);
            // 
            // btnTeacherManage
            // 
            this.btnTeacherManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnTeacherManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManage.ForeColor = System.Drawing.Color.White;
            this.btnTeacherManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManage.Image")));
            this.btnTeacherManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManage.Location = new System.Drawing.Point(51, 310);
            this.btnTeacherManage.Name = "btnTeacherManage";
            this.btnTeacherManage.Size = new System.Drawing.Size(120, 33);
            this.btnTeacherManage.TabIndex = 1;
            this.btnTeacherManage.Text = "    讲师信息管理";
            this.btnTeacherManage.UseVisualStyleBackColor = false;
            this.btnTeacherManage.Click += new System.EventHandler(this.btnTeacherManage_Click);
            // 
            // btnCourseManage
            // 
            this.btnCourseManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnCourseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseManage.ForeColor = System.Drawing.Color.White;
            this.btnCourseManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseManage.Image")));
            this.btnCourseManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManage.Location = new System.Drawing.Point(51, 271);
            this.btnCourseManage.Name = "btnCourseManage";
            this.btnCourseManage.Size = new System.Drawing.Size(120, 33);
            this.btnCourseManage.TabIndex = 1;
            this.btnCourseManage.Text = "    课程信息管理";
            this.btnCourseManage.UseVisualStyleBackColor = false;
            this.btnCourseManage.Click += new System.EventHandler(this.btnCourseManage_Click);
            // 
            // btnAddCourseInfo
            // 
            this.btnAddCourseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnAddCourseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourseInfo.ForeColor = System.Drawing.Color.White;
            this.btnAddCourseInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourseInfo.Image")));
            this.btnAddCourseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourseInfo.Location = new System.Drawing.Point(51, 232);
            this.btnAddCourseInfo.Name = "btnAddCourseInfo";
            this.btnAddCourseInfo.Size = new System.Drawing.Size(120, 33);
            this.btnAddCourseInfo.TabIndex = 1;
            this.btnAddCourseInfo.Text = "    添加课程信息";
            this.btnAddCourseInfo.UseVisualStyleBackColor = false;
            this.btnAddCourseInfo.Click += new System.EventHandler(this.btnAddCourseInfo_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 3);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.Location = new System.Drawing.Point(227, 76);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(690, 470);
            this.panelMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddCourseInfo;
        private System.Windows.Forms.Button btnEditPwd;
        private System.Windows.Forms.Button btnTeacherManage;
        private System.Windows.Forms.Button btnCourseManage;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnClose;
    }
}