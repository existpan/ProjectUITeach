using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManageUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 窗体移动
        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);//得到变量值
                leftFlag = true;//鼠标按下左键时标注为true
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false；
            }
        }
        #endregion

        private void FormEmbedding(Form form)
        {
            foreach (Control item in this.panelMain.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            //FrmCourseManage frmCourse = new FrmCourseManage();
            form.TopLevel = false;
            form.Parent = this.panelMain;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加课程信息
        private void btnAddCourseInfo_Click(object sender, EventArgs e)
        {

        }
        //课程信息管理
        private void btnCourseManage_Click(object sender, EventArgs e)
        {
            FormEmbedding(new FrmCourseManage());
        }
        //教师信息管理
        private void btnTeacherManage_Click(object sender, EventArgs e)
        {

        }
        //修改登录密码
        private void btnEditPwd_Click(object sender, EventArgs e)
        {
            FormEmbedding(new FrmModifyPwd());
        }
    }
}
