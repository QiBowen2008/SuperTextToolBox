using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Drawing.Text;

namespace SuperTextToolBox
{
    public partial class frmTextToPic : AntdUI.BaseForm
    {
        public frmTextToPic()
        {
            InitializeComponent();
        }

        public static string[] oldfilenames;
        public static string newoutputpath;
        public static string novel;
        public static string noveltext;
        void Calc()
        {
            int textcountperpage = (Convert.ToInt32(uiIntegerUpDown3.Value));
            double size = (Convert.ToInt32(uiIntegerUpDown4.Value));
            double allpx = Math.Pow((size + 1) / 72 * 96, 2) * textcountperpage;
            int width = Convert.ToInt32((Convert.ToInt32(uiIntegerUpDown1.Value)) * Math.Sqrt(allpx / (Convert.ToInt32(uiIntegerUpDown1.Value) * (Convert.ToInt32(uiIntegerUpDown2.Value)))));
            int height = Convert.ToInt32((Convert.ToInt32(uiIntegerUpDown2.Value)) * Math.Sqrt(allpx / (Convert.ToInt32(uiIntegerUpDown1.Value) * (Convert.ToInt32(uiIntegerUpDown2.Value)))));
            PicInfo.weight = width;
            PicInfo.height = height;
            PicInfo.size = size;
        }
        static string ProcessString(string input, int interval)
        {
            // 移除所有的换行符
            string noNewLines = input.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

            // 创建一个StringBuilder对象以提高性能
            StringBuilder sb = new StringBuilder();

            // 遍历字符串，并在指定位置插入换行符
            for (int i = 0; i < noNewLines.Length; i++)
            {
                if (i > 0 && i % interval == 0)
                    sb.AppendLine();
                sb.Append(noNewLines[i]);
            }

            return sb.ToString();
        }

        void ConvertTextToImages(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                Calc();
                // 读取文本文件
                string filePath = @novel; // 指定你的文本文件路径
                int charsPerImage = (Convert.ToInt32(uiIntegerUpDown3.Value)); // 每张图片上的字符数

                string outputDirectory = @"输出目录"; // 输出目录
                Size imageSize = new Size(PicInfo.weight + 100, PicInfo.height + 500);
                // 创建输出目录如果不存在
                Directory.CreateDirectory(outputDirectory);

                // 读取文本文件
                string text = ProcessString(textBox1.Text, Convert.ToInt32((PicInfo.weight - 200) / (PicInfo.size / 72 * 96)));
                int totalChars = text.Length;



                // 设置字体样式
                Font font = new Font(uiComboBox1.Text, (Convert.ToInt32(uiIntegerUpDown4.Value))); // 宋体，字号可以调整
                SolidBrush brush = new SolidBrush(Color.Black);
                // 设置图片大小



                // 开始处理文本
                for (int i = 0; i < count; i++)
                {
                    // 计算每个图片上显示的文本片段
                    int startCharIndex = i * charsPerImage;
                    int endCharIndex = Math.Min(startCharIndex + charsPerImage, totalChars);
                    string segment = text.Substring(startCharIndex, endCharIndex - startCharIndex);

                    // 创建图片
                    using (Bitmap bitmap = new Bitmap(imageSize.Width, imageSize.Height))
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            // 清除背景
                            graphics.Clear(Color.White);

                            // 计算文本的位置，使其居中显示
                            SizeF textSize = graphics.MeasureString(segment, font);
                            PointF location = new PointF((imageSize.Width - textSize.Width) / 2, (imageSize.Height - textSize.Height) / 2);
                            // 绘制文本
                            graphics.DrawString(segment, font, brush, location);
                        }
                        DateTime now = DateTime.Now;
                        // 将时间转换为毫秒级的时间戳
                        long milliseconds = now.Ticks / TimeSpan.TicksPerMillisecond;
                        string outputFilePath = Path.Combine(outputDirectory, milliseconds.ToString() + ".png");
                        bitmap.Save(outputFilePath, ImageFormat.Png);
                    }

                }
                Process.Start("explorer", @outputDirectory);
            }
            else
            {
                MessageBox.Show("请输入文本");
            }

        }

        private void ChooseNovel(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                novel = openFileDialog1.FileName;
                noveltext = File.ReadAllText(@novel, Encoding.GetEncoding(0));
                textBox1.Text = noveltext;
                count = textBox1.Text.Length / (Convert.ToInt32(uiIntegerUpDown3.Value)) + 1;
                if (count != 1)
                {
                    label4.Text = "需要" + (count - 1).ToString() + "-" + count.ToString() + "张图片";
                }
                else
                {
                    label4.Text = "需要" + count.ToString() + "张笔记";
                }
            }

        }
        public static int count;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            count = textBox1.Text.Length / (Convert.ToInt32(uiIntegerUpDown3.Value)) + 1;
            if (count != 1)
            {
                label4.Text = "需要" + (count - 1).ToString() + "-" + count.ToString() + "张图片";
            }
            else
            {
                label4.Text = "需要" + count.ToString() + "张笔记";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            // 获取所有已安装的字体系列
            var fontFamilies = installedFonts.Families;
            foreach (var ttfname in fontFamilies)
            {
                string ttfstr = ttfname.ToString();
                string newString = ttfstr.Substring(18);
                string laststring = newString.Remove(newString.Length - 1, 1);
                uiComboBox1.Items.Add(laststring);
            }
             
        }


        private void uiIntegerUpDown3_ValueChanged(object sender, EventArgs e)
        {
            count = textBox1.Text.Length /( Convert .ToInt32 ( uiIntegerUpDown3.Value)) + 1;
            if (count != 1)
            {
                label4.Text = "需要" + (count - 1).ToString() + "-" + count.ToString() + "张图片";
            }
            else
            {
                label4.Text = "需要" + count.ToString() + "张笔记";
            }
        }

        private void uiIntegerUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            uiComboBox1.Text = uiComboBox1.SelectedValue.ToString();
        }
    }
    public static class PicInfo
    {
        public static int height;
        public static int weight;
        public static double size;
        public static string character;
        public static int allpx;
        public static int dpi;
    }
}