namespace RubikResolverWinForms
{
    partial class Resolver
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
            this.NextMoveBtn = new System.Windows.Forms.Button();
            this.PrevMoveBtn = new System.Windows.Forms.Button();
            this.Face1PictureBox = new System.Windows.Forms.PictureBox();
            this.Face3PictureBox = new System.Windows.Forms.PictureBox();
            this.Face5PictureBox = new System.Windows.Forms.PictureBox();
            this.Face6PictureBox = new System.Windows.Forms.PictureBox();
            this.Face4PictureBox = new System.Windows.Forms.PictureBox();
            this.Face2PictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentMoveTxt = new System.Windows.Forms.TextBox();
            this.CountMoveTxt = new System.Windows.Forms.TextBox();
            this.CurrentMoveLbl = new System.Windows.Forms.Label();
            this.CountMoveLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Face1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face6PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextMoveBtn
            // 
            this.NextMoveBtn.Location = new System.Drawing.Point(450, 429);
            this.NextMoveBtn.Name = "NextMoveBtn";
            this.NextMoveBtn.Size = new System.Drawing.Size(75, 23);
            this.NextMoveBtn.TabIndex = 0;
            this.NextMoveBtn.Text = "dalej";
            this.NextMoveBtn.UseVisualStyleBackColor = true;
            this.NextMoveBtn.Click += new System.EventHandler(this.NextMoveBtn_Click);
            // 
            // PrevMoveBtn
            // 
            this.PrevMoveBtn.Location = new System.Drawing.Point(12, 429);
            this.PrevMoveBtn.Name = "PrevMoveBtn";
            this.PrevMoveBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevMoveBtn.TabIndex = 1;
            this.PrevMoveBtn.Text = "wstecz";
            this.PrevMoveBtn.UseVisualStyleBackColor = true;
            this.PrevMoveBtn.Click += new System.EventHandler(this.PrevMoveBtn_Click);
            // 
            // Face1PictureBox
            // 
            this.Face1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face1PictureBox.Location = new System.Drawing.Point(212, 31);
            this.Face1PictureBox.Name = "Face1PictureBox";
            this.Face1PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face1PictureBox.TabIndex = 7;
            this.Face1PictureBox.TabStop = false;
            this.Face1PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face1PictureBox_Paint);
            // 
            // Face3PictureBox
            // 
            this.Face3PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face3PictureBox.Location = new System.Drawing.Point(212, 145);
            this.Face3PictureBox.Name = "Face3PictureBox";
            this.Face3PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face3PictureBox.TabIndex = 8;
            this.Face3PictureBox.TabStop = false;
            this.Face3PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face3PictureBox_Paint);
            // 
            // Face5PictureBox
            // 
            this.Face5PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face5PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face5PictureBox.Location = new System.Drawing.Point(212, 262);
            this.Face5PictureBox.Name = "Face5PictureBox";
            this.Face5PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face5PictureBox.TabIndex = 9;
            this.Face5PictureBox.TabStop = false;
            this.Face5PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face5PictureBox_Paint);
            // 
            // Face6PictureBox
            // 
            this.Face6PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face6PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face6PictureBox.Location = new System.Drawing.Point(212, 374);
            this.Face6PictureBox.Name = "Face6PictureBox";
            this.Face6PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face6PictureBox.TabIndex = 10;
            this.Face6PictureBox.TabStop = false;
            this.Face6PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face6PictureBox_Paint);
            // 
            // Face4PictureBox
            // 
            this.Face4PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face4PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face4PictureBox.Location = new System.Drawing.Point(357, 145);
            this.Face4PictureBox.Name = "Face4PictureBox";
            this.Face4PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face4PictureBox.TabIndex = 11;
            this.Face4PictureBox.TabStop = false;
            this.Face4PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face4PictureBox_Paint);
            // 
            // Face2PictureBox
            // 
            this.Face2PictureBox.BackgroundImage = global::RubikResolverWinForms.Properties.Resources._1;
            this.Face2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face2PictureBox.Location = new System.Drawing.Point(67, 145);
            this.Face2PictureBox.Name = "Face2PictureBox";
            this.Face2PictureBox.Size = new System.Drawing.Size(70, 70);
            this.Face2PictureBox.TabIndex = 12;
            this.Face2PictureBox.TabStop = false;
            this.Face2PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Face2PictureBox_Paint);
            // 
            // CurrentMoveTxt
            // 
            this.CurrentMoveTxt.Location = new System.Drawing.Point(67, 12);
            this.CurrentMoveTxt.Name = "CurrentMoveTxt";
            this.CurrentMoveTxt.Size = new System.Drawing.Size(70, 20);
            this.CurrentMoveTxt.TabIndex = 13;
            this.CurrentMoveTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountMoveTxt
            // 
            this.CountMoveTxt.Location = new System.Drawing.Point(67, 38);
            this.CountMoveTxt.Name = "CountMoveTxt";
            this.CountMoveTxt.Size = new System.Drawing.Size(70, 20);
            this.CountMoveTxt.TabIndex = 14;
            this.CountMoveTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentMoveLbl
            // 
            this.CurrentMoveLbl.AutoSize = true;
            this.CurrentMoveLbl.Location = new System.Drawing.Point(2, 12);
            this.CurrentMoveLbl.Name = "CurrentMoveLbl";
            this.CurrentMoveLbl.Size = new System.Drawing.Size(36, 13);
            this.CurrentMoveLbl.TabIndex = 15;
            this.CurrentMoveLbl.Text = "Ruch:";
            // 
            // CountMoveLbl
            // 
            this.CountMoveLbl.AutoSize = true;
            this.CountMoveLbl.Location = new System.Drawing.Point(2, 38);
            this.CountMoveLbl.Name = "CountMoveLbl";
            this.CountMoveLbl.Size = new System.Drawing.Size(59, 13);
            this.CountMoveLbl.TabIndex = 16;
            this.CountMoveLbl.Text = "Ile ruchów:";
            // 
            // Resolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 482);
            this.Controls.Add(this.CountMoveLbl);
            this.Controls.Add(this.CurrentMoveLbl);
            this.Controls.Add(this.CountMoveTxt);
            this.Controls.Add(this.CurrentMoveTxt);
            this.Controls.Add(this.Face2PictureBox);
            this.Controls.Add(this.Face4PictureBox);
            this.Controls.Add(this.Face6PictureBox);
            this.Controls.Add(this.Face5PictureBox);
            this.Controls.Add(this.Face3PictureBox);
            this.Controls.Add(this.Face1PictureBox);
            this.Controls.Add(this.PrevMoveBtn);
            this.Controls.Add(this.NextMoveBtn);
            this.Name = "Resolver";
            this.Text = "Resolver";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Resolver_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Face1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face6PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextMoveBtn;
        private System.Windows.Forms.Button PrevMoveBtn;
        private System.Windows.Forms.PictureBox Face1PictureBox;
        private System.Windows.Forms.PictureBox Face3PictureBox;
        private System.Windows.Forms.PictureBox Face5PictureBox;
        private System.Windows.Forms.PictureBox Face6PictureBox;
        private System.Windows.Forms.PictureBox Face4PictureBox;
        private System.Windows.Forms.PictureBox Face2PictureBox;
        private System.Windows.Forms.TextBox CurrentMoveTxt;
        private System.Windows.Forms.TextBox CountMoveTxt;
        private System.Windows.Forms.Label CurrentMoveLbl;
        private System.Windows.Forms.Label CountMoveLbl;
    }
}