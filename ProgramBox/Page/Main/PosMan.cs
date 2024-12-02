using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastStart.Window
{
    /// <summary>
    /// 文件位置管理
    /// </summary>
    public partial class PosMan : Form
    {
        public PosMan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QuickPos_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "测试程序";
            item.SubItems.Add("D:\\test.exe");
            listView1.Items.Add(item);
        }
    }
}
