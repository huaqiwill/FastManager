using System;
using System.Diagnostics;

namespace ProgramBox.Utils
{
    public class Command
    {
        // 运行命令
        public static string Run(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c {command}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Trim(); // 去掉输出末尾的换行符
        }

        public static void Start(string app)
        {

        }

        public static void Exec(string cmd, string errMsg)
        {
            try
            {
                string[] c = cmd.Split(' ');
                string arg;
                if (c.Length > 1)
                {
                    arg = cmd.Replace(c[0] + " ", "");
                }
                else
                {
                    arg = "";
                }
                // 打开设备管理器
                Process.Start(c[0], arg);
            }
            catch (Exception ex)
            {
                App.MsgError(errMsg + "\n错误原因：" + ex.Message);
            }
        }
    }
}
