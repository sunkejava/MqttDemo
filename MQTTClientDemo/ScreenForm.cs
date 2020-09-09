using MQTTClientDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTClientDemo
{
    public partial class ScreenForm : Form
    {
        public ScreenForm()
        {
            InitializeComponent();
        }

        private void ScreenForm_Load(object sender, EventArgs e)
        {
            try
            {
                ScreenHelp sh = new ScreenHelp();
                Pic_Info.Image = sh.GetScreen();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateInfo(Bitmap bmp,string id)
        {
            Invoke(new Action(() => 
            {
                Pic_Info.Image = bmp;
                Status_Lb.Text = $"显示用户{id}的桌面";
            }));
        }
    }
}
