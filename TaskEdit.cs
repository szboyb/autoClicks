using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Linq;

namespace autoClick
{
    public partial class TaskEdit : Form
    {
        XmlDocument doc = new XmlDocument();
        
        //XML每行的内容
        //private string xmlLine = "";

        List<cTask> ctasks = new List<cTask>();
        List<cStep> csteps = new List<cStep>();


        public TaskEdit()
        {
            InitializeComponent();
        }

        private void TaskEdit_Load(object sender, EventArgs e)
        {

            ////如果找到与指定谓词定义的条件匹配的第一个元素，则为该元素；
            //var emp = ct.Find(match: e => e.Id == 5);

            doc.Load("Tasks.xml"); //我是把xml放到debug里面了.你的路径就随便啦.不过这样方便一些.
            RecursionTreeControl(doc.DocumentElement, treeView1.Nodes);//将加载完成的XML文件显示在TreeView控件中
            treeView1.ExpandAll();//展开TreeView控件中的所有项
        }

        private void RecursionTreeControl(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)//循环遍历当前元素的子元素集合
            {
                try
                {
                    TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                    string id = node.Attributes["i"].Value.Trim();
                    new_child.Name = node.Attributes["i"].Value;
                    new_child.Text = node.Attributes["Name"].Value;
                    nodes.Add(new_child);//向当前TreeNodeCollection集合中添加当前节点

                    switch (node.Name)
                    {
                        case "Task"://任务
                            cTask ct = new cTask(int.Parse(node.Attributes["i"].Value),
                                node.Attributes["Name"].Value,
                                int.Parse(node.Attributes["interval"].Value), 
                                int.Parse(node.Attributes["count"].Value)
                                );
                            ctasks.Add(ct);
                            new_child.ToolTipText = "Task";
                            //new_child.Text = node.Attributes["Name"].Value + "," + node.Attributes["i"].Value + "," + node.Attributes["interval"].Value;
                            break;
                        case "step"://步骤
                            cStep cs = new cStep(int.Parse(node.Attributes["i"].Value),
                                int.Parse(node.Attributes["x"].Value),
                                int.Parse(node.Attributes["y"].Value),
                                int.Parse(node.Attributes["s"].Value),
                                node.Attributes["Name"].Value,
                                int.Parse(node.Attributes["t"].Value)
                                );
                            csteps.Add(cs);
                            new_child.ToolTipText = "step,"+ node.Attributes["t"].Value;
                            //new_child.Text = node.Attributes["Name"].Value + "," + node.Attributes["i"].Value + "," + node.Attributes["x"].Value + "," + node.Attributes["y"].Value + "," + node.Attributes["s"].Value;
                            break;
                    }

                    RecursionTreeControl(node, new_child.Nodes);//调用本方法进行递归
                }
                catch (Exception ex)
                {
                    label1.Text += ex.Message;
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<cTask> ct = new List<cTask>();
            //ct.Add(new cTask { Id = 1, cTaskName = "Nancy.Davolio", Interval = 100 });
            //ct.Add(new cTask { Id = 2, cTaskName = "Andrew.Fuller", Interval = 100 });
            //ct.Add(new cTask { Id = 5, cTaskName = "Steven.Buchanan", Interval = 200 });
            //var ct200 = ct.FindAll(w => w.Interval == 200);
            //var max = ct.Max(t => t.Id);
            try
            {
                TreeNode CurrentNode = treeView1.SelectedNode;
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    int taskid = 0;
                    
                    switch (CurrentNode.ToolTipText.Substring(0, 4))
                    {                        
                        case "Task":
                            taskid = int.Parse(CurrentNode.Name); 
                            try
                            {
                                var tasksteps = csteps.FindAll(w => w.T == taskid);
                                var newid = tasksteps.Max(t => t.I) + 1;
                                TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                                new_child.Name = (newid).ToString();
                                new_child.Text = "新建步骤";
                                new_child.ToolTipText = "step," + (taskid).ToString();
                                treeView1.SelectedNode.Nodes.Add(new_child);
                                csteps.Add(new cStep { I = newid, X = 0, Y = 0, D = "新建步骤", S = 1, T = taskid });
                            }
                            catch
                            {
                                try
                                {
                                    TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                                    new_child.Name = "1";
                                    new_child.Text = "新建步骤";
                                    new_child.ToolTipText = "step," + (taskid).ToString();
                                    treeView1.SelectedNode.Nodes.Add(new_child);
                                    csteps.Add(new cStep { I = 1, X = 0, Y = 0, D = "新建步骤", S = 1, T = taskid });
                                }
                                catch
                                { }
                            }
                            break;
                        case "step":
                            taskid = int.Parse(CurrentNode.ToolTipText.Substring(5));
                            var tasksteps2 = csteps.FindAll(w => w.T == taskid);
                            var newid2 = tasksteps2.Max(t => t.I)+1;

                            TreeNode new_child2 = new TreeNode();//定义一个TreeNode节点对象
                            new_child2.Name = (newid2).ToString();
                            new_child2.Text = "新建步骤";
                            new_child2.ToolTipText = "step," + (taskid).ToString();
                            treeView1.SelectedNode.Parent.Nodes.Add(new_child2);

                            csteps.Add(new cStep { I = newid2, X = 0, Y = 0, D = "新建步骤", S = 1, T = taskid });
                            break;
                    }
                    toolStripStatusLabel1.Text = "新建步骤成功";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void addRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {                
                //var tasks = csteps.FindAll(w => w.T == taskid);
                var newid = ctasks.Max(t => t.Id) + 1;
                ctasks.Add(new cTask(newid,"新建任务",30,1));

                TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                new_child.Name = (newid).ToString();
                new_child.Text = "新建步骤";
                new_child.ToolTipText = "Task";
                treeView1.Nodes.Add(new_child);

                toolStripStatusLabel1.Text = "新建任务成功";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                //写文件头部内容
                //下面是生成RSS的OPML文件
                sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
                sb.Append("<Tasks>\n");
                //遍历根节点
                foreach (cTask t in ctasks)
                {
                    sb.Append("  <Task i='" + t.Id + "' Name='" + t.cTaskName + "' interval='" + t.Interval + "' count='" + t.Count + "' >\n");
                    var tasksteps = csteps.FindAll(w => w.T == t.Id);
                    foreach (cStep s in tasksteps)
                    {
                        sb.Append("    <step i='" + s.I + "' x='" + s.X + "' y='" + s.Y + "' s='" + s.S + "' Name='" + s.D + "' t='" + s.T + "' ></step>\n");
                    }
                    sb.Append("  </Task>\n");
                }
                sb.Append("</Tasks>\n");
                StreamWriter sr = new StreamWriter("Tasks.xml", false, System.Text.Encoding.UTF8);
                sr.Write(sb.ToString());
                sr.Close();
                toolStripStatusLabel1.Text = "保存成功";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }


        //private void parseNode(TreeNode tn, StringBuilder sb)
        //{
        //    IEnumerator ie = tn.Nodes.GetEnumerator();
        //    while (ie.MoveNext())
        //    {
        //        TreeNode ctn = (TreeNode)ie.Current;
        //        xmlLine = GetRSSText(ctn);
        //        sb.Append(xmlLine);
        //        //如果还有子节点则继续遍历
        //        if (ctn.Nodes.Count > 0)
        //        {
        //            parseNode(ctn, sb);
        //        }
        //        sb.Append("</Node>\n");
        //    }
        //}
        ////成生RSS节点的XML文本行
        //private string GetRSSText(TreeNode node)
        //{
        //    //根据Node属性生成XML文本
        //    string rssText = "<Node Name=\"" + node.Name + "\" Text=\"" + node.Text + "\" >";
        //    return rssText;
        //}

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    treeView1.SelectedNode = CurrentNode;//选中这个节点
                    //treeView1.LabelEdit = true;
                    //treeView1.SelectedNode.BeginEdit();
                    //new_child.Name = node.Attributes["i"].Value;
                    //new_child.Text = node.Attributes["Name"].Value;
                    //new_child.ToolTipText = "Task"or "step";
                    int taski = int.Parse(CurrentNode.Name);
                    switch (CurrentNode.ToolTipText.Substring(0, 4))
                    {
                        case "Task":
                            foreach (cTask ct in ctasks)
                            {
                                if (ct.Id == taski)
                                {
                                    txtTaskid.Text = ct.Id.ToString();
                                    txtTaskname.Text = ct.cTaskName;
                                    txtTaskInterval.Text = ct.Interval.ToString();
                                    txtTaskCount.Text = ct.Count.ToString();

                                    txtStepid.Text = "";
                                    txtStepName.Text = "";
                                    txtStepx.Text = "";
                                    txtStepy.Text = "";
                                    txtStepinterval.Text = "";
                                    txtStepTaskid.Text = "";
                                }
                            }
                            break;
                        case "step":
                            int setpti = int.Parse(CurrentNode.ToolTipText.Replace("step,", ""));
                            foreach (cStep cs in csteps)
                            {
                                if (cs.I == taski && cs.T == setpti)
                                {
                                    txtStepid.Text = taski.ToString();
                                    txtStepName.Text = cs.D;
                                    txtStepx.Text = cs.X.ToString();
                                    txtStepy.Text = cs.Y.ToString();
                                    txtStepinterval.Text = cs.S.ToString();
                                    txtStepTaskid.Text = cs.T.ToString();

                                    foreach (cTask ct in ctasks)
                                    {
                                        if (ct.Id == cs.T)
                                        {
                                            txtTaskid.Text = ct.Id.ToString();
                                            txtTaskname.Text = ct.cTaskName;
                                            txtTaskInterval.Text = ct.Interval.ToString();
                                            txtTaskCount.Text = ct.Count.ToString();
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            reflashdata();
            reflashtree();
        }

        private void reflashdata()
        { 
            int taskid = 0;
            int stepid = 0;
            if (txtTaskid.Text.Length > 0) taskid = int.Parse(txtTaskid.Text);
            if (txtStepid.Text.Length > 0) stepid = int.Parse(txtStepid.Text);
            if (taskid > 0)
            {
                var taskindex = ctasks.FindIndex(w => w.Id == taskid);
                ctasks[taskindex].cTaskName = txtTaskname.Text;
                ctasks[taskindex].Interval = int.Parse(txtTaskInterval.Text);
                ctasks[taskindex].Count = int.Parse(txtTaskCount.Text);
                if (stepid > 0)
                {
                    var stepsindex = csteps.Find(w => w.I == stepid && w.T == taskid);
                    stepsindex.X = int.Parse(txtStepx.Text);
                    stepsindex.Y = int.Parse(txtStepy.Text);
                    stepsindex.S = int.Parse(txtStepinterval.Text);
                    stepsindex.D = txtStepName.Text;
                }
            }
        }

        private void reflashtree()
        {
            treeView1.Nodes.Clear();
            foreach (cTask cs in ctasks)
            {
                TreeNode task_child = new TreeNode();//定义一个TreeNode节点对象
                task_child.Name = cs.Id.ToString();
                task_child.Text = cs.cTaskName;
                task_child.ToolTipText = "Task";
                //var tasksteps = csteps.FindAll(w => w.T == t.Id);
                foreach (cStep ct in csteps.FindAll(w => w.T == cs.Id))
                {
                    TreeNode step_child = new TreeNode();//定义一个TreeNode节点对象
                    step_child.Name = ct.I.ToString();
                    step_child.Text = ct.D;
                    step_child.ToolTipText = "step," + ct.T;
                    task_child.Nodes.Add(step_child);
                }
                treeView1.Nodes.Add(task_child);
                treeView1.ExpandAll();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetMousePoint();
        }
        /// <summary>
        /// 显示的是鼠标在屏幕的位置坐标
        /// </summary>
        private void GetMousePoint()
        {
            Point ms = Control.MousePosition;
            this.label1.Text = string.Format("当前鼠标位置：{0}:{1}", ms.X, ms.Y);
            MouseButtons mb = Control.MouseButtons;

            //  获取鼠标动作（按下了 那个按键)
            //if (mb == System.Windows.Forms.MouseButtons.Left){}
            if (mb == System.Windows.Forms.MouseButtons.Right)
            {
                txtStepx.Text = ms.X.ToString();
                txtStepy.Text = ms.Y.ToString();
            }
            //if (mb == System.Windows.Forms.MouseButtons.Middle) this.lpx.Text = "Middle";

        }

        private void txtStepx_TextChanged(object sender, EventArgs e)
        {
            //if (txtStepid.Text.Length > 0)
            //{
            //    reflashdata();
            //    reflashtree();
            //}
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //删除步骤
                if (txtStepid.Text.Length > 0)
                {
                    int taskid = int.Parse(txtTaskid.Text);
                    int stepid = int.Parse(txtStepid.Text);
                    var stepsindex = csteps.Find(w => w.I == stepid && w.T == taskid);
                    csteps.Remove(stepsindex);
                    treeView1.SelectedNode.Remove();
                    reflashtree();
                    txtStepid.Text =  txtStepinterval.Text = txtStepName.Text = txtStepTaskid.Text = txtStepx.Text = txtStepy.Text = "";
                }
                else
                { 
                
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        //                if (cs.I == taski && cs.T == setpti)
        //                {
        //                    txtStepid.Text = taski.ToString();
        //                    txtStepName.Text = cs.D;
        //                    txtStepx.Text = cs.X.ToString();
        //                    txtStepy.Text = cs.Y.ToString();
        //                    txtStepinterval.Text = cs.S.ToString();
        //                    txtStepTaskid.Text = cs.T.ToString();

        //                    foreach (cTask ct in ctasks)
        //                    {
        //                        if (ct.Id == cs.T)
        //                        {
        //                            txtTaskid.Text = ct.Id.ToString();
        //                            txtTaskname.Text = ct.cTaskName;
        //                            txtTaskInterval.Text = ct.Interval.ToString();
        //                        }
        //}
        //                }

        //string id = node.Attributes["i"].Value.Trim();
        //new_child.Name = node.Attributes["i"].Value;
        //            new_child.Text = node.Attributes["Name"].Value;
        //            nodes.Add(new_child);//向当前TreeNodeCollection集合中添加当前节点

        //            switch (node.Name)
        //            {
        //                case "Task"://任务
        //                    cTask ct = new cTask(int.Parse(node.Attributes["i"].Value),
        //                        node.Attributes["Name"].Value,
        //                        int.Parse(node.Attributes["interval"].Value));
        //ctasks.Add(ct);
        //                    new_child.ToolTipText = "Task";
        //                    new_child.Text = node.Attributes["Name"].Value + "," + node.Attributes["i"].Value + "," + node.Attributes["interval"].Value;
        //                    break;
        //                case "step"://步骤
        //                    cStep cs = new cStep(int.Parse(node.Attributes["i"].Value),
        //                        int.Parse(node.Attributes["x"].Value),
        //                        int.Parse(node.Attributes["y"].Value),
        //                        int.Parse(node.Attributes["s"].Value),
        //                        node.Attributes["Name"].Value,
        //                        int.Parse(node.Attributes["t"].Value)
        //                        );
        //csteps.Add(cs);
        //                    new_child.ToolTipText = "step," + node.Attributes["t"].Value;
        //                    new_child.Text = node.Attributes["Name"].Value + "," + node.Attributes["i"].Value + "," + node.Attributes["x"].Value + "," + node.Attributes["y"].Value + "," + node.Attributes["s"].Value;
        //                    break;
        //            }
    }
    class cStep
    {
        int i;
        int x;
        int y;
        int s;
        string d;
        int t;

        public cStep()
        {

        }
        public cStep(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iin">序列</param>
        /// <param name="xin">x</param>
        /// <param name="yin">y</param>
        /// <param name="sin">之后的停顿</param>
        /// <param name="din">说明</param>
        /// <param name="tin">TaskID</param>
        public cStep(int iin, int xin, int yin, int sin, string din,int tin)
        {
            I = iin;
            X = xin;
            Y = yin;
            S = sin;
            D = din;
            T = tin;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        /// <summary>
        /// ID,序列
        /// </summary>
        public int I { get => i; set => i = value; }
        /// <summary>
        /// 说明
        /// </summary>
        public string D { get => d; set => d = value; }
        /// <summary>
        /// S 执行后的停顿秒数
        /// </summary>
        public int S { get => s; set => s = value; }
        /// <summary>
        /// 归属任务
        /// </summary>
        public int T { get => t; set => t = value; }
    }

    class cTask
    {
        int _id;
        string _name;
        int _interval;
        int _count;
        public cTask()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="interval">执行间隔</param>
        public cTask(int id,string name, int interval,int count)
        {
            Id = id;
            cTaskName = name;
            Interval = interval;
            Count = count;
        }

        public string cTaskName { get => _name; set => _name = value; }
        public int Interval { get => _interval; set => _interval = value; }
        public int Id { get => _id; set => _id = value; }
        public int Count { get => _count; set => _count = value; }
    }
}
