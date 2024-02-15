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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt3 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt4 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt5 = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(55, 79);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(391, 179);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 305);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox1.Size = new System.Drawing.Size(391, 184);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "原文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "翻译结果";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(55, 506);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(391, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频调节";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "语速";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "音量";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(245, 24);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(138, 56);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(64, 24);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(128, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(654, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel2.Text = "字数：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel3.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(47, 20);
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
            this.comboBox1.Location = new System.Drawing.Point(473, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 35);
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
            this.comboBox2.Location = new System.Drawing.Point(473, 149);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 35);
            this.comboBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "源语言";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "目标语言";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(471, 199);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 27);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看语言字母列表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "领域选择";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "普通",
            "it",
            "finance",
            "machinery",
            "senimed",
            "novel",
            "academic",
            "aerospace",
            "wiki",
            "news",
            "law",
            "contract"});
            this.comboBox3.Location = new System.Drawing.Point(474, 571);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 35);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.Text = "普通";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(471, 542);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(172, 27);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "查看数字对应列表";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "翻译";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(473, 245);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(137, 29);
            this.ucBtnExt1.TabIndex = 23;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.button1_Click);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "打开文本文档";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.Gold;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(474, 296);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.Gold;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(136, 29);
            this.ucBtnExt2.TabIndex = 24;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.button4_Click);
            // 
            // ucBtnExt3
            // 
            this.ucBtnExt3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnText = "保存翻译结果";
            this.ucBtnExt3.ConerRadius = 5;
            this.ucBtnExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt3.EnabledMouseEffect = false;
            this.ucBtnExt3.FillColor = System.Drawing.Color.DodgerBlue;
            this.ucBtnExt3.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.IsRadius = true;
            this.ucBtnExt3.IsShowRect = true;
            this.ucBtnExt3.IsShowTips = false;
            this.ucBtnExt3.Location = new System.Drawing.Point(473, 350);
            this.ucBtnExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt3.Name = "ucBtnExt3";
            this.ucBtnExt3.RectColor = System.Drawing.Color.DodgerBlue;
            this.ucBtnExt3.RectWidth = 1;
            this.ucBtnExt3.Size = new System.Drawing.Size(137, 29);
            this.ucBtnExt3.TabIndex = 25;
            this.ucBtnExt3.TabStop = false;
            this.ucBtnExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt3.TipsText = "";
            this.ucBtnExt3.BtnClick += new System.EventHandler(this.button3_Click);
            // 
            // ucBtnExt4
            // 
            this.ucBtnExt4.BackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt4.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnText = "朗读结果";
            this.ucBtnExt4.ConerRadius = 5;
            this.ucBtnExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt4.EnabledMouseEffect = false;
            this.ucBtnExt4.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt4.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt4.IsRadius = true;
            this.ucBtnExt4.IsShowRect = true;
            this.ucBtnExt4.IsShowTips = false;
            this.ucBtnExt4.Location = new System.Drawing.Point(473, 404);
            this.ucBtnExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt4.Name = "ucBtnExt4";
            this.ucBtnExt4.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt4.RectWidth = 1;
            this.ucBtnExt4.Size = new System.Drawing.Size(137, 29);
            this.ucBtnExt4.TabIndex = 26;
            this.ucBtnExt4.TabStop = false;
            this.ucBtnExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt4.TipsText = "";
            this.ucBtnExt4.BtnClick += new System.EventHandler(this.button7_Click);
            // 
            // ucBtnExt5
            // 
            this.ucBtnExt5.BackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt5.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnText = "保存结果音频";
            this.ucBtnExt5.ConerRadius = 5;
            this.ucBtnExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt5.EnabledMouseEffect = false;
            this.ucBtnExt5.FillColor = System.Drawing.Color.BlueViolet;
            this.ucBtnExt5.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt5.IsRadius = true;
            this.ucBtnExt5.IsShowRect = true;
            this.ucBtnExt5.IsShowTips = false;
            this.ucBtnExt5.Location = new System.Drawing.Point(473, 460);
            this.ucBtnExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt5.Name = "ucBtnExt5";
            this.ucBtnExt5.RectColor = System.Drawing.Color.BlueViolet;
            this.ucBtnExt5.RectWidth = 1;
            this.ucBtnExt5.Size = new System.Drawing.Size(137, 29);
            this.ucBtnExt5.TabIndex = 26;
            this.ucBtnExt5.TabStop = false;
            this.ucBtnExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt5.TipsText = "";
            this.ucBtnExt5.BtnClick += new System.EventHandler(this.button8_Click);
            // 
            // frmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(654, 652);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.ucBtnExt5);
            this.Controls.Add(this.ucBtnExt4);
            this.Controls.Add(this.ucBtnExt3);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTranslate";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Purple;
            this.Text = "翻译";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 641, 596);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt4;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt5;
    }
}