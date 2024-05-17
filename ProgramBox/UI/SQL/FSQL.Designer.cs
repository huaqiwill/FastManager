using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FSQL
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
            this.mysql8posLB = new Sunny.UI.UILabel();
            this.mysql5posLB = new Sunny.UI.UILabel();
            this.mysql8posBtn = new Sunny.UI.UIButton();
            this.mysql5posBtn = new Sunny.UI.UIButton();
            this.mysql8configBtn = new Sunny.UI.UIButton();
            this.mysql8restartBtn = new Sunny.UI.UIButton();
            this.mysql5configBtn = new Sunny.UI.UIButton();
            this.mysql5restartBtn = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.mysql8startBtn = new Sunny.UI.UIButton();
            this.mysql5startBtn = new Sunny.UI.UIButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 630);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            this.tabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mysql8posLB);
            this.tabPage1.Controls.Add(this.mysql5posLB);
            this.tabPage1.Controls.Add(this.mysql8posBtn);
            this.tabPage1.Controls.Add(this.mysql5posBtn);
            this.tabPage1.Controls.Add(this.mysql8configBtn);
            this.tabPage1.Controls.Add(this.mysql8restartBtn);
            this.tabPage1.Controls.Add(this.mysql5configBtn);
            this.tabPage1.Controls.Add(this.mysql5restartBtn);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Controls.Add(this.mysql8startBtn);
            this.tabPage1.Controls.Add(this.mysql5startBtn);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MySQL服务管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // mysql8posLB
            // 
            this.mysql8posLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8posLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.mysql8posLB.Location = new System.Drawing.Point(528, 71);
            this.mysql8posLB.Name = "mysql8posLB";
            this.mysql8posLB.Size = new System.Drawing.Size(520, 23);
            this.mysql8posLB.TabIndex = 29;
            this.mysql8posLB.Text = "D:\\Study\\Code\\03_WorkMine\\MineNET";
            this.mysql8posLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mysql5posLB
            // 
            this.mysql5posLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5posLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.mysql5posLB.Location = new System.Drawing.Point(528, 26);
            this.mysql5posLB.Name = "mysql5posLB";
            this.mysql5posLB.Size = new System.Drawing.Size(520, 23);
            this.mysql5posLB.TabIndex = 28;
            this.mysql5posLB.Text = "D:\\Study\\Code\\03_WorkMine\\MineNET";
            this.mysql5posLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mysql8posBtn
            // 
            this.mysql8posBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql8posBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8posBtn.Location = new System.Drawing.Point(448, 71);
            this.mysql8posBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql8posBtn.Name = "mysql8posBtn";
            this.mysql8posBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql8posBtn.TabIndex = 27;
            this.mysql8posBtn.Text = "目录";
            this.mysql8posBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8posBtn.Click += new System.EventHandler(this.uiButton8_Click);
            // 
            // mysql5posBtn
            // 
            this.mysql5posBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql5posBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5posBtn.Location = new System.Drawing.Point(448, 26);
            this.mysql5posBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql5posBtn.Name = "mysql5posBtn";
            this.mysql5posBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql5posBtn.TabIndex = 26;
            this.mysql5posBtn.Text = "目录";
            this.mysql5posBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5posBtn.Click += new System.EventHandler(this.uiButton7_Click);
            // 
            // mysql8configBtn
            // 
            this.mysql8configBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql8configBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8configBtn.Location = new System.Drawing.Point(379, 71);
            this.mysql8configBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql8configBtn.Name = "mysql8configBtn";
            this.mysql8configBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql8configBtn.TabIndex = 25;
            this.mysql8configBtn.Text = "配置";
            this.mysql8configBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // mysql8restartBtn
            // 
            this.mysql8restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql8restartBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8restartBtn.Location = new System.Drawing.Point(310, 71);
            this.mysql8restartBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql8restartBtn.Name = "mysql8restartBtn";
            this.mysql8restartBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql8restartBtn.TabIndex = 24;
            this.mysql8restartBtn.Text = "重启";
            this.mysql8restartBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // mysql5configBtn
            // 
            this.mysql5configBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql5configBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5configBtn.Location = new System.Drawing.Point(379, 26);
            this.mysql5configBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql5configBtn.Name = "mysql5configBtn";
            this.mysql5configBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql5configBtn.TabIndex = 23;
            this.mysql5configBtn.Text = "配置";
            this.mysql5configBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5configBtn.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // mysql5restartBtn
            // 
            this.mysql5restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql5restartBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5restartBtn.Location = new System.Drawing.Point(310, 26);
            this.mysql5restartBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql5restartBtn.Name = "mysql5restartBtn";
            this.mysql5restartBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql5restartBtn.TabIndex = 22;
            this.mysql5restartBtn.Text = "重启";
            this.mysql5restartBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5restartBtn.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(17, 71);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(134, 23);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "MySQL8.0.12";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(17, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(134, 23);
            this.uiLabel1.TabIndex = 20;
            this.uiLabel1.Text = "MySQL5.7.26";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mysql8startBtn
            // 
            this.mysql8startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql8startBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8startBtn.Location = new System.Drawing.Point(241, 71);
            this.mysql8startBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql8startBtn.Name = "mysql8startBtn";
            this.mysql8startBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql8startBtn.TabIndex = 19;
            this.mysql8startBtn.Text = "启动";
            this.mysql8startBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql8startBtn.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // mysql5startBtn
            // 
            this.mysql5startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql5startBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5startBtn.Location = new System.Drawing.Point(241, 26);
            this.mysql5startBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mysql5startBtn.Name = "mysql5startBtn";
            this.mysql5startBtn.Size = new System.Drawing.Size(63, 23);
            this.mysql5startBtn.TabIndex = 18;
            this.mysql5startBtn.Text = "启动";
            this.mysql5startBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql5startBtn.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MySQL可视化工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FSQL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MySQL服务管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 651, 432);
            this.Load += new System.EventHandler(this.MySQLEnvFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UIButton mysql8startBtn;
        private UIButton mysql5startBtn;
        private UILabel uiLabel1;
        private UILabel uiLabel2;
        private UIButton mysql5restartBtn;
        private UIButton mysql5configBtn;
        private UIButton mysql8configBtn;
        private UIButton mysql8restartBtn;
        private UIButton mysql5posBtn;
        private UIButton mysql8posBtn;
        private UILabel mysql8posLB;
        private UILabel mysql5posLB;
    }
}