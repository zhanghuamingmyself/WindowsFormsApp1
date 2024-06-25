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
            this.button1 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.input1 = new AntdUI.Input();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "获取设备";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "imei";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(58, 159);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(259, 53);
            this.input1.TabIndex = 2;
            this.input1.Text = "input1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Label label1;
        private AntdUI.Input input1;
    }
}

