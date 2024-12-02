using FastStart.Window;
using FastStart.Window.Des;
using FastStart.Window.Dev;
using ProgramBox;
using ProgramBox.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastStart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeNotifyIcon();
            //使用ALT + T能够呼出应用程序
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, MOD_ALT, VK_T); // 注册热键
        }

        private void host文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 数据生成工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 注册表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 环境变量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开环境变量编辑窗口
                Process.Start("SystemPropertiesAdvanced.exe", "Environment");
            }
            catch
            {
                // 处理异常
                MessageBox.Show("无法打开");
            }
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开环境变量编辑窗口
                Process.Start("explorer.exe", null);
            }
            catch
            {
                // 处理异常
                MessageBox.Show("无法打开");
            }
        }

        private void 记事本ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开环境变量编辑窗口
                Process.Start("notepad.exe", null);
            }
            catch
            {
                // 处理异常
                MessageBox.Show("无法打开");
            }
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开环境变量编辑窗口
                Process.Start("cmd.exe", null);
            }
            catch
            {
                // 处理异常
                MessageBox.Show("无法打开");
            }
        }

        private void 磁盘管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开磁盘管理器
                Process.Start("diskmgmt.msc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开磁盘管理器: " + ex.Message);
            }
        }

        private void 设备管理器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开设备管理器
                Process.Start("devmgmt.msc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开设备管理器: " + ex.Message);
            }

        }

        private void 任务管理器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开任务管理器
                Process.Start("taskmgr.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开任务管理器: " + ex.Message);
            }
        }

        private void 计划任务ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开计划任务
                Process.Start("taskschd.msc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开计划任务: " + ex.Message);
            }
        }

        private void 注册表ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开计划任务
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开注册表: " + ex.Message);
            }
        }

        private void hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HostsFileEditForm h = new HostsFileEditForm();
            //h.Show();

            try
            {
                // 定义要启动的进程信息
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "HOSTS文件管理工具2.02.20171231.exe", // 替换为要启动的程序的路径或名称
                    UseShellExecute = true // 是否使用操作系统外壳启动进程
                };

                // 启动进程
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // 处理启动进程时的异常
                MessageBox.Show($"启动进程时发生错误: {ex.Message}");
            }
        }

        private void 执行任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开计划任务
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开注册表: " + ex.Message);
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 数据生成工具ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGenForm d = new DataGenForm();
            d.Show();
        }

        private void 快速打开工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosMan q = new PosMan();
            q.Show();
        }

        private void 正则表达式regex101comToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://regex101.com/";
            App.OpenInBrowser(url);
        }

        private void gPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://chat.openai.com/";
            App.OpenInBrowser(url);
        }

        private void 手机号生成工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.lddgo.net/string/random-phone-number";
            App.OpenInBrowser(url);
        }

        private void 首选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigMain configMain = new ConfigMain();
            configMain.Show();
        }

        private void ico在线转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.OpenInBrowser("http://www.ico8.net/index.php?action=make");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // 将窗体隐藏到屏幕左边
            int height = Screen.GetBounds(this).Height;
            int width = Screen.GetBounds(this).Width;

            Left = width - Width - 200;
            Top = 100;

            // Left = 100;
        }

        private const int EdgeOffset = 5; // 边缘偏移量
        private bool isMouseAtEdge = false;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // 如果鼠标在窗体边缘附近，显示窗体
            if (!isMouseAtEdge && Math.Abs(Cursor.Position.X - Left) <= EdgeOffset)
            {
                Show();
                isMouseAtEdge = true;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isMouseAtEdge = false;
        }

        private void 环境变量管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnvManForm m = new EnvManForm();
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void 使用notepad打开hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private NotifyIcon notifyIcon;//通知图标

        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application; // 设置托盘图标
            notifyIcon.Visible = true;
            notifyIcon.Click += NotifyIcon_Click;
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;
            // 点击托盘图标时，将窗体显示出来
            if (e2.Button == MouseButtons.Left)
            {
                // 鼠标左键点击时显示窗体
                Show();
                WindowState = FormWindowState.Normal;
            }
            else if (e2.Button == MouseButtons.Right)
            {
                // 鼠标右键点击时显示菜单
                ContextMenuStrip menu = contextMenuStrip2;


                // 显示菜单
                menu.Show(Cursor.Position);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 拦截窗体关闭事件，隐藏窗体并显示在托盘中
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // 阻止窗体直接关闭
                Hide(); // 隐藏窗体
                notifyIcon.ShowBalloonTip(1000, "应用程序", "已最小化到托盘 使用Alt+T呼出", ToolTipIcon.Info); // 显示托盘提示信息
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 退出应用程序
            notifyIcon.Visible = false; // 隐藏托盘图标
            Application.Exit();
        }


        // 声明 RegisterHotKey 和 UnregisterHotKey 函数
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // 定义常量
        private const int MYACTION_HOTKEY_ID = 1;
        private const uint MOD_ALT = 0x0001; // Alt 键的标识符
        private const uint VK_T = 0x54; // T 键的虚拟键码

        //窗口消息处理
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // 处理热键消息
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                // 当接收到注册的热键消息时，显示窗体
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesignMain designMainForm = new DesignMain();
            designMainForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DevMain devMainForm = new DevMain();
            devMainForm.ShowDialog();
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 鼠标左键点击时显示窗体
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            EnvMan envMan = new EnvMan();
            envMan.Show();
        }

        private void 程序ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 官网ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 网络ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hOSTS编辑工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostsFileEdit h = new HostsFileEdit();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProMan projectMan = new ProMan();
            projectMan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SevMan man = new SevMan();
            man.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PosMan man = new PosMan();
            man.ShowDialog();
        }
    }
}
