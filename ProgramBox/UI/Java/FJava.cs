using ProgramBox.Utils;
using SharpConfig;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
Java环境管理

2024.5.12 添加功能 JDK环境管理、Maven环境管理、Gradle环境管理
**/
namespace ProgramBox.UI
{
    public partial class FJava : UIForm
    {
        Configuration configuration;
        FMain mainFrm;

        public FJava()
        {
            InitializeComponent();
        }

        private string savePath = App.FullPath("java_path.txt");

        private void Form1_Load(object sender, EventArgs e)
        {
            configuration = Configuration.LoadFromFile(App.ConfigPath);
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;

            if (!File.Exists(savePath))
            {
                File.Create(savePath).Close();
            }

            textBox_jdk8.Disabled();
            textBox_jdk11.Disabled();
            textBox_jdk17.Disabled();

            textBox_jdk8.Text = configuration["jdk"]["jdk8"].StringValue;
            textBox_jdk11.Text = configuration["jdk"]["jdk11"].StringValue;
            textBox_jdk17.Text = configuration["jdk"]["jdk17"].StringValue;

            if (WinEnv.Exist(configuration["jdk"]["jdk8"].StringValue))
            {
                PathVarButtonSelect("jdk8");
            }
            if (WinEnv.Exist(configuration["jdk"]["jdk11"].StringValue))
            {
                PathVarButtonSelect("jdk11");
            }
            if (WinEnv.Exist(configuration["jdk"]["jdk17"].StringValue))
            {
                PathVarButtonSelect("jdk17");
            }
        }

        private void npm华为源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("npm.bat", "config set registry https://mirrors.huaweicloud.com/repository/npm/");
            string output = process.StandardOutput.ReadToEnd();
            App.MsgInfo(output);
        }

        private void 打开mvnrepority位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\mvn-reportary");
        }

        private void 打开maven所在位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 配置maven位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void jdk11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jdk17ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jdk配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string SelectPath()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // 设置对话框的标题和说明
                dialog.Description = "请选择一个文件夹";
                dialog.ShowNewFolderButton = true;

                // 打开对话框，并检查用户是否点击了“确定”按钮
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // 用户选择了文件夹，可以在这里处理选择的路径
                    string selectedPath = dialog.SelectedPath;
                    return selectedPath;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jdk8 = SelectPath();
            if (string.IsNullOrWhiteSpace(jdk8)) return;
            textBox_jdk8.Text = jdk8;
            configuration["jdk"]["jdk8"].StringValue = textBox_jdk8.Text;
            configuration.SaveToFile(App.ConfigPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jdk11 = SelectPath();
            if (string.IsNullOrWhiteSpace(jdk11)) return;
            textBox_jdk11.Text = jdk11;
            configuration["jdk"]["jdk11"].StringValue = textBox_jdk11.Text;
            configuration.SaveToFile(App.ConfigPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jdk17 = SelectPath();
            if (string.IsNullOrWhiteSpace(jdk17)) return;
            textBox_jdk17.Text = jdk17;
            configuration["jdk"]["jdk17"].StringValue = textBox_jdk17.Text;
            configuration.SaveToFile(App.ConfigPath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            configuration["jdk"]["jdk8"].StringValue = textBox_jdk8.Text;
            configuration["jdk"]["jdk11"].StringValue = textBox_jdk11.Text;
            configuration["jdk"]["jdk17"].StringValue = textBox_jdk17.Text;
            configuration.SaveToFile(App.ConfigPath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_jdk8.Text = configuration["jdk"]["jdk8"].StringValue;
            textBox_jdk11.Text = configuration["jdk"]["jdk11"].StringValue;
            textBox_jdk17.Text = configuration["jdk"]["jdk17"].StringValue;
        }

        private void PathVarRemoveAll()
        {
            WinEnv.Remove(configuration["jdk"]["jdk8"].StringValue);
            WinEnv.Remove(configuration["jdk"]["jdk11"].StringValue);
            WinEnv.Remove(configuration["jdk"]["jdk17"].StringValue);
        }

        private void PathVarButtonSelect(string name)
        {
            button_setjdk8.Text = "选择";
            button_setjdk11.Text = "选择";
            button_setjdk17.Text = "选择";

            button_setjdk8.Enabled = true;
            button_setjdk11.Enabled = true;
            button_setjdk17.Enabled = true;

            switch (name)
            {
                case "jdk8":
                    button_setjdk8.Text = "已选择";
                    button_setjdk8.Enabled = false;
                    break;
                case "jdk11":
                    button_setjdk11.Text = "已选择";
                    button_setjdk11.Enabled = false;
                    break;
                case "jdk17":
                    button_setjdk17.Text = "已选择";
                    button_setjdk17.Enabled = false;
                    break;
            }
        }

        private void button_setjdk8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(configuration["jdk"]["jdk8"].StringValue))
            {
                App.MsgError("请先设置JDK8的路径");
                return;
            }

            Task.Run(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    button_setjdk8.Text = "设置中";
                    button_setjdk8.Enabled = false;
                });
                PathVarRemoveAll();
                WinEnv.Set(configuration["jdk"]["jdk8"].StringValue);

                BeginInvoke((MethodInvoker)delegate
                {
                    PathVarButtonSelect("jdk8");
                });
            });
        }

        private void button_setjdk11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(configuration["jdk"]["jdk11"].StringValue))
            {
                App.MsgError("请先设置JDK11的路径");
                return;
            }

            Task.Run(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    button_setjdk11.Text = "设置中";
                    button_setjdk11.Enabled = false;
                });
                PathVarRemoveAll();
                WinEnv.Set(configuration["jdk"]["jdk11"].StringValue);

                BeginInvoke((MethodInvoker)delegate
                {
                    PathVarButtonSelect("jdk11");
                });
            });
        }

        private void button_setjdk17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(configuration["jdk"]["jdk17"].StringValue))
            {
                App.MsgError("请先设置JDK17的路径");
                return;
            }

            Task.Run(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    button_setjdk17.Text = "设置中";
                    button_setjdk17.Enabled = false;
                });
                PathVarRemoveAll();
                WinEnv.Set(configuration["jdk"]["jdk17"].StringValue);

                BeginInvoke((MethodInvoker)delegate
                {
                    PathVarButtonSelect("jdk17");
                });
            });
        }

        private void npm清华源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void npm默认源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiContextMenuStrip1.Show(uiButton1, 0, uiButton1.Height + 10);
        }

        private void jDK18ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jDK11ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void jDK17ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
