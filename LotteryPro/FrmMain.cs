using LotteryPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPro
{
    public partial class FrmMain : Form
    {
        //选号器对象创建
        private Selector selector = new Selector();
        List<string> random = null;
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
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //定时器方法
        private void timerCreateNumber_Tick(object sender, EventArgs e)
        {
            random=selector.GetRandomList();

            this.label1.Text = random[0];
            this.label2.Text = random[1];
            this.label3.Text = random[2];
            this.label4.Text = random[3];
            this.label5.Text = random[4];
            this.label6.Text = random[5];
            this.label7.Text = random[6];

        }
        //启动选号
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnSelect.Enabled = true;
            this.timerCreateNumber.Start();
        }
        //选择号码
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.timerCreateNumber.Stop();
            this.btnSelect.Enabled = false;
            this.btnStart.Enabled = true;
            //创建双色球对象
            DoubleChromosphere doubleChromosphere = new DoubleChromosphere
            {
                Numbers = this.random
            };
            //添加到选号池 备打印、远程保存等方法使用
            this.selector.SelectNumberList.Add(doubleChromosphere);
            //在numberlist中显示号码
            string num = string.Empty;
            foreach (string item in this.random)
            {
                num += item + "  ";
            }
            this.lbNumberList.Items.Add(num);
        }
        //清除选择
        private void btnClear_Click(object sender, EventArgs e)
        { 
            this.btnSelect.Enabled = true;
            this.lbNumberList.Items.Clear();
            this.selector.SelectNumberList.Clear();
        }
        //确认购买
        private void btnConfirmBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
