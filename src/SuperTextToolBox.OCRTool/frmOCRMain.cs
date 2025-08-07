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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTextToolBox.OCRTool
{
    public partial class OCRFull : AntdUI.BaseForm
    {
        public static string TableSavePath;
        private Dictionary<string, FullOcrModel> langmodel;
        // 用于标识是否正在处理，防止重复执行
        private bool isProcessing = false;

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
            // 获取当前DPI比例并调整控件尺寸
            float dpiX, dpiY;
            using (Graphics g = CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }
            float scaleFactor = dpiX / 96f; // 96 DPI 是标准DPI
        }

        private ExcelPackage TableOCR(string path)
        {
            string resulttext;
            if (langmodel.TryGetValue(uiComboBox1.Text, out FullOcrModel selectedModel))
            {
                using PaddleOcrTableRecognizer tableRec = new(LocalTableRecognitionModel.ChineseMobileV2_SLANET);
                using Mat src = Cv2.ImRead(Path.Combine(path));
                TableDetectionResult tableResult = tableRec.Run(src);

                using PaddleOcrAll all = new(selectedModel);
                all.Detector.UnclipRatio = 1.2f;
                PaddleOcrResult ocrResult = all.Run(src);

                string html = tableResult.RebuildTable(ocrResult);
                resulttext = "转换表格成功";
                string name = Path.GetFileNameWithoutExtension(path);
                string outDir = Path.Combine(Environment.CurrentDirectory, "out");
                if (!Directory.Exists(outDir))
                {
                    Directory.CreateDirectory(outDir);
                }
                string savefile = Path.Combine(outDir, $"{name}.html");
                File.WriteAllText(savefile, html);

                try
                {
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
                    return package;
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
            string resulttext = "error";
            if (langmodel.TryGetValue(uiComboBox1.Text, out FullOcrModel selectedModel))
            {
                using (PaddleOcrAll all = new PaddleOcrAll(selectedModel, PaddleDevice.Gpu())
                {
                    AllowRotateDetection = true,
                    Enable180Classification = false,
                })
                {
                    using (Mat src = Cv2.ImRead(path))
                    {
                        PaddleOcrResult result = all.Run(src);
                        resulttext = result.Text;
                    }
                }
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
                        string outputPath = Path.Combine(filesavepath, $"{Guid.NewGuid()}.txt");
                        File.WriteAllText(outputPath, textBox1.Text);
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                    }
                }
            }
        }

        private void CombineXlsx()
        {
            Console.WriteLine("请输入包含Excel文件的目录路径：");

            string sourceDirectory = Path.Combine(Environment.CurrentDirectory, "out");

            try
            {
                if (!Directory.Exists(sourceDirectory))
                {
                    Console.WriteLine("目录不存在！");
                    return;
                }

                var excelFiles = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (excelFiles.Count == 0)
                {
                    Console.WriteLine("目录中没有找到Excel文件！");
                    return;
                }
                SaveFileDialog ofd = new SaveFileDialog();
                string outputPath = Path.Combine(sourceDirectory, $"Combined_{DateTime.Now:yyyyMMddHHmmss}.xlsx");
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    outputPath = ofd.FileName;
                }
                ofd.Dispose();
                using (var mergedPackage = new ExcelPackage(new FileInfo(outputPath)))
                {
                    foreach (string filePath in excelFiles)
                    {
                        try
                        {
                            using (var sourcePackage = new ExcelPackage(new FileInfo(filePath)))
                            {
                                if (sourcePackage.Workbook.Worksheets.Count == 0)
                                {
                                    Console.WriteLine($"跳过空文件: {Path.GetFileName(filePath)}");
                                    continue;
                                }

                                ExcelWorksheet sourceSheet = sourcePackage.Workbook.Worksheets[0];
                                string baseName = Path.GetFileNameWithoutExtension(filePath);
                                string newSheetName = GetUniqueSheetName(mergedPackage.Workbook, baseName);
                                ExcelWorksheet newSheet = mergedPackage.Workbook.Worksheets.Add(newSheetName, sourceSheet);
                                Console.WriteLine($"已添加: {newSheetName}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"处理文件 {Path.GetFileName(filePath)} 时出错: {ex.Message}");
                        }
                    }

                    if (mergedPackage.Workbook.Worksheets.Count > 0)
                    {
                        mergedPackage.Save();
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show($"\n合并完成！文件已保存至: {outputPath}");
                        }));
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

        private static string GetUniqueSheetName(ExcelWorkbook workbook, string baseName)
        {
            string cleanName = CleanSheetName(baseName);
            string newName = cleanName;
            int counter = 1;

            while (workbook.Worksheets.Any(ws => ws.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
            {
                newName = $"{cleanName}_{counter}";
                if (newName.Length > 31)
                {
                    newName = newName.Substring(0, 31 - counter.ToString().Length - 1) + "_" + counter;
                }
                counter++;
            }
            return newName;
        }

        private static string CleanSheetName(string name)
        {
            char[] invalidChars = { ':', '\\', '/', '?', '*', '[', ']' };
            string cleanName = new string(name.Where(c => !invalidChars.Contains(c)).ToArray());
            return cleanName.Length > 31 ? cleanName.Substring(0, 31) : cleanName;
        }

        private static void DeleteSourceFiles(IEnumerable<string> files)
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
            // 防止重复点击
            if (isProcessing) return;
            isProcessing = true;
            uiButton3.Enabled = false;

            // 启动后台线程处理OCR
            Task.Run(() =>
            {
                try
                {
                    if (uiComboBox2.Text == "图片转文字")
                    {
                        ProcessTextOCR();
                    }
                    else
                    {
                        ProcessTableOCR();
                    }
                }
                finally
                {
                    // 处理完成后恢复按钮状态
                    Invoke(new Action(() =>
                    {
                        uiButton3.Enabled = true;
                        isProcessing = false;
                    }));
                }
            });
        }

        private void ProcessTextOCR()
        {
            // 先在UI线程获取需要处理的行数据
            List<Tuple<int, string>> rowsToProcess = new List<Tuple<int, string>>();
            Invoke(new Action(() =>
            {
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    if (row.Cells["Status"].Value?.ToString() != "转换成功")
                    {
                        rowsToProcess.Add(Tuple.Create(i, row.Cells["FileName"].Value?.ToString() ?? ""));
                    }
                }
            }));

            // 处理每一行
            foreach (var item in rowsToProcess)
            {
                int rowIndex = item.Item1;
                string path = item.Item2;
                if (string.IsNullOrEmpty(path)) continue;

                string ocrResult = TextOCR(path);
                if (uiCheckBox1.Checked)
                {
                    Invoke(new Action(() =>
                    {
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                            string outputFilePath = Path.Combine(folderBrowserDialog1.SelectedPath, $"{milliseconds}.txt");
                            File.WriteAllText(outputFilePath, ocrResult);
                            textBox1.Text = "任务已完成";
                        }
                    }));
                }
                else
                {
                    // 更新文本框内容（跨线程）
                    Invoke(new Action(() =>
                    {
                        textBox1.Text += ocrResult;
                    }));
                }

                // 更新行状态（跨线程）
                Invoke(new Action(() =>
                {
                    if (rowIndex < uiDataGridView1.Rows.Count)
                    {
                        uiDataGridView1.Rows[rowIndex].Cells["Status"].Value = "转换成功";
                    }
                }));
            }
        }

        private void ProcessTableOCR()
        {
            bool saveSuccess = false;
            List<Tuple<int, string>> rowsToProcess = new List<Tuple<int, string>>();
            Invoke(new Action(() =>
            {
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    if (row.Cells["Status"].Value?.ToString() != "转换成功")
                    {
                        rowsToProcess.Add(Tuple.Create(i, row.Cells["FileName"].Value?.ToString() ?? ""));
                    }
                }
            }));

            foreach (var item in rowsToProcess)
            {
                int rowIndex = item.Item1;
                string path = item.Item2;
                if (string.IsNullOrEmpty(path)) continue;

                if (uiCheckBox1.Checked)
                {
                    ExcelPackage excelPackage = TableOCR(path);
                    if (excelPackage != null)
                    {
                        string outDir = Path.Combine(Environment.CurrentDirectory, "out");
                        Directory.CreateDirectory(outDir);
                        string savePath = Path.Combine(outDir, $"{rowIndex}.xlsx");
                        excelPackage.SaveAs(new FileInfo(savePath));
                        excelPackage.Dispose();
                        saveSuccess = true;
                    }
                }
                else
                {

                    Invoke(new Action(() =>
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExcelPackage excelPackage = TableOCR(path);
                            if (excelPackage != null)
                            {
                                excelPackage.SaveAs(new FileInfo(saveFileDialog1.FileName));
                                excelPackage.Dispose();
                                saveSuccess = true;
                            }
                        }
                    }));


                }
                // 更新行状态
                Invoke(new Action(() =>
                {
                    if (rowIndex < uiDataGridView1.Rows.Count)
                    {
                        uiDataGridView1.Rows[rowIndex].Cells["Status"].Value = saveSuccess ? "转换完成" : "用户放弃保存";
                    }
                }));
            }
            if (uiCheckBox1.Checked)
            {
                CombineXlsx();
            }
        }

        private void uiComboBox2_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            Invoke(new Action(() =>
            {
                uiComboBox2 .Text =uiComboBox2 .SelectedValue .ToString ();
                if (uiComboBox2.Text == "图片转表格")
                {
                    label5.Text = "合并输出表格";
                }
                else
                {
                    uiCheckBox1.Enabled = true;
                    label5.Text = "直接为每个图片创建一个txt";
                }
            }));
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiComboBox1_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            uiComboBox1 .Text =uiComboBox1 .SelectedValue .ToString ();
        }
    }
}