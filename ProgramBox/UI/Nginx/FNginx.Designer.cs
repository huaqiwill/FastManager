namespace ProgramBox.UI
{
    partial class FNginx
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nginxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nginxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nginxToolStripMenuItem
            // 
            this.nginxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动服务ToolStripMenuItem,
            this.停止服务ToolStripMenuItem,
            this.程序位置ToolStripMenuItem,
            this.配置ToolStripMenuItem});
            this.nginxToolStripMenuItem.Name = "nginxToolStripMenuItem";
            this.nginxToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.nginxToolStripMenuItem.Text = "服务管理";
            // 
            // 启动服务ToolStripMenuItem
            // 
            this.启动服务ToolStripMenuItem.Name = "启动服务ToolStripMenuItem";
            this.启动服务ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.启动服务ToolStripMenuItem.Text = "启动服务";
            // 
            // 停止服务ToolStripMenuItem
            // 
            this.停止服务ToolStripMenuItem.Name = "停止服务ToolStripMenuItem";
            this.停止服务ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.停止服务ToolStripMenuItem.Text = "停止服务";
            // 
            // 程序位置ToolStripMenuItem
            // 
            this.程序位置ToolStripMenuItem.Name = "程序位置ToolStripMenuItem";
            this.程序位置ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.程序位置ToolStripMenuItem.Text = "程序位置";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 63);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1064, 602);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 1;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1064, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FNginx
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FNginx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nginx服务管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 510, 326);
            this.Load += new System.EventHandler(this.NginxEnvFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nginxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

