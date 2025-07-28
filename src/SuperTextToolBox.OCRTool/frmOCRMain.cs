using OfficeOpenXml;
using OpenCvSharp;
using Sdcb.PaddleInference;
using Sdcb.PaddleOCR;
using Sdcb.PaddleOCR.Models;
using Sdcb.PaddleOCR.Models.Local;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SuperTextToolBox.OCRTool
{
    public partial class OCRFull : AntdUI.BaseForm
    {
        public static string TableSavePath;
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
        private ExcelPackage TableOCR(string path)
        {
            string resulttext;
            if (langmodel.TryGetValue(uiComboBox1.Text, out FullOcrModel selectedModel))
            {
                // 使用选中的模型
                FullOcrModel model = selectedModel;
                // 这里可以使用 selectedModel 进行OCR处理

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
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\out");
                }
                string savefile = $"{Environment.CurrentDirectory}\\out\\{name}.html";
                File.WriteAllText(savefile, html);

                try
                {
                    // 移除using语句，避免自动释放
                    var package = new ExcelPackage();
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    var htmlTable = new HtmlAgilityPack.HtmlDocument();
                    htmlTable.LoadHtml(html);
                    var table = htmlTable.DocumentNode.SelectSingleNode("//table");

                    if (table == null)
                    {
                        MessageBox.Show("未找到表格内容");
                        return null;
                    }

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
                    return package; // 此时package未被释放
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("不支持当前语言");
                return null;
            }
        }
        private string TextOCR(string path)
        {
            string resulttext;
            if (langmodel.TryGetValue(uiComboBox1.Text, out FullOcrModel selectedModel))
            {
                // 使用选中的模型
                FullOcrModel model = selectedModel;
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
                        resulttext = result.Text;
                        foreach (PaddleOcrResultRegion region in result.Regions)
                        {
                            MessageBox.Show($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                        }
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
        private void CombineXlsx() {
            Console.WriteLine("请输入包含Excel文件的目录路径：");

            string sourceDirectory;
            sourceDirectory = Environment.CurrentDirectory + "\\out";


            try
            {
                if (!Directory.Exists(sourceDirectory))
                {
                    Console.WriteLine("目录不存在！");
                    return;
                }

                // 获取目录中所有Excel文件（支持.xlsx和.xls）
                var excelFiles = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (excelFiles.Count == 0)
                {
                    Console.WriteLine("目录中没有找到Excel文件！");
                    return;
                }

                // 创建合并后的文件路径（在源目录中）
                string outputPath = Path.Combine(sourceDirectory, $"Combined_{DateTime.Now:yyyyMMddHHmmss}.xlsx");

                using (var mergedPackage = new ExcelPackage(new FileInfo(outputPath)))
                {
                    foreach (string filePath in excelFiles)
                    {
                        try
                        {
                            using (var sourcePackage = new ExcelPackage(new FileInfo(filePath)))
                            {
                               

                                // 检查文件是否包含工作表
                                if (sourcePackage.Workbook.Worksheets.Count == 0)
                                {
                                    Console.WriteLine($"跳过空文件: {Path.GetFileName(filePath)}");
                                    continue;
                                }

                                // 获取第一个工作表
                                ExcelWorksheet sourceSheet = sourcePackage.Workbook.Worksheets[0];

                                // 生成唯一的工作表名称
                                string baseName = Path.GetFileNameWithoutExtension(filePath);
                                string newSheetName = GetUniqueSheetName(mergedPackage.Workbook, baseName);

                                // 复制工作表到目标工作簿
                                ExcelWorksheet newSheet = mergedPackage.Workbook.Worksheets.Add(newSheetName, sourceSheet);
                                Console.WriteLine($"已添加: {newSheetName}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"处理文件 {Path.GetFileName(filePath)} 时出错: {ex.Message}");
                        }
                    }

                    // 保存合并后的文件
                    if (mergedPackage.Workbook.Worksheets.Count > 0)
                    {
                        mergedPackage.Save();
                        MessageBox .Show($"\n合并完成！文件已保存至: {outputPath}");

                        // 删除源文件
                        DeleteSourceFiles(excelFiles);
                    }
                    else
                    {
                        Console.WriteLine("没有有效的工作表可合并！");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"发生错误: {ex.Message}");
            }
        }

        // 生成唯一的工作表名称
        private static string GetUniqueSheetName(ExcelWorkbook workbook, string baseName)
        {
            // 清理非法字符并截断（Excel工作表名称最大31字符）
            string cleanName = CleanSheetName(baseName);
            string newName = cleanName;
            int counter = 1;

            while (workbook.Worksheets.Any(ws => ws.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
            {
                newName = $"{cleanName}_{counter}";
                // 确保名称长度不超过31字符
                if (newName.Length > 31)
                {
                    newName = newName.Substring(0, 31 - counter.ToString().Length - 1) + "_" + counter;
                }
                counter++;
            }
            return newName;
        }

        // 清理非法字符
        private static string CleanSheetName(string name)
        {
            // 替换非法字符
            char[] invalidChars = { ':', '\\', '/', '?', '*', '[', ']' };
            string cleanName = new string(name
                .Where(c => !invalidChars.Contains(c))
                .ToArray());

            // 截断到31字符
            return cleanName.Length > 31 ? cleanName.Substring(0, 31) : cleanName;
        }

        // 删除源文件
        private static void DeleteSourceFiles(System.Collections.Generic.IEnumerable<string> files)
        {
            Console.WriteLine("\n是否要删除源文件？(Y/N)");
            if (Console.ReadKey().Key != ConsoleKey.Y)
            {
                Console.WriteLine("\n已取消删除源文件。");
                return;
            }

            Console.WriteLine("\n正在删除源文件...");
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                    Console.WriteLine($"已删除: {Path.GetFileName(file)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"删除 {Path.GetFileName(file)} 失败: {ex.Message}");
                }
            }
        }
    

 
        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiButton3.Enabled = false;
            if (uiComboBox2.Text == "图片转文字")
            {
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    if (row.Cells["Status"].Value.ToString() != "转换成功")
                    {
                        if (uiCheckBox1.Checked == true)
                        {
                            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                            {
                                string eachresult = TextOCR((string)row.Cells["FileName"].Value);
                                DateTime now = DateTime.Now;
                                // 将时间转换为毫秒级的时间戳
                                long milliseconds = now.Ticks / TimeSpan.TicksPerMillisecond;
                                string outputFilePath = Path.Combine(folderBrowserDialog1.SelectedPath, milliseconds.ToString() + ".txt");
                                StreamWriter sw = new StreamWriter(outputFilePath);
                                sw.Write(eachresult);
                                sw.Flush();
                                sw.Dispose();
                                textBox1.Text = "任务已完成";
                            }
                        }
                        else
                        {
                            textBox1.Text = textBox1.Text + TextOCR((string)row.Cells["FileName"].Value);
                        }
                        row.Cells["Status"].Value = "转换成功";
                    }
                }
            }
            else
            {
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++){
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    if (row.Cells["Status"].Value.ToString() != "转换成功")
                    {
                        if (uiCheckBox1.Checked == true)
                        {
                            ExcelPackage excelPackage;
                            excelPackage = TableOCR((string)row.Cells["FileName"].Value);
                            excelPackage.SaveAs(Environment.CurrentDirectory + "\\out\\" + i.ToString() + ".xlsx");
                            excelPackage.Dispose();
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                TableOCR((string)row.Cells["FileName"].Value).SaveAs(saveFileDialog1.FileName);
                                row.Cells["Status"].Value = "转换成功";
                            }
                            else
                            {
                                row.Cells["Status"].Value = "用户放弃保存";
                            }
                        }
                        

                    }
                }
                if (uiCheckBox1.Checked == true)
                {
                    CombineXlsx();
                }


            }

            uiButton3.Enabled = true;
        }

        private void uiComboBox2_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            if (uiComboBox2.Text == "图片转表格")
            {
                label5.Text = "直接为每个图片创建一个xlsx";
            }
            else
            {
                uiCheckBox1.Enabled = true;
                label5.Text = "直接为每个图片创建一个txt";
            }
        }
    }
}
