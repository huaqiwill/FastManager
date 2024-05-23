using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramBox.UI.Node
{
    /// <summary>
    /// nodejs环境管理工具
    /// </summary>
    public class NodeTools
    {

        /// <summary>
        /// 2024.5.17
        /// 通过用户目录下的.npmrc文件设置镜像的地址，默认淘宝镜像
        /// </summary>
        private void SetRegistryByNpmrc(string registry = "https://registry.npmmirror.com/")
        {
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string npmrc = userFolderPath + "\\.npmrc";
            string saveContent = $"registry={registry}\r\n";
            // 如果文件不存在直接写入
            if (!File.Exists(npmrc))
            {
                File.WriteAllText(npmrc, saveContent);
                return;
            }

            string content = File.ReadAllText(npmrc);
            string pattern = @"registry=(https?://[\w./]+)";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(content);

            if (match.Success)
            {
                string registryUrl = match.Groups[1].Value; // groups[0]是整个匹配的字符串，groups[1]是第一个括号内匹配的内容
                Console.WriteLine($"提取的registry URL: {registryUrl}");
                // 使用Regex.Replace方法进行替换
                string modifiedText = Regex.Replace(content, pattern, saveContent);
                File.WriteAllText(npmrc, modifiedText);
            }
            else
            {
                Console.WriteLine("未找到匹配的registry URL。");
                File.AppendText(saveContent);
            }
        }

        /// <summary>
        /// 2024.5.17
        /// 通过用户目录下的.npmrc文件获取镜像的地址
        /// </summary>
        /// <returns></returns>
        private string GetRegistryByNpmrc()
        {
            // 获取当前用户的个人目录路径
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string npmrc = userFolderPath + "\\.npmrc";
            if (!File.Exists(npmrc)) return "";

            string content = File.ReadAllText(npmrc);
            string pattern = @"registry=(https?://[\w./]+)";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(content);

            if (match.Success)
            {
                string registryUrl = match.Groups[1].Value; // groups[0]是整个匹配的字符串，groups[1]是第一个括号内匹配的内容
                Console.WriteLine($"提取的registry URL: {registryUrl}");
                return registryUrl;
            }
            else
            {
                Console.WriteLine("未找到匹配的registry URL。");
                return "";
            }

        }
    }
}
