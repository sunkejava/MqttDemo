using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTClientDemo.Common
{
    public class MqttClient
    {
        private IMqttClient mqttClient = null;

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ServerHost { get; set; }

        public int Port { get; set; }

        public int AlivePeriod { get; set; } = 2000;

        public int TimeOut { get; set; } = 2000;

        public bool IsUseTls { get; set; } = false;

        public async Task StartClientAsync()
        {
            if (mqttClient == null)
            {
                try
                {
                    var option = new MqttClientOptionsBuilder()
                        .WithClientId(Guid.NewGuid().ToString())
                        .WithTcpServer(ServerHost, Port)
                        .WithCredentials(UserName, Password)
                        //.WithTls(new MqttClientOptionsBuilderTlsParameters() 
                        //{
                        //    UseTls = IsUseTls,
                        //    SslProtocol = System.Security.Authentication.SslProtocols.Tls12
                        //})
                        .WithCleanSession(false)
                        .WithKeepAlivePeriod(TimeSpan.FromSeconds(AlivePeriod))
                        .WithCleanSession(true)
                        //.WithCommunicationTimeout(TimeSpan.FromSeconds(TimeOut))
                        .Build();
                    mqttClient = new MqttFactory().CreateMqttClient();

                    #region 监听事件

                    mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;//订阅消息反馈
                    mqttClient.Connected += MqttClient_Connected;//连接事件
                    mqttClient.Disconnected += MqttClient_Disconnected;//断开连接事件

                    #endregion

                    await mqttClient.ConnectAsync(option);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task StopClientAsync()
        {
            if (mqttClient != null)
            {
                try
                {
                    if (mqttClient.IsConnected)
                    {
                        await mqttClient.DisconnectAsync();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IMqttClient GetClient() 
        {
            return mqttClient;
        }

        /// <summary>
        /// 订阅主题
        /// </summary>
        /// <param name="topic">主题</param>
        /// <returns></returns>
        public void Subscribe(string topic)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                try
                {
                    mqttClient.SubscribeAsync(new TopicFilterBuilder()
                        .WithTopic(topic)
                        .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce)
                        .Build()
                        ).Wait();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <param name="topic">主题</param>
        /// <returns></returns>
        public void UnSubscribe(string topic)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                try
                {
                    mqttClient.UnsubscribeAsync(topic).Wait();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        /// <summary>
        /// 发布主题
        /// </summary>
        /// <param name="topic">主题</param>
        /// <param name="inputStr">消息</param>
        /// <returns></returns>
        public void PublishTopicAsync(string topic,string inputStr)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                try
                {
                    mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                        .WithTopic(topic)
                        .WithPayload(inputStr)
                        .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce)
                        .WithRetainFlag(true)
                        .Build()
                        ).Wait();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void MqttClient_Disconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            
        }

        private void MqttClient_Connected(object sender, MqttClientConnectedEventArgs e)
        {
            
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            
        }
    }
}
