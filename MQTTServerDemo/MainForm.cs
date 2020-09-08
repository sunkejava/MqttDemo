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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Status_Control.Items[1].Text = "未启用";
            Status_Control.Items[2].Text = DateTime.Now.ToString("yyyy年MM月dd日  HH时mm分ss秒");
        }

    }
}
