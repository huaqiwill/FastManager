using ProgramBox.Utils;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBox.UI
{
    public partial class FPython : UIForm
    {
        public FPython()
        {
            InitializeComponent();
        }
        FMain mainFrm;

        // pip 国内源
        private void PythonEnvFrm_Load(object sender, EventArgs e)
        {
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;

            Task.Run(() =>
            {
                string indexUrl = Command.Run($"pip config get global.index-url");
                string trustedHost = Command.Run($"pip config get install.trusted-host");

                BeginInvoke((MethodInvoker)delegate
                {
                    InfoTB.Text = "";
                    InfoTB.Text += ($"当前PIP版本：v1.9.8\n");
                    InfoTB.Text += ($"当前PIP镜像：{indexUrl}\n");
                    InfoTB.Text += ($"当前PIP信任：{trustedHost}\n");
                });
            });
        }

        // pip 当前源
        private void button3_Click(object sender, EventArgs e)
        {
            string indexUrl = Command.Run($"pip config get global.index-url");
            string trustedHost = Command.Run($"pip config get install.trusted-host");
            App.MsgInfo("Index-Url：" + indexUrl + "\nTrusted-Host：" + trustedHost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PipCMS.Show(PipRegistryBtn, 0, PipRegistryBtn.Height + 10);
        }

        private string GetHost(string url)
        {
            string pattern = @"https?://([^/]+)/.*"; // 匹配host部分的正则表达式
            Match match = Regex.Match(url, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return string.Empty;
        }

        private void SetPipSource(string name, string url)
        {
            string host = GetHost(url);
            Command.Run($"pip config set global.index-url {url}");
            Command.Run($"pip config set install.trusted-host {host}");
            Command.Run($"pip config set global.timeout 2000");
            App.MsgInfo($"配置{name}成功");
        }

        private void pip清华源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPipSource("清华源", "https://pypi.tuna.tsinghua.edu.cn/simple");
        }

        private void pip华为源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPipSource("华为源", "");
        }

        private void pip豆瓣源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPipSource("豆瓣源", "http://pypi.douban.com/simple/");
        }

        private void pip阿里云ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPipSource("阿里云", "http://mirrors.aliyun.com/pypi/simple/");
        }

        private void pip中国科学技术大学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPipSource("中国科学技术大学", "https://pypi.mirrors.ustc.edu.cn/simple/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pipConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "pip", "pip.ini");
            if (File.Exists(pipConfigPath))
            {
                Process.Start("notepad.exe", pipConfigPath);
            }
            else
            {
                App.MsgError("未找到Pip全局配置文件");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            App.MsgInfo("帮助文档");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            // PyQt5工具

        }
    }
}
