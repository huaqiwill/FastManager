using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FRedis
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
            this.tabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenPosBtn = new Sunny.UI.UIButton();
            this.RedisCLIBtn = new Sunny.UI.UIButton();
            this.button3 = new Sunny.UI.UIButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerStopBtn = new Sunny.UI.UIButton();
            this.ServerStartBtn = new Sunny.UI.UIButton();
            this.button_delete = new Sunny.UI.UIButton();
            this.label_show = new System.Windows.Forms.Label();
            this.button_update = new Sunny.UI.UIButton();
            this.button_add = new Sunny.UI.UIButton();
            this.listBox_item = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenPosBtn);
            this.tabPage1.Controls.Add(this.RedisCLIBtn);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.ServerStopBtn);
            this.tabPage1.Controls.Add(this.ServerStartBtn);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.label_show);
            this.tabPage1.Controls.Add(this.button_update);
            this.tabPage1.Controls.Add(this.button_add);
            this.tabPage1.Controls.Add(this.listBox_item);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Redis服务管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenPosBtn
            // 
            this.OpenPosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPosBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenPosBtn.Location = new System.Drawing.Point(18, 151);
            this.OpenPosBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.OpenPosBtn.Name = "OpenPosBtn";
            this.OpenPosBtn.Size = new System.Drawing.Size(182, 39);
            this.OpenPosBtn.TabIndex = 21;
            this.OpenPosBtn.Text = "打开配置文件位置";
            this.OpenPosBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenPosBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // RedisCLIBtn
            // 
            this.RedisCLIBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedisCLIBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedisCLIBtn.Location = new System.Drawing.Point(18, 106);
            this.RedisCLIBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.RedisCLIBtn.Name = "RedisCLIBtn";
            this.RedisCLIBtn.Size = new System.Drawing.Size(182, 39);
            this.RedisCLIBtn.TabIndex = 20;
            this.RedisCLIBtn.Text = "Redis CLI";
            this.RedisCLIBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedisCLIBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(425, 290);
            this.button3.MinimumSize = new System.Drawing.Size(1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "...";
            this.button3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 30);
            this.textBox1.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 26);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 20);
            this.toolStripStatusLabel1.Text = "Redis版本：v9.1.6";
            // 
            // ServerStopBtn
            // 
            this.ServerStopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerStopBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerStopBtn.Location = new System.Drawing.Point(18, 61);
            this.ServerStopBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ServerStopBtn.Name = "ServerStopBtn";
            this.ServerStopBtn.Size = new System.Drawing.Size(182, 39);
            this.ServerStopBtn.TabIndex = 16;
            this.ServerStopBtn.Text = "停止服务";
            this.ServerStopBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerStopBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ServerStartBtn
            // 
            this.ServerStartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerStartBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerStartBtn.Location = new System.Drawing.Point(18, 16);
            this.ServerStartBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ServerStartBtn.Name = "ServerStartBtn";
            this.ServerStartBtn.Size = new System.Drawing.Size(182, 39);
            this.ServerStartBtn.TabIndex = 15;
            this.ServerStartBtn.Text = "启动服务";
            this.ServerStartBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerStartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.Location = new System.Drawing.Point(484, 419);
            this.button_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 38);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "删除";
            this.button_delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Location = new System.Drawing.Point(14, 523);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(69, 20);
            this.label_show.TabIndex = 13;
            this.label_show.Text = "label1";
            // 
            // button_update
            // 
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_update.Location = new System.Drawing.Point(484, 371);
            this.button_update.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 42);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "配置";
            this.button_update.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // button_add
            // 
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Location = new System.Drawing.Point(484, 326);
            this.button_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 39);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "添加";
            this.button_add.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // listBox_item
            // 
            this.listBox_item.FormattingEnabled = true;
            this.listBox_item.ItemHeight = 20;
            this.listBox_item.Location = new System.Drawing.Point(18, 326);
            this.listBox_item.Name = "listBox_item";
            this.listBox_item.Size = new System.Drawing.Size(460, 184);
            this.listBox_item.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Redis可视化工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FRedis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FRedis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Redis服务管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 643, 436);
            this.Load += new System.EventHandler(this.RedisEnvFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UIButton button_delete;
        private System.Windows.Forms.Label label_show;
        private UIButton button_update;
        private UIButton button_add;
        private System.Windows.Forms.ListBox listBox_item;
        private System.Windows.Forms.TabPage tabPage2;
        private UIButton ServerStopBtn;
        private UIButton ServerStartBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private UIButton button3;
        private UIButton RedisCLIBtn;
        private UIButton OpenPosBtn;
    }
}