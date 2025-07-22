namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dropdown1 = new AntdUI.Dropdown();
            this.input1 = new AntdUI.Input();
            this.SuspendLayout();
            // 
            // dropdown1
            // 
            this.dropdown1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.dropdown1.Location = new System.Drawing.Point(128, 60);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.ShowArrow = true;
            this.dropdown1.Size = new System.Drawing.Size(356, 50);
            this.dropdown1.TabIndex = 0;
            this.dropdown1.Text = "dropdown1";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(128, 140);
            this.input1.Name = "input1";
            this.input1.SelectionStart = 6;
            this.input1.Size = new System.Drawing.Size(343, 95);
            this.input1.TabIndex = 1;
            this.input1.Text = "input1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.dropdown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Dropdown dropdown1;
        private AntdUI.Input input1;
    }
}

