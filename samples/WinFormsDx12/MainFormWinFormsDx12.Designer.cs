namespace TerraFX.Samples.WinForms
{
    partial class MainFormWinFormsDX12
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.TextureBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 519);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.Location = new System.Drawing.Point(4, 0);
            this.MainSplitter.Name = "MainSplitter";
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.MainSplitter.Size = new System.Drawing.Size(929, 519);
            this.MainSplitter.SplitterDistance = 308;
            this.MainSplitter.SplitterWidth = 5;
            this.MainSplitter.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12563F));
            this.tableLayoutPanel1.Controls.Add(this.ColorBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextureBtn, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ColorBtn
            // 
            this.ColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBtn.Location = new System.Drawing.Point(80, 106);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(147, 97);
            this.ColorBtn.TabIndex = 0;
            this.ColorBtn.Text = "Color";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // TextureBtn
            // 
            this.TextureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextureBtn.Location = new System.Drawing.Point(80, 312);
            this.TextureBtn.Name = "TextureBtn";
            this.TextureBtn.Size = new System.Drawing.Size(147, 97);
            this.TextureBtn.TabIndex = 1;
            this.TextureBtn.Text = "Texture";
            this.TextureBtn.UseVisualStyleBackColor = true;
            this.TextureBtn.Click += new System.EventHandler(this.TextureBtn_Click);
            // 
            // MainFormWinFormsDx12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.MainSplitter);
            this.Controls.Add(this.splitter1);
            this.Name = "MainFormWinFormsDx12";
            this.Text = "WinFormsDx12";
            this.MainSplitter.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Button TextureBtn;
    }
}

