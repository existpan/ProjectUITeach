namespace CourseManageUI
{
    partial class FrmAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCourse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddCourseCount = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxCourseInfo = new System.Windows.Forms.GroupBox();
            this.txtCourseName_Add = new System.Windows.Forms.TextBox();
            this.txtCourseContent_Add = new System.Windows.Forms.TextBox();
            this.txtClassHour_Add = new System.Windows.Forms.TextBox();
            this.txtCredit_Add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCourseCategory_Add = new System.Windows.Forms.ComboBox();
            this.ckbAutoClear = new System.Windows.Forms.CheckBox();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "当前位置：新增课程";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "已添加课程总数：";
            // 
            // lblAddCourseCount
            // 
            this.lblAddCourseCount.AutoSize = true;
            this.lblAddCourseCount.Location = new System.Drawing.Point(278, 19);
            this.lblAddCourseCount.Name = "lblAddCourseCount";
            this.lblAddCourseCount.Size = new System.Drawing.Size(11, 12);
            this.lblAddCourseCount.TabIndex = 2;
            this.lblAddCourseCount.Text = "0";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine.Location = new System.Drawing.Point(0, 36);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(690, 1);
            this.lblLine.TabIndex = 4;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnSaveToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToDB.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(467, 12);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(110, 26);
            this.btnSaveToDB.TabIndex = 5;
            this.btnSaveToDB.Text = "  保存到数据库";
            this.btnSaveToDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(597, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 26);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "  关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBoxCourseInfo
            // 
            this.groupBoxCourseInfo.Controls.Add(this.ckbAutoClear);
            this.groupBoxCourseInfo.Controls.Add(this.cbbCourseCategory_Add);
            this.groupBoxCourseInfo.Controls.Add(this.label7);
            this.groupBoxCourseInfo.Controls.Add(this.label5);
            this.groupBoxCourseInfo.Controls.Add(this.label4);
            this.groupBoxCourseInfo.Controls.Add(this.label6);
            this.groupBoxCourseInfo.Controls.Add(this.label2);
            this.groupBoxCourseInfo.Controls.Add(this.txtCredit_Add);
            this.groupBoxCourseInfo.Controls.Add(this.txtClassHour_Add);
            this.groupBoxCourseInfo.Controls.Add(this.txtCourseContent_Add);
            this.groupBoxCourseInfo.Controls.Add(this.txtCourseName_Add);
            this.groupBoxCourseInfo.Location = new System.Drawing.Point(10, 44);
            this.groupBoxCourseInfo.Name = "groupBoxCourseInfo";
            this.groupBoxCourseInfo.Size = new System.Drawing.Size(672, 101);
            this.groupBoxCourseInfo.TabIndex = 1;
            this.groupBoxCourseInfo.TabStop = false;
            this.groupBoxCourseInfo.Text = "[课程信息]";
            // 
            // txtCourseName_Add
            // 
            this.txtCourseName_Add.Location = new System.Drawing.Point(71, 30);
            this.txtCourseName_Add.Name = "txtCourseName_Add";
            this.txtCourseName_Add.Size = new System.Drawing.Size(250, 21);
            this.txtCourseName_Add.TabIndex = 4;
            this.txtCourseName_Add.Text = ".NET全栈开发课程";
            // 
            // txtCourseContent_Add
            // 
            this.txtCourseContent_Add.Location = new System.Drawing.Point(71, 64);
            this.txtCourseContent_Add.Name = "txtCourseContent_Add";
            this.txtCourseContent_Add.Size = new System.Drawing.Size(325, 21);
            this.txtCourseContent_Add.TabIndex = 4;
            this.txtCourseContent_Add.Text = "C#语法/OOP/SQL/Winform/HTML/CSS/Jquery/JavaScript";
            // 
            // txtClassHour_Add
            // 
            this.txtClassHour_Add.Location = new System.Drawing.Point(373, 30);
            this.txtClassHour_Add.Name = "txtClassHour_Add";
            this.txtClassHour_Add.Size = new System.Drawing.Size(120, 21);
            this.txtClassHour_Add.TabIndex = 4;
            this.txtClassHour_Add.Text = "500";
            // 
            // txtCredit_Add
            // 
            this.txtCredit_Add.Location = new System.Drawing.Point(546, 30);
            this.txtCredit_Add.Name = "txtCredit_Add";
            this.txtCredit_Add.Size = new System.Drawing.Size(120, 21);
            this.txtCredit_Add.TabIndex = 4;
            this.txtCredit_Add.Text = "20";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "课程概述：";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "学分：";
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
            // cbbCourseCategory_Add
            // 
            this.cbbCourseCategory_Add.FormattingEnabled = true;
            this.cbbCourseCategory_Add.Location = new System.Drawing.Point(501, 65);
            this.cbbCourseCategory_Add.Name = "cbbCourseCategory_Add";
            this.cbbCourseCategory_Add.Size = new System.Drawing.Size(165, 20);
            this.cbbCourseCategory_Add.TabIndex = 7;
            // 
            // ckbAutoClear
            // 
            this.ckbAutoClear.AutoSize = true;
            this.ckbAutoClear.Location = new System.Drawing.Point(74, -1);
            this.ckbAutoClear.Name = "ckbAutoClear";
            this.ckbAutoClear.Size = new System.Drawing.Size(132, 16);
            this.ckbAutoClear.TabIndex = 7;
            this.ckbAutoClear.Text = "添加后自动清除文本";
            this.ckbAutoClear.UseVisualStyleBackColor = true;
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
            this.CourseCategory});
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(223)))));
            this.dgvCourseList.Location = new System.Drawing.Point(10, 151);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.Size = new System.Drawing.Size(671, 311);
            this.dgvCourseList.TabIndex = 7;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 150;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 80;
            // 
            // ClassHour
            // 
            this.ClassHour.HeaderText = "课时";
            this.ClassHour.Name = "ClassHour";
            this.ClassHour.ReadOnly = true;
            // 
            // CourseContent
            // 
            this.CourseContent.HeaderText = "课程概述";
            this.CourseContent.Name = "CourseContent";
            this.CourseContent.ReadOnly = true;
            this.CourseContent.Width = 180;
            // 
            // CourseCategory
            // 
            this.CourseCategory.HeaderText = "课程分类";
            this.CourseCategory.Name = "CourseCategory";
            this.CourseCategory.ReadOnly = true;
            this.CourseCategory.Width = 118;
            // 
            // FrmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.groupBoxCourseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblAddCourseCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCourse";
            this.Text = "FrmAddCourse";
            this.groupBoxCourseInfo.ResumeLayout(false);
            this.groupBoxCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddCourseCount;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxCourseInfo;
        private System.Windows.Forms.ComboBox cbbCourseCategory_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCredit_Add;
        private System.Windows.Forms.TextBox txtClassHour_Add;
        private System.Windows.Forms.TextBox txtCourseContent_Add;
        private System.Windows.Forms.TextBox txtCourseName_Add;
        private System.Windows.Forms.CheckBox ckbAutoClear;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCategory;
    }
}