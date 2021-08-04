using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace autoClick
{
    public partial class autoClick : Form
    {
        public autoClick()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        const int MOUSEEVENTF_WHEEL = 0x0800;

        //public static void TestMoveMouse()
        //{
            //mouse_event(MOUSEEVENTF_MOVE, 50, 50, 0, 0);//相对当前鼠标位置x轴和y轴分别移动50像素
        //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);//鼠标滚动，使界面向下滚动20的高度
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 显示的是窗口内部的位置坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            lx.Text = p.X.ToString();
            ly.Text = p.Y.ToString();
            
        }

        /// <summary>
        /// 显示的是鼠标在屏幕的位置坐标
        /// </summary>
        private void GetMousePoint()
        {
            Point ms = Control.MousePosition;
            this.lpx.Text = string.Format("当前鼠标位置：{0}:{1}", ms.X, ms.Y);
            MouseButtons mb = Control.MouseButtons;

            //  获取鼠标动作（按下了 那个按键)
            if (mb == System.Windows.Forms.MouseButtons.Left)
            {
                this.lpx.Text = "Left";
            }
            if (mb == System.Windows.Forms.MouseButtons.Right)
            {
                this.lpx.Text = "Right";
                if (lindex.Text == "1")
                {
                    txtx.Text = ms.X.ToString();
                    txty.Text = ms.Y.ToString();
                }
                if (lindex.Text == "2")
                {
                    txtx2.Text = ms.X.ToString();
                    txty2.Text = ms.Y.ToString();
                }

            }
            if (mb == System.Windows.Forms.MouseButtons.Middle) this.lpx.Text = "Middle";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetMousePoint();
            y.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            SetCursorPos(Int32.Parse(txtx.Text), Int32.Parse(txty.Text));
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            string clog = DateTime.Now.ToLongTimeString() + "|" + txtlogs.Text;
            txtlogs.Text = clog;

            Thread.Sleep(3000);
            int ix2 = Int32.Parse(txtx2.Text);
            int iy2 = Int32.Parse(txty2.Text);
            if (ix2 > 0)
            {
                SetCursorPos(ix2, iy2);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }

            int ctime1 = int.Parse(txtTime1.Text);
            int ctime2 = int.Parse(txtTime2.Text);
            Random ctime = new Random();
            timer2.Interval = ctime.Next(ctime1, ctime1 + ctime2) * 1000;
            timer2.Enabled = true;
            lr.Text = "next:" + DateTime.Now.AddMilliseconds(timer2.Interval).ToLongTimeString();
            y.Text = timer2.Interval.ToString();
        }

        private void btn_Auto_Click(object sender, EventArgs e)
        {
            int lri = int.Parse(lr.Text);
            lr.Text = (lri + 1).ToString();

            Point ms = Control.MousePosition;
            txtx.Text = ms.X.ToString();
            txty.Text = ms.Y.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SetCursorPos(Int32.Parse(txtx.Text), Int32.Parse(txty.Text));
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            string clog = DateTime.Now.ToLongTimeString() + "|" + txtlogs.Text;
            txtlogs.Text = clog;

            Thread.Sleep(3000);
            int ix2 = Int32.Parse(txtx2.Text);
            int iy2 = Int32.Parse(txty2.Text);
            if (ix2 > 0)
            {
                SetCursorPos(ix2, iy2);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }

            int ctime1 = int.Parse(txtTime1.Text);
            int ctime2 = int.Parse(txtTime2.Text);
            Random ctime = new Random();
            timer2.Interval = ctime.Next(ctime1, ctime1 + ctime2) * 1000;
            timer2.Enabled = true;
            lr.Text = "next:" + DateTime.Now.AddMilliseconds(timer2.Interval).ToLongTimeString();
            y.Text = timer2.Interval.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            txtlogs.Text = "stop|"+txtlogs.Text;
        }

        private void txtx_Validated(object sender, EventArgs e)
        {
            txtx.Text = isnum(txtx.Text, 1000).ToString();
        }

        private void txty_Validated(object sender, EventArgs e)
        {
            txty.Text = isnum(txty.Text, 100).ToString();
        }

        private void txtTime1_Validated(object sender, EventArgs e)
        {
            txtTime1.Text = isnum(txtTime1.Text, 30).ToString();
        }

        private void txtTime2_Validated(object sender, EventArgs e)
        {
            txtTime2.Text = isnum(txtTime2.Text, 20).ToString();
        }

        private int isnum(string e, int maxd)
        {
            try {
                maxd = int.Parse(e);
            }
            catch {
            }
            return maxd;
        }

        private void txtx2_Click(object sender, EventArgs e)
        {
            lindex.Text = "2";
        }

        private void txtx_Click(object sender, EventArgs e)
        {
            lindex.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskEdit te = new TaskEdit();
            te.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            excuteTasks et = new excuteTasks();
            et.ShowDialog();
        }
    }
}
