namespace SuperWenZiToolBox
{
    partial class frmTranslate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button8 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "翻译";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(41, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(294, 144);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox1.Size = new System.Drawing.Size(294, 148);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "原文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "翻译结果";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "保存翻译结果";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "打开文本文档";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文档|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文档|*.txt";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(355, 294);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "朗读结果";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(41, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频调节";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "语速";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "音量";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(221, 20);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 42);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(64, 20);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(94, 42);
            this.trackBar1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(355, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "保存结果音频";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel2.Text = "字数：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel4.Text = "/2000";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ara",
            "alb",
            "arg",
            "aym",
            "oss",
            "ori",
            "pl",
            "bak",
            "bel",
            "bul",
            "bem",
            "bal",
            "bho",
            "chv",
            "dan",
            "sha",
            "log",
            "ru",
            "fra",
            "san",
            "fao",
            "gla",
            "hkm",
            "guj",
            "grn",
            "kor",
            "hak",
            "hau",
            "kir",
            "cat",
            "kab",
            "kah",
            "cos",
            "kli",
            "kas",
            "lat",
            "lag",
            "lin",
            "ruy",
            "roh",
            "may",
            "mg",
            "mah",
            "mau",
            "mlt",
            "nor",
            "afr",
            "pt",
            "pus",
            "nya",
            "jp",
            "srd",
            "srp",
            "epo",
            "slo",
            "som",
            "th",
            "tam",
            "tel",
            "ukr",
            "ven",
            "spa",
            "hu",
            "hil",
            "nno",
            "sna",
            "sun",
            "en",
            "it",
            "ina",
            "ibo",
            "arm",
            "zh",
            "yue",
            "zul",
            "gle",
            "arq",
            "amh",
            "aze",
            "est",
            "orm",
            "per",
            "baq",
            "ber",
            "sme",
            "bli",
            "ice",
            "tso",
            "de",
            "tet",
            "fil",
            "fri",
            "kon",
            "kal",
            "gra",
            "nl",
            "ht",
            "glg",
            "cs",
            "kan",
            "cor",
            "cre",
            "hrv",
            "kok",
            "lao",
            "lav",
            "lug",
            "kin",
            "ro",
            "bur",
            "mal",
            "mai",
            "mao",
            "hmn",
            "nea",
            "sot",
            "pan",
            "twi",
            "swe",
            "sm",
            "sol",
            "nob",
            "swa",
            "tr",
            "tgl",
            "tua",
            "wln",
            "wol",
            "heb",
            "fry",
            "los",
            "nqo",
            "ceb",
            "",
            "hi",
            "vie",
            "ach",
            "ido",
            "iku",
            "cht",
            "zaz",
            "jav",
            "oci",
            "aka",
            "asm",
            "ast",
            "oji",
            "bre",
            "pot",
            "pam",
            "ped",
            "bis",
            "bos",
            "tat",
            "div",
            "fin",
            "ful",
            "ups",
            "geo",
            "eno",
            "hup",
            "mot",
            "frn",
            "kau",
            "xho",
            "cri",
            "que",
            "kur",
            "rom",
            "lim",
            "ltz",
            "lit",
            "loj",
            "mar",
            "mac",
            "glv",
            "ben",
            "nbl",
            "nep",
            "pap",
            "chr",
            "sec",
            "sin",
            "sk",
            "src",
            "tgk",
            "tir",
            "tuk",
            "wel",
            "urd",
            "el",
            "sil",
            "haw",
            "snd",
            "syr",
            "id",
            "yid",
            "ing",
            "yor",
            "ir",
            "wyw",
            "frm"});
            this.comboBox1.Location = new System.Drawing.Point(355, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 20);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ara",
            "alb",
            "arg",
            "aym",
            "oss",
            "ori",
            "pl",
            "bak",
            "bel",
            "bul",
            "bem",
            "bal",
            "bho",
            "chv",
            "dan",
            "sha",
            "log",
            "ru",
            "fra",
            "san",
            "fao",
            "gla",
            "hkm",
            "guj",
            "grn",
            "kor",
            "hak",
            "hau",
            "kir",
            "cat",
            "kab",
            "kah",
            "cos",
            "kli",
            "kas",
            "lat",
            "lag",
            "lin",
            "ruy",
            "roh",
            "may",
            "mg",
            "mah",
            "mau",
            "mlt",
            "nor",
            "afr",
            "pt",
            "pus",
            "nya",
            "jp",
            "srd",
            "srp",
            "epo",
            "slo",
            "som",
            "th",
            "tam",
            "tel",
            "ukr",
            "ven",
            "spa",
            "hu",
            "hil",
            "nno",
            "sna",
            "sun",
            "en",
            "it",
            "ina",
            "ibo",
            "arm",
            "zh",
            "yue",
            "zul",
            "gle",
            "arq",
            "amh",
            "aze",
            "est",
            "orm",
            "per",
            "baq",
            "ber",
            "sme",
            "bli",
            "ice",
            "tso",
            "de",
            "tet",
            "fil",
            "fri",
            "kon",
            "kal",
            "gra",
            "nl",
            "ht",
            "glg",
            "cs",
            "kan",
            "cor",
            "cre",
            "hrv",
            "kok",
            "lao",
            "lav",
            "lug",
            "kin",
            "ro",
            "bur",
            "mal",
            "mai",
            "mao",
            "hmn",
            "nea",
            "sot",
            "pan",
            "twi",
            "swe",
            "sm",
            "sol",
            "nob",
            "swa",
            "tr",
            "tgl",
            "tua",
            "wln",
            "wol",
            "heb",
            "fry",
            "los",
            "nqo",
            "ceb",
            "",
            "hi",
            "vie",
            "ach",
            "ido",
            "iku",
            "cht",
            "zaz",
            "jav",
            "oci",
            "aka",
            "asm",
            "ast",
            "oji",
            "bre",
            "pot",
            "pam",
            "ped",
            "bis",
            "bos",
            "tat",
            "div",
            "fin",
            "ful",
            "ups",
            "geo",
            "eno",
            "hup",
            "mot",
            "frn",
            "kau",
            "xho",
            "cri",
            "que",
            "kur",
            "rom",
            "lim",
            "ltz",
            "lit",
            "loj",
            "mar",
            "mac",
            "glv",
            "ben",
            "nbl",
            "nep",
            "pap",
            "chr",
            "sec",
            "sin",
            "sk",
            "src",
            "tgk",
            "tir",
            "tuk",
            "wel",
            "urd",
            "el",
            "sil",
            "haw",
            "snd",
            "syr",
            "id",
            "yid",
            "ing",
            "yor",
            "ir",
            "wyw",
            "frm"});
            this.comboBox2.Location = new System.Drawing.Point(355, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 20);
            this.comboBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "源语言";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "目标语言";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(353, 130);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 12);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看语言字母列表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // frmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 477);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTranslate";
            this.Text = "翻译";
            this.Load += new System.EventHandler(this.frmTranslate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}