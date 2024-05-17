using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNG2ICO
{
    public partial class FormatterFrm : Form
    {
        public FormatterFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_row.SelectedIndex = 0;
            comboBox_dst.SelectedIndex = 0;
        }

        private void png2ico(string inputPath, string outputPath, int size = 256)
        {
            // 读取 PNG 图片文件
            using (var pngStream = new FileStream(inputPath, FileMode.Open))
            {
                using (var pngImage = Image.FromStream(pngStream))
                {
                    // 创建 ICO 格式的图标
                    using (var memoryStream = new MemoryStream())
                    {
                        using (var iconImage = new Bitmap(pngImage, new Size(size, size)))
                        {
                            Icon.FromHandle(iconImage.GetHicon()).Save(memoryStream);
                        }

                        // 将 ICO 图标保存到文件
                        File.WriteAllBytes(outputPath, memoryStream.ToArray());
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG文件 (*.png)|*.exe|所有文件 (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;



                textBox_filePath.Text = filePath;

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG文件 (*.png)|*.exe|所有文件 (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;



                textBox_outputPath.Text = filePath;

            }
        }

        // 转换
        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(textBox_filePath.Text);
            string newFileName = Path.GetDirectoryName(textBox_filePath.Text);
            string ouputPath = newFileName + "\\" + fileName + ".ico";

            int size;
            try
            {
                size = Convert.ToInt32(textBox_sizeX.Text);
            }
            catch
            {
                MsgBoxUtil.Error("尺寸只能为整数");
                return;
            }

            png2ico(textBox_filePath.Text, ouputPath, size);

            MsgBoxUtil.Info("转换成功");
        }
    }
}
