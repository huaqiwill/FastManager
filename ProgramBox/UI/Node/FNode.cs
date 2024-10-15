using ProgramBox.Utils;
using SharpConfig;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
Nodejs环境管理工具

2024.5.13 添加对Nodejs环境管理的支持、添加对npm、pnpm、yarn工具的管理和支持

**/
namespace ProgramBox.UI
{
    public partial class FNode : Form
    {
        public FNode()
        {
            InitializeComponent();
        }

        FMain mainFrm;
        Configuration cfg;

        private string savePath = App.FullPath("path.txt");

        private void Form1_Load(object sender, EventArgs e)
        {
            cfg = Configuration.LoadFromFile(App.ConfigPath);

            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;

            if (!File.Exists(savePath)) File.Create(savePath).Close();

            AddBtn.Disabled();
            EditBtn.Disabled();
            DelBtn.Disabled();

            cfg["node"]["node12"].StringValue = "D:\\Peng\\App\\Code\\Node\\node12.12.0";
            cfg["node"]["node16"].StringValue = "D:\\Peng\\App\\Code\\Node\\node16.13.2";
            cfg["node"]["node18"].StringValue = "D:\\Peng\\App\\Code\\Node\\node18.18.2";
            cfg["node"]["node20"].StringValue = "D:\\Peng\\App\\Code\\Node\\node20.10.0";
            cfg.SaveToFile(App.ConfigPath);

            InitNode();
            InitNpm();

            ReadNodeList();
        }

        // 获取nodejs目录下的环境，如果有，获取版本号和跟路径
        public void ReadNodeList()
        {
            TraverseNodeDirectory();
        }

        /// <summary>
        /// 2024.5.17
        /// 遍历node目录，获取 nodeenv 目录下的 nodejs sdk
        /// </summary>
        void TraverseNodeDirectory()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(App.BaseEnvPath);

                // 遍历当前目录下的所有文件
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"File: {file.FullName}");
                    ListViewItemNodeEnvAdd(file.Name, file.FullName);
                }

                // 遍历当前目录下的所有子目录，并对每个子目录递归调用本方法
                //DirectoryInfo[] subDirs = dir.GetDirectories();
                //foreach (DirectoryInfo subDir in subDirs)
                //{
                //    Console.WriteLine($"Directory: {subDir.FullName}");
                //    TraverseDirectory(subDir.FullName); // 递归调用
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing directory: {ex.Message}");
            }
        }


        private void InitNode()
        {
            Task.Run(() =>
            {
                NodePath();
                NodeVersion();
                LoadNode();
            });
        }

        private void InitNpm()
        {
            Task.Run(() =>
            {
                NpmVersion();
                NpmRegistry();
            });
        }

        private void NodePath()
        {
            var node12 = cfg["node"]["node12"].StringValue;
            var node16 = cfg["node"]["node16"].StringValue;
            var node18 = cfg["node"]["node18"].StringValue;
            var node20 = cfg["node"]["node20"].StringValue;

            string v = Command.Run("node -v");
            BeginInvoke((MethodInvoker)delegate
            {
                if (WinEnv.Exist(node12))
                {
                    NodePathLabel.Text = "当前node路径：" + node12;
                }
                if (WinEnv.Exist(node16))
                {
                    NodePathLabel.Text = "当前node路径：" + node16;
                }
                if (WinEnv.Exist(node18))
                {
                    NodePathLabel.Text = "当前node路径：" + node18;
                }
                if (WinEnv.Exist(node20))
                {
                    NodePathLabel.Text = "当前node路径：" + node20;
                }
            });
        }

        /// <summary>
        /// Node版本
        /// </summary>
        private void NodeVersion()
        {
            //string v = CmdUtil.Run("node -v");
            //BeginInvoke((MethodInvoker)delegate
            //{
            //    NodeVersionLabel.Text = "当前node版本：" + v;
            //});
        }

        /// <summary>
        /// Npm版本
        /// </summary>
        private void NpmVersion()
        {
            string v = Command.Run("npm -v");
            BeginInvoke((MethodInvoker)delegate
            {
                NpmVersionLabel.Text = "npm当前版本：" + v;
            });
        }

        /// <summary>
        /// npm镜像
        /// </summary>
        private void NpmRegistry()
        {
            try
            {
                string v = Command.Run("npm config get registry");
                BeginInvoke((MethodInvoker)delegate
                {
                    NpmRegisrtyLabel.Text = "npm当前镜像：" + v;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// Node的路径列表
        /// </summary>
        private void LoadNode()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                NodeLV.Items.Clear();
                ListViewItemNodeEnvAdd("node12", cfg["node"]["node12"].StringValue);
                ListViewItemNodeEnvAdd("node16", cfg["node"]["node16"].StringValue);
                ListViewItemNodeEnvAdd("node18", cfg["node"]["node18"].StringValue);
                ListViewItemNodeEnvAdd("node20", cfg["node"]["node20"].StringValue);
            });
        }

        /// <summary>
        /// 配置node
        /// </summary>
        /// <param name="key"></param>
        private void SetNode(string key)
        {
            Task.Run(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    NodeVersionBtn.Enabled = false;
                    Cursor = Cursors.WaitCursor;
                });
                WinEnv.Remove(cfg["node"]["node12"].StringValue);
                WinEnv.Remove(cfg["node"]["node16"].StringValue);
                WinEnv.Remove(cfg["node"]["node18"].StringValue);
                WinEnv.Remove(cfg["node"]["node20"].StringValue);

                WinEnv.Set(cfg["node"][key].StringValue);
                BeginInvoke((MethodInvoker)delegate
                {
                    Cursor = Cursors.Arrow;
                    NodeVersionBtn.Enabled = true;
                    InitNode();
                });
            });
        }

        private void ListViewItemNodeEnvAdd(string name, string path)
        {
            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(path);

            string status = WinEnv.Exist(path) ? "已设置" : "";

            item.SubItems.Add(status);
            NodeLV.Items.Add(item);
        }

        private void npm华为源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("npm.bat", "config set registry https://mirrors.huaweicloud.com/repository/npm/");
            string output = process.StandardOutput.ReadToEnd();
            App.MsgInfo(output);
        }

        private void 在资源管理器打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (listBox_item.SelectedIndex == -1)
            //{
            //    return;
            //}

            //string filePath = (string)listBox_item.SelectedItem;
            //Process.Start("explorer.exe", "/select," + filePath);
        }

        private void listBox_item_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox_item_Click(object sender, EventArgs e)
        {

        }

        private void listBox_item_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FNodeEnvAdd().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem item = NodeLV.SelectedItems[0];
            if (item == null) return;

            string key = item.Text;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择nodejs环境";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                cfg["node"][key].StringValue = path;
                cfg.SaveToFile(App.ConfigPath);
                item.SubItems[1].Text = path;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FNodeEnvAdd().ShowDialog();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_config_Click(object sender, EventArgs e)
        {
            ListViewItem item = NodeLV.SelectedItems[0];
            if (item == null) return;

            string key = item.Text;
            string label = Text;
            Task.Run(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    Text = "设置中！请勿中途退出";
                });
                SetNode(key);
                BeginInvoke((MethodInvoker)delegate
                {
                    LoadNode();
                    Text = label;
                });
            });
        }

        private void SetNpmSource(string name, string url)
        {
            try
            {
                string res = Command.Run($"npm config set registry {url}");
                if (res == "")
                {
                    InitNpm();
                    App.MsgInfo($"配置{name}成功");
                }
                else
                {
                    App.MsgError(res);
                }
            }
            catch (Exception ex)
            {
                App.MsgError(ex.Message);
            }
        }

        private void npm腾讯源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNpmSource("腾讯源", "http://mirrors.cloud.tencent.com/npm/");
        }


        private void npm淘宝源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNpmSource("淘宝源", "https://registry.npmmirror.com");
        }

        private void npm华为源ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetNpmSource("华为源", "https://mirrors.huaweicloud.com/repository/npm/");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string s = Command.Run("npm config get registry");
            App.MsgInfo(s);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NpmCMS.Show(Btn_SetNpmSource, 0, Btn_SetNpmSource.Height);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = Command.Run("npm -v");
            App.MsgInfo(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // npm可视化包
            string s = Command.Run("npm list -g --depth 0");
            App.MsgInfo(s);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            // npm全局模块
            string s = Command.Run("npm list -g --depth 0");
            App.MsgInfo(s);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NodeCMS.Show(NodeVersionBtn, 0, NodeVersionBtn.Height + 10);
        }

        private void node12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNode("node12");
        }

        private void node16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNode("node16");
        }

        private void node18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNode("node18");
        }

        private void node20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNode("node20");
        }

        private void pnpm华为源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnpm清华源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnpm淘宝源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PnpmCmdBtn_Click(object sender, EventArgs e)
        {
            PnpmCMS.Show(PnpmCmdBtn, 0, PnpmCmdBtn.Height);
        }

        private void YarnCmdBtn_Click(object sender, EventArgs e)
        {
            YarnCMS.Show(YarnCmdBtn, 0, YarnCmdBtn.Height);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            new FNodeEnv().ShowDialog();
        }


        private void NodeLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            EditBtn.Enabled = true;
        }
    }
}
