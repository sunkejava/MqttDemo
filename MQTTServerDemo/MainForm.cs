using MQTTnet;
using MQTTnet.Server;
using MQTTServerDemo.Common;
using MQTTServerDemo.Entity;
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
        IMqttServer mqttServer = null;
        List<ClientInfo> ClientInfos = new List<ClientInfo>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Status_Control.Items[1].Text = "未启用";
            Status_Control.Items[3].Text = DateTime.Now.ToString("yyyy年MM月dd日  HH时mm分ss秒");
            Grid_Date.RowsDefaultCellStyle.BackColor = Color.Bisque;
            Grid_Date.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            Grid_Date.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Date.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行
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
            mqttServer = server.GetServer();

            #region 注册监听事件

            if (mqttServer != null)
            {
                mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;//收到消息事件
                mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;//订阅事件
                mqttServer.ClientUnsubscribedTopic += MqttServer_ClientUnsubscribedTopic;//取消订阅事件
                mqttServer.ClientConnected += MqttServer_ClientConnected;//客户端连接事件
                mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;//客户端断开连接事件
                mqttServer.Started += MqttServer_Started;
                mqttServer.Stopped += MqttServer_Stopped;
            }

            #endregion

        }

        private void UpdateConnectCount()
        {
            Invoke((new Action(() =>
            {
                ConectCount_Lb.Text = "客户端连接数:" + ClientInfos.Count.ToString();
                TimeLabel_Lb.Text = DateTime.Now.ToString("yyyy年MM月dd日  HH时mm分ss秒");
            })));                       
            Grid_Date.DelegateControl(() => 
            { 
                Grid_Date.DataSource = new BindingList<ClientInfo>(ClientInfos);
                Grid_Date.Refresh();
            });
        }

        #region mqtt监听事件

        private void MqttServer_Stopped(object sender, EventArgs e)
        {
            Invoke((new Action(() => 
            {
                NowStatus_Lb.Text = "未启动";
            })));
        }

        private void MqttServer_Started(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                NowStatus_Lb.Text = "已启动";
            })));
        }

        private void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            //var WasDisconnect = e.WasCleanDisconnect ? "已断开" : "未断开";
            //Console.WriteLine($"客户端[{e.ClientId}]{WasDisconnect}连接！");
            var sc = ClientInfos.Find(o => o.Id.Equals(e.ClientId));
            if (sc != null)
            {
                ClientInfos.Remove(sc);
            }
            UpdateConnectCount();
        }

        private void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已连接!");
            ClientInfos.Add(new ClientInfo() { Id = e.ClientId,IpAddress = "",Port = "",ConnectTime = DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒")});
            UpdateConnectCount();
        }

        private void MqttServer_ClientUnsubscribedTopic(object sender, MqttClientUnsubscribedTopicEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]取消订阅消息[{e.TopicFilter}]");
            UpdateConnectCount();
        }

        private void MqttServer_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]订阅消息[{e.TopicFilter}]");
            UpdateConnectCount();
        }

        private void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]接收消息：{e.ApplicationMessage.Topic} 载体：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");
            UpdateConnectCount();
        }

        #endregion
    }
}
