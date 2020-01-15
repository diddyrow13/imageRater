namespace imageRater
{
    partial class imageRaterMain
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
            this.imageRaterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.centerPictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.leftImageLabel = new System.Windows.Forms.Label();
            this.centerImageLabel = new System.Windows.Forms.Label();
            this.rightImageLabel = new System.Windows.Forms.Label();
            this.rightRate2 = new System.Windows.Forms.RadioButton();
            this.rightRate1 = new System.Windows.Forms.RadioButton();
            this.rightRate0 = new System.Windows.Forms.RadioButton();
            this.ratePicturesButton = new System.Windows.Forms.Button();
            this.rightGroupBox = new System.Windows.Forms.GroupBox();
            this.centerGroupBox = new System.Windows.Forms.GroupBox();
            this.centerRate1 = new System.Windows.Forms.RadioButton();
            this.centerRate0 = new System.Windows.Forms.RadioButton();
            this.centerRate2 = new System.Windows.Forms.RadioButton();
            this.leftGroupBox = new System.Windows.Forms.GroupBox();
            this.leftRate1 = new System.Windows.Forms.RadioButton();
            this.leftRate0 = new System.Windows.Forms.RadioButton();
            this.leftRate2 = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageRaterMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.rightGroupBox.SuspendLayout();
            this.centerGroupBox.SuspendLayout();
            this.leftGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageRaterMenuStrip
            // 
            this.imageRaterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.imageRaterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.imageRaterMenuStrip.Name = "imageRaterMenuStrip";
            this.imageRaterMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.imageRaterMenuStrip.TabIndex = 0;
            this.imageRaterMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFolderToolStripMenuItem,
            this.chooseFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chooseFolderToolStripMenuItem
            // 
            this.chooseFolderToolStripMenuItem.Name = "chooseFolderToolStripMenuItem";
            this.chooseFolderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.chooseFolderToolStripMenuItem.Text = "Choose Folder";
            this.chooseFolderToolStripMenuItem.Click += new System.EventHandler(this.chooseFolderToolStripMenuItem_Click);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPictureBox.Location = new System.Drawing.Point(12, 103);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(320, 320);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox.TabIndex = 1;
            this.leftPictureBox.TabStop = false;
            // 
            // centerPictureBox
            // 
            this.centerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerPictureBox.Location = new System.Drawing.Point(434, 103);
            this.centerPictureBox.Name = "centerPictureBox";
            this.centerPictureBox.Size = new System.Drawing.Size(320, 320);
            this.centerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.centerPictureBox.TabIndex = 2;
            this.centerPictureBox.TabStop = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPictureBox.Location = new System.Drawing.Point(861, 103);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(320, 320);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox.TabIndex = 3;
            this.rightPictureBox.TabStop = false;
            // 
            // leftImageLabel
            // 
            this.leftImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftImageLabel.Location = new System.Drawing.Point(12, 50);
            this.leftImageLabel.Name = "leftImageLabel";
            this.leftImageLabel.Size = new System.Drawing.Size(320, 46);
            this.leftImageLabel.TabIndex = 4;
            this.leftImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerImageLabel
            // 
            this.centerImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.centerImageLabel.Location = new System.Drawing.Point(434, 50);
            this.centerImageLabel.Name = "centerImageLabel";
            this.centerImageLabel.Size = new System.Drawing.Size(320, 46);
            this.centerImageLabel.TabIndex = 5;
            this.centerImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightImageLabel
            // 
            this.rightImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightImageLabel.Location = new System.Drawing.Point(861, 50);
            this.rightImageLabel.Name = "rightImageLabel";
            this.rightImageLabel.Size = new System.Drawing.Size(320, 46);
            this.rightImageLabel.TabIndex = 6;
            this.rightImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightRate2
            // 
            this.rightRate2.AutoSize = true;
            this.rightRate2.Location = new System.Drawing.Point(95, 19);
            this.rightRate2.Name = "rightRate2";
            this.rightRate2.Size = new System.Drawing.Size(31, 17);
            this.rightRate2.TabIndex = 16;
            this.rightRate2.TabStop = true;
            this.rightRate2.Text = "2";
            this.rightRate2.UseVisualStyleBackColor = true;
            // 
            // rightRate1
            // 
            this.rightRate1.AutoSize = true;
            this.rightRate1.Location = new System.Drawing.Point(58, 19);
            this.rightRate1.Name = "rightRate1";
            this.rightRate1.Size = new System.Drawing.Size(31, 17);
            this.rightRate1.TabIndex = 15;
            this.rightRate1.TabStop = true;
            this.rightRate1.Text = "1";
            this.rightRate1.UseVisualStyleBackColor = true;
            // 
            // rightRate0
            // 
            this.rightRate0.AutoSize = true;
            this.rightRate0.Checked = true;
            this.rightRate0.Location = new System.Drawing.Point(21, 19);
            this.rightRate0.Name = "rightRate0";
            this.rightRate0.Size = new System.Drawing.Size(31, 17);
            this.rightRate0.TabIndex = 14;
            this.rightRate0.TabStop = true;
            this.rightRate0.Text = "0";
            this.rightRate0.UseVisualStyleBackColor = true;
            // 
            // ratePicturesButton
            // 
            this.ratePicturesButton.Location = new System.Drawing.Point(558, 513);
            this.ratePicturesButton.Name = "ratePicturesButton";
            this.ratePicturesButton.Size = new System.Drawing.Size(75, 23);
            this.ratePicturesButton.TabIndex = 4;
            this.ratePicturesButton.Text = "Rate";
            this.ratePicturesButton.UseVisualStyleBackColor = true;
            this.ratePicturesButton.Click += new System.EventHandler(this.ratePicturesButton_Click);
            // 
            // rightGroupBox
            // 
            this.rightGroupBox.Controls.Add(this.rightRate1);
            this.rightGroupBox.Controls.Add(this.rightRate0);
            this.rightGroupBox.Controls.Add(this.rightRate2);
            this.rightGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightGroupBox.Location = new System.Drawing.Point(961, 429);
            this.rightGroupBox.Name = "rightGroupBox";
            this.rightGroupBox.Size = new System.Drawing.Size(132, 51);
            this.rightGroupBox.TabIndex = 3;
            this.rightGroupBox.TabStop = false;
            // 
            // centerGroupBox
            // 
            this.centerGroupBox.Controls.Add(this.centerRate1);
            this.centerGroupBox.Controls.Add(this.centerRate0);
            this.centerGroupBox.Controls.Add(this.centerRate2);
            this.centerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerGroupBox.Location = new System.Drawing.Point(520, 429);
            this.centerGroupBox.Name = "centerGroupBox";
            this.centerGroupBox.Size = new System.Drawing.Size(132, 51);
            this.centerGroupBox.TabIndex = 2;
            this.centerGroupBox.TabStop = false;
            // 
            // centerRate1
            // 
            this.centerRate1.AutoSize = true;
            this.centerRate1.Location = new System.Drawing.Point(58, 19);
            this.centerRate1.Name = "centerRate1";
            this.centerRate1.Size = new System.Drawing.Size(31, 17);
            this.centerRate1.TabIndex = 15;
            this.centerRate1.TabStop = true;
            this.centerRate1.Text = "1";
            this.centerRate1.UseVisualStyleBackColor = true;
            // 
            // centerRate0
            // 
            this.centerRate0.AutoSize = true;
            this.centerRate0.Checked = true;
            this.centerRate0.Location = new System.Drawing.Point(21, 19);
            this.centerRate0.Name = "centerRate0";
            this.centerRate0.Size = new System.Drawing.Size(31, 17);
            this.centerRate0.TabIndex = 14;
            this.centerRate0.TabStop = true;
            this.centerRate0.Text = "0";
            this.centerRate0.UseVisualStyleBackColor = true;
            // 
            // centerRate2
            // 
            this.centerRate2.AutoSize = true;
            this.centerRate2.Location = new System.Drawing.Point(95, 19);
            this.centerRate2.Name = "centerRate2";
            this.centerRate2.Size = new System.Drawing.Size(31, 17);
            this.centerRate2.TabIndex = 16;
            this.centerRate2.TabStop = true;
            this.centerRate2.Text = "2";
            this.centerRate2.UseVisualStyleBackColor = true;
            // 
            // leftGroupBox
            // 
            this.leftGroupBox.Controls.Add(this.leftRate1);
            this.leftGroupBox.Controls.Add(this.leftRate0);
            this.leftGroupBox.Controls.Add(this.leftRate2);
            this.leftGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftGroupBox.Location = new System.Drawing.Point(96, 429);
            this.leftGroupBox.Name = "leftGroupBox";
            this.leftGroupBox.Size = new System.Drawing.Size(132, 51);
            this.leftGroupBox.TabIndex = 1;
            this.leftGroupBox.TabStop = false;
            // 
            // leftRate1
            // 
            this.leftRate1.AutoSize = true;
            this.leftRate1.Location = new System.Drawing.Point(58, 19);
            this.leftRate1.Name = "leftRate1";
            this.leftRate1.Size = new System.Drawing.Size(31, 17);
            this.leftRate1.TabIndex = 15;
            this.leftRate1.TabStop = true;
            this.leftRate1.Text = "1";
            this.leftRate1.UseVisualStyleBackColor = true;
            // 
            // leftRate0
            // 
            this.leftRate0.AutoSize = true;
            this.leftRate0.Checked = true;
            this.leftRate0.Location = new System.Drawing.Point(21, 19);
            this.leftRate0.Name = "leftRate0";
            this.leftRate0.Size = new System.Drawing.Size(31, 17);
            this.leftRate0.TabIndex = 14;
            this.leftRate0.TabStop = true;
            this.leftRate0.Text = "0";
            this.leftRate0.UseVisualStyleBackColor = true;
            // 
            // leftRate2
            // 
            this.leftRate2.AutoSize = true;
            this.leftRate2.Location = new System.Drawing.Point(95, 19);
            this.leftRate2.Name = "leftRate2";
            this.leftRate2.Size = new System.Drawing.Size(31, 17);
            this.leftRate2.TabIndex = 16;
            this.leftRate2.TabStop = true;
            this.leftRate2.Text = "2";
            this.leftRate2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // chooseFileToolStripMenuItem
            // 
            this.chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            this.chooseFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chooseFileToolStripMenuItem.Text = "Choose File";
            this.chooseFileToolStripMenuItem.Click += new System.EventHandler(this.chooseFileToolStripMenuItem_Click);
            // 
            // imageRaterMain
            // 
            this.AcceptButton = this.ratePicturesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.leftGroupBox);
            this.Controls.Add(this.centerGroupBox);
            this.Controls.Add(this.rightGroupBox);
            this.Controls.Add(this.ratePicturesButton);
            this.Controls.Add(this.rightImageLabel);
            this.Controls.Add(this.centerImageLabel);
            this.Controls.Add(this.leftImageLabel);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.centerPictureBox);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.imageRaterMenuStrip);
            this.MainMenuStrip = this.imageRaterMenuStrip;
            this.Name = "imageRaterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Rater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.imageRaterMain_FormClosing);
            this.imageRaterMenuStrip.ResumeLayout(false);
            this.imageRaterMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.rightGroupBox.ResumeLayout(false);
            this.rightGroupBox.PerformLayout();
            this.centerGroupBox.ResumeLayout(false);
            this.centerGroupBox.PerformLayout();
            this.leftGroupBox.ResumeLayout(false);
            this.leftGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip imageRaterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFolderToolStripMenuItem;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox centerPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.Label leftImageLabel;
        private System.Windows.Forms.Label centerImageLabel;
        private System.Windows.Forms.Label rightImageLabel;
        private System.Windows.Forms.RadioButton rightRate2;
        private System.Windows.Forms.RadioButton rightRate1;
        private System.Windows.Forms.RadioButton rightRate0;
        private System.Windows.Forms.Button ratePicturesButton;
        private System.Windows.Forms.GroupBox rightGroupBox;
        private System.Windows.Forms.GroupBox centerGroupBox;
        private System.Windows.Forms.RadioButton centerRate1;
        private System.Windows.Forms.RadioButton centerRate0;
        private System.Windows.Forms.RadioButton centerRate2;
        private System.Windows.Forms.GroupBox leftGroupBox;
        private System.Windows.Forms.RadioButton leftRate1;
        private System.Windows.Forms.RadioButton leftRate0;
        private System.Windows.Forms.RadioButton leftRate2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem chooseFileToolStripMenuItem;
    }
}

