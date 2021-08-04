
namespace autoClick
{
    partial class TaskEdit
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtStepid = new System.Windows.Forms.TextBox();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.txtStepx = new System.Windows.Forms.TextBox();
            this.txtStepy = new System.Windows.Forms.TextBox();
            this.txtStepinterval = new System.Windows.Forms.TextBox();
            this.txtTaskid = new System.Windows.Forms.TextBox();
            this.txtTaskname = new System.Windows.Forms.TextBox();
            this.txtTaskInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStepTaskid = new System.Windows.Forms.TextBox();
            this.btnFlash = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbtaskcount = new System.Windows.Forms.Label();
            this.txtTaskCount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(187, 385);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addRootToolStripMenuItem,
            this.delToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem.Text = "新增步骤";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addRootToolStripMenuItem
            // 
            this.addRootToolStripMenuItem.Name = "addRootToolStripMenuItem";
            this.addRootToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addRootToolStripMenuItem.Text = "新增任务";
            this.addRootToolStripMenuItem.Click += new System.EventHandler(this.addRootToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.delToolStripMenuItem.Text = "删除";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "提交保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = true;
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(205, 13);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 12);
            this.toolStripStatusLabel1.TabIndex = 1;
            this.toolStripStatusLabel1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "提交保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 452);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(361, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Location = new System.Drawing.Point(559, 427);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(111, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtStepid
            // 
            this.txtStepid.Location = new System.Drawing.Point(263, 190);
            this.txtStepid.Name = "txtStepid";
            this.txtStepid.ReadOnly = true;
            this.txtStepid.Size = new System.Drawing.Size(81, 21);
            this.txtStepid.TabIndex = 6;
            // 
            // txtStepName
            // 
            this.txtStepName.Location = new System.Drawing.Point(263, 217);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(81, 21);
            this.txtStepName.TabIndex = 6;
            // 
            // txtStepx
            // 
            this.txtStepx.Location = new System.Drawing.Point(263, 244);
            this.txtStepx.Name = "txtStepx";
            this.txtStepx.Size = new System.Drawing.Size(81, 21);
            this.txtStepx.TabIndex = 6;
            this.txtStepx.TextChanged += new System.EventHandler(this.txtStepx_TextChanged);
            // 
            // txtStepy
            // 
            this.txtStepy.Location = new System.Drawing.Point(263, 271);
            this.txtStepy.Name = "txtStepy";
            this.txtStepy.Size = new System.Drawing.Size(81, 21);
            this.txtStepy.TabIndex = 6;
            // 
            // txtStepinterval
            // 
            this.txtStepinterval.Location = new System.Drawing.Point(263, 298);
            this.txtStepinterval.Name = "txtStepinterval";
            this.txtStepinterval.Size = new System.Drawing.Size(81, 21);
            this.txtStepinterval.TabIndex = 6;
            // 
            // txtTaskid
            // 
            this.txtTaskid.Location = new System.Drawing.Point(263, 58);
            this.txtTaskid.Name = "txtTaskid";
            this.txtTaskid.ReadOnly = true;
            this.txtTaskid.Size = new System.Drawing.Size(81, 21);
            this.txtTaskid.TabIndex = 6;
            // 
            // txtTaskname
            // 
            this.txtTaskname.Location = new System.Drawing.Point(263, 85);
            this.txtTaskname.Name = "txtTaskname";
            this.txtTaskname.Size = new System.Drawing.Size(81, 21);
            this.txtTaskname.TabIndex = 6;
            // 
            // txtTaskInterval
            // 
            this.txtTaskInterval.Location = new System.Drawing.Point(263, 112);
            this.txtTaskInterval.Name = "txtTaskInterval";
            this.txtTaskInterval.Size = new System.Drawing.Size(81, 21);
            this.txtTaskInterval.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "任务ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "任务名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "间隔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "步骤ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "步骤名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "步骤x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "步骤y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "步骤间隔";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "任务id";
            // 
            // txtStepTaskid
            // 
            this.txtStepTaskid.Location = new System.Drawing.Point(264, 326);
            this.txtStepTaskid.Name = "txtStepTaskid";
            this.txtStepTaskid.ReadOnly = true;
            this.txtStepTaskid.Size = new System.Drawing.Size(81, 21);
            this.txtStepTaskid.TabIndex = 6;
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(207, 374);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(75, 23);
            this.btnFlash.TabIndex = 2;
            this.btnFlash.Text = "更新";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbtaskcount
            // 
            this.lbtaskcount.AutoSize = true;
            this.lbtaskcount.Location = new System.Drawing.Point(205, 142);
            this.lbtaskcount.Name = "lbtaskcount";
            this.lbtaskcount.Size = new System.Drawing.Size(53, 12);
            this.lbtaskcount.TabIndex = 1;
            this.lbtaskcount.Text = "执行次数";
            // 
            // txtTaskCount
            // 
            this.txtTaskCount.Location = new System.Drawing.Point(263, 139);
            this.txtTaskCount.Name = "txtTaskCount";
            this.txtTaskCount.Size = new System.Drawing.Size(81, 21);
            this.txtTaskCount.TabIndex = 6;
            this.txtTaskCount.Text = "1";
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 477);
            this.Controls.Add(this.txtStepTaskid);
            this.Controls.Add(this.txtStepinterval);
            this.Controls.Add(this.txtTaskCount);
            this.Controls.Add(this.txtTaskInterval);
            this.Controls.Add(this.txtStepy);
            this.Controls.Add(this.txtTaskname);
            this.Controls.Add(this.txtTaskid);
            this.Controls.Add(this.txtStepx);
            this.Controls.Add(this.txtStepName);
            this.Controls.Add(this.txtStepid);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbtaskcount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Controls.Add(this.treeView1);
            this.Name = "TaskEdit";
            this.Text = "任务编辑器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskEdit_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox txtStepid;
        private System.Windows.Forms.TextBox txtStepName;
        private System.Windows.Forms.TextBox txtStepx;
        private System.Windows.Forms.TextBox txtStepy;
        private System.Windows.Forms.TextBox txtStepinterval;
        private System.Windows.Forms.TextBox txtTaskid;
        private System.Windows.Forms.TextBox txtTaskname;
        private System.Windows.Forms.TextBox txtTaskInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStepTaskid;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbtaskcount;
        private System.Windows.Forms.TextBox txtTaskCount;
    }
}