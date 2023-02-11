using JiebaNet.Analyser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using JiebaNet.Segmenter.Common;
using JiebaNet.Segmenter;
using WordCloudSharp;

namespace WordCloudApp
{
    public partial class Form1 : Form
    {
        public string maskpic = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string text = textBox1.Text;
                var wordWeight = ExtractTagsWithWeight(text);
                var wordFreqs = Counter(text, wordWeight);
                CreateWordCloud1(wordFreqs);
                pictureBox1.Image = Image.FromFile("result.jpg");
            }
            else
            {
                string text = textBox1.Text;
                var wordWeight = ExtractTagsWithWeight(text);
                var wordFreqs = Counter(text, wordWeight);
                CreateWordCloud2(wordFreqs,maskpic);
                pictureBox1.Image = Image.FromFile("result.jpg");
            }
            
        }
        /// <summary>
        /// 从指定文本中抽取关键词的同时得到其权重
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static WordWeightPair[] ExtractTagsWithWeight(string text)
        {
            var extractor = new TfidfExtractor();
            var wordWeight = extractor.ExtractTagsWithWeight(text, 50);
            StringBuilder sbr = new StringBuilder();
            sbr.Append("词语");
            sbr.Append(",");
            sbr.Append("权重");
            sbr.AppendLine(",");
            foreach (var item in wordWeight)
            {
                sbr.Append(item.Word);
                sbr.Append(",");
                sbr.Append(item.Weight);
                sbr.AppendLine(",");
            }
            string filename = "关键词权重统计.csv";
            File.WriteAllText(filename, sbr.ToString(), Encoding.UTF8);
            return wordWeight.ToArray();
        }
        static KeyValuePair<string, int>[] Counter(string text, WordWeightPair[] wordWeightAry)
        {
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(text);
            var freqs = new Counter<string>(segments);
            KeyValuePair<string, int>[] countAry = new KeyValuePair<string, int>[wordWeightAry.Length];
            for (int i = 0; i < wordWeightAry.Length; i++)
            {
                string key = wordWeightAry[i].Word;
                countAry[i] = new KeyValuePair<string, int>(key, freqs[key]);
            }
            StringBuilder sbr = new StringBuilder();
            sbr.Append("词语");
            sbr.Append(",");
            sbr.Append("词频");
            sbr.AppendLine(",");
            foreach (var pair in countAry)
            {
                sbr.Append(pair.Key);
                sbr.Append(",");
                sbr.Append(pair.Value);
                sbr.AppendLine(",");
            }
            string filename = "词频统计结果.csv";
            File.WriteAllText(filename, sbr.ToString(), Encoding.UTF8);
            return countAry;
        }
        /// <summary>
        /// 创建词云图
        /// </summary>
        /// <param name="countAry"></param>
        static void CreateWordCloud1(KeyValuePair<string, int>[] countAry)
        {
            string resultPath = "result.jpg";
            //使用蒙版图片
            //var wordCloud = new WordCloud(mask.Width, mask.Height, mask: mask, allowVerical: true, fontname: "YouYuan");
            //不使用蒙版图片
            var wordCloud = new WordCloud(1000, 1000,false, null,-1,1,null, false);
            var result = wordCloud.Draw(countAry.Select(it => it.Key).ToList(), countAry.Select(it => it.Value).ToList());
            result.Save(resultPath);
        }
        static void CreateWordCloud2(KeyValuePair<string, int>[] countAry,string markPath)
        {
   
            string resultPath = "result.jpg";
            Console.WriteLine("开始生成图片，读取蒙版：" + markPath);
            Image mask = Image.FromFile(markPath);
            //使用蒙版图片
            var wordCloud = new WordCloud(mask.Width, mask.Height, mask: mask, allowVerical: true, fontname: "YouYuan");
            //不使用蒙版图片
            //var wordCloud = new WordCloud(1000, 1000,false, null,-1,1,null, false);
            var result = wordCloud.Draw(countAry.Select(it => it.Key).ToList(), countAry.Select(it => it.Value).ToList());
            result.Save(resultPath);
            Console.WriteLine("图片生成完成，保存图片：" + resultPath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("result.jpg"))
            {
                File.Delete("result.jpg");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            File.Copy("result.jpg", saveFileDialog1.FileName,true );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("mask1s.jpg");
            maskpic = "mask1.png";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("mask2s.jpg");
            maskpic = "mask2.png";
        }
    }
}
