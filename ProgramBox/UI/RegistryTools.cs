using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBox.UI
{
    // 镜像工具
    internal class RegistryTools
    {
        /// <summary>
        /// 使用默认浏览器打开
        /// Python镜像、华为源
        /// </summary>
        public void pythonRegistry()
        {
            string pythonStr = "https://mirrors.huaweicloud.com/python/";
            Process.Start(pythonStr);
        }



    }
}
