namespace FastStart
{
    partial class HostsFileEdit
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
            this.txtHostsContent = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.定位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在Notepad中打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHostsContent
            // 
            this.txtHostsContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHostsContent.Location = new System.Drawing.Point(11, 30);
            this.txtHostsContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtHostsContent.Multiline = true;
            this.txtHostsContent.Name = "txtHostsContent";
            this.txtHostsContent.Size = new System.Drawing.Size(692, 364);
            this.txtHostsContent.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(628, 401);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 34);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.定位ToolStripMenuItem,
            this.在Notepad中打开ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 定位ToolStripMenuItem
            // 
            this.定位ToolStripMenuItem.Name = "定位ToolStripMenuItem";
            this.定位ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.定位ToolStripMenuItem.Text = "定位";
            this.定位ToolStripMenuItem.Click += new System.EventHandler(this.定位ToolStripMenuItem_Click);
            // 
            // 在Notepad中打开ToolStripMenuItem
            // 
            this.在Notepad中打开ToolStripMenuItem.Name = "在Notepad中打开ToolStripMenuItem";
            this.在Notepad中打开ToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.在Notepad中打开ToolStripMenuItem.Text = "在Notepad中打开";
            this.在Notepad中打开ToolStripMenuItem.Click += new System.EventHandler(this.在Notepad中打开ToolStripMenuItem_Click);
            // 
            // HostsFileEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 443);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txtHostsContent);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HostsFileEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hosts文件编辑工具";
            this.Load += new System.EventHandler(this.hosts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostsContent;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 定位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在Notepad中打开ToolStripMenuItem;
    }
}