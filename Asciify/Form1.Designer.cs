namespace Asciify
{
    partial class Form1
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
            this.asciiPicTextBox = new System.Windows.Forms.TextBox();
            this.ogPicture = new System.Windows.Forms.PictureBox();
            this.grayPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.greyScaleBtn = new System.Windows.Forms.Button();
            this.kernalSize = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.kernalWidth = new System.Windows.Forms.NumericUpDown();
            this.kernalHeight = new System.Windows.Forms.NumericUpDown();
            this.asciiPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kernalWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernalHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // asciiPicTextBox
            // 
            this.asciiPicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asciiPicTextBox.Font = new System.Drawing.Font("Consolas", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiPicTextBox.Location = new System.Drawing.Point(803, 43);
            this.asciiPicTextBox.Multiline = true;
            this.asciiPicTextBox.Name = "asciiPicTextBox";
            this.asciiPicTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asciiPicTextBox.Size = new System.Drawing.Size(1037, 895);
            this.asciiPicTextBox.TabIndex = 0;
            this.asciiPicTextBox.WordWrap = false;
            // 
            // ogPicture
            // 
            this.ogPicture.Location = new System.Drawing.Point(24, 43);
            this.ogPicture.Name = "ogPicture";
            this.ogPicture.Size = new System.Drawing.Size(347, 439);
            this.ogPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ogPicture.TabIndex = 1;
            this.ogPicture.TabStop = false;
            // 
            // grayPicture
            // 
            this.grayPicture.Location = new System.Drawing.Point(403, 43);
            this.grayPicture.Name = "grayPicture";
            this.grayPicture.Size = new System.Drawing.Size(365, 439);
            this.grayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayPicture.TabIndex = 2;
            this.grayPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1852, 40);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // greyScaleBtn
            // 
            this.greyScaleBtn.Location = new System.Drawing.Point(197, 759);
            this.greyScaleBtn.Name = "greyScaleBtn";
            this.greyScaleBtn.Size = new System.Drawing.Size(220, 58);
            this.greyScaleBtn.TabIndex = 12;
            this.greyScaleBtn.Text = "Greyscale";
            this.greyScaleBtn.UseVisualStyleBackColor = true;
            this.greyScaleBtn.Click += new System.EventHandler(this.greyScaleBtn_Click);
            // 
            // kernalSize
            // 
            this.kernalSize.AutoSize = true;
            this.kernalSize.Location = new System.Drawing.Point(249, 534);
            this.kernalSize.Name = "kernalSize";
            this.kernalSize.Size = new System.Drawing.Size(122, 25);
            this.kernalSize.TabIndex = 13;
            this.kernalSize.Text = "Kernal Size";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(192, 605);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(62, 25);
            this.width.TabIndex = 16;
            this.width.Text = "width";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(346, 605);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(71, 25);
            this.height.TabIndex = 17;
            this.height.Text = "height";
            // 
            // kernalWidth
            // 
            this.kernalWidth.Location = new System.Drawing.Point(168, 642);
            this.kernalWidth.Name = "kernalWidth";
            this.kernalWidth.Size = new System.Drawing.Size(120, 31);
            this.kernalWidth.TabIndex = 18;
            this.kernalWidth.ValueChanged += new System.EventHandler(this.kernalWidth_ValueChanged);
            // 
            // kernalHeight
            // 
            this.kernalHeight.Location = new System.Drawing.Point(322, 642);
            this.kernalHeight.Name = "kernalHeight";
            this.kernalHeight.Size = new System.Drawing.Size(120, 31);
            this.kernalHeight.TabIndex = 19;
            this.kernalHeight.ValueChanged += new System.EventHandler(this.kernalHeight_ValueChanged);
            // 
            // asciiPic
            // 
            this.asciiPic.Location = new System.Drawing.Point(204, 839);
            this.asciiPic.Name = "asciiPic";
            this.asciiPic.Size = new System.Drawing.Size(213, 66);
            this.asciiPic.TabIndex = 20;
            this.asciiPic.Text = "Ascii Picture";
            this.asciiPic.UseVisualStyleBackColor = true;
            this.asciiPic.Click += new System.EventHandler(this.asciiPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 950);
            this.Controls.Add(this.asciiPic);
            this.Controls.Add(this.kernalHeight);
            this.Controls.Add(this.kernalWidth);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.kernalSize);
            this.Controls.Add(this.greyScaleBtn);
            this.Controls.Add(this.grayPicture);
            this.Controls.Add(this.ogPicture);
            this.Controls.Add(this.asciiPicTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1878, 1021);
            this.Name = "Form1";
            this.Text = "Greyscale";
            ((System.ComponentModel.ISupportInitialize)(this.ogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kernalWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernalHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asciiPicTextBox;
        private System.Windows.Forms.PictureBox ogPicture;
        private System.Windows.Forms.PictureBox grayPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button greyScaleBtn;
        private System.Windows.Forms.Label kernalSize;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.NumericUpDown kernalWidth;
        private System.Windows.Forms.NumericUpDown kernalHeight;
        private System.Windows.Forms.Button asciiPic;
    }
}

