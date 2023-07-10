using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;
namespace SuperWenZiToolBox
{
    public partial class frmTexttoWave : Sunny.UI.UIForm
    {
        private int yinliangvalue = 100;
        public double yusu = 0;
        public frmTexttoWave()
        {
            InitializeComponent();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请输入文本");
            }
            else
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                voice.Rate = trackBar2.Value - 5; //设置语速,[-10,10]
                voice.Volume = yinliangvalue; //设置音量,[0,100]
                voice.SpeakAsync(textBox1.Text);  //播放指定的字符串,这是异步朗读
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先输入文本");
            }
            else
            {
                saveFileDialog1.Filter = "音频 | *.mp3";
                string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
                if (autosave == "True")
                {
                    string filesavepath = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
                    if (filesavepath != "")
                    {
                        SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                        voice.SetOutputToWaveFile(saveFileDialog1.FileName);
                        voice.Rate = trackBar2.Value - 5; //设置语速,[-10,10]
                        voice.Volume = yinliangvalue; //设置音量,[0,100]
                        voice.Speak(textBox1.Text);
                        voice.SetOutputToNull();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                            voice.SetOutputToWaveFile(saveFileDialog1.FileName);
                            voice.Rate = trackBar2.Value - 5; //设置语速,[-10,10]
                            voice.Volume = yinliangvalue; //设置音量,[0,100]
                            voice.Speak(textBox1.Text);
                            voice.SetOutputToNull();
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                        voice.SetOutputToWaveFile(saveFileDialog1.FileName);
                        voice.Rate = trackBar2.Value - 5; //设置语速,[-10,10]
                        voice.Volume = yinliangvalue; //设置音量,[0,100]
                        voice.Speak(textBox1.Text);
                        voice.SetOutputToNull();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            if (button2.Text == "暂停")
            {
                speech.Pause();
                button2.Text = "继续";
            }
            else
            {
                speech.Resume();
                button2.Text = "暂停";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(0));
                textBox1.Text = sr.ReadToEnd();
            }
        }
        private void frmTexttoWave_Load(object sender, EventArgs e) => toolStripStatusLabel3.Text = yinliangvalue.ToString();
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            yinliangvalue = trackBar1.Value * 10;
            toolStripStatusLabel3.Text = yinliangvalue.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            yusu = trackBar2.Value - 5;
            toolStripStatusLabel5.Text = yusu.ToString();
        }
    }
}