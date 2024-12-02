using Sunny.UI;

namespace ProgramBox.UI
{
    partial class FRabbitMQ
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
            this.button_delete = new System.Windows.Forms.Button();
            this.label_show = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_item = new System.Windows.Forms.ListBox();
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
            this.tabControl1.ItemSize = new System.Drawing.Size(190, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 630);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.label_show);
            this.tabPage1.Controls.Add(this.button_update);
            this.tabPage1.Controls.Add(this.button_add);
            this.tabPage1.Controls.Add(this.listBox_item);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1064, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RabbitMQ服务管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(509, 205);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 38);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Location = new System.Drawing.Point(5, 398);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(69, 20);
            this.label_show.TabIndex = 13;
            this.label_show.Text = "label1";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(509, 147);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 42);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "配置";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(509, 89);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 39);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // listBox_item
            // 
            this.listBox_item.FormattingEnabled = true;
            this.listBox_item.ItemHeight = 20;
            this.listBox_item.Location = new System.Drawing.Point(12, 89);
            this.listBox_item.Name = "listBox_item";
            this.listBox_item.Size = new System.Drawing.Size(460, 304);
            this.listBox_item.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RabbitMQ可视化工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FRabbitMQ
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FRabbitMQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RabbitMQ服务管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.RabbitMQEnvFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox listBox_item;
        private System.Windows.Forms.TabPage tabPage2;
    }
}