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
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Subtxt_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime_Lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.Text_Pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_PortNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceiveMessage = new System.Windows.Forms.TextBox();
            this.Panel_Top.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
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
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(791, 66);
            this.Panel_Top.TabIndex = 0;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.splitContainer1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 66);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(791, 465);
            this.Panel_Main.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label,
            this.Subtxt_Lb,
            this.NowTime_Lb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(92, 17);
            this.Status_Label.Text = "状态：未连接！";
            // 
            // Subtxt_Lb
            // 
            this.Subtxt_Lb.Name = "Subtxt_Lb";
            this.Subtxt_Lb.Size = new System.Drawing.Size(70, 17);
            this.Subtxt_Lb.Text = "订阅数：15";
            // 
            // NowTime_Lb
            // 
            this.NowTime_Lb.Name = "NowTime_Lb";
            this.NowTime_Lb.Size = new System.Drawing.Size(134, 17);
            this.NowTime_Lb.Text = "2020年9月9日00:07:59";
            // 
            // Text_Pwd
            // 
            this.Text_Pwd.Location = new System.Drawing.Point(288, 41);
            this.Text_Pwd.Margin = new System.Windows.Forms.Padding(2);
            this.Text_Pwd.Name = "Text_Pwd";
            this.Text_Pwd.Size = new System.Drawing.Size(93, 21);
            this.Text_Pwd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "密  码：";
            // 
            // Text_UserName
            // 
            this.Text_UserName.Location = new System.Drawing.Point(288, 3);
            this.Text_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.Size = new System.Drawing.Size(93, 21);
            this.Text_UserName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "用户名：";
            // 
            // Text_Host
            // 
            this.Text_Host.Location = new System.Drawing.Point(68, 41);
            this.Text_Host.Margin = new System.Windows.Forms.Padding(2);
            this.Text_Host.Name = "Text_Host";
            this.Text_Host.Size = new System.Drawing.Size(93, 21);
            this.Text_Host.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "地  址：";
            // 
            // Text_PortNum
            // 
            this.Text_PortNum.Location = new System.Drawing.Point(68, 3);
            this.Text_PortNum.Margin = new System.Windows.Forms.Padding(2);
            this.Text_PortNum.Name = "Text_PortNum";
            this.Text_PortNum.Size = new System.Drawing.Size(93, 21);
            this.Text_PortNum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "端口号：";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(635, 11);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(91, 45);
            this.Btn_Start.TabIndex = 16;
            this.Btn_Start.Text = "连接";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(791, 465);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Location = new System.Drawing.Point(72, 20);
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(299, 21);
            this.txtPubTopic.TabIndex = 6;
            this.txtPubTopic.Text = "manipulated";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "发布主题";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(12, 61);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(359, 325);
            this.txtSendMessage.TabIndex = 7;
            // 
            // BtnPublish
            // 
            this.BtnPublish.Location = new System.Drawing.Point(133, 398);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(95, 36);
            this.BtnPublish.TabIndex = 8;
            this.BtnPublish.Text = "发布";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(328, 5);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(60, 23);
            this.btnSubscribe.TabIndex = 10;
            this.btnSubscribe.Text = "订阅";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(71, 6);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(240, 21);
            this.txtSubTopic.TabIndex = 9;
            this.txtSubTopic.Text = "position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "订阅主题";
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.Location = new System.Drawing.Point(12, 34);
            this.txtReceiveMessage.Multiline = true;
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.Size = new System.Drawing.Size(382, 406);
            this.txtReceiveMessage.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Top);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MqttNet客户端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}