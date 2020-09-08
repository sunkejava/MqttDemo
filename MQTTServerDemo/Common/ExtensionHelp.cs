using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTServerDemo.Common
{
    public static class ExtensionHelp
    {
        /// <summary>
        /// string转实体类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T ToDeserializeObject<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public static T ToDeserializeObject<T>(this string str, T t)
        {
            return JsonConvert.DeserializeAnonymousType<T>(str, t);
        }

        /// <summary>
        /// 实体转json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ToSerializeObject<T>(this T o)
        {
            return JsonConvert.SerializeObject(o);
        }

        /// <summary>
        /// 图片转换为字节数组
        /// </summary>
        /// <param name="image">图片</param>
        /// <returns>字节数组</returns>
        public static byte[] ImageToBytes(this Image image)
        {
            Clipboard.Clear();
            MemoryStream stream = new MemoryStream();
            new Bitmap(image, image.Width, image.Height).Save(stream, ImageFormat.Bmp);
            return stream.GetBuffer();
        }

        /// <summary>
        /// 是否为Null或空或空白字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string str)
        {
            return String.IsNullOrWhiteSpace(str);
        }
    }
}
