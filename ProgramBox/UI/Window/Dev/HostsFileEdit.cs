using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastStart
{
    /// <summary>
    /// hosts文件编辑工具
    /// </summary>
    public partial class HostsFileEdit : Form
    {
        public HostsFileEdit()
        {
            InitializeComponent();
            LoadHostsFile();
            txtHostsContent.ScrollBars = ScrollBars.Both; // 显示水平和垂直滚动条
            txtHostsContent.TabStop = false;
        }

        private void hosts_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!IsAdministrator())
                //{
                //    MessageBox.Show("请以管理员身份运行程序以编辑 Hosts 文件。");
                //    return;
                //}

                using (StreamWriter sw = new StreamWriter(HostsFilePath, false, Encoding.GetEncoding("GBK")))
                {
                    // 逐行写入文件
                    foreach (string line in txtHostsContent.Lines)
                    {
                        sw.WriteLine(line);
                    }
                }

                MessageBox.Show("Hosts 文件已保存。");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("没有权限保存 Hosts 文件。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private const string HostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        private void LoadHostsFile()
        {
            try
            {
                //if (!IsAdministrator())
                //{
                //    MessageBox.Show("请以管理员身份运行程序以编辑 Hosts 文件。");
                //    return;
                //}

                if (File.Exists(HostsFilePath))
                {
                    //string hostsContent = File.ReadAllText(HostsFilePath, Encoding.GetEncoding("GBK"));
                    //txtHostsContent.Text = hostsContent;

                    using (StreamReader sr = new StreamReader(HostsFilePath, Encoding.GetEncoding("GBK"), false))
                    {
                        string line;
                        bool first = true;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (first)
                            {
                                txtHostsContent.Text += line;
                                first = false;
                            }
                            else
                            {
                                txtHostsContent.Text += "\r\n" + line;
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hosts 文件不存在。");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("没有访问 Hosts 文件的权限。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void RunAsAdmin()
        {
            string executablePath = Assembly.GetEntryAssembly().Location;
            Console.WriteLine("当前可执行文件路径：" + executablePath);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = executablePath, // 指定要以管理员权限运行的可执行文件
                UseShellExecute = true,
                Verb = "runas" // 使用 'runas' 动词请求管理员权限
            };

            try
            {
                Process.Start(startInfo); // 启动进程
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法以管理员权限运行：" + ex.Message);
            }
        }

        private void 定位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开资源管理器并选中指定的文件
                Process.Start("explorer.exe", $"/select, \"{HostsFilePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void 在Notepad中打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                // 启动记事本并打开 hosts 文件
                Process.Start("notepad.exe", HostsFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
    }
}
