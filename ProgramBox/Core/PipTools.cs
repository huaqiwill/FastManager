using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramBox.Utils;

namespace ProgramBox.UI.Python
{
    /**
    2024.5.18
    pip.ini文件位置：C:\Users\31734\AppData\Roaming\pip\pip.ini
    **/
    internal class PipTools
    {
        // 升级pip命令
        public static void PipUpdate()
        {
            string cmd = "python.exe -m pip install --upgrade pip";
            Command.Run(cmd);
        }

        /// <summary>
        /// pip展示
        /// </summary>
        public static string PipShow(string packageName)
        {
            string cmd = "pip show packageName";
            string result = Command.Run(cmd);
            return result;
        }

        /// <summary>
        /// pip镜像设置，默认华为镜像
        /// </summary>
        /// <param name="regisry"></param>
        public static void PipRegistreySet(string regisry = "https://repo.huaweicloud.com/repository/pypi/simple")
        {
            Uri uri = new Uri(regisry);
            string pipR = string.Format(@"
[global]
index-url = {0}
trusted-host = {1}
timeout = 120
", regisry, uri.Host);
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pipP = Path.Combine(userFolderPath, @".pip\pip.ini");
            File.WriteAllText(pipP, pipR);
        }
    }
}
