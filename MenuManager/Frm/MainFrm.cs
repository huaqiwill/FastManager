using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetBrainsMenu
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void 菜单添加工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CommonMenuFrm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new JetBrainsOpenMenuFrm().ShowDialog();
        }
    }
}
