using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.tabControlMenu = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UtilsLV = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ToolsLV = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WinToolsLV = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.uiLinkLabel2 = new Sunny.UI.UILinkLabel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.selfStartCB = new Sunny.UI.UICheckBox();
            this.palletIconCB = new Sunny.UI.UICheckBox();
            this.PalletNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.PalletCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScriptLV = new System.Windows.Forms.ListView();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.PalletCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Controls.Add(this.tabPage3);
            this.tabControlMenu.Controls.Add(this.tabPage4);
            this.tabControlMenu.Controls.Add(this.tabPage5);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMenu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlMenu.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControlMenu.Location = new System.Drawing.Point(0, 35);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1082, 677);
            this.tabControlMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMenu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UtilsLV);
            this.tabPage1.Location = new System.Drawing.Point(181, 0);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage1.Size = new System.Drawing.Size(901, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "环境管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UtilsLV
            // 
            this.UtilsLV.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.UtilsLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UtilsLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UtilsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UtilsLV.ForeColor = System.Drawing.Color.OrangeRed;
            this.UtilsLV.GridLines = true;
            this.UtilsLV.HideSelection = false;
            this.UtilsLV.Location = new System.Drawing.Point(15, 15);
            this.UtilsLV.Margin = new System.Windows.Forms.Padding(20);
            this.UtilsLV.Name = "UtilsLV";
            this.UtilsLV.Size = new System.Drawing.Size(871, 647);
            this.UtilsLV.TabIndex = 0;
            this.UtilsLV.UseCompatibleStateImageBehavior = false;
            this.UtilsLV.DoubleClick += new System.EventHandler(this.listView_utils_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ToolsLV);
            this.tabPage2.Location = new System.Drawing.Point(181, 0);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage2.Size = new System.Drawing.Size(901, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "编程工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ToolsLV
            // 
            this.ToolsLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolsLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsLV.ForeColor = System.Drawing.Color.OrangeRed;
            this.ToolsLV.GridLines = true;
            this.ToolsLV.HideSelection = false;
            this.ToolsLV.Location = new System.Drawing.Point(15, 15);
            this.ToolsLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolsLV.Name = "ToolsLV";
            this.ToolsLV.Size = new System.Drawing.Size(871, 647);
            this.ToolsLV.TabIndex = 1;
            this.ToolsLV.UseCompatibleStateImageBehavior = false;
            this.ToolsLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_tools_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WinToolsLV);
            this.tabPage3.Location = new System.Drawing.Point(181, 0);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage3.Size = new System.Drawing.Size(901, 677);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "系统工具";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WinToolsLV
            // 
            this.WinToolsLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinToolsLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WinToolsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinToolsLV.ForeColor = System.Drawing.Color.OrangeRed;
            this.WinToolsLV.GridLines = true;
            this.WinToolsLV.HideSelection = false;
            this.WinToolsLV.Location = new System.Drawing.Point(15, 15);
            this.WinToolsLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WinToolsLV.Name = "WinToolsLV";
            this.WinToolsLV.Size = new System.Drawing.Size(871, 647);
            this.WinToolsLV.TabIndex = 2;
            this.WinToolsLV.UseCompatibleStateImageBehavior = false;
            this.WinToolsLV.SelectedIndexChanged += new System.EventHandler(this.listView_win_SelectedIndexChanged);
            this.WinToolsLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_win_MouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ScriptLV);
            this.tabPage4.Location = new System.Drawing.Point(181, 0);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage4.Size = new System.Drawing.Size(901, 677);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "脚本管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.uiLinkLabel2);
            this.tabPage5.Controls.Add(this.uiLinkLabel1);
            this.tabPage5.Controls.Add(this.uiButton1);
            this.tabPage5.Controls.Add(this.selfStartCB);
            this.tabPage5.Controls.Add(this.palletIconCB);
            this.tabPage5.Location = new System.Drawing.Point(181, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage5.Size = new System.Drawing.Size(901, 677);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "程序配置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // uiLinkLabel2
            // 
            this.uiLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel2.Location = new System.Drawing.Point(18, 162);
            this.uiLinkLabel2.Name = "uiLinkLabel2";
            this.uiLinkLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLinkLabel2.TabIndex = 4;
            this.uiLinkLabel2.TabStop = true;
            this.uiLinkLabel2.Text = "使用文档";
            this.uiLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel2.Click += new System.EventHandler(this.uiLinkLabel2_Click);
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.Location = new System.Drawing.Point(18, 132);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLinkLabel1.TabIndex = 3;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "关于";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(18, 87);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "首选项";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // selfStartCB
            // 
            this.selfStartCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selfStartCB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selfStartCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.selfStartCB.Location = new System.Drawing.Point(18, 52);
            this.selfStartCB.MinimumSize = new System.Drawing.Size(1, 1);
            this.selfStartCB.Name = "selfStartCB";
            this.selfStartCB.Size = new System.Drawing.Size(150, 29);
            this.selfStartCB.TabIndex = 1;
            this.selfStartCB.Text = "开机自启动";
            this.selfStartCB.CheckedChanged += new System.EventHandler(this.uiCheckBox2_CheckedChanged);
            // 
            // palletIconCB
            // 
            this.palletIconCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.palletIconCB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.palletIconCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.palletIconCB.Location = new System.Drawing.Point(18, 17);
            this.palletIconCB.MinimumSize = new System.Drawing.Size(1, 1);
            this.palletIconCB.Name = "palletIconCB";
            this.palletIconCB.Size = new System.Drawing.Size(150, 29);
            this.palletIconCB.TabIndex = 0;
            this.palletIconCB.Text = "托盘图标";
            this.palletIconCB.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // PalletNI
            // 
            this.PalletNI.ContextMenuStrip = this.PalletCMS;
            this.PalletNI.Text = "notifyIcon1";
            this.PalletNI.Visible = true;
            this.PalletNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.PalletNI.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // PalletCMS
            // 
            this.PalletCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PalletCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.PalletCMS.Name = "contextMenuStrip1";
            this.PalletCMS.Size = new System.Drawing.Size(211, 80);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // ScriptLV
            // 
            this.ScriptLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScriptLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptLV.ForeColor = System.Drawing.Color.OrangeRed;
            this.ScriptLV.GridLines = true;
            this.ScriptLV.HideSelection = false;
            this.ScriptLV.Location = new System.Drawing.Point(15, 15);
            this.ScriptLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScriptLV.Name = "ScriptLV";
            this.ScriptLV.Size = new System.Drawing.Size(871, 647);
            this.ScriptLV.TabIndex = 3;
            this.ScriptLV.UseCompatibleStateImageBehavior = false;
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 712);
            this.Controls.Add(this.tabControlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "编程环境管理工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1082, 712);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.SizeChanged += new System.EventHandler(this.MainFrm_SizeChanged);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.PalletCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UITabControlMenu tabControlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView UtilsLV;
        private System.Windows.Forms.ListView ToolsLV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView WinToolsLV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NotifyIcon PalletNI;
        private System.Windows.Forms.ContextMenuStrip PalletCMS;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage5;
        private UICheckBox palletIconCB;
        private UICheckBox selfStartCB;
        private UIButton uiButton1;
        private UILinkLabel uiLinkLabel2;
        private UILinkLabel uiLinkLabel1;
        private System.Windows.Forms.ListView ScriptLV;
    }
}