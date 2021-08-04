using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace autoClick
{
    public partial class excuteTasks : Form
    {
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

        public excuteTasks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 所有任务
        /// </summary>
        List<cTask> ctasks = new List<cTask>();

        /// <summary>
        /// 选中要执行的任务
        /// </summary>
        List<cTask> selectedctasks = new List<cTask>();

        /// <summary>
        /// 正在执行的任务
        /// </summary>
        cTask currentTask;

        /// <summary>
        /// 所有步骤列表
        /// </summary>
        List<cStep> csteps = new List<cStep>();
        
        /// <summary>
        /// 执行的步骤列表
        /// </summary>
        List<cStep> executeSteps = new List<cStep>();

        private void button1_Click(object sender, EventArgs e)
        {
            initexec();
        }

        private void initexec()
        {
            currentTask = new cTask();
            currentTask.Id = 0;
            selectedctasks.Clear();
            for (int i = 0; i < clbTasks.Items.Count; i++)
            {
                if (clbTasks.GetItemChecked(i))
                {
                    cTask ct = ctasks.Find(w => w.cTaskName == clbTasks.GetItemText(clbTasks.Items[i]));
                    selectedctasks.Add(new cTask(ct.Id, ct.cTaskName, ct.Interval, ct.Count));
                }
            }
            if (selectedctasks.Count > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        /// <summary>
        /// 读取任务列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            clbTasks.Items.Clear();
            //加载指定路径的xml文件
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true; //忽略文档里面的注释
            XmlReader reader = XmlReader.Create(@"..\..\Tasks.xml", settings);
            xmlDoc.Load(reader);

            //得到根节点
            XmlNode xn = xmlDoc.SelectSingleNode("Tasks");
            //得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            List<cTask> TaskList = new List<cTask>();
            foreach (XmlNode item in xnl)
            {
                cTask ctask1 = new cTask();
                //将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)item;
                //得到所有属性的属性值
                //XmlNodeList xmlnl = xe.ChildNodes;
                ctask1.cTaskName = xe.Attributes["name"].Value;

                //ctask1.cTaskName = xmlnl.Item(0).Attributes["name"].Value;

                TaskList.Add(ctask1);
                clbTasks.Items.Add(ctask1.cTaskName,true);
            }
            reader.Close(); //读取完数据后需关闭
            //clbTasks.DataSource = TaskList;
            
        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox cb = (CheckedListBox)sender;
            cTask ct = ctasks.Find(w => w.cTaskName == cb.Text.ToString());
            if (ct.Id > 0)
            {
                label3.Text = "执行次数：" + ct.Count.ToString() + "（次）;执行间隔：" + ct.Interval.ToString()+"（秒）";
                listBox1.Items.Clear();
                foreach (cStep cs in csteps.FindAll(w => w.T == ct.Id))
                {
                    string v = cs.I.ToString() + "," + cs.X.ToString() + "," + cs.Y.ToString() + "," + cs.S.ToString() + "," + cs.D + "," + cs.T.ToString();
                    listBox1.Items.Add(v);
                }
            }
        }

        private void get_data()
        {
            ctasks.Clear();
            csteps.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Tasks.xml");
            loadData(doc.DocumentElement);
            
        }
        private void loadData(XmlNode xmlNode)
            {
                foreach (XmlNode node in xmlNode.ChildNodes)//循环遍历当前元素的子元素集合
                {
                    try
                    {
                       switch (node.Name)
                       {
                            case "Task"://任务
                                cTask ct = new cTask(int.Parse(node.Attributes["i"].Value),
                                    node.Attributes["Name"].Value,
                                    int.Parse(node.Attributes["interval"].Value),
                                    int.Parse(node.Attributes["count"].Value));
                                ctasks.Add(ct);
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
                                break;
                        }
                        loadData(node);//调用本方法进行递归
                    }
                    catch (Exception ex)
                    {
                        txtlogs.Text += ex.Message;
                    }
                }
            }
        private void reclbTasks()
        {
            clbTasks.Items.Clear();
            foreach (cTask cs in ctasks)
            {
                clbTasks.Items.Add(cs.cTaskName,true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_data();
            reclbTasks();
        }

        private void executeTask_Load(object sender, EventArgs e)
        {
            get_data();
            reclbTasks();
        }

        private void btnedittask_Click(object sender, EventArgs e)
        {
            new TaskEdit().ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.Hour == 0 && DateTime.Now.Minute < 3)
            {
                initexec();
                Thread.Sleep(180000);
            }
            if (currentTask.Id == 0)
            {
                foreach (cTask ct in selectedctasks)
                {
                    if(ct.Interval>0) ct.Interval = ct.Interval - 1;
                }
                foreach (cTask ct in selectedctasks)
                {
                    if (ct.Interval == 0)
                    {
                        if (ct.Count > 0 | ct.Count == -1)
                        {
                            currentTask = new cTask(ct.Id, ct.cTaskName, ct.Interval, ct.Count);
                            cTask infotask = ctasks.FindLast(w => w.Id == ct.Id);
                            ct.Interval = infotask.Interval;

                            //building step
                            executeSteps.Clear();
                            foreach (cStep cs in csteps.FindAll(w => w.T == ct.Id))
                            {
                                executeSteps.Add(cs);
                            }
                            timer1.Enabled = false;
                            timer2.Enabled = true;
                            break;
                        }
                    }
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            //executeSteps
            //      <step i='1' x='100' y='259' s='2' Name='步骤1' t='1' ></step>
            //      < step i = '2' x = '476' y = '257' s = '2' Name = '步骤2' t = '1' ></ step >
            //      < step i = '3' x = '476' y = '257' s = '2' Name = '步骤2' t = '1' ></ step >
            if (executeSteps.Count > 0)
            {
                foreach (cStep cs in executeSteps)
                {
                    SetCursorPos(cs.X, cs.Y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    txtlogs.Text = currentTask.cTaskName + ":" + cs.D + ":" + DateTime.Now.ToLongTimeString() + "\r\n" + txtlogs.Text;
                    timer2.Interval = cs.S*1000;
                    executeSteps.Remove(cs);
                    break;
                }
            }
            else
            {                
                cTask c = selectedctasks.FindLast(w => w.Id == currentTask.Id);
                if(c.Count>0)  c.Count = c.Count - 1;
                currentTask.Id = 0;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer2.Enabled = false;
            txtlogs.Text = "停止执行:" + DateTime.Now.ToLongTimeString() + "\r\n" + txtlogs.Text;
        }
    }
}
