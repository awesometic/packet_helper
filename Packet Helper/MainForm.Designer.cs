﻿namespace Packet_Helper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_PacketActivity = new System.Windows.Forms.ListView();
            this.columnHeader_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SrcIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DestIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Protocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SrcPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DestPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Man = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_DevList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CaptureRestart = new System.Windows.Forms.Button();
            this.button_CaptureStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_tray_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_PacketActivity
            // 
            this.listView_PacketActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_No,
            this.columnHeader_Time,
            this.columnHeader_SrcIP,
            this.columnHeader_DestIP,
            this.columnHeader_Protocol,
            this.columnHeader_SrcPort,
            this.columnHeader_DestPort,
            this.columnHeader_Length,
            this.columnHeader_Info});
            this.listView_PacketActivity.Location = new System.Drawing.Point(198, 51);
            this.listView_PacketActivity.Name = "listView_PacketActivity";
            this.listView_PacketActivity.Size = new System.Drawing.Size(774, 498);
            this.listView_PacketActivity.TabIndex = 0;
            this.listView_PacketActivity.UseCompatibleStateImageBehavior = false;
            this.listView_PacketActivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_No
            // 
            this.columnHeader_No.Text = "No.";
            this.columnHeader_No.Width = 45;
            // 
            // columnHeader_Time
            // 
            this.columnHeader_Time.Text = "Time";
            this.columnHeader_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Time.Width = 80;
            // 
            // columnHeader_SrcIP
            // 
            this.columnHeader_SrcIP.Text = "Source IP";
            this.columnHeader_SrcIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_SrcIP.Width = 120;
            // 
            // columnHeader_DestIP
            // 
            this.columnHeader_DestIP.Text = "Destination IP";
            this.columnHeader_DestIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_DestIP.Width = 120;
            // 
            // columnHeader_Protocol
            // 
            this.columnHeader_Protocol.Text = "Protocol";
            this.columnHeader_Protocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_SrcPort
            // 
            this.columnHeader_SrcPort.Text = "Src Port";
            // 
            // columnHeader_DestPort
            // 
            this.columnHeader_DestPort.Text = "Dst Port";
            // 
            // columnHeader_Length
            // 
            this.columnHeader_Length.Text = "Length";
            this.columnHeader_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Info
            // 
            this.columnHeader_Info.Text = "Info";
            this.columnHeader_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Info.Width = 160;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Save,
            this.toolStripMenuItem_Close});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem_File.Text = "파일";
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Open.Text = "열기";
            // 
            // toolStripMenuItem_Save
            // 
            this.toolStripMenuItem_Save.Name = "toolStripMenuItem_Save";
            this.toolStripMenuItem_Save.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Save.Text = "저장";
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Close.Text = "프로그램 종료";
            // 
            // toolStripMenuItem_Info
            // 
            this.toolStripMenuItem_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Man,
            this.toolStripMenuItem_About});
            this.toolStripMenuItem_Info.Name = "toolStripMenuItem_Info";
            this.toolStripMenuItem_Info.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem_Info.Text = "정보";
            // 
            // toolStripMenuItem_Man
            // 
            this.toolStripMenuItem_Man.Name = "toolStripMenuItem_Man";
            this.toolStripMenuItem_Man.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem_Man.Text = "사용법";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem_About.Text = "Packet Helper 정보";
            // 
            // comboBox_DevList
            // 
            this.comboBox_DevList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DevList.FormattingEnabled = true;
            this.comboBox_DevList.Location = new System.Drawing.Point(14, 66);
            this.comboBox_DevList.Name = "comboBox_DevList";
            this.comboBox_DevList.Size = new System.Drawing.Size(178, 20);
            this.comboBox_DevList.TabIndex = 2;
            this.comboBox_DevList.SelectedIndexChanged += new System.EventHandler(this.comboBox_DevList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the Network Device";
            // 
            // button_CaptureRestart
            // 
            this.button_CaptureRestart.Location = new System.Drawing.Point(14, 92);
            this.button_CaptureRestart.Name = "button_CaptureRestart";
            this.button_CaptureRestart.Size = new System.Drawing.Size(75, 23);
            this.button_CaptureRestart.TabIndex = 4;
            this.button_CaptureRestart.Text = "Restart";
            this.button_CaptureRestart.UseVisualStyleBackColor = true;
            this.button_CaptureRestart.Click += new System.EventHandler(this.button_CaptureRestart_Click);
            // 
            // button_CaptureStop
            // 
            this.button_CaptureStop.Location = new System.Drawing.Point(117, 92);
            this.button_CaptureStop.Name = "button_CaptureStop";
            this.button_CaptureStop.Size = new System.Drawing.Size(75, 23);
            this.button_CaptureStop.TabIndex = 5;
            this.button_CaptureStop.Text = "Stop";
            this.button_CaptureStop.UseVisualStyleBackColor = true;
            this.button_CaptureStop.Click += new System.EventHandler(this.button_CaptureStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_tray_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem_tray_exit
            // 
            this.toolStripMenuItem_tray_exit.Name = "toolStripMenuItem_tray_exit";
            this.toolStripMenuItem_tray_exit.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_tray_exit.Text = "프로그램 종료";
            this.toolStripMenuItem_tray_exit.Click += new System.EventHandler(this.toolStripMenuItem_tray_exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 561);
            this.Controls.Add(this.button_CaptureStop);
            this.Controls.Add(this.button_CaptureRestart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_DevList);
            this.Controls.Add(this.listView_PacketActivity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Packet Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Info;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Man;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ComboBox comboBox_DevList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader_No;
        private System.Windows.Forms.ColumnHeader columnHeader_Time;
        private System.Windows.Forms.ColumnHeader columnHeader_SrcIP;
        private System.Windows.Forms.ColumnHeader columnHeader_DestIP;
        private System.Windows.Forms.ColumnHeader columnHeader_Protocol;
        private System.Windows.Forms.ColumnHeader columnHeader_Length;
        private System.Windows.Forms.ColumnHeader columnHeader_Info;
        public System.Windows.Forms.ListView listView_PacketActivity;
        private System.Windows.Forms.Button button_CaptureRestart;
        private System.Windows.Forms.Button button_CaptureStop;
        private System.Windows.Forms.ColumnHeader columnHeader_SrcPort;
        private System.Windows.Forms.ColumnHeader columnHeader_DestPort;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_tray_exit;
    }
}

