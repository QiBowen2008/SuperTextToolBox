using OfficeOpenXml;
using OpenCvSharp;
using Sdcb.PaddleInference;
using Sdcb.PaddleOCR;
using Sdcb.PaddleOCR.Models;
using Sdcb.PaddleOCR.Models.Local;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperTextToolBox.OCRTool
{
    public partial class OCRFull : AntdUI .BaseForm 
    {
        private Dictionary<string, FullOcrModel> langmodel;
        public OCRFull()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            langmodel = new Dictionary<string, FullOcrModel>
            {
                {"简体中文",LocalFullModels.ChineseV5 },
                {"繁体中文",LocalFullModels.TraditionalChineseV3 },
                {"英文",LocalFullModels.EnglishV4 },
                {"日文",LocalFullModels.JapanV4 },
                {"韩文",LocalFullModels.KoreanV4 },
                {"泰卢固文",LocalFullModels.TeluguV4 },
                {"卡纳达文",LocalFullModels.KannadaV4 },
                {"泰米尔文",LocalFullModels.TamilV4},
                {"拉丁文",LocalFullModels.LatinV3 },
                {"阿拉伯文",LocalFullModels.ArabicV4 },
                {"斯拉夫文",LocalFullModels.CyrillicV3 },
                {"梵文",LocalFullModels.DevanagariV4 }
            };
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string imagePath = Environment.GetCommandLineArgs()[1];
                uiDataGridView1.Rows.Add(imagePath, "待转换");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 获取当前DPI比例
            float dpiX, dpiY;
            using (Graphics g = CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }
            // 根据DPI比例调整控件尺寸
            float scaleFactor = dpiX / 96f; // 96 DPI 是标准DPI

        }

        private string OCR(string path)
        {
            string resulttext;
            if (langmodel.TryGetValue(uiComboBox1.Text, out FullOcrModel selectedModel))
            {
                // 使用选中的模型
                FullOcrModel model= selectedModel;
                // 这里可以使用 selectedModel 进行OCR处理
                if (uiComboBox2.Text == "图片转文字")
                {
                    using (PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Gpu())
                    {
                        AllowRotateDetection = true, /* 允许识别有角度的文字 */
                        Enable180Classification = false, /* 允许识别旋转角度大于90度的文字 */
                    })
                    {
                        // Load local file by following code:
                        using (Mat src = Cv2.ImRead(path))
                        //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
                        {
                            PaddleOcrResult result = all.Run(src);
                            Console.WriteLine("Detected all texts: \n" + result.Text);
                            resulttext = result.Text;
                            foreach (PaddleOcrResultRegion region in result.Regions)
                            {
                                Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                            }
                        }
                    }
                }else
                {
                    using PaddleOcrTableRecognizer tableRec = new(LocalTableRecognitionModel.ChineseMobileV2_SLANET);
                    using Mat src = Cv2.ImRead(Path.Combine(path));
                    // Table detection
                    TableDetectionResult tableResult = tableRec.Run(src);

                    // Normal OCR
                    using PaddleOcrAll all = new(selectedModel);
                    all.Detector.UnclipRatio = 1.2f;
                    PaddleOcrResult ocrResult = all.Run(src);

                    // Rebuild table
                    string html = tableResult.RebuildTable(ocrResult);
                    resulttext = "转换表格成功";
                    string name = Path.GetFileNameWithoutExtension(path);
                    if (!Directory.Exists(Environment.CurrentDirectory + "\\out"))
                    { Directory.CreateDirectory(Environment.CurrentDirectory + "\\out"); }
                    string savefile = $"{Environment.CurrentDirectory}\\out\\{name}.html";
                    File.WriteAllText(savefile, html);
                    try
                    {
                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                            var htmlTable = new HtmlAgilityPack.HtmlDocument();
                            htmlTable.LoadHtml(html);
                            var table = htmlTable.DocumentNode.SelectSingleNode("//table");
                            int row = 1, col = 1;
                            foreach (var tr in table.SelectNodes(".//tr"))
                            {
                                col = 1;
                                foreach (var td in tr.SelectNodes(".//td|.//th"))
                                {
                                    worksheet.Cells[row, col].Value = td.InnerText;
                                    col++;
                                }
                                row++;
                            }
                            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                            {
                                package.SaveAs(saveFileDialog2.FileName);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("保存为xlsx失败，已经为您保存好html格式，修复可以试试在控制面板找到程序和功能-打开或关闭Windows功能，打开NetFramwork3.5");
                        toolStripStatusLabel1.Text = "未完全成功";
                        return "ERROR!";
                    }
                }
            }
            
            else
            {
                resulttext = "error";
            }
            return resulttext;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "图片|*.png;*.jpg;*.jpeg;*.tiff;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            uiButton3.Enabled = true;
            foreach (string filename in ofd.FileNames)
            {
                uiDataGridView1.Rows.Add(filename, "待转换");
               
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先识别");
            }
            else
            {
                saveFileDialog1.Filter = "文本文档 | *.txt";
                string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
                if (autosave == "True")
                {
                    string filesavepath = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
                    if (filesavepath != "")
                    {
                        StreamWriter sw = new StreamWriter(filesavepath + "\\" + Guid.NewGuid().ToString() + ".txt");
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(textBox1.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiButton3.Enabled = false;
            if (uiCheckBox1.Checked == true)
            {
                folderBrowserDialog1.ShowDialog();
            }
            for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = uiDataGridView1.Rows[i];
                if(row.Cells["Status"].Value.ToString() != "转换成功"){
                if (uiCheckBox1.Checked == true)
                {
                    string eachresult = OCR((string)row.Cells["FileName"].Value);
                    DateTime now = DateTime.Now;
                    // 将时间转换为毫秒级的时间戳
                    long milliseconds = now.Ticks / TimeSpan.TicksPerMillisecond;
                    string outputFilePath = Path.Combine(folderBrowserDialog1.SelectedPath, milliseconds.ToString() + ".txt");
                    StreamWriter sw = new StreamWriter(outputFilePath);
                    sw.Write(eachresult);
                    sw.Flush();
                    sw.Dispose();
                }
                else
                {
                    textBox1.Text = textBox1.Text + OCR((string)row.Cells["FileName"].Value);
                }
                row.Cells["Status"].Value = "转换成功"; }
            }
            uiButton3.Enabled = true;
        }


        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OCRFull_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
