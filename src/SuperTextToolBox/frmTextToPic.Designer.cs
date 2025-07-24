namespace SuperTextToolBox 
{
    partial class frmTextToPic
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
            this.textBox1 = new AntdUI.Input();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiIntegerUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.uiIntegerUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiComboBox1 = new AntdUI.Dropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.uiIntegerUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.uiIntegerUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.uiButton1 = new AntdUI.Button();
            this.uiButton2 = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 292);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "等待处理的文本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "                ";
            // 
            // uiIntegerUpDown1
            // 
            this.uiIntegerUpDown1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown1.Location = new System.Drawing.Point(595, 135);
            this.uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiIntegerUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(133, 0);
            this.uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.Size = new System.Drawing.Size(133, 30);
            this.uiIntegerUpDown1.TabIndex = 10;
            this.uiIntegerUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.uiIntegerUpDown1.ValueChanged += new System.EventHandler(this.uiIntegerUpDown1_ValueChanged);
            // 
            // uiIntegerUpDown2
            // 
            this.uiIntegerUpDown2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown2.Location = new System.Drawing.Point(738, 133);
            this.uiIntegerUpDown2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiIntegerUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiIntegerUpDown2.MinimumSize = new System.Drawing.Size(133, 0);
            this.uiIntegerUpDown2.Name = "uiIntegerUpDown2";
            this.uiIntegerUpDown2.Size = new System.Drawing.Size(133, 30);
            this.uiIntegerUpDown2.TabIndex = 11;
            this.uiIntegerUpDown2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(504, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "图片比例";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(504, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "字体大小";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DefaultBack = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.Location = new System.Drawing.Point(595, 230);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(84, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.uiComboBox1.ShowArrow = true;
            this.uiComboBox1.Size = new System.Drawing.Size(277, 39);
            this.uiComboBox1.TabIndex = 15;
            this.uiComboBox1.Text = "Arial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(504, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "字体";
            // 
            // uiIntegerUpDown3
            // 
            this.uiIntegerUpDown3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown3.Location = new System.Drawing.Point(595, 291);
            this.uiIntegerUpDown3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiIntegerUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiIntegerUpDown3.MinimumSize = new System.Drawing.Size(133, 0);
            this.uiIntegerUpDown3.Name = "uiIntegerUpDown3";
            this.uiIntegerUpDown3.Size = new System.Drawing.Size(133, 30);
            this.uiIntegerUpDown3.TabIndex = 11;
            this.uiIntegerUpDown3.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.uiIntegerUpDown3.ValueChanged += new System.EventHandler(this.uiIntegerUpDown3_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(504, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "每张字数";
            // 
            // uiIntegerUpDown4
            // 
            this.uiIntegerUpDown4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown4.Location = new System.Drawing.Point(595, 188);
            this.uiIntegerUpDown4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiIntegerUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiIntegerUpDown4.MinimumSize = new System.Drawing.Size(133, 0);
            this.uiIntegerUpDown4.Name = "uiIntegerUpDown4";
            this.uiIntegerUpDown4.Size = new System.Drawing.Size(133, 30);
            this.uiIntegerUpDown4.TabIndex = 12;
            this.uiIntegerUpDown4.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(171, 42);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(127, 43);
            this.uiButton1.TabIndex = 18;
            this.uiButton1.Text = "选择txt文件";
            this.uiButton1.Click += new System.EventHandler(this.ChooseNovel);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(330, 42);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(127, 43);
            this.uiButton2.TabIndex = 19;
            this.uiButton2.Text = "转换图片";
            this.uiButton2.Click += new System.EventHandler(this.ConvertTextToImages);
            // 
            // frmTextToPic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(905, 437);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiIntegerUpDown4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiIntegerUpDown3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiIntegerUpDown2);
            this.Controls.Add(this.uiIntegerUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTextToPic";
            this.Text = "文字转图片";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIntegerUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AntdUI.Input textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System .Windows .Forms .NumericUpDown uiIntegerUpDown1;
        private System .Windows .Forms .NumericUpDown uiIntegerUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AntdUI.Dropdown uiComboBox1;
        private System.Windows.Forms.Label label5;
        private System .Windows .Forms .NumericUpDown uiIntegerUpDown3;
        private System.Windows.Forms.Label label6;
        private System .Windows .Forms .NumericUpDown uiIntegerUpDown4;
        private AntdUI.Button uiButton1;
        private AntdUI.Button uiButton2;
    }
}