using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FJava
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
            this.tabControl1 = new Sunny.UI.UITabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_setjdk17 = new System.Windows.Forms.Button();
            this.button_setjdk11 = new System.Windows.Forms.Button();
            this.button_setjdk8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_jdk17 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_jdk11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_jdk8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.jDK18ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jDK11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jDK17ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 630);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiButton1);
            this.tabPage2.Controls.Add(this.button_setjdk17);
            this.tabPage2.Controls.Add(this.button_setjdk11);
            this.tabPage2.Controls.Add(this.button_setjdk8);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox_jdk17);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_jdk11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox_jdk8);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1064, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JDK环境配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_setjdk17
            // 
            this.button_setjdk17.Location = new System.Drawing.Point(562, 288);
            this.button_setjdk17.Name = "button_setjdk17";
            this.button_setjdk17.Size = new System.Drawing.Size(75, 31);
            this.button_setjdk17.TabIndex = 19;
            this.button_setjdk17.Text = "选择";
            this.button_setjdk17.UseVisualStyleBackColor = true;
            this.button_setjdk17.Click += new System.EventHandler(this.button_setjdk17_Click);
            // 
            // button_setjdk11
            // 
            this.button_setjdk11.Location = new System.Drawing.Point(561, 246);
            this.button_setjdk11.Name = "button_setjdk11";
            this.button_setjdk11.Size = new System.Drawing.Size(75, 31);
            this.button_setjdk11.TabIndex = 18;
            this.button_setjdk11.Text = "选择";
            this.button_setjdk11.UseVisualStyleBackColor = true;
            this.button_setjdk11.Click += new System.EventHandler(this.button_setjdk11_Click);
            // 
            // button_setjdk8
            // 
            this.button_setjdk8.Location = new System.Drawing.Point(561, 209);
            this.button_setjdk8.Name = "button_setjdk8";
            this.button_setjdk8.Size = new System.Drawing.Size(75, 31);
            this.button_setjdk8.TabIndex = 17;
            this.button_setjdk8.Text = "选择";
            this.button_setjdk8.UseVisualStyleBackColor = true;
            this.button_setjdk8.Click += new System.EventHandler(this.button_setjdk8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_jdk17
            // 
            this.textBox_jdk17.Location = new System.Drawing.Point(107, 291);
            this.textBox_jdk17.Name = "textBox_jdk17";
            this.textBox_jdk17.Size = new System.Drawing.Size(368, 30);
            this.textBox_jdk17.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "jdk17";
            // 
            // textBox_jdk11
            // 
            this.textBox_jdk11.Location = new System.Drawing.Point(107, 250);
            this.textBox_jdk11.Name = "textBox_jdk11";
            this.textBox_jdk11.Size = new System.Drawing.Size(368, 30);
            this.textBox_jdk11.TabIndex = 3;
            this.textBox_jdk11.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "jdk11";
            // 
            // textBox_jdk8
            // 
            this.textBox_jdk8.Location = new System.Drawing.Point(107, 213);
            this.textBox_jdk8.Name = "textBox_jdk8";
            this.textBox_jdk8.Size = new System.Drawing.Size(368, 30);
            this.textBox_jdk8.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "jdk8";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(663, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Maven环境配置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(663, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gradle环境配置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(16, 14);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(111, 39);
            this.uiButton1.TabIndex = 20;
            this.uiButton1.Text = "JDK环境";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jDK18ToolStripMenuItem,
            this.jDK11ToolStripMenuItem,
            this.jDK17ToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // jDK18ToolStripMenuItem
            // 
            this.jDK18ToolStripMenuItem.Name = "jDK18ToolStripMenuItem";
            this.jDK18ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.jDK18ToolStripMenuItem.Text = "JDK8";
            this.jDK18ToolStripMenuItem.Click += new System.EventHandler(this.jDK18ToolStripMenuItem_Click);
            // 
            // jDK11ToolStripMenuItem
            // 
            this.jDK11ToolStripMenuItem.Name = "jDK11ToolStripMenuItem";
            this.jDK11ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.jDK11ToolStripMenuItem.Text = "JDK11";
            this.jDK11ToolStripMenuItem.Click += new System.EventHandler(this.jDK11ToolStripMenuItem_Click_1);
            // 
            // jDK17ToolStripMenuItem
            // 
            this.jDK17ToolStripMenuItem.Name = "jDK17ToolStripMenuItem";
            this.jDK17ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.jDK17ToolStripMenuItem.Text = "JDK17";
            this.jDK17ToolStripMenuItem.Click += new System.EventHandler(this.jDK17ToolStripMenuItem_Click_1);
            // 
            // FJava
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FJava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Java环境变量修改工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 663, 452);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_jdk17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_jdk11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_jdk8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_setjdk8;
        private System.Windows.Forms.Button button_setjdk17;
        private System.Windows.Forms.Button button_setjdk11;
        private UIButton uiButton1;
        private UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jDK18ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jDK11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jDK17ToolStripMenuItem;
    }
}

