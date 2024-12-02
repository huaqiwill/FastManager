using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBox.UI
{
    public partial class FSQLImport : UIForm
    {
        public FSQLImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSQLConfig config = new FSQLConfig();
            config.ShowDialog();
        }

        private void sQL导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sQL导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 使用教程ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SQLMainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
