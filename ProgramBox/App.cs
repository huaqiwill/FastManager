using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBox
{
    /**
    工具类

    2024.5.16 全局变量管理
    **/
    public class App
    {
        // 全局配置文件
        public static readonly string ConfigPath = FullPath("config.ini");

        // Json数据文件
        public static readonly string JsonPath = FullPath("data.json");

        // ENV目录
        public static readonly string BaseEnvPath = "D:\\ProgramBox\\env";


        // 处理DPI感知
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();
        public static void ProcessDPIAware()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
        }

        // 完整路径
        public static string FullPath(string shortPath)
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), shortPath);
        }

        // 从远程服务器下载文件
        public async static Task<bool> DownloadFile(string url, string name)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        await content.CopyToAsync(new FileStream(name, FileMode.Create));
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public static Bitmap GetBitmapFromIcon(string exePath)
        {
            return Icon.ExtractAssociatedIcon(exePath).ToBitmap();
        }

        // 在默认浏览器中打开网页
        public static void OpenInBrowser(string url)
        {
            try
            {
                // 使用默认浏览器打开网页
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开默认浏览器: " + ex.Message);
            }
        }

        // 在资源管理器中打开文件
        public static void OpenInExplorer(string filePath)
        {
            try
            {
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开默认浏览器: " + ex.Message);
            }
        }


        public static void MsgInfo(string msg)
        {
            MessageBox.Show(msg, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgWarn(string msg)
        {
            MessageBox.Show(msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgError(string msg, string caption = "错误")
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static DialogResult MsgAsk(string msg, string caption = "询问")
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
