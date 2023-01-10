using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace SuperWenZiToolBox
{
    public partial class frmTexttoWave : Form
    {
        public frmTexttoWave()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
            voice.Rate = -1; //设置语速,[-10,10]
            voice.Volume = 100; //设置音量,[0,100]
            voice.SpeakAsync(textBox1.Text);  //播放指定的字符串,这是异步朗读
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.ShowDialog();
                SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                voice.SetOutputToWaveFile(saveFileDialog1.FileName);
                voice.Speak(textBox1.Text);
                voice.SetOutputToNull();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            if (button2.Text=="暂停")
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
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
            }

        }
    }
}
