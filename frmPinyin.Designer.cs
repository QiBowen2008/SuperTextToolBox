namespace SuperWenZiToolBox
{
    partial class frmPinyin
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "转换结果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "原文";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox1.Size = new System.Drawing.Size(294, 111);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(28, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(294, 111);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(508, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(342, 76);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton1.Size = new System.Drawing.Size(146, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Purple;
            this.uiButton1.TabIndex = 14;
            this.uiButton1.Text = "转换";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(342, 133);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton2.Size = new System.Drawing.Size(146, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.Purple;
            this.uiButton2.TabIndex = 15;
            this.uiButton2.Text = "打开文本文档";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.button4_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(342, 194);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiButton3.Size = new System.Drawing.Size(146, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.Purple;
            this.uiButton3.TabIndex = 16;
            this.uiButton3.Text = "保存结果";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPinyin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(508, 405);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.Name = "frmPinyin";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Purple;
            this.Text = "文字转拼音";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 480, 332);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
    }
}