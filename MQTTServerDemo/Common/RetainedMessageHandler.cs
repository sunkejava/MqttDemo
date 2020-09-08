using MQTTnet;
using MQTTnet.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTServerDemo.Common
{
    /// <summary>
    /// 服务器支持保留的MQTT消息。这些消息会在连接并订阅时保留并发送给客户端。
    /// 它还支持保存所有保留的消息并在服务器启动后加载它们。这需要实现一个接口。
    /// 以下代码显示如何将保留的消息序列化为JSON：
    /// </summary>
    public class RetainedMessageHandler : IMqttServerStorage
    {
        //存储的实现：//此代码使用JSON库“Newtonsoft.Json
        private const string Filename = "C:\\RetainedMessages.json";

        public Task SaveRetainedMessagesAsync(IList<MqttApplicationMessage> messages)
        {
            //var json = File.ReadAllText(Filename);
            //var jsonObject = JsonConvert.DeserializeObject<List<MqttApplicationMessage>>(json ?? "") ?? new List<MqttApplicationMessage>();
            //foreach (var item in jsonObject)
            //{
            //    messages.Add(item);
            //}
            //File.WriteAllText(Filename, JsonConvert.SerializeObject(messages));
            return Task.FromResult(0);
        }

        public Task<IList<MqttApplicationMessage>> LoadRetainedMessagesAsync()
        {
            IList<MqttApplicationMessage> retainedMessages;
            if (File.Exists(Filename))
            {
                var json = File.ReadAllText(Filename);
                retainedMessages = JsonConvert.DeserializeObject<List<MqttApplicationMessage>>(json);
            }
            else
            {
                retainedMessages = new List<MqttApplicationMessage>();
            }

            return Task.FromResult(retainedMessages);
        }
    }
}
