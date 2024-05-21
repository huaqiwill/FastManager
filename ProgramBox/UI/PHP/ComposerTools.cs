using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBox.UI.PHP
{
    internal class ComposerTools
    {
        // composer 配置阿里源
        public static void ComposerSetAliyun()
        {
            string str = "composer config -g repo.packagist composer https://mirrors.aliyun.com/composer/";

        }

        // 检查php是否存在
        public static void checkPhp()
        {

        }

        // 检查composer是否存在
        public static void checkComposer()
        {

        }
    }
}
