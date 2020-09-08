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
            this.AppName = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_Control
            // 
            this.Status_Control.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status_Control.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppName,
            this.NowStatus,
            this.TimeLabel});
            this.Status_Control.Location = new System.Drawing.Point(0, 544);
            this.Status_Control.Name = "Status_Control";
            this.Status_Control.Size = new System.Drawing.Size(1184, 26);
            this.Status_Control.TabIndex = 0;
            this.Status_Control.Text = "statusStrip1";
            // 
            // AppName
            // 
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(133, 20);
            this.AppName.Text = "MqttNet服务端：";
            // 
            // NowStatus
            // 
            this.NowStatus.AutoSize = false;
            this.NowStatus.Name = "NowStatus";
            this.NowStatus.Size = new System.Drawing.Size(225, 20);
            this.NowStatus.Text = "当前状态:未启用";
            this.NowStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = false;
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(500, 20);
            this.TimeLabel.Text = "当前时间: 2020年09月28日   15时25分35秒";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 570);
            this.Controls.Add(this.Status_Control);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MqttNet服务器端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Status_Control.ResumeLayout(false);
            this.Status_Control.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_Control;
        private System.Windows.Forms.ToolStripStatusLabel AppName;
        private System.Windows.Forms.ToolStripStatusLabel NowStatus;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
    }
}