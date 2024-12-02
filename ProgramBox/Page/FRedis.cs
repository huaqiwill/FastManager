using FastStart;
using ProgramBox.Utils;
using SharpConfig;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBox.UI
{
    public partial class FRedis : UIForm
    {
        private Configuration configuration;
        public FRedis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(redisServer);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private string redisServer;
        private string redisCli;

        private void GenPath()
        {
            redisServer = configuration["redis"]["redis_server"].StringValue + "/redis-server.exe";
            redisCli = configuration["redis"]["redis_server"].StringValue + "/redis-cli.exe";
        }

        FMain mainFrm;

        private void RedisEnvFrm_Load(object sender, EventArgs e)
        {
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;

            configuration = Configuration.LoadFromFile(App.ConfigPath);

            textBox1.Text = configuration["redis"]["redis_server"].StringValue;
            GenPath();


        }

        private void GetRedisVersion()
        {
            string redisPath = textBox1.Text;
            if (string.IsNullOrWhiteSpace(redisPath))
            {
                App.MsgError("请先配置Redis环境");
                return;
            }
        }


        private void StatusSetRedisVersion(string version)
        {
            toolStripStatusLabel1.Text = "Redis版本：" + version;
        }

        private void button3_Click(object sender, EventArgs e)
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
                    textBox1.Text = selectedPath;

                    configuration["redis"]["redis_server"].StringValue = selectedPath;
                    configuration.SaveToFile(App.ConfigPath);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(redisCli);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = configuration["redis"]["redis_server"].StringValue + @"\redis.windows.conf";
            Process.Start("explorer.exe", $"/select, \"{filePath}\"");
        }
    }
}
