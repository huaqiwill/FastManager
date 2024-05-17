using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "选择一个文件夹";
            folderBrowserDialog.ShowNewFolderButton = false;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                textBox1.Text = selectedFolder;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图标文件 (*.ico)|*.ico|所有文件 (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;

                textBox2.Text = filename;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Icon icon = new Icon(textBox2.Text);
            if (icon == null)
            {
                MsgBoxUtil.Info("失败");
                return;

            }

            try
            {
                SetFolderIcon(textBox1.Text, icon);
                MsgBoxUtil.Info("成功");
            }
            catch (System.Exception ex)
            {
                MsgBoxUtil.Error(ex.Message, "设置图标错误");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private static Icon GetFolderIcon(string folderPath)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgSmall = SHGetFileInfo(folderPath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);

            if (hImgSmall != IntPtr.Zero)
            {
                Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
                DestroyIcon(shinfo.hIcon);
                return icon;
            }

            return null;
        }

        private static void SetFolderIcon(string folderPath, Icon icon)
        {
            string desktopIniPath = Path.Combine(folderPath, "desktop.ini");
            string iconFilePath = Path.Combine(folderPath, "folder.ico");

            File.WriteAllText(desktopIniPath, "[.ShellClassInfo]\r\nIconResource=" + iconFilePath + ",0");

            File.SetAttributes(desktopIniPath, File.GetAttributes(desktopIniPath) | FileAttributes.Hidden);

            File.WriteAllBytes(iconFilePath, IconToBytes(icon));

            File.SetAttributes(iconFilePath, File.GetAttributes(iconFilePath) | FileAttributes.Hidden);

            SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero);
        }


        private static byte[] IconToBytes(Icon icon)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                icon.Save(ms);
                return ms.ToArray();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DestroyIcon(IntPtr hIcon);

        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private const uint SHGFI_ICON = 0x100;
        private const uint SHGFI_SMALLICON = 0x1;
        private const uint SHCNE_ASSOCCHANGED = 0x08000000;
        private const uint SHCNF_FLUSH = 0x1000;


    }
}
