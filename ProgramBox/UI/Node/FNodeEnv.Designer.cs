namespace ProgramBox.UI
{
    partial class FNodeEnv
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
            this.DelBtn = new Sunny.UI.UIButton();
            this.EditBtn = new Sunny.UI.UIButton();
            this.AddBtn = new Sunny.UI.UIButton();
            this.NodeLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DelBtn.Location = new System.Drawing.Point(172, 47);
            this.DelBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 39);
            this.DelBtn.TabIndex = 8;
            this.DelBtn.Text = "删除";
            this.DelBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditBtn.Location = new System.Drawing.Point(91, 47);
            this.EditBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 39);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "修改";
            this.EditBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Location = new System.Drawing.Point(10, 47);
            this.AddBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 39);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "添加";
            this.AddBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NodeLV
            // 
            this.NodeLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.NodeLV.FullRowSelect = true;
            this.NodeLV.GridLines = true;
            this.NodeLV.HideSelection = false;
            this.NodeLV.Location = new System.Drawing.Point(10, 92);
            this.NodeLV.Name = "NodeLV";
            this.NodeLV.Size = new System.Drawing.Size(640, 224);
            this.NodeLV.TabIndex = 5;
            this.NodeLV.UseCompatibleStateImageBehavior = false;
            this.NodeLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "位置";
            this.columnHeader2.Width = 496;
            // 
            // FNodeEnv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(659, 324);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NodeLV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FNodeEnv";
            this.ShowIcon = false;
            this.Text = "NODE环境配置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 687, 456);
            this.Load += new System.EventHandler(this.FNodeEnv_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton DelBtn;
        private Sunny.UI.UIButton EditBtn;
        private Sunny.UI.UIButton AddBtn;
        private System.Windows.Forms.ListView NodeLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}