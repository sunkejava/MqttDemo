using MQTTClientDemo.Common;
using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MqttClient = MQTTClientDemo.Common.MqttClient;

namespace MQTTClientDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MqttClient client = new MqttClient();
        IMqttClient mqttClient = null;
        ScreenForm sh = new ScreenForm();
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void Btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text_Host.Text.IsEmpty() || Text_PortNum.Text.IsEmpty() || Text_Pwd.Text.IsEmpty() || Text_UserName.Text.IsEmpty())
                {
                    MessageBox.Show("请录入必须的配置信息之后再连接！");
                    return;
                }
                bool IsStart = Btn_Start.Text.Equals("连接");
                Btn_Start.Text = IsStart ? "断开" : "连接";
                client.ServerHost = Text_Host.Text.Trim();
                client.Port = int.Parse(Text_PortNum.Text.Trim());
                client.IsUseTls = false;
                client.UserName = Text_UserName.Text.Trim();
                client.Password = Text_Pwd.Text.Trim();
                client.TimeOut = 2500;
                client.AlivePeriod = 2500;
                if (IsStart)
                {
                    await client.StartClientAsync();
                    Status_Label.Text = $"状态：已连接!";
                }
                else
                {
                    await client.StopClientAsync();
                    Status_Label.Text = $"状态：未连接!";
                }
                mqttClient = client.GetClient();
                #region 事件监听

                if (mqttClient != null)
                {
                    mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;//订阅消息反馈
                    mqttClient.Connected += MqttClient_Connected;//连接事件
                    mqttClient.Disconnected += MqttClient_Disconnected;//断开连接事件
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine($"操作异常，原因为：{ex.Message}");
            }
        }

        #region 监听事件

        private void MqttClient_Disconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            Invoke((new Action(() => 
            {
                Status_Label.Text = $"状态：未连接!";
            })));
        }

        private void MqttClient_Connected(object sender, MqttClientConnectedEventArgs e)
        {
            Invoke((new Action(() =>
            {
                Status_Label.Text = $"状态：已连接！";
            })));
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Invoke((new Action(() =>
            {
                txtReceiveMessage.AppendText($">> {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}{Environment.NewLine}");
                if (e.ApplicationMessage.Topic.Equals("DeclineScreen"))
                {
                    sh.UpdateInfo(sj.Base64StrToImage(Encoding.UTF8.GetString(e.ApplicationMessage.Payload)),e.ClientId);
                }
            })));
        }

        #endregion

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                string topic = txtPubTopic.Text.Trim();

                if (string.IsNullOrEmpty(topic))
                {
                    MessageBox.Show("发布主题不能为空！");
                    return;
                }
                string inputString = txtSendMessage.Text.Trim();
                client.PublishTopicAsync(topic, inputString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"操作异常，原因为：{ex.Message}");
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                string topic = txtSubTopic.Text.Trim();

                if (string.IsNullOrEmpty(topic))
                {
                    MessageBox.Show("订阅主题不能为空！");
                    return;
                }

                if (!mqttClient.IsConnected)
                {
                    MessageBox.Show("MQTT客户端尚未连接！");
                    return;
                }

                client.Subscribe(topic);
                txtReceiveMessage.AppendText($"已订阅[{topic}]主题" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"操作异常，原因为：{ex.Message}");
            }
            
        }

        static Thread thread;

        #region 共享桌面

        /// <summary>
        /// 共享桌面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (thread == null || !thread.IsAlive)
            {
                thread = new Thread(new ThreadStart(SendScreen));
                thread.Start();
            }
        }
        ScreenHelp sj = new ScreenHelp();
        private void SendScreen()
        {
            try
            {
                if (mqttClient.IsConnected)
                {
                    StringBuilder inputString = new StringBuilder();
                    while (mqttClient.IsConnected)
                    {
                        inputString.Clear();
                        inputString.Append(sj.ToBase64(sj.GetScreen()));
                        client.PublishTopicAsync("DeclineScreen", inputString.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("mqtt未连接！");
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 接收共享桌面

        private void button2_Click(object sender, EventArgs e)
        {
            if (mqttClient.IsConnected)
            {
                client.Subscribe("DeclineScreen");
                if (sh == null)
                {
                    sh = new ScreenForm();
                }
                sh.Show();
            }
            else 
            {
                MessageBox.Show("MQTT客户端尚未连接！");
            }
        }

        #endregion


    }
}
