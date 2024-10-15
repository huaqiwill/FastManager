using Microsoft.Win32;
using ProgramBox.Utils;
using SharpConfig;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Policy;
using ProgramBox.Model;

namespace ProgramBox.UI
{
    public partial class FMain : UIForm
    {
        private Configuration config;

        public FMain()
        {
            InitializeComponent();
        }

        private void java环境配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FJava().ShowDialog();
        }

        private void node环境配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FNode().ShowDialog();
        }

        private void mySQL环境管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FSQL().ShowDialog();
        }

        private void redis环境管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRedis().ShowDialog();
        }

        /// <summary>
        /// 开机自启动管理
        /// </summary>
        /// <param name="bootSelfStart"></param>
        private void SelfStarting(bool bootSelfStart)
        {
            string keyStr = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyStr, true))
            {
                if (bootSelfStart)
                {
                    // 开机自启动
                    key.SetValue("BaichuiMonitor", Application.ExecutablePath);//设置为开机启动
                }
                else
                {
                    if (key != null)//如果该项不存在的话，则创建该项
                    {
                        try
                        {
                            key.DeleteValue("BaichuiMonitor");//取消开机启动
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
            }
        }

        JsonDataUtil jsonDataUtils;

        private void DefaultConfigs()
        {
            

            jsonDataUtils.InsAtomList.Add(new InsAtom("cpp", "C++环境管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("java", "Java环境管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("python", "Python环境管理理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("php", "PHP环境管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("node", "Nodejs环境管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("mysql", "MySQL服务管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("redis", "Redis服务管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("minio", "MinIO服务管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("rabbitmq", "RabbitMQ服务管理"));
            jsonDataUtils.InsAtomList.Add(new InsAtom("nginx", "Nginx服务管理"));

            jsonDataUtils.NativeAtomList.Add(new NativeAtom("VSCode", "D:\\Peng\\App\\Code\\Microsoft VS Code\\code.exe"));
            jsonDataUtils.NativeAtomList.Add(new NativeAtom("IDEA", "D:\\Peng\\App\\Code\\IntelliJ IDEA 2023.3.1\\bin\\idea64.exe"));

            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("disk", "磁盘管理"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("device", "设备管理器"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("task", "任务管理器"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("planned_task", "计划任务"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("regedit", "注册表"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("env", "环境变量"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("res", "资源监视器"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("config", "系统配置"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("info", "系统信息"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("event", "事件查看器"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("firewall", "防火墙"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("server", "服务"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("computer", "计算机管理"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("security", "本地安全策略"));
            jsonDataUtils.WinToolAtomList.Add(new WinToolAtom("control", "控制面板"));

            jsonDataUtils.Save();
        }


        private void MainFrm_Load(object sender, EventArgs e)
        {
            // 如果配置文件不存在，则创建配置文件
            if (!File.Exists(App.ConfigPath)) File.Create(App.ConfigPath).Close();
            // 读取配置文件
            config = Configuration.LoadFromFile(App.ConfigPath);

            // 默认配置
            jsonDataUtils = new JsonDataUtil();
            //DefaultConfigs();

            // 托盘图标
            PalletNI.Icon = Image.FromFile(App.FullPath(@"icon\icon\icon.png")).ToIcon();
            PalletNI.Text = Text;
            palletIconCB.Checked = config["win"]["TrayIcon"].BoolValue;
            selfStartCB.Checked = config["win"]["SelfStarting"].BoolValue;

            // 读取JSON文件内容
            jsonDataUtils.InsAtomList.ForEach(atom =>
            {
                LVUtilsAdd(atom);
            });
            // 常用工具
            jsonDataUtils.NativeAtomList.ForEach(atom =>
            {
                LVToolsAdd(atom);
            });
            // Windows工具
            jsonDataUtils.WinToolAtomList.ForEach(atom =>
            {
                LVWinAdd(atom);
            });

            // 开机自启动管理
            SelfStarting(selfStartCB.Checked);
            // 托盘图标管理
            TrayIcon(palletIconCB.Checked);

            //tabControlMenu.ImageList = new ImageList();
            //tabControlMenu.ImageList.Images.Add(Image.FromFile(@"\icon\icon\icon.png"));

        }

        private async void LVUrlAdd(WebAtom atom)
        {
            atom.Url = "https://www.mingrisoft.com/favicon.ico";
            // 提取url的host
            Uri uri = new Uri(atom.Url);
            string domain = uri.Host;
            // 图标下载地址
            string iconPath = domain + "/favicon.ico";

            bool res = await App.DownloadFile(iconPath, atom.Name + ".ico");
            // 如果图片下载不成功，则使用默认图片
            if (!res)
            {


            }
        }

        private void LVUtilsAdd(InsAtom atom)
        {
            // 添加图标
            if (UtilsLV.LargeImageList == null)
            {
                UtilsLV.LargeImageList = new ImageList()
                {
                    ImageSize = new Size(64, 64)
                };
            }

            try
            {
                UtilsLV.LargeImageList.Images.Add(atom.Key, Image.FromFile(App.FullPath(atom.IconPath)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // 指定表项
            ListViewItem item = new ListViewItem();
            item.Text = atom.Name;
            item.ImageKey = atom.Key;
            item.Tag = atom.Key;
            UtilsLV.Items.Add(item);
        }

        private void LVWinAdd(InsAtom atom)
        {
            // 添加图标
            if (WinToolsLV.LargeImageList == null)
            {
                WinToolsLV.LargeImageList = new ImageList();
                WinToolsLV.LargeImageList.ImageSize = new Size(64, 64);
            }

            try
            {
                WinToolsLV.LargeImageList.Images.Add(atom.Key, Image.FromFile(App.FullPath(atom.IconPath)));
            }
            catch (Exception ex)
            {

            }

            // 指定表项
            ListViewItem item = new ListViewItem();
            item.Text = atom.Name;
            item.ImageKey = atom.Key;
            item.Tag = atom.Key;
            WinToolsLV.Items.Add(item);
        }


        private void LVToolsAdd(NativeAtom atom)
        {
            // 添加图标
            if (ToolsLV.LargeImageList == null)
            {
                ToolsLV.LargeImageList = new ImageList();
                ToolsLV.LargeImageList.ImageSize = new Size(64, 64);
            }

            if (File.Exists(atom.ExecPath))
            {
                ToolsLV.LargeImageList.Images.Add(atom.Name, App.GetBitmapFromIcon(atom.ExecPath));
            }

            // 指定表项
            ListViewItem item = new ListViewItem();
            item.Text = atom.Name;
            item.ImageKey = atom.Name;
            item.Tag = atom.ExecPath;
            ToolsLV.Items.Add(item);
        }

        private void listView_utils_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = UtilsLV.SelectedItems[0];
            switch (item.Tag)
            {
                case "java":
                    new FJava().ShowDialog();
                    break;
                case "php":
                    new FPHP().ShowDialog();
                    break;
                case "node":
                    new FNode().ShowDialog();
                    break;
                case "mysql":
                    new FSQL().ShowDialog();
                    break;
                case "python":
                    new FPython().ShowDialog();
                    break;
                case "redis":
                    new FRedis().ShowDialog();
                    break;
                case "minio":
                    new FMinio().ShowDialog();
                    break;
                case "rabbitmq":
                    new FRabbitMQ().ShowDialog();
                    break;
                case "cpp":
                    new FCPP().ShowDialog();
                    break;
                case "nginx":
                    new FNginx().ShowDialog();
                    break;

            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.MsgInfo("关于");
        }

        private void 使用文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.MsgInfo("使用文档");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (App.MsgAsk("确认退出程序吗？") != DialogResult.OK) return;
            Environment.Exit(0);
        }

        private void 环境变量备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 环境变量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "sysdm.cpl,EditEnvironmentVariables");
        }

        private void listView_tools_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ToolsLV.SelectedItems[0];
            Process.Start((string)item.Tag);
        }

        private void listView_win_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = WinToolsLV.SelectedItems[0];
            switch (item.Tag)
            {
                case "disk":
                    WinCommonUtil.openDisk();
                    break;
                case "device":
                    WinCommonUtil.openDisk();
                    break;
                case "planned_task":
                    WinCommonUtil.openPlannedTask();
                    break;
                case "regedit":
                    WinCommonUtil.openRegedit();
                    break;
                case "task":
                    WinCommonUtil.openTask();
                    break;
                case "env":
                    WinCommonUtil.openEnv();
                    break;
                case "res":
                    WinCommonUtil.openRes();
                    break;
                case "config":
                    WinCommonUtil.openConfig();
                    break;
                case "info":
                    WinCommonUtil.openInfo();
                    break;
                case "event":
                    WinCommonUtil.openEvent();
                    break;
                case "firewall":
                    WinCommonUtil.openFirewall();
                    break;
                case "server":
                    WinCommonUtil.openServer();
                    break;
                case "computer":
                    WinCommonUtil.openCM();
                    break;
                case "security":
                    WinCommonUtil.openLocalSecrity();
                    break;
                case "control":
                    WinCommonUtil.openControl();
                    break;
            }
        }

        private void 首选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView_win_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void MainFrm_SizeChanged(object sender, EventArgs e)
        {
            // 当窗口最小化时
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                PalletNI.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // NotifyIcon闪烁效果参考
            // https://blog.csdn.net/m0_52434264/article/details/125417304
            // 

            Show();
            WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (palletIconCB.Checked)
            {
                e.Cancel = true;
                if (WindowState == FormWindowState.Normal && this.Visible == true)
                {
                    PalletNI.Visible = true;//在通知区显示Form的Icon
                    WindowState = FormWindowState.Minimized;
                    Visible = false;
                    ShowInTaskbar = false;//使Form不在任务栏上显示
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void TrayIcon(bool show)
        {
            PalletNI.Visible = show;
        }

        private void palletIconCB_Click(object sender, EventArgs e)
        {
            palletIconCB.Checked = !palletIconCB.Checked;
            config["win"]["TrayIcon"].BoolValue = palletIconCB.Checked;
            config.SaveToFile(App.ConfigPath);
            TrayIcon(palletIconCB.Checked);
        }

        private void SelfStartCB_Click(object sender, EventArgs e)
        {
            selfStartCB.Checked = !selfStartCB.Checked;
            config["win"]["SelfStarting"].BoolValue = selfStartCB.Checked;
            config.SaveToFile(App.ConfigPath);
            SelfStarting(selfStartCB.Checked);
        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // palletIconCB.Checked = !palletIconCB.Checked;
            config["win"]["TrayIcon"].BoolValue = palletIconCB.Checked;
            config.SaveToFile(App.ConfigPath);
            TrayIcon(palletIconCB.Checked);
        }

        private void uiCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            // selfStartCB.Checked = !selfStartCB.Checked;
            config["win"]["SelfStarting"].BoolValue = selfStartCB.Checked;
            config.SaveToFile(App.ConfigPath);
            SelfStarting(selfStartCB.Checked);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            App.MsgInfo("关于");
        }

        private void uiLinkLabel2_Click(object sender, EventArgs e)
        {
            App.MsgInfo("使用文档");
        }
    }
}
