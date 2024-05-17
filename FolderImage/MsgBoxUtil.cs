using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderImage
{
    internal class MsgBoxUtil
    {
        public static void Info(string msg)
        {
            MessageBox.Show(msg, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string msg)
        {
            MessageBox.Show(msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg, string caption = "错误")
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
