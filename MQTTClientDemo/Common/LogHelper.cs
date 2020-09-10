using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTClientDemo.Common
{
    public class LogHelper
    {
        // Methods
        public static string ToLog(object log)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "logs";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string str2 = AppDomain.CurrentDomain.BaseDirectory + "logs/" + DateTime.Now.ToString("yyyyMMdd") + "log.txt";
                if (File.Exists(str2))
                {
                    File.SetAttributes(str2, FileAttributes.Normal);
                }
                using (StreamWriter writer = new StreamWriter(str2, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "  " + log);
                    writer.Flush();
                    writer.Dispose();
                }
            }
            catch (Exception)
            {
            }
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
