namespace EmguHW1
{
    partial class ImageProcessForm
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
            this._imageReadingButton = new System.Windows.Forms.Button();
            this._grayButton = new System.Windows.Forms.Button();
            this._histogramButton = new System.Windows.Forms.Button();
            this._edgeButton = new System.Windows.Forms.Button();
            this._thresholdButton = new System.Windows.Forms.Button();
            this._smoothButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this._inputGroupBox = new System.Windows.Forms.GroupBox();
            this._inputPictureBox = new System.Windows.Forms.PictureBox();
            this._outputGroupBox = new System.Windows.Forms.GroupBox();
            this._outputPictureBox = new System.Windows.Forms.PictureBox();
            this._risePointButton = new System.Windows.Forms.Button();
            this._inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._inputPictureBox)).BeginInit();
            this._outputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _imageReadingButton
            // 
            this._imageReadingButton.Location = new System.Drawing.Point(42, 42);
            this._imageReadingButton.Name = "_imageReadingButton";
            this._imageReadingButton.Size = new System.Drawing.Size(75, 23);
            this._imageReadingButton.TabIndex = 0;
            this._imageReadingButton.Text = "讀取圖片";
            this._imageReadingButton.UseVisualStyleBackColor = true;
            this._imageReadingButton.Click += new System.EventHandler(this.ClickImageReadingButton);
            // 
            // _grayButton
            // 
            this._grayButton.Location = new System.Drawing.Point(367, 22);
            this._grayButton.Name = "_grayButton";
            this._grayButton.Size = new System.Drawing.Size(75, 23);
            this._grayButton.TabIndex = 1;
            this._grayButton.Text = "灰階處理";
            this._grayButton.UseVisualStyleBackColor = true;
            this._grayButton.Click += new System.EventHandler(this.ClickGrayButton);
            // 
            // _histogramButton
            // 
            this._histogramButton.Location = new System.Drawing.Point(457, 22);
            this._histogramButton.Name = "_histogramButton";
            this._histogramButton.Size = new System.Drawing.Size(75, 23);
            this._histogramButton.TabIndex = 2;
            this._histogramButton.Text = "直方圖均化";
            this._histogramButton.UseVisualStyleBackColor = true;
            this._histogramButton.Click += new System.EventHandler(this.ClickHistogramButton);
            // 
            // _edgeButton
            // 
            this._edgeButton.Location = new System.Drawing.Point(548, 22);
            this._edgeButton.Name = "_edgeButton";
            this._edgeButton.Size = new System.Drawing.Size(75, 23);
            this._edgeButton.TabIndex = 3;
            this._edgeButton.Text = "邊緣檢測";
            this._edgeButton.UseVisualStyleBackColor = true;
            this._edgeButton.Click += new System.EventHandler(this.ClickEdgeButton);
            // 
            // _thresholdButton
            // 
            this._thresholdButton.Location = new System.Drawing.Point(367, 62);
            this._thresholdButton.Name = "_thresholdButton";
            this._thresholdButton.Size = new System.Drawing.Size(75, 23);
            this._thresholdButton.TabIndex = 6;
            this._thresholdButton.Text = "二值化";
            this._thresholdButton.UseVisualStyleBackColor = true;
            this._thresholdButton.Click += new System.EventHandler(this.ClickThresholdButton);
            // 
            // _smoothButton
            // 
            this._smoothButton.Location = new System.Drawing.Point(457, 62);
            this._smoothButton.Name = "_smoothButton";
            this._smoothButton.Size = new System.Drawing.Size(75, 23);
            this._smoothButton.TabIndex = 5;
            this._smoothButton.Text = "模糊";
            this._smoothButton.UseVisualStyleBackColor = true;
            this._smoothButton.Click += new System.EventHandler(this.ClickSmoothButton);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(548, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "自選功能(3)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // _inputGroupBox
            // 
            this._inputGroupBox.Controls.Add(this._inputPictureBox);
            this._inputGroupBox.Location = new System.Drawing.Point(27, 116);
            this._inputGroupBox.Name = "_inputGroupBox";
            this._inputGroupBox.Size = new System.Drawing.Size(330, 340);
            this._inputGroupBox.TabIndex = 9;
            this._inputGroupBox.TabStop = false;
            this._inputGroupBox.Text = "Input";
            // 
            // _inputPictureBox
            // 
            this._inputPictureBox.Location = new System.Drawing.Point(15, 20);
            this._inputPictureBox.Name = "_inputPictureBox";
            this._inputPictureBox.Size = new System.Drawing.Size(300, 300);
            this._inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._inputPictureBox.TabIndex = 10;
            this._inputPictureBox.TabStop = false;
            // 
            // _outputGroupBox
            // 
            this._outputGroupBox.Controls.Add(this._outputPictureBox);
            this._outputGroupBox.Location = new System.Drawing.Point(382, 116);
            this._outputGroupBox.Name = "_outputGroupBox";
            this._outputGroupBox.Size = new System.Drawing.Size(330, 340);
            this._outputGroupBox.TabIndex = 10;
            this._outputGroupBox.TabStop = false;
            this._outputGroupBox.Text = "Output";
            // 
            // _outputPictureBox
            // 
            this._outputPictureBox.Location = new System.Drawing.Point(15, 19);
            this._outputPictureBox.Name = "_outputPictureBox";
            this._outputPictureBox.Size = new System.Drawing.Size(300, 300);
            this._outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._outputPictureBox.TabIndex = 10;
            this._outputPictureBox.TabStop = false;
            // 
            // _risePointButton
            // 
            this._risePointButton.Location = new System.Drawing.Point(638, 22);
            this._risePointButton.Name = "_risePointButton";
            this._risePointButton.Size = new System.Drawing.Size(74, 63);
            this._risePointButton.TabIndex = 11;
            this._risePointButton.Text = "向右旋\r\n轉30度";
            this._risePointButton.UseVisualStyleBackColor = true;
            // 
            // ImageProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 479);
            this.Controls.Add(this._risePointButton);
            this.Controls.Add(this._outputGroupBox);
            this.Controls.Add(this._inputGroupBox);
            this.Controls.Add(this._thresholdButton);
            this.Controls.Add(this._smoothButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this._edgeButton);
            this.Controls.Add(this._histogramButton);
            this.Controls.Add(this._grayButton);
            this.Controls.Add(this._imageReadingButton);
            this.Name = "ImageProcessForm";
            this.Text = "Digital Image Processing";
            this._inputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._inputPictureBox)).EndInit();
            this._outputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _imageReadingButton;
        private System.Windows.Forms.Button _grayButton;
        private System.Windows.Forms.Button _histogramButton;
        private System.Windows.Forms.Button _edgeButton;
        private System.Windows.Forms.Button _thresholdButton;
        private System.Windows.Forms.Button _smoothButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox _inputGroupBox;
        private System.Windows.Forms.PictureBox _inputPictureBox;
        private System.Windows.Forms.GroupBox _outputGroupBox;
        private System.Windows.Forms.PictureBox _outputPictureBox;
        private System.Windows.Forms.Button _risePointButton;
    }
}

