using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FPython
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
            this.contextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.tabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new Sunny.UI.UIButton();
            this.listView_node = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InfoTB = new Sunny.UI.UITextBox();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.button4 = new Sunny.UI.UIButton();
            this.button3 = new Sunny.UI.UIButton();
            this.PipCMS = new Sunny.UI.UIContextMenuStrip();
            this.pip清华源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pip华为源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pip豆瓣源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pip阿里云ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pip中国科学技术大学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PipRegistryBtn = new Sunny.UI.UIButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PipCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 630);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiButton2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listView_node);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Python环境管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Python SDK";
            this.button1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // listView_node
            // 
            this.listView_node.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_node.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_node.FullRowSelect = true;
            this.listView_node.GridLines = true;
            this.listView_node.HideSelection = false;
            this.listView_node.Location = new System.Drawing.Point(0, 297);
            this.listView_node.Name = "listView_node";
            this.listView_node.Size = new System.Drawing.Size(1064, 293);
            this.listView_node.TabIndex = 1;
            this.listView_node.UseCompatibleStateImageBehavior = false;
            this.listView_node.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "版本";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "路径";
            this.columnHeader2.Width = 496;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InfoTB);
            this.tabPage2.Controls.Add(this.uiLinkLabel1);
            this.tabPage2.Controls.Add(this.uiButton1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.PipRegistryBtn);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PIP可视化工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InfoTB
            // 
            this.InfoTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoTB.Location = new System.Drawing.Point(154, 34);
            this.InfoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.InfoTB.Multiline = true;
            this.InfoTB.Name = "InfoTB";
            this.InfoTB.Padding = new System.Windows.Forms.Padding(5);
            this.InfoTB.ShowText = false;
            this.InfoTB.Size = new System.Drawing.Size(889, 217);
            this.InfoTB.TabIndex = 7;
            this.InfoTB.Text = "11212\r\n232323\r\n2323\r\n1312";
            this.InfoTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoTB.Watermark = "";
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.Location = new System.Drawing.Point(151, 6);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(124, 23);
            this.uiLinkLabel1.TabIndex = 6;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "PIP工具文档";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(8, 129);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(137, 35);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "PIP升级命令";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(8, 88);
            this.button4.MinimumSize = new System.Drawing.Size(1, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "PIP配置文件";
            this.button4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.PipCMS;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(8, 47);
            this.button3.MinimumSize = new System.Drawing.Size(1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "PIP当前镜像";
            this.button3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PipCMS
            // 
            this.PipCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.PipCMS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PipCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PipCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pip清华源ToolStripMenuItem,
            this.pip华为源ToolStripMenuItem,
            this.pip豆瓣源ToolStripMenuItem,
            this.pip阿里云ToolStripMenuItem,
            this.pip中国科学技术大学ToolStripMenuItem});
            this.PipCMS.Name = "contextMenuStrip2";
            this.PipCMS.Size = new System.Drawing.Size(269, 124);
            // 
            // pip清华源ToolStripMenuItem
            // 
            this.pip清华源ToolStripMenuItem.Name = "pip清华源ToolStripMenuItem";
            this.pip清华源ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.pip清华源ToolStripMenuItem.Text = "pip清华源";
            this.pip清华源ToolStripMenuItem.Click += new System.EventHandler(this.pip清华源ToolStripMenuItem_Click);
            // 
            // pip华为源ToolStripMenuItem
            // 
            this.pip华为源ToolStripMenuItem.Name = "pip华为源ToolStripMenuItem";
            this.pip华为源ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.pip华为源ToolStripMenuItem.Text = "pip华为源";
            this.pip华为源ToolStripMenuItem.Click += new System.EventHandler(this.pip华为源ToolStripMenuItem_Click);
            // 
            // pip豆瓣源ToolStripMenuItem
            // 
            this.pip豆瓣源ToolStripMenuItem.Name = "pip豆瓣源ToolStripMenuItem";
            this.pip豆瓣源ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.pip豆瓣源ToolStripMenuItem.Text = "pip豆瓣源";
            this.pip豆瓣源ToolStripMenuItem.Click += new System.EventHandler(this.pip豆瓣源ToolStripMenuItem_Click);
            // 
            // pip阿里云ToolStripMenuItem
            // 
            this.pip阿里云ToolStripMenuItem.Name = "pip阿里云ToolStripMenuItem";
            this.pip阿里云ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.pip阿里云ToolStripMenuItem.Text = "pip阿里云";
            this.pip阿里云ToolStripMenuItem.Click += new System.EventHandler(this.pip阿里云ToolStripMenuItem_Click);
            // 
            // pip中国科学技术大学ToolStripMenuItem
            // 
            this.pip中国科学技术大学ToolStripMenuItem.Name = "pip中国科学技术大学ToolStripMenuItem";
            this.pip中国科学技术大学ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.pip中国科学技术大学ToolStripMenuItem.Text = "pip中国科学技术大学";
            this.pip中国科学技术大学ToolStripMenuItem.Click += new System.EventHandler(this.pip中国科学技术大学ToolStripMenuItem_Click);
            // 
            // PipRegistryBtn
            // 
            this.PipRegistryBtn.ContextMenuStrip = this.PipCMS;
            this.PipRegistryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PipRegistryBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PipRegistryBtn.Location = new System.Drawing.Point(8, 6);
            this.PipRegistryBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.PipRegistryBtn.Name = "PipRegistryBtn";
            this.PipRegistryBtn.Size = new System.Drawing.Size(137, 35);
            this.PipRegistryBtn.TabIndex = 2;
            this.PipRegistryBtn.Text = "PIP国内镜像";
            this.PipRegistryBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PipRegistryBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 60);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(13, 54);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(126, 34);
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "PyQt5工具";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // FPython
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FPython";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Python环境管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 657, 432);
            this.Load += new System.EventHandler(this.PythonEnvFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.PipCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UIContextMenuStrip contextMenuStrip1;
        private UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView_node;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private UIButton button1;
        private UIButton PipRegistryBtn;
        private UIContextMenuStrip PipCMS;
        private System.Windows.Forms.ToolStripMenuItem pip清华源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pip华为源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pip豆瓣源ToolStripMenuItem;
        private UIButton button3;
        private System.Windows.Forms.ToolStripMenuItem pip阿里云ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pip中国科学技术大学ToolStripMenuItem;
        private UIButton button4;
        private UIButton uiButton1;
        private UILinkLabel uiLinkLabel1;
        private UITextBox InfoTB;
        private UIButton uiButton2;
    }
}