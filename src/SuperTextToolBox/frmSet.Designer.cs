namespace SuperTextToolBox
{
    partial class frmSet
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
            AntdUI.Tabs.StyleLine styleLine2 = new AntdUI.Tabs.StyleLine();
            SuperTextToolBox.Properties.Settings settings2 = new SuperTextToolBox.Properties.Settings();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.uiButton1 = new AntdUI.Button();
            this.uiButton2 = new AntdUI.Button();
            this.tabs1 = new AntdUI.Tabs();
            this.tabPage5 = new AntdUI.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.switch1 = new AntdUI.Switch();
            this.switch2 = new AntdUI.Switch();
            this.button1 = new AntdUI.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.input1 = new AntdUI.Input();
            this.tabPage6 = new AntdUI.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiComboBox2 = new AntdUI.Dropdown();
            this.uiComboBox1 = new AntdUI.Dropdown();
            this.tabs1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(94, 374);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(122, 51);
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "保存";
            this.uiButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(403, 374);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(143, 51);
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "取消";
            this.uiButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabs1
            // 
            this.tabs1.Controls.Add(this.tabPage5);
            this.tabs1.Controls.Add(this.tabPage6);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs1.Location = new System.Drawing.Point(12, 26);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tabPage5);
            this.tabs1.Pages.Add(this.tabPage6);
            this.tabs1.SelectedIndex = 1;
            this.tabs1.Size = new System.Drawing.Size(607, 345);
            this.tabs1.Style = styleLine2;
            this.tabs1.TabIndex = 9;
            this.tabs1.Text = "tabs1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.switch1);
            this.tabPage5.Controls.Add(this.switch2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.input1);
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(0, 0);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "开启一件保存";
            // 
            // switch1
            // 
            this.switch1.Checked = global::SuperTextToolBox.Properties.Settings.Default.AutoIcon;
            this.switch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SuperTextToolBox.Properties.Settings.Default, "AutoIcon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.switch1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switch1.Location = new System.Drawing.Point(27, 227);
            this.switch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(320, 29);
            this.switch1.TabIndex = 22;
            this.switch1.Text = "关闭时最小化到任务栏右下角";
            // 
            // switch2
            // 
            this.switch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switch2.Location = new System.Drawing.Point(172, 92);
            this.switch2.MinimumSize = new System.Drawing.Size(1, 1);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(59, 29);
            this.switch2.TabIndex = 26;
            this.switch2.Text = "开启一键保存";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(533, 152);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "默认保存目录";
            // 
            // input1
            // 
            this.input1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input1.Location = new System.Drawing.Point(162, 135);
            this.input1.Margin = new System.Windows.Forms.Padding(4);
            this.input1.MinimumSize = new System.Drawing.Size(1, 16);
            this.input1.Name = "input1";
            this.input1.Padding = new System.Windows.Forms.Padding(5);
            this.input1.Size = new System.Drawing.Size(352, 51);
            this.input1.TabIndex = 23;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.linkLabel1);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.uiComboBox2);
            this.tabPage6.Controls.Add(this.uiComboBox1);
            this.tabPage6.Location = new System.Drawing.Point(3, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(601, 314);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看获取教程（每月有免费限额）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ApiKey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "AppID";
            // 
            // uiComboBox2
            // 
            settings2.AutoIcon = false;
            settings2.SettingsKey = "";
            settings2.TranslateApiKey = "";
            settings2.TranslateAppID = "";
            this.uiComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings2, "TranslateApiKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uiComboBox2.DefaultBack = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox2.Location = new System.Drawing.Point(139, 141);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(432, 50);
            this.uiComboBox2.TabIndex = 10;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SuperTextToolBox.Properties.Settings.Default, "TranslateAppID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uiComboBox1.DefaultBack = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.Location = new System.Drawing.Point(139, 64);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(432, 52);
            this.uiComboBox1.TabIndex = 9;
            this.uiComboBox1.Text = global::SuperTextToolBox.Properties.Settings.Default.TranslateAppID;
            // 
            // frmSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(659, 474);
            this.Controls.Add(this.tabs1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSet";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmSet_Load);
            this.tabs1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private AntdUI.Button uiButton1;
        private AntdUI.Button uiButton2;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        private AntdUI.Switch switch1;
        private AntdUI.Switch switch2;
        private AntdUI.Button button1;
        private System.Windows.Forms.Label label6;
        private AntdUI.Input input1;
        private AntdUI.TabPage tabPage6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AntdUI.Dropdown uiComboBox2;
        private AntdUI.Dropdown uiComboBox1;
    }
}