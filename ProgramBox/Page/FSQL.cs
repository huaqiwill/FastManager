using ProgramBox.Utils;
using SharpConfig;
using Sunny.UI;
using System;
using System.Windows.Forms;

/**
MySQL服务管理

2024.5.12 添加功能 启动SQL服务、停止SQL服务
2024.5.12 
**/
namespace ProgramBox.UI
{
    public partial class FSQL : UIForm
    {
        private Configuration configuration;

        public FSQL()
        {
            InitializeComponent();
        }



        FMain mainFrm;

        private void MySQLEnvFrm_Load(object sender, EventArgs e)
        {
            // 默认效果
            mysql5posLB.Text = "";
            mysql8posLB.Text = "";

            // 
            configuration = Configuration.LoadFromFile(App.ConfigPath);
            // 窗口位置和大小
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;

            // mysql5初始化
            string mysql5pos = configuration["mysql5"]["position"].StringValue;
            if (string.IsNullOrEmpty(mysql5pos))
            {
                mysql5startBtn.Enabled = false;
                mysql5restartBtn.Enabled = false;
                mysql5configBtn.Enabled = false;
                mysql5posBtn.Enabled = true;
            }
            else
            {
                mysql5posLB.Text = mysql5pos;
            }

            // mysql8初始化
            string mysql8pos = configuration["mysql8"]["position"].StringValue;
            if (string.IsNullOrEmpty(mysql8pos))
            {
                mysql8startBtn.Enabled = false;
                mysql8restartBtn.Enabled = false;
                mysql8configBtn.Enabled = false;
                mysql8posBtn.Enabled = true;
            }
            else
            {
                mysql8posLB.Text = mysql8pos;
            }

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            // 启动

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            // 重启

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            // 目录
            string mysql5pos = configuration["mysql5"]["position"].StringValue;
            if (string.IsNullOrEmpty(mysql5pos))
            {
                // 配置MySQL5的位置
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    // 设置对话框的描述信息
                    folderBrowserDialog.Description = "Please Select MySQL5";

                    // 如果用户选择了文件夹，则将选定的文件夹路径赋值给textBox1
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        configuration["mysql5"]["position"].StringValue = folderBrowserDialog.SelectedPath;
                        configuration.SaveToFile(App.ConfigPath);
                        mysql5posLB.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            else
            {
                // 打开MySQL5的位置
                App.OpenInExplorer(mysql5pos);
            }

        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            // 目录
            string mysql8pos = configuration["mysql8"]["position"].StringValue;
            if (string.IsNullOrEmpty(mysql8pos))
            {
                // 配置MySQL5的位置
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Please Select MySQL8";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        configuration["mysql8"]["position"].StringValue = folderBrowserDialog.SelectedPath;
                        configuration.SaveToFile(App.ConfigPath);
                        mysql8posLB.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            else
            {
                // 打开MySQL5的位置
                App.OpenInExplorer(mysql8pos);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }
    }
}
