namespace RubikResolverWinForms
{
    partial class PhotoLoader
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ColorsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Face3PictureBox = new System.Windows.Forms.PictureBox();
            this.Face2PictureBox = new System.Windows.Forms.PictureBox();
            this.Face4PictureBox = new System.Windows.Forms.PictureBox();
            this.Face5PictureBox = new System.Windows.Forms.PictureBox();
            this.Face6PictureBox = new System.Windows.Forms.PictureBox();
            this.Face1PictureBox = new System.Windows.Forms.PictureBox();
            this.Image6Btn = new System.Windows.Forms.Button();
            this.Image3Btn = new System.Windows.Forms.Button();
            this.Image2Btn = new System.Windows.Forms.Button();
            this.Image4Btn = new System.Windows.Forms.Button();
            this.Image5Btn = new System.Windows.Forms.Button();
            this.Image1Btn = new System.Windows.Forms.Button();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ResolveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ColorsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Face3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face6PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ColorsContextMenu
            // 
            this.ColorsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.ColorsContextMenu.Name = "ColorsContextMenu";
            this.ColorsContextMenu.Size = new System.Drawing.Size(114, 136);
            // 
            // Face3PictureBox
            // 
            this.Face3PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._3;
            this.Face3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face3PictureBox.Location = new System.Drawing.Point(166, 156);
            this.Face3PictureBox.Name = "Face3PictureBox";
            this.Face3PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face3PictureBox.TabIndex = 11;
            this.Face3PictureBox.TabStop = false;
            this.Face3PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face3PictureBox_Paint);
            this.Face3PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face3PictureBox_MouseClick);
            // 
            // Face2PictureBox
            // 
            this.Face2PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._2;
            this.Face2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face2PictureBox.Location = new System.Drawing.Point(90, 156);
            this.Face2PictureBox.Name = "Face2PictureBox";
            this.Face2PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face2PictureBox.TabIndex = 10;
            this.Face2PictureBox.TabStop = false;
            this.Face2PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face2PictureBox_Paint);
            this.Face2PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face2PictureBox_MouseClick);
            // 
            // Face4PictureBox
            // 
            this.Face4PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._4;
            this.Face4PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face4PictureBox.Location = new System.Drawing.Point(242, 156);
            this.Face4PictureBox.Name = "Face4PictureBox";
            this.Face4PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face4PictureBox.TabIndex = 9;
            this.Face4PictureBox.TabStop = false;
            this.Face4PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face4PictureBox_Paint);
            this.Face4PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face4PictureBox_MouseClick);
            // 
            // Face5PictureBox
            // 
            this.Face5PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._5;
            this.Face5PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face5PictureBox.Location = new System.Drawing.Point(168, 232);
            this.Face5PictureBox.Name = "Face5PictureBox";
            this.Face5PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face5PictureBox.TabIndex = 8;
            this.Face5PictureBox.TabStop = false;
            this.Face5PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face5PictureBox_Paint);
            this.Face5PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face5PictureBox_MouseClick);
            // 
            // Face6PictureBox
            // 
            this.Face6PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._6;
            this.Face6PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face6PictureBox.Location = new System.Drawing.Point(168, 308);
            this.Face6PictureBox.Name = "Face6PictureBox";
            this.Face6PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face6PictureBox.TabIndex = 7;
            this.Face6PictureBox.TabStop = false;
            this.Face6PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face6PictureBox_Paint);
            this.Face6PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face6PictureBox_MouseClick);
            // 
            // Face1PictureBox
            // 
            this.Face1PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face1PictureBox.Location = new System.Drawing.Point(166, 80);
            this.Face1PictureBox.Name = "Face1PictureBox";
            this.Face1PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face1PictureBox.TabIndex = 6;
            this.Face1PictureBox.TabStop = false;
            this.Face1PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face1PictureBox_Paint);
            this.Face1PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Face1PictureBox_MouseClick);
            // 
            // Image6Btn
            // 
            this.Image6Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image6Btn.Location = new System.Drawing.Point(169, 384);
            this.Image6Btn.Name = "Image6Btn";
            this.Image6Btn.Size = new System.Drawing.Size(69, 62);
            this.Image6Btn.TabIndex = 5;
            this.Image6Btn.UseVisualStyleBackColor = true;
            this.Image6Btn.Click += new System.EventHandler(this.Image6Btn_Click);
            // 
            // Image3Btn
            // 
            this.Image3Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image3Btn.Location = new System.Drawing.Point(91, 88);
            this.Image3Btn.Name = "Image3Btn";
            this.Image3Btn.Size = new System.Drawing.Size(69, 62);
            this.Image3Btn.TabIndex = 4;
            this.Image3Btn.UseVisualStyleBackColor = true;
            this.Image3Btn.Click += new System.EventHandler(this.Image3Btn_Click);
            // 
            // Image2Btn
            // 
            this.Image2Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image2Btn.Location = new System.Drawing.Point(12, 156);
            this.Image2Btn.Name = "Image2Btn";
            this.Image2Btn.Size = new System.Drawing.Size(69, 62);
            this.Image2Btn.TabIndex = 3;
            this.Image2Btn.UseVisualStyleBackColor = true;
            this.Image2Btn.Click += new System.EventHandler(this.Image2Btn_Click);
            // 
            // Image4Btn
            // 
            this.Image4Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image4Btn.Location = new System.Drawing.Point(318, 156);
            this.Image4Btn.Name = "Image4Btn";
            this.Image4Btn.Size = new System.Drawing.Size(69, 62);
            this.Image4Btn.TabIndex = 2;
            this.Image4Btn.UseVisualStyleBackColor = true;
            this.Image4Btn.Click += new System.EventHandler(this.Image4Btn_Click);
            // 
            // Image5Btn
            // 
            this.Image5Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image5Btn.Location = new System.Drawing.Point(244, 240);
            this.Image5Btn.Name = "Image5Btn";
            this.Image5Btn.Size = new System.Drawing.Size(69, 62);
            this.Image5Btn.TabIndex = 1;
            this.Image5Btn.UseVisualStyleBackColor = true;
            this.Image5Btn.Click += new System.EventHandler(this.Image5Btn_Click);
            // 
            // Image1Btn
            // 
            this.Image1Btn.BackgroundImage = global::RubikResolverWinForms.Properties.Resources.open_file2;
            this.Image1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image1Btn.Location = new System.Drawing.Point(168, 12);
            this.Image1Btn.Name = "Image1Btn";
            this.Image1Btn.Size = new System.Drawing.Size(69, 62);
            this.Image1Btn.TabIndex = 0;
            this.Image1Btn.UseVisualStyleBackColor = true;
            this.Image1Btn.Click += new System.EventHandler(this.Image1Btn_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.yellow;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.orange;
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Image = global::RubikResolverWinForms.Properties.Resources.white;
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // ResolveBtn
            // 
            this.ResolveBtn.Location = new System.Drawing.Point(504, 415);
            this.ResolveBtn.Name = "ResolveBtn";
            this.ResolveBtn.Size = new System.Drawing.Size(75, 23);
            this.ResolveBtn.TabIndex = 12;
            this.ResolveBtn.Text = "Rozwiąż";
            this.ResolveBtn.UseVisualStyleBackColor = true;
            this.ResolveBtn.Click += new System.EventHandler(this.ResolveBtn_Click);
            // 
            // PhotoLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.ResolveBtn);
            this.Controls.Add(this.Face3PictureBox);
            this.Controls.Add(this.Face2PictureBox);
            this.Controls.Add(this.Face4PictureBox);
            this.Controls.Add(this.Face5PictureBox);
            this.Controls.Add(this.Face6PictureBox);
            this.Controls.Add(this.Face1PictureBox);
            this.Controls.Add(this.Image6Btn);
            this.Controls.Add(this.Image3Btn);
            this.Controls.Add(this.Image2Btn);
            this.Controls.Add(this.Image4Btn);
            this.Controls.Add(this.Image5Btn);
            this.Controls.Add(this.Image1Btn);
            this.Name = "PhotoLoader";
            this.Text = "PhotoLoader";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ColorsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Face3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face6PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Image1Btn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Image3Btn;
        private System.Windows.Forms.Button Image2Btn;
        private System.Windows.Forms.Button Image4Btn;
        private System.Windows.Forms.Button Image5Btn;
        private System.Windows.Forms.Button Image6Btn;
        private System.Windows.Forms.PictureBox Face3PictureBox;
        private System.Windows.Forms.PictureBox Face2PictureBox;
        private System.Windows.Forms.PictureBox Face4PictureBox;
        private System.Windows.Forms.PictureBox Face5PictureBox;
        private System.Windows.Forms.PictureBox Face6PictureBox;
        private System.Windows.Forms.PictureBox Face1PictureBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip ColorsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.Button ResolveBtn;
    }
}