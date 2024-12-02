namespace ProgramBox.UI
{
    partial class FSQLImport
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用教程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.数据库ToolStripMenuItem.Text = "数据源";
            this.数据库ToolStripMenuItem.Click += new System.EventHandler(this.数据库ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQL导入ToolStripMenuItem,
            this.sQL导出ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // sQL导入ToolStripMenuItem
            // 
            this.sQL导入ToolStripMenuItem.Name = "sQL导入ToolStripMenuItem";
            this.sQL导入ToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.sQL导入ToolStripMenuItem.Text = "SQL导入";
            this.sQL导入ToolStripMenuItem.Click += new System.EventHandler(this.sQL导入ToolStripMenuItem_Click);
            // 
            // sQL导出ToolStripMenuItem
            // 
            this.sQL导出ToolStripMenuItem.Name = "sQL导出ToolStripMenuItem";
            this.sQL导出ToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.sQL导出ToolStripMenuItem.Text = "SQL导出";
            this.sQL导出ToolStripMenuItem.Click += new System.EventHandler(this.sQL导出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于程序ToolStripMenuItem,
            this.使用教程ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于程序ToolStripMenuItem
            // 
            this.关于程序ToolStripMenuItem.Name = "关于程序ToolStripMenuItem";
            this.关于程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.关于程序ToolStripMenuItem.Text = "关于程序";
            this.关于程序ToolStripMenuItem.Click += new System.EventHandler(this.关于程序ToolStripMenuItem_Click);
            // 
            // 使用教程ToolStripMenuItem
            // 
            this.使用教程ToolStripMenuItem.Name = "使用教程ToolStripMenuItem";
            this.使用教程ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.使用教程ToolStripMenuItem.Text = "使用教程";
            this.使用教程ToolStripMenuItem.Click += new System.EventHandler(this.使用教程ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 30);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL文件";
            // 
            // FSQLImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(569, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSQLImport";
            this.Text = "SQL导入导出工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 569, 373);
            this.Load += new System.EventHandler(this.SQLMainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用教程ToolStripMenuItem;
    }
}

