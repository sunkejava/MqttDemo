using MQTTServerDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTServerDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MQTTServer server = new MQTTServer();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Status_Control.Items[1].Text = "未启用";
            Status_Control.Items[2].Text = DateTime.Now.ToString("yyyy年MM月dd日  HH时mm分ss秒");
        }

        private async void Btn_Start_ClickAsync(object sender, EventArgs e)
        {
            if (Text_ConnectionCount.Text.IsEmpty() || Text_PortNum.Text.IsEmpty() || Text_Pwd.Text.IsEmpty() || Text_UserName.Text.IsEmpty())
            {
                MessageBox.Show("请录入必须的配置信息之后再启动服务！");
                return;
            }
            bool IsStart = Btn_Start.Text.Equals("启动");
            Btn_Start.Text = IsStart ? "停止" : "启动";
            server.ConnctionCount = int.Parse(Text_ConnectionCount.Text.Trim());
            server.PortNum = int.Parse(Text_PortNum.Text.Trim());
            server.UserName = Text_UserName.Text.Trim();
            server.Password = Text_Pwd.Text.Trim();
            if (IsStart)
            {
                await server.StartServer();
            }
            else 
            {
                await server.StopServer();
            }
        }
    }
}
