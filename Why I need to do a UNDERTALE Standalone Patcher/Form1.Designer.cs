namespace UTCSXPatcherGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.scriptFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveOutputButton = new System.Windows.Forms.Button();
            this.outputFileSelect = new System.Windows.Forms.Button();
            this.outputFileTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadInputButton = new System.Windows.Forms.Button();
            this.inputFileSelect = new System.Windows.Forms.Button();
            this.inputFileTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.runScriptButton = new System.Windows.Forms.Button();
            this.scriptFileSelect = new System.Windows.Forms.Button();
            this.scriptFileTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.DefaultExt = "win";
            this.inputFileDialog.FileName = "openFileDialog1";
            this.inputFileDialog.Filter = "Data Files|*.win;*.unx;*.ios;audiogroup*.dat";
            this.inputFileDialog.SupportMultiDottedExtensions = true;
            this.inputFileDialog.Title = "Select input file...";
            // 
            // outputFileDialog
            // 
            this.outputFileDialog.DefaultExt = "win";
            this.outputFileDialog.Filter = "Game Maker Data|*.win;*.unx;*.ios;audiogroup*.dat";
            this.outputFileDialog.SupportMultiDottedExtensions = true;
            this.outputFileDialog.Title = "Select output file...";
            // 
            // scriptFileDialog
            // 
            this.scriptFileDialog.FileName = "openFileDialog2";
            this.scriptFileDialog.Filter = "C# Script|*.csx";
            this.scriptFileDialog.SupportMultiDottedExtensions = true;
            this.scriptFileDialog.Title = "Select script file...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "data.win\'s";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveOutputButton);
            this.groupBox3.Controls.Add(this.outputFileSelect);
            this.groupBox3.Controls.Add(this.outputFileTB);
            this.groupBox3.Location = new System.Drawing.Point(6, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 67);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "output file";
            // 
            // saveOutputButton
            // 
            this.saveOutputButton.Location = new System.Drawing.Point(103, 43);
            this.saveOutputButton.Name = "saveOutputButton";
            this.saveOutputButton.Size = new System.Drawing.Size(43, 23);
            this.saveOutputButton.TabIndex = 2;
            this.saveOutputButton.Text = "save";
            this.saveOutputButton.UseVisualStyleBackColor = true;
            this.saveOutputButton.Click += new System.EventHandler(this.saveOutputButton_Click);
            // 
            // outputFileSelect
            // 
            this.outputFileSelect.Location = new System.Drawing.Point(223, 18);
            this.outputFileSelect.Name = "outputFileSelect";
            this.outputFileSelect.Size = new System.Drawing.Size(37, 23);
            this.outputFileSelect.TabIndex = 1;
            this.outputFileSelect.Text = "...";
            this.outputFileSelect.UseVisualStyleBackColor = true;
            this.outputFileSelect.Click += new System.EventHandler(this.outputFileSelect_Click);
            // 
            // outputFileTB
            // 
            this.outputFileTB.Location = new System.Drawing.Point(7, 21);
            this.outputFileTB.Name = "outputFileTB";
            this.outputFileTB.Size = new System.Drawing.Size(209, 21);
            this.outputFileTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadInputButton);
            this.groupBox2.Controls.Add(this.inputFileSelect);
            this.groupBox2.Controls.Add(this.inputFileTB);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "input file";
            // 
            // loadInputButton
            // 
            this.loadInputButton.Location = new System.Drawing.Point(102, 46);
            this.loadInputButton.Name = "loadInputButton";
            this.loadInputButton.Size = new System.Drawing.Size(43, 23);
            this.loadInputButton.TabIndex = 2;
            this.loadInputButton.Text = "load";
            this.loadInputButton.UseVisualStyleBackColor = true;
            this.loadInputButton.Click += new System.EventHandler(this.loadInputButton_Click);
            // 
            // inputFileSelect
            // 
            this.inputFileSelect.Location = new System.Drawing.Point(223, 18);
            this.inputFileSelect.Name = "inputFileSelect";
            this.inputFileSelect.Size = new System.Drawing.Size(37, 23);
            this.inputFileSelect.TabIndex = 1;
            this.inputFileSelect.Text = "...";
            this.inputFileSelect.UseVisualStyleBackColor = true;
            this.inputFileSelect.Click += new System.EventHandler(this.inputFileSelect_Click);
            // 
            // inputFileTB
            // 
            this.inputFileTB.Location = new System.Drawing.Point(7, 21);
            this.inputFileTB.Name = "inputFileTB";
            this.inputFileTB.Size = new System.Drawing.Size(209, 21);
            this.inputFileTB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.runScriptButton);
            this.groupBox4.Controls.Add(this.scriptFileSelect);
            this.groupBox4.Controls.Add(this.scriptFileTB);
            this.groupBox4.Location = new System.Drawing.Point(299, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 159);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "script file";
            // 
            // runScriptButton
            // 
            this.runScriptButton.Location = new System.Drawing.Point(96, 111);
            this.runScriptButton.Name = "runScriptButton";
            this.runScriptButton.Size = new System.Drawing.Size(75, 23);
            this.runScriptButton.TabIndex = 4;
            this.runScriptButton.Text = "run";
            this.runScriptButton.UseVisualStyleBackColor = true;
            this.runScriptButton.Click += new System.EventHandler(this.runScriptButton_ClickAsync);
            // 
            // scriptFileSelect
            // 
            this.scriptFileSelect.Location = new System.Drawing.Point(226, 67);
            this.scriptFileSelect.Name = "scriptFileSelect";
            this.scriptFileSelect.Size = new System.Drawing.Size(37, 23);
            this.scriptFileSelect.TabIndex = 3;
            this.scriptFileSelect.Text = "...";
            this.scriptFileSelect.UseVisualStyleBackColor = true;
            this.scriptFileSelect.Click += new System.EventHandler(this.scriptFileSelect_Click);
            // 
            // scriptFileTB
            // 
            this.scriptFileTB.Location = new System.Drawing.Point(10, 70);
            this.scriptFileTB.Name = "scriptFileTB";
            this.scriptFileTB.Size = new System.Drawing.Size(209, 21);
            this.scriptFileTB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 16);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiting works";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(583, 234);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "USP GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.SaveFileDialog outputFileDialog;
        private System.Windows.Forms.OpenFileDialog scriptFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button outputFileSelect;
        private System.Windows.Forms.TextBox outputFileTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputFileSelect;
        private System.Windows.Forms.TextBox inputFileTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button scriptFileSelect;
        private System.Windows.Forms.TextBox scriptFileTB;
        private System.Windows.Forms.Button saveOutputButton;
        private System.Windows.Forms.Button loadInputButton;
        private System.Windows.Forms.Button runScriptButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

