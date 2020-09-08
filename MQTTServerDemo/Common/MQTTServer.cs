using MQTTnet;
using MQTTnet.Protocol;
using MQTTnet.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MQTTServerDemo.Common
{
    public class MQTTServer
    {
        private IMqttServer mqttServer = null;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 监听端口，默认60000
        /// </summary>
        public int PortNum { get; set; } = 60000;
        
        /// <summary>
        /// 连接数,默认5000
        /// </summary>
        public int ConnctionCount { get; set; } = 5000;

        /// <summary>
        /// 拦截客户端消息Topic
        /// </summary>
        public string MessageInterceptorFilter { get; set; }

        /// <summary>
        /// 拦截订阅消息
        /// </summary>
        public string SubscriptionInterceptor { get; set; }

        /// <summary>
        /// 是否使用证书
        /// </summary>
        public bool IsUseCert { get; set; } = false;

        public async Task StartServer()
        {
            if (mqttServer == null)
            {
                try
                {
                    #region 初始化MqttServer

                    var options = new MqttServerOptionsBuilder().WithConnectionValidator(context =>
                    {
                        //验证MQTT客户端
                        if (!string.IsNullOrEmpty(context.ClientId))
                        {
                            Console.WriteLine(context.Username);
                            Console.WriteLine(context.Password);
                            if (context.Username != UserName || context.Password != Password)
                            {
                                context.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                            }
                            else
                            {
                                context.ReturnCode = MqttConnectReturnCode.ConnectionAccepted;
                            }
                        }
                        else
                        {
                            context.ReturnCode = MqttConnectReturnCode.ConnectionRefusedIdentifierRejected;
                        }
                    })
                    .WithConnectionBacklog(ConnctionCount)//设置连接数
                    .WithDefaultEndpointPort(PortNum)//默认监听端口是1883 这里设置成1884
                    .WithPersistentSessions()//使用持续会话
                    .WithEncryptionSslProtocol(SslProtocols.Tls12)
                    .WithStorage(new RetainedMessageHandler())//存储的实现,保留的应用程序消息
                    //拦截消息,扩展来自客户端的所有消息的时间戳
                    .WithApplicationMessageInterceptor(context =>
                    {
                        if (MqttTopicFilterComparer.IsMatch(context.ApplicationMessage.Topic, MessageInterceptorFilter))
                        {
                            context.ApplicationMessage.Payload = Encoding.UTF8.GetBytes(DateTime.Now.ToString("O"));
                            Console.WriteLine("此消息被被处理");
                        }
                    })

                    //拦截订阅
                    .WithSubscriptionInterceptor(context =>
                    {
                        if (context.TopicFilter.Topic.StartsWith("admin/foo/bar") && context.ClientId != "theAdmin")
                        {
                            context.AcceptSubscription = false;
                        }

                        if (context.TopicFilter.Topic.StartsWith("the/secret/stuff") && context.ClientId != "Imperator")
                        {
                            context.AcceptSubscription = false;
                            context.CloseConnection = true;
                        }
                    })
                    .Build();

                    //使用证书
                    if (IsUseCert)
                    {
                        var certificate = new X509Certificate2(@"C:\certs\test\test.cer", "", X509KeyStorageFlags.Exportable);
                        options.TlsEndpointOptions.Certificate = certificate.Export(X509ContentType.Pfx);
                        options.TlsEndpointOptions.IsEnabled = true;
                    }
                    mqttServer = new MqttFactory().CreateMqttServer();

                    #endregion

                    #region 注册监听事件

                    mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;//收到消息事件
                    mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;//订阅事件
                    mqttServer.ClientUnsubscribedTopic += MqttServer_ClientUnsubscribedTopic;//取消订阅事件
                    mqttServer.ClientConnected += MqttServer_ClientConnected;//客户端连接事件
                    mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;//客户端断开连接事件
                    //mqttServer.Started += MqttServer_Started;//启动事件
                    //mqttServer.Stopped += MqttServer_Stopped;//停止事件
                    #endregion

                    await Task.Run(async () => await mqttServer.StartAsync(options));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task StopServer()
        {
            if (mqttServer != null)
            {
                await Task.Run(async() => await mqttServer.StopAsync());
            }
        }

        private void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            var WasDisconnect = e.WasCleanDisconnect ? "已断开" : "未断开";
            Console.WriteLine($"客户端[{e.ClientId}]{WasDisconnect}连接！");
        }

        private void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]已连接!");
        }

        private void MqttServer_ClientUnsubscribedTopic(object sender, MqttClientUnsubscribedTopicEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]取消订阅消息[{e.TopicFilter}]");
        }

        private void MqttServer_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]订阅消息[{e.TopicFilter}]");
        }

        private void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Console.WriteLine($"客户端[{e.ClientId}]接收消息：{e.ApplicationMessage.Topic} 载体：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");
        }
    }
}
