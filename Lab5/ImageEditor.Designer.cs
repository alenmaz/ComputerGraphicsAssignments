
namespace ImageEditor
{
    partial class ImageEditor
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
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.imageDataButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.brightnessBox = new System.Windows.Forms.TextBox();
            this.colorFilter = new System.Windows.Forms.Label();
            this.brightnessFilter = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.editedImageData = new System.Windows.Forms.Button();
            this.ImageData = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XCoordinateBox = new System.Windows.Forms.TextBox();
            this.YCoordinateBox = new System.Windows.Forms.TextBox();
            this.SinglePixelColorBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.SinglePixelColorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceBox
            // 
            this.sourceBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sourceBox.Location = new System.Drawing.Point(12, 12);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(275, 353);
            this.sourceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceBox.TabIndex = 0;
            this.sourceBox.TabStop = false;
            this.sourceBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(575, 398);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(63, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(506, 398);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(63, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(644, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // imageDataButton
            // 
            this.imageDataButton.Location = new System.Drawing.Point(573, 12);
            this.imageDataButton.Name = "imageDataButton";
            this.imageDataButton.Size = new System.Drawing.Size(215, 23);
            this.imageDataButton.TabIndex = 7;
            this.imageDataButton.Text = "Show image data";
            this.imageDataButton.UseVisualStyleBackColor = true;
            this.imageDataButton.Click += new System.EventHandler(this.showData_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(12, 401);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(63, 20);
            this.colorBox.TabIndex = 8;
            this.colorBox.Text = "0,0,0";
            // 
            // brightnessBox
            // 
            this.brightnessBox.Location = new System.Drawing.Point(120, 401);
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.Size = new System.Drawing.Size(63, 20);
            this.brightnessBox.TabIndex = 9;
            this.brightnessBox.Text = "1";
            // 
            // colorFilter
            // 
            this.colorFilter.AutoSize = true;
            this.colorFilter.Location = new System.Drawing.Point(12, 385);
            this.colorFilter.Name = "colorFilter";
            this.colorFilter.Size = new System.Drawing.Size(56, 13);
            this.colorFilter.TabIndex = 10;
            this.colorFilter.Text = "Color Filter";
            // 
            // brightnessFilter
            // 
            this.brightnessFilter.AutoSize = true;
            this.brightnessFilter.Location = new System.Drawing.Point(117, 385);
            this.brightnessFilter.Name = "brightnessFilter";
            this.brightnessFilter.Size = new System.Drawing.Size(56, 13);
            this.brightnessFilter.TabIndex = 11;
            this.brightnessFilter.Text = "Brightness";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultBox.Location = new System.Drawing.Point(292, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(275, 353);
            this.resultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultBox.TabIndex = 12;
            this.resultBox.TabStop = false;
            // 
            // editedImageData
            // 
            this.editedImageData.Location = new System.Drawing.Point(573, 38);
            this.editedImageData.Name = "editedImageData";
            this.editedImageData.Size = new System.Drawing.Size(215, 23);
            this.editedImageData.TabIndex = 13;
            this.editedImageData.Text = "Show edited image data";
            this.editedImageData.UseVisualStyleBackColor = true;
            this.editedImageData.Click += new System.EventHandler(this.editedImageData_Click);
            // 
            // ImageData
            // 
            this.ImageData.Location = new System.Drawing.Point(573, 67);
            this.ImageData.Name = "ImageData";
            this.ImageData.Size = new System.Drawing.Size(215, 298);
            this.ImageData.TabIndex = 15;
            this.ImageData.Text = "";
            this.ImageData.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(713, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Pixel";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // XCoordinateBox
            // 
            this.XCoordinateBox.Location = new System.Drawing.Point(228, 401);
            this.XCoordinateBox.Name = "XCoordinateBox";
            this.XCoordinateBox.Size = new System.Drawing.Size(32, 20);
            this.XCoordinateBox.TabIndex = 19;
            // 
            // YCoordinateBox
            // 
            this.YCoordinateBox.Location = new System.Drawing.Point(286, 400);
            this.YCoordinateBox.Name = "YCoordinateBox";
            this.YCoordinateBox.Size = new System.Drawing.Size(32, 20);
            this.YCoordinateBox.TabIndex = 20;
            // 
            // SinglePixelColorBox
            // 
            this.SinglePixelColorBox.Location = new System.Drawing.Point(361, 400);
            this.SinglePixelColorBox.Name = "SinglePixelColorBox";
            this.SinglePixelColorBox.Size = new System.Drawing.Size(63, 20);
            this.SinglePixelColorBox.TabIndex = 21;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(208, 404);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 22;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(266, 404);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 23;
            this.YLabel.Text = "Y";
            this.YLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SinglePixelColorLabel
            // 
            this.SinglePixelColorLabel.AutoSize = true;
            this.SinglePixelColorLabel.Location = new System.Drawing.Point(324, 404);
            this.SinglePixelColorLabel.Name = "SinglePixelColorLabel";
            this.SinglePixelColorLabel.Size = new System.Drawing.Size(31, 13);
            this.SinglePixelColorLabel.TabIndex = 24;
            this.SinglePixelColorLabel.Text = "Color";
            this.SinglePixelColorLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SinglePixelColorLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.SinglePixelColorBox);
            this.Controls.Add(this.YCoordinateBox);
            this.Controls.Add(this.XCoordinateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ImageData);
            this.Controls.Add(this.editedImageData);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.brightnessFilter);
            this.Controls.Add(this.colorFilter);
            this.Controls.Add(this.brightnessBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.imageDataButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.sourceBox);
            this.Name = "ImageEditor";
            this.Text = "Лабораторная 5";
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button imageDataButton;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox brightnessBox;
        private System.Windows.Forms.Label colorFilter;
        private System.Windows.Forms.Label brightnessFilter;
        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.Button editedImageData;
        private System.Windows.Forms.RichTextBox ImageData;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XCoordinateBox;
        private System.Windows.Forms.TextBox YCoordinateBox;
        private System.Windows.Forms.TextBox SinglePixelColorBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label SinglePixelColorLabel;
    }
}

