using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNG2ICO
{
    public enum ClassA
    {
        JPG,
        PNG,
        ICO,
    }

    public enum CllB
    {
        JPG,
        PNG,
        WEBP,
        ICO,
    }

    public class ImageConvertUtil
    {
        public void png2ico(string inputPath, string outputPath, int size = 256)
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

        public void png2jpg()
        {

        }

        public void png2webp()
        {

        }


        public void png2()
        {

        }



    }
}
