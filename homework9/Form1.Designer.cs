namespace Example9_2
{
    partial class Form_crawler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_URL = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.button_Crawl = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_URL);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // listBox_URL
            // 
            this.listBox_URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_URL.Font = new System.Drawing.Font("宋体", 12F);
            this.listBox_URL.FormattingEnabled = true;
            this.listBox_URL.ItemHeight = 20;
            this.listBox_URL.Location = new System.Drawing.Point(0, 128);
            this.listBox_URL.Name = "listBox_URL";
            this.listBox_URL.Size = new System.Drawing.Size(800, 322);
            this.listBox_URL.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLimit);
            this.panel2.Controls.Add(this.labelLimit);
            this.panel2.Controls.Add(this.button_Crawl);
            this.panel2.Controls.Add(this.txtURL);
            this.panel2.Controls.Add(this.labelURL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 128);
            this.panel2.TabIndex = 1;
            // 
            // txtLimit
            // 
            this.txtLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLimit.Font = new System.Drawing.Font("宋体", 12F);
            this.txtLimit.Location = new System.Drawing.Point(120, 70);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(500, 30);
            this.txtLimit.TabIndex = 4;
            this.txtLimit.Text = "10";
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLimit.Location = new System.Drawing.Point(25, 75);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(69, 20);
            this.labelLimit.TabIndex = 3;
            this.labelLimit.Text = "Limit:";
            // 
            // button_Crawl
            // 
            this.button_Crawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Crawl.Font = new System.Drawing.Font("宋体", 12F);
            this.button_Crawl.Location = new System.Drawing.Point(650, 40);
            this.button_Crawl.Name = "button_Crawl";
            this.button_Crawl.Size = new System.Drawing.Size(125, 41);
            this.button_Crawl.TabIndex = 2;
            this.button_Crawl.Text = "Crawl";
            this.button_Crawl.UseVisualStyleBackColor = true;
            this.button_Crawl.Click += new System.EventHandler(this.button_Crawl_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Font = new System.Drawing.Font("宋体", 12F);
            this.txtURL.Location = new System.Drawing.Point(120, 20);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(500, 30);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("宋体", 12F);
            this.labelURL.Location = new System.Drawing.Point(25, 25);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(49, 20);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // Form_crawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_crawler";
            this.Text = "Crawler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_URL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button button_Crawl;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label labelLimit;
    }
}
