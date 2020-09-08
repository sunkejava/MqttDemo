namespace MQTTServerDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Status_Control = new System.Windows.Forms.StatusStrip();
            this.AppName_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowStatus_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLabel_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Text_Pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_ConnectionCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_PortNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConectCount_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Control.SuspendLayout();
            this.Panel_Top.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Status_Control
            // 
            this.Status_Control.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status_Control.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppName_Lb,
            this.NowStatus_Lb,
            this.ConectCount_Lb,
            this.TimeLabel_Lb});
            this.Status_Control.Location = new System.Drawing.Point(0, 544);
            this.Status_Control.Name = "Status_Control";
            this.Status_Control.Size = new System.Drawing.Size(1184, 26);
            this.Status_Control.TabIndex = 0;
            this.Status_Control.Text = "statusStrip1";
            // 
            // AppName_Lb
            // 
            this.AppName_Lb.Name = "AppName_Lb";
            this.AppName_Lb.Size = new System.Drawing.Size(133, 20);
            this.AppName_Lb.Text = "MqttNet服务端：";
            // 
            // NowStatus_Lb
            // 
            this.NowStatus_Lb.AutoSize = false;
            this.NowStatus_Lb.Name = "NowStatus_Lb";
            this.NowStatus_Lb.Size = new System.Drawing.Size(225, 20);
            this.NowStatus_Lb.Text = "当前状态:未启用";
            this.NowStatus_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel_Lb
            // 
            this.TimeLabel_Lb.AutoSize = false;
            this.TimeLabel_Lb.Name = "TimeLabel_Lb";
            this.TimeLabel_Lb.Size = new System.Drawing.Size(500, 20);
            this.TimeLabel_Lb.Text = "当前时间: 2020年09月28日   15时25分35秒";
            this.TimeLabel_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Top
            // 
            this.Panel_Top.Controls.Add(this.Btn_Start);
            this.Panel_Top.Controls.Add(this.groupBox1);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1184, 102);
            this.Panel_Top.TabIndex = 1;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(998, 25);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(121, 56);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "启动";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_ClickAsync);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Text_Pwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Text_UserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Text_ConnectionCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Text_PortNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // Text_Pwd
            // 
            this.Text_Pwd.Location = new System.Drawing.Point(400, 62);
            this.Text_Pwd.Name = "Text_Pwd";
            this.Text_Pwd.Size = new System.Drawing.Size(123, 25);
            this.Text_Pwd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "密  码：";
            // 
            // Text_UserName
            // 
            this.Text_UserName.Location = new System.Drawing.Point(400, 15);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.Size = new System.Drawing.Size(123, 25);
            this.Text_UserName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户名：";
            // 
            // Text_ConnectionCount
            // 
            this.Text_ConnectionCount.Location = new System.Drawing.Point(106, 65);
            this.Text_ConnectionCount.Name = "Text_ConnectionCount";
            this.Text_ConnectionCount.Size = new System.Drawing.Size(123, 25);
            this.Text_ConnectionCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "连接数：";
            // 
            // Text_PortNum
            // 
            this.Text_PortNum.Location = new System.Drawing.Point(106, 18);
            this.Text_PortNum.Name = "Text_PortNum";
            this.Text_PortNum.Size = new System.Drawing.Size(123, 25);
            this.Text_PortNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.dataGridView1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 102);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(1184, 442);
            this.Panel_Main.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // ConectCount_Lb
            // 
            this.ConectCount_Lb.AutoSize = false;
            this.ConectCount_Lb.Name = "ConectCount_Lb";
            this.ConectCount_Lb.Size = new System.Drawing.Size(150, 20);
            this.ConectCount_Lb.Text = "连接数：10";
            this.ConectCount_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 570);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Status_Control);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MqttNet服务器端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Status_Control.ResumeLayout(false);
            this.Status_Control.PerformLayout();
            this.Panel_Top.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_Control;
        private System.Windows.Forms.ToolStripStatusLabel AppName_Lb;
        private System.Windows.Forms.ToolStripStatusLabel NowStatus_Lb;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel_Lb;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_PortNum;
        private System.Windows.Forms.TextBox Text_ConnectionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel ConectCount_Lb;
    }
}