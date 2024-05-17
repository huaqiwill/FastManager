namespace ProgramBox.UI
{
    partial class FSQLConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HostTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host";
            // 
            // HostTB
            // 
            this.HostTB.Location = new System.Drawing.Point(170, 67);
            this.HostTB.Name = "HostTB";
            this.HostTB.Size = new System.Drawing.Size(243, 30);
            this.HostTB.TabIndex = 3;
            // 
            // UserTB
            // 
            this.UserTB.Location = new System.Drawing.Point(170, 117);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(243, 30);
            this.UserTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(170, 165);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(243, 30);
            this.PasswordTB.TabIndex = 5;
            // 
            // PortTB
            // 
            this.PortTB.Location = new System.Drawing.Point(170, 216);
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(243, 30);
            this.PortTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "端口";
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(243, 267);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(75, 35);
            this.TestBtn.TabIndex = 8;
            this.TestBtn.Text = "测试";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(335, 267);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 35);
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "确定";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // FSQLConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 339);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.PortTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserTB);
            this.Controls.Add(this.HostTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSQLConfig";
            this.Text = "MySQL配置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 486, 326);
            this.Load += new System.EventHandler(this.SQLConfigFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HostTB;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button OkBtn;
    }
}