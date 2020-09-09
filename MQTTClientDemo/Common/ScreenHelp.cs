using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTClientDemo.Common
{
    public class ScreenHelp
    {
        public string GetBase64StrOfScreen()
        {
            try
            {
                Rectangle tScreenRect = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                using (Bitmap bitmap = new Bitmap(tScreenRect.Width, tScreenRect.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                        g.DrawImage(bitmap, 0, 0, tScreenRect, GraphicsUnit.Pixel);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] arr = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(arr, 0, (int)ms.Length);
                            return Convert.ToBase64String(arr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }

        public string ToBase64(Bitmap bmp)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ImgToBase64String 转换失败 Exception:" + ex.Message);
                return "";
            }
        }

        public Bitmap Base64StrToImage(string inputStr)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(inputStr);
                using (MemoryStream ms = new MemoryStream(arr))
                {
                    Bitmap bmp = new Bitmap(ms);
                    ms.Close();
                    return bmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base64StringToImage 转换失败/nException：" + ex.Message);
                return null;
            }
        }

    }
}
