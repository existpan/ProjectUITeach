namespace CourseManageUI
{
    partial class FrmModifyPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyPwd));
            this.gpbUserModifyPwd = new System.Windows.Forms.GroupBox();
            this.btnSave_PwdEdit = new System.Windows.Forms.Button();
            this.btnExit_Edit = new System.Windows.Forms.Button();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.gpbUserModifyPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbUserModifyPwd
            // 
            this.gpbUserModifyPwd.Controls.Add(this.label3);
            this.gpbUserModifyPwd.Controls.Add(this.label2);
            this.gpbUserModifyPwd.Controls.Add(this.label1);
            this.gpbUserModifyPwd.Controls.Add(this.txtConfirmPwd);
            this.gpbUserModifyPwd.Controls.Add(this.txtNewPwd);
            this.gpbUserModifyPwd.Controls.Add(this.txtOldPwd);
            this.gpbUserModifyPwd.Controls.Add(this.btnExit_Edit);
            this.gpbUserModifyPwd.Controls.Add(this.btnSave_PwdEdit);
            this.gpbUserModifyPwd.Location = new System.Drawing.Point(201, 134);
            this.gpbUserModifyPwd.Name = "gpbUserModifyPwd";
            this.gpbUserModifyPwd.Size = new System.Drawing.Size(270, 170);
            this.gpbUserModifyPwd.TabIndex = 0;
            this.gpbUserModifyPwd.TabStop = false;
            this.gpbUserModifyPwd.Text = "[用户修改密码]";
            // 
            // btnSave_PwdEdit
            // 
            this.btnSave_PwdEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnSave_PwdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_PwdEdit.ForeColor = System.Drawing.Color.White;
            this.btnSave_PwdEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_PwdEdit.Image")));
            this.btnSave_PwdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave_PwdEdit.Location = new System.Drawing.Point(32, 129);
            this.btnSave_PwdEdit.Name = "btnSave_PwdEdit";
            this.btnSave_PwdEdit.Size = new System.Drawing.Size(86, 26);
            this.btnSave_PwdEdit.TabIndex = 3;
            this.btnSave_PwdEdit.Text = "  提交修改";
            this.btnSave_PwdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave_PwdEdit.UseVisualStyleBackColor = false;
            // 
            // btnExit_Edit
            // 
            this.btnExit_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.btnExit_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit_Edit.ForeColor = System.Drawing.Color.White;
            this.btnExit_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit_Edit.Image")));
            this.btnExit_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit_Edit.Location = new System.Drawing.Point(174, 129);
            this.btnExit_Edit.Name = "btnExit_Edit";
            this.btnExit_Edit.Size = new System.Drawing.Size(60, 26);
            this.btnExit_Edit.TabIndex = 4;
            this.btnExit_Edit.Text = "  退出";
            this.btnExit_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit_Edit.UseVisualStyleBackColor = false;
            this.btnExit_Edit.Click += new System.EventHandler(this.btnExit_Edit_Click);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(100, 34);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(145, 21);
            this.txtOldPwd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "新密码确认：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(100, 61);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(145, 21);
            this.txtNewPwd.TabIndex = 5;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(100, 90);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Size = new System.Drawing.Size(145, 21);
            this.txtConfirmPwd.TabIndex = 5;
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.gpbUserModifyPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifyPwd";
            this.Text = "FrmModifyPwd";
            this.gpbUserModifyPwd.ResumeLayout(false);
            this.gpbUserModifyPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUserModifyPwd;
        private System.Windows.Forms.Button btnSave_PwdEdit;
        private System.Windows.Forms.Button btnExit_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
    }
}