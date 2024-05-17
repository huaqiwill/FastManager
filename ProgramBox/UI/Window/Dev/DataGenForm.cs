using ProgramBox;
using ProgramBox.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastStart
{
    /// <summary>
    /// 数据生成工具集
    /// </summary>
    public partial class DataGenForm : Form
    {
        public DataGenForm()
        {
            InitializeComponent();
        }

        //手机号生成工具
        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.lddgo.net/string/random-phone-number";
            App.OpenInBrowser(url);
        }

        //正则表达式工具
        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://regex101.com/";
            App.OpenInBrowser(url);
        }

        //GPT
        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://chat.openai.com/";
            App.OpenInBrowser(url);
        }

        private void DataGenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
