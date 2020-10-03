namespace CourseManageUI
{
    partial class FrmCourseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnModifyCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName_Modify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnCourseQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCourseCount = new System.Windows.Forms.Label();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.panel_Modify = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCourseCategory_Modify = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCredit_Modify = new System.Windows.Forms.TextBox();
            this.txtClassHour_Modify = new System.Windows.Forms.TextBox();
            this.txtCourseContent_Modify = new System.Windows.Forms.TextBox();
            this.lblCourseIdNum = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.btnExit_Edit = new System.Windows.Forms.Button();
            this.btnSave_Edit = new System.Windows.Forms.Button();
            this.cbbCourseCategory = new System.Windows.Forms.ComboBox();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.panel_Modify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "当前位置：课程管理";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(321, 12);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(86, 26);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "  添加课程";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // btnModifyCourse
            // 
            this.btnModifyCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnModifyCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCourse.ForeColor = System.Drawing.Color.White;
            this.btnModifyCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyCourse.Image")));
            this.btnModifyCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyCourse.Location = new System.Drawing.Point(413, 12);
            this.btnModifyCourse.Name = "btnModifyCourse";
            this.btnModifyCourse.Size = new System.Drawing.Size(86, 26);
            this.btnModifyCourse.TabIndex = 2;
            this.btnModifyCourse.Text = "  修改课程";
            this.btnModifyCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyCourse.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCourse.Image")));
            this.btnDeleteCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCourse.Location = new System.Drawing.Point(505, 12);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteCourse.TabIndex = 2;
            this.btnDeleteCourse.Text = "  删除课程";
            this.btnDeleteCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(597, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "  退出管理";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine.Location = new System.Drawing.Point(0, 36);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(690, 1);
            this.lblLine.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程分类：";
            // 
            // txtCourseName_Modify
            // 
            this.txtCourseName_Modify.Location = new System.Drawing.Point(71, 30);
            this.txtCourseName_Modify.Name = "txtCourseName_Modify";
            this.txtCourseName_Modify.Size = new System.Drawing.Size(250, 21);
            this.txtCourseName_Modify.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程名称：";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(287, 56);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(120, 21);
            this.txtCourseName.TabIndex = 4;
            // 
            // btnCourseQuery
            // 
            this.btnCourseQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnCourseQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseQuery.ForeColor = System.Drawing.Color.White;
            this.btnCourseQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseQuery.Image")));
            this.btnCourseQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseQuery.Location = new System.Drawing.Point(413, 53);
            this.btnCourseQuery.Name = "btnCourseQuery";
            this.btnCourseQuery.Size = new System.Drawing.Size(86, 26);
            this.btnCourseQuery.TabIndex = 2;
            this.btnCourseQuery.Text = "  提交查询";
            this.btnCourseQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourseQuery.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "查询结果总数：";
            // 
            // lblCourseCount
            // 
            this.lblCourseCount.AutoSize = true;
            this.lblCourseCount.Location = new System.Drawing.Point(595, 60);
            this.lblCourseCount.Name = "lblCourseCount";
            this.lblCourseCount.Size = new System.Drawing.Size(11, 12);
            this.lblCourseCount.TabIndex = 0;
            this.lblCourseCount.Text = "0";
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourseList.ColumnHeadersHeight = 30;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.Credit,
            this.ClassHour,
            this.CourseContent,
            this.Teacher});
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(223)))));
            this.dgvCourseList.Location = new System.Drawing.Point(11, 96);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.Size = new System.Drawing.Size(671, 362);
            this.dgvCourseList.TabIndex = 5;
            // 
            // panel_Modify
            // 
            this.panel_Modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Modify.Controls.Add(this.groupBox1);
            this.panel_Modify.Controls.Add(this.lblCourseIdNum);
            this.panel_Modify.Controls.Add(this.lblCourseId);
            this.panel_Modify.Controls.Add(this.btnExit_Edit);
            this.panel_Modify.Controls.Add(this.btnSave_Edit);
            this.panel_Modify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Modify.Location = new System.Drawing.Point(0, 323);
            this.panel_Modify.Name = "panel_Modify";
            this.panel_Modify.Size = new System.Drawing.Size(690, 147);
            this.panel_Modify.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCourseCategory_Modify);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCredit_Modify);
            this.groupBox1.Controls.Add(this.txtClassHour_Modify);
            this.groupBox1.Controls.Add(this.txtCourseContent_Modify);
            this.groupBox1.Controls.Add(this.txtCourseName_Modify);
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[课程信息]";
            // 
            // cbbCourseCategory_Modify
            // 
            this.cbbCourseCategory_Modify.FormattingEnabled = true;
            this.cbbCourseCategory_Modify.Location = new System.Drawing.Point(501, 65);
            this.cbbCourseCategory_Modify.Name = "cbbCourseCategory_Modify";
            this.cbbCourseCategory_Modify.Size = new System.Drawing.Size(165, 20);
            this.cbbCourseCategory_Modify.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "课程分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "学分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "课时：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "课程概述：";
            // 
            // txtCredit_Modify
            // 
            this.txtCredit_Modify.Location = new System.Drawing.Point(546, 30);
            this.txtCredit_Modify.Name = "txtCredit_Modify";
            this.txtCredit_Modify.Size = new System.Drawing.Size(120, 21);
            this.txtCredit_Modify.TabIndex = 4;
            // 
            // txtClassHour_Modify
            // 
            this.txtClassHour_Modify.Location = new System.Drawing.Point(373, 30);
            this.txtClassHour_Modify.Name = "txtClassHour_Modify";
            this.txtClassHour_Modify.Size = new System.Drawing.Size(120, 21);
            this.txtClassHour_Modify.TabIndex = 4;
            // 
            // txtCourseContent_Modify
            // 
            this.txtCourseContent_Modify.Location = new System.Drawing.Point(71, 64);
            this.txtCourseContent_Modify.Name = "txtCourseContent_Modify";
            this.txtCourseContent_Modify.Size = new System.Drawing.Size(325, 21);
            this.txtCourseContent_Modify.TabIndex = 4;
            // 
            // lblCourseIdNum
            // 
            this.lblCourseIdNum.AutoSize = true;
            this.lblCourseIdNum.Location = new System.Drawing.Point(70, 13);
            this.lblCourseIdNum.Name = "lblCourseIdNum";
            this.lblCourseIdNum.Size = new System.Drawing.Size(29, 12);
            this.lblCourseIdNum.TabIndex = 0;
            this.lblCourseIdNum.Text = "0000";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(12, 13);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(65, 12);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "课程编号：";
            // 
            // btnExit_Edit
            // 
            this.btnExit_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnExit_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit_Edit.ForeColor = System.Drawing.Color.White;
            this.btnExit_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit_Edit.Image")));
            this.btnExit_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit_Edit.Location = new System.Drawing.Point(595, 13);
            this.btnExit_Edit.Name = "btnExit_Edit";
            this.btnExit_Edit.Size = new System.Drawing.Size(86, 26);
            this.btnExit_Edit.TabIndex = 2;
            this.btnExit_Edit.Text = "  退出修改";
            this.btnExit_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit_Edit.UseVisualStyleBackColor = false;
            // 
            // btnSave_Edit
            // 
            this.btnSave_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnSave_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Edit.ForeColor = System.Drawing.Color.White;
            this.btnSave_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_Edit.Image")));
            this.btnSave_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave_Edit.Location = new System.Drawing.Point(504, 13);
            this.btnSave_Edit.Name = "btnSave_Edit";
            this.btnSave_Edit.Size = new System.Drawing.Size(86, 26);
            this.btnSave_Edit.TabIndex = 2;
            this.btnSave_Edit.Text = "  提交修改";
            this.btnSave_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave_Edit.UseVisualStyleBackColor = false;
            // 
            // cbbCourseCategory
            // 
            this.cbbCourseCategory.FormattingEnabled = true;
            this.cbbCourseCategory.Location = new System.Drawing.Point(85, 56);
            this.cbbCourseCategory.Name = "cbbCourseCategory";
            this.cbbCourseCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbCourseCategory.TabIndex = 7;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "老师";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Width = 118;
            // 
            // CourseContent
            // 
            this.CourseContent.HeaderText = "课程概述";
            this.CourseContent.Name = "CourseContent";
            this.CourseContent.ReadOnly = true;
            this.CourseContent.Width = 180;
            // 
            // ClassHour
            // 
            this.ClassHour.HeaderText = "课时";
            this.ClassHour.Name = "ClassHour";
            this.ClassHour.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 80;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 150;
            // 
            // FrmCourseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.cbbCourseCategory);
            this.Controls.Add(this.panel_Modify);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnModifyCourse);
            this.Controls.Add(this.lblCourseCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCourseQuery);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCourseManage";
            this.Text = "FrmCourseManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.panel_Modify.ResumeLayout(false);
            this.panel_Modify.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnModifyCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName_Modify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnCourseQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Panel panel_Modify;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseIdNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCredit_Modify;
        private System.Windows.Forms.TextBox txtClassHour_Modify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseContent_Modify;
        private System.Windows.Forms.ComboBox cbbCourseCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCourseCategory_Modify;
        private System.Windows.Forms.Button btnSave_Edit;
        private System.Windows.Forms.Button btnExit_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
    }
}