namespace MQTTClientDemo
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
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Text_Pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_PortNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiveMessage = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Subtxt_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel_Top.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.Controls.Add(this.button2);
            this.Panel_Top.Controls.Add(this.button1);
            this.Panel_Top.Controls.Add(this.Btn_Start);
            this.Panel_Top.Controls.Add(this.Text_Pwd);
            this.Panel_Top.Controls.Add(this.label3);
            this.Panel_Top.Controls.Add(this.Text_UserName);
            this.Panel_Top.Controls.Add(this.label4);
            this.Panel_Top.Controls.Add(this.Text_Host);
            this.Panel_Top.Controls.Add(this.label2);
            this.Panel_Top.Controls.Add(this.Text_PortNum);
            this.Panel_Top.Controls.Add(this.label1);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1055, 82);
            this.Panel_Top.TabIndex = 0;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(562, 11);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(121, 56);
            this.Btn_Start.TabIndex = 16;
            this.Btn_Start.Text = "连接";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Text_Pwd
            // 
            this.Text_Pwd.Location = new System.Drawing.Point(384, 51);
            this.Text_Pwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text_Pwd.Name = "Text_Pwd";
            this.Text_Pwd.Size = new System.Drawing.Size(123, 25);
            this.Text_Pwd.TabIndex = 15;
            this.Text_Pwd.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "密  码：";
            // 
            // Text_UserName
            // 
            this.Text_UserName.Location = new System.Drawing.Point(384, 4);
            this.Text_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.Size = new System.Drawing.Size(123, 25);
            this.Text_UserName.TabIndex = 13;
            this.Text_UserName.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "用户名：";
            // 
            // Text_Host
            // 
            this.Text_Host.Location = new System.Drawing.Point(91, 51);
            this.Text_Host.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text_Host.Name = "Text_Host";
            this.Text_Host.Size = new System.Drawing.Size(123, 25);
            this.Text_Host.TabIndex = 11;
            this.Text_Host.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "地  址：";
            // 
            // Text_PortNum
            // 
            this.Text_PortNum.Location = new System.Drawing.Point(91, 4);
            this.Text_PortNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text_PortNum.Name = "Text_PortNum";
            this.Text_PortNum.Size = new System.Drawing.Size(123, 25);
            this.Text_PortNum.TabIndex = 9;
            this.Text_PortNum.Text = "50000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "端口号：";
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.splitContainer1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 82);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(1055, 582);
            this.Panel_Main.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnPublish);
            this.splitContainer1.Panel1.Controls.Add(this.txtSendMessage);
            this.splitContainer1.Panel1.Controls.Add(this.txtPubTopic);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtReceiveMessage);
            this.splitContainer1.Panel2.Controls.Add(this.btnSubscribe);
            this.splitContainer1.Panel2.Controls.Add(this.txtSubTopic);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 582);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnPublish
            // 
            this.BtnPublish.Location = new System.Drawing.Point(177, 498);
            this.BtnPublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(127, 45);
            this.BtnPublish.TabIndex = 8;
            this.BtnPublish.Text = "发布";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(16, 76);
            this.txtSendMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(477, 405);
            this.txtSendMessage.TabIndex = 7;
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Location = new System.Drawing.Point(96, 25);
            this.txtPubTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(397, 25);
            this.txtPubTopic.TabIndex = 6;
            this.txtPubTopic.Text = "manipulated";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "发布主题";
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.Location = new System.Drawing.Point(16, 42);
            this.txtReceiveMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReceiveMessage.Multiline = true;
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.Size = new System.Drawing.Size(508, 506);
            this.txtReceiveMessage.TabIndex = 11;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(437, 6);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(80, 29);
            this.btnSubscribe.TabIndex = 10;
            this.btnSubscribe.Text = "订阅";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(95, 8);
            this.txtSubTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(319, 25);
            this.txtSubTopic.TabIndex = 9;
            this.txtSubTopic.Text = "position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "订阅主题";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label,
            this.Subtxt_Lb,
            this.NowTime_Lb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1055, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(114, 20);
            this.Status_Label.Text = "状态：未连接！";
            // 
            // Subtxt_Lb
            // 
            this.Subtxt_Lb.Name = "Subtxt_Lb";
            this.Subtxt_Lb.Size = new System.Drawing.Size(87, 20);
            this.Subtxt_Lb.Text = "订阅数：15";
            // 
            // NowTime_Lb
            // 
            this.NowTime_Lb.Name = "NowTime_Lb";
            this.NowTime_Lb.Size = new System.Drawing.Size(170, 20);
            this.NowTime_Lb.Text = "2020年9月9日00:07:59";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "共享";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(848, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "显示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 664);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Top);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MqttNet客户端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private System.Windows.Forms.ToolStripStatusLabel Subtxt_Lb;
        private System.Windows.Forms.ToolStripStatusLabel NowTime_Lb;
        private System.Windows.Forms.TextBox Text_Pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_Host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_PortNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtPubTopic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Button BtnPublish;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceiveMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}