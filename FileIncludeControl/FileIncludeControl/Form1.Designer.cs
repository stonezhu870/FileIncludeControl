namespace FileIncludeControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInclude = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpDir = new System.Windows.Forms.TextBox();
            this.gpInclude = new System.Windows.Forms.GroupBox();
            this.gpGroup = new System.Windows.Forms.GroupBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.txtFileB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpInclude.SuspendLayout();
            this.gpGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInclude
            // 
            this.btnInclude.Location = new System.Drawing.Point(364, 142);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(98, 37);
            this.btnInclude.TabIndex = 0;
            this.btnInclude.Text = "添加到项目中";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件列表：";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFileName.Location = new System.Drawing.Point(120, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(342, 23);
            this.txtFileName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "排除文件：";
            // 
            // txtExpFile
            // 
            this.txtExpFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExpFile.Location = new System.Drawing.Point(120, 69);
            this.txtExpFile.Name = "txtExpFile";
            this.txtExpFile.Size = new System.Drawing.Size(342, 23);
            this.txtExpFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "排除目录：";
            // 
            // txtExpDir
            // 
            this.txtExpDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExpDir.Location = new System.Drawing.Point(120, 108);
            this.txtExpDir.Name = "txtExpDir";
            this.txtExpDir.Size = new System.Drawing.Size(342, 23);
            this.txtExpDir.TabIndex = 2;
            // 
            // gpInclude
            // 
            this.gpInclude.Controls.Add(this.txtFileName);
            this.gpInclude.Controls.Add(this.txtExpDir);
            this.gpInclude.Controls.Add(this.btnInclude);
            this.gpInclude.Controls.Add(this.label3);
            this.gpInclude.Controls.Add(this.label1);
            this.gpInclude.Controls.Add(this.txtExpFile);
            this.gpInclude.Controls.Add(this.label2);
            this.gpInclude.Location = new System.Drawing.Point(12, 29);
            this.gpInclude.Name = "gpInclude";
            this.gpInclude.Size = new System.Drawing.Size(493, 192);
            this.gpInclude.TabIndex = 3;
            this.gpInclude.TabStop = false;
            this.gpInclude.Text = "包含项目文件";
            // 
            // gpGroup
            // 
            this.gpGroup.Controls.Add(this.btnGroup);
            this.gpGroup.Controls.Add(this.txtFileB);
            this.gpGroup.Controls.Add(this.label6);
            this.gpGroup.Controls.Add(this.label5);
            this.gpGroup.Controls.Add(this.txtFileA);
            this.gpGroup.Controls.Add(this.label4);
            this.gpGroup.Location = new System.Drawing.Point(12, 223);
            this.gpGroup.Name = "gpGroup";
            this.gpGroup.Size = new System.Drawing.Size(493, 185);
            this.gpGroup.TabIndex = 4;
            this.gpGroup.TabStop = false;
            this.gpGroup.Text = "文件分组";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(364, 131);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(98, 37);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "文件分组";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // txtFileB
            // 
            this.txtFileB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFileB.Location = new System.Drawing.Point(120, 73);
            this.txtFileB.Name = "txtFileB";
            this.txtFileB.Size = new System.Drawing.Size(342, 23);
            this.txtFileB.TabIndex = 2;
            this.txtFileB.Text = "[FILE].gen.cs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(51, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "根文件：将【A特征文件】作为根文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(30, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "文件特征B：";
            // 
            // txtFileA
            // 
            this.txtFileA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFileA.Location = new System.Drawing.Point(120, 34);
            this.txtFileA.Name = "txtFileA";
            this.txtFileA.Size = new System.Drawing.Size(342, 23);
            this.txtFileA.TabIndex = 2;
            this.txtFileA.Text = "[FILE].cs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "文件特征A：";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(511, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(248, 396);
            this.txtLog.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 420);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.gpGroup);
            this.Controls.Add(this.gpInclude);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vs File Helper";
            this.gpInclude.ResumeLayout(false);
            this.gpInclude.PerformLayout();
            this.gpGroup.ResumeLayout(false);
            this.gpGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpDir;
        private System.Windows.Forms.GroupBox gpInclude;
        private System.Windows.Forms.GroupBox gpGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileA;
        private System.Windows.Forms.TextBox txtFileB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

