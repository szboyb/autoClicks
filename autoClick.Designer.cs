
namespace autoClick
{
    partial class autoClick
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lx = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.ly = new System.Windows.Forms.Label();
            this.px = new System.Windows.Forms.Label();
            this.lpy = new System.Windows.Forms.Label();
            this.lpx = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lr = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlogs = new System.Windows.Forms.RichTextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.lindex = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始自动点击";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lx
            // 
            this.lx.AutoSize = true;
            this.lx.Location = new System.Drawing.Point(38, 65);
            this.lx.Name = "lx";
            this.lx.Size = new System.Drawing.Size(0, 12);
            this.lx.TabIndex = 2;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(10, 65);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(17, 12);
            this.y.TabIndex = 4;
            this.y.Text = "y:";
            // 
            // ly
            // 
            this.ly.AutoSize = true;
            this.ly.Location = new System.Drawing.Point(38, 76);
            this.ly.Name = "ly";
            this.ly.Size = new System.Drawing.Size(0, 12);
            this.ly.TabIndex = 3;
            // 
            // px
            // 
            this.px.AutoSize = true;
            this.px.Location = new System.Drawing.Point(5, 50);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(11, 12);
            this.px.TabIndex = 6;
            this.px.Text = "x";
            // 
            // lpy
            // 
            this.lpy.AutoSize = true;
            this.lpy.Location = new System.Drawing.Point(16, 108);
            this.lpy.Name = "lpy";
            this.lpy.Size = new System.Drawing.Size(11, 12);
            this.lpy.TabIndex = 5;
            this.lpy.Text = "2";
            // 
            // lpx
            // 
            this.lpx.AutoSize = true;
            this.lpx.Location = new System.Drawing.Point(10, 108);
            this.lpx.Name = "lpx";
            this.lpx.Size = new System.Drawing.Size(11, 12);
            this.lpx.TabIndex = 6;
            this.lpx.Text = "2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(40, 135);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(47, 21);
            this.txtx.TabIndex = 7;
            this.txtx.Text = "0";
            this.txtx.Click += new System.EventHandler(this.txtx_Click);
            this.txtx.Validated += new System.EventHandler(this.txtx_Validated);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(93, 135);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(47, 21);
            this.txty.TabIndex = 8;
            this.txty.Text = "0";
            this.txty.Validated += new System.EventHandler(this.txty_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "一、";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "二、";
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(8, 207);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(26, 21);
            this.txtTime1.TabIndex = 7;
            this.txtTime1.Text = "60";
            this.txtTime1.Validated += new System.EventHandler(this.txtTime1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "间隔时间：固定+随机（秒）";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(10, 86);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(11, 12);
            this.lr.TabIndex = 4;
            this.lr.Text = "1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(-1, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(134, 48);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "1. 鼠标右击选择目标，\n2. 输入间隔时间，\n3. 开始自动点击";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtlogs
            // 
            this.txtlogs.BackColor = System.Drawing.SystemColors.Info;
            this.txtlogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogs.Location = new System.Drawing.Point(-1, 282);
            this.txtlogs.Name = "txtlogs";
            this.txtlogs.Size = new System.Drawing.Size(161, 70);
            this.txtlogs.TabIndex = 9;
            this.txtlogs.Text = "";
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(53, 207);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(26, 21);
            this.txtTime2.TabIndex = 7;
            this.txtTime2.Text = "30";
            this.txtTime2.Validated += new System.EventHandler(this.txtTime2_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "+";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(40, 159);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(47, 21);
            this.txtx2.TabIndex = 7;
            this.txtx2.Text = "0";
            this.txtx2.Click += new System.EventHandler(this.txtx2_Click);
            this.txtx2.Validated += new System.EventHandler(this.txtx_Validated);
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(93, 159);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(47, 21);
            this.txty2.TabIndex = 8;
            this.txty2.Text = "0";
            this.txty2.Validated += new System.EventHandler(this.txty_Validated);
            // 
            // lindex
            // 
            this.lindex.AutoSize = true;
            this.lindex.Location = new System.Drawing.Point(38, 120);
            this.lindex.Name = "lindex";
            this.lindex.Size = new System.Drawing.Size(11, 12);
            this.lindex.TabIndex = 4;
            this.lindex.Text = "1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-4, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "编辑多任务";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "执行多任务";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // autoClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtlogs);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lpx);
            this.Controls.Add(this.lpy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.px);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lindex);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.y);
            this.Controls.Add(this.ly);
            this.Controls.Add(this.lx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "autoClick";
            this.Text = "鼠标自动点击";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lx;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label ly;
        private System.Windows.Forms.Label px;
        private System.Windows.Forms.Label lpy;
        private System.Windows.Forms.Label lpx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtlogs;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label lindex;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

