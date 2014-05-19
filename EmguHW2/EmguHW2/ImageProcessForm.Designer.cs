namespace EmguHW2
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
            this._cameraButton = new System.Windows.Forms.Button();
            this._movieButton = new System.Windows.Forms.Button();
            this._inputGroupBox = new System.Windows.Forms.GroupBox();
            this._inputPictureBox = new System.Windows.Forms.PictureBox();
            this._outputGroupBox = new System.Windows.Forms.GroupBox();
            this._outputPictureBox = new System.Windows.Forms.PictureBox();
            this._cannyButton = new System.Windows.Forms.Button();
            this._grayButton = new System.Windows.Forms.Button();
            this._inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._inputPictureBox)).BeginInit();
            this._outputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _cameraButton
            // 
            this._cameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cameraButton.Location = new System.Drawing.Point(51, 40);
            this._cameraButton.Name = "_cameraButton";
            this._cameraButton.Size = new System.Drawing.Size(100, 35);
            this._cameraButton.TabIndex = 0;
            this._cameraButton.Text = " 開啟攝影機";
            this._cameraButton.UseVisualStyleBackColor = true;
            this._cameraButton.Click += new System.EventHandler(this.ClickCameraButton);
            // 
            // _movieButton
            // 
            this._movieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._movieButton.Location = new System.Drawing.Point(161, 40);
            this._movieButton.Name = "_movieButton";
            this._movieButton.Size = new System.Drawing.Size(100, 35);
            this._movieButton.TabIndex = 1;
            this._movieButton.Text = "讀取視訊檔";
            this._movieButton.UseVisualStyleBackColor = true;
            this._movieButton.Click += new System.EventHandler(this.ClickMovieButton);
            // 
            // _inputGroupBox
            // 
            this._inputGroupBox.Controls.Add(this._inputPictureBox);
            this._inputGroupBox.Location = new System.Drawing.Point(51, 86);
            this._inputGroupBox.Name = "_inputGroupBox";
            this._inputGroupBox.Size = new System.Drawing.Size(312, 320);
            this._inputGroupBox.TabIndex = 4;
            this._inputGroupBox.TabStop = false;
            this._inputGroupBox.Text = "Input";
            // 
            // _inputPictureBox
            // 
            this._inputPictureBox.Location = new System.Drawing.Point(6, 14);
            this._inputPictureBox.Name = "_inputPictureBox";
            this._inputPictureBox.Size = new System.Drawing.Size(300, 300);
            this._inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._inputPictureBox.TabIndex = 1;
            this._inputPictureBox.TabStop = false;
            // 
            // _outputGroupBox
            // 
            this._outputGroupBox.Controls.Add(this._outputPictureBox);
            this._outputGroupBox.Location = new System.Drawing.Point(378, 86);
            this._outputGroupBox.Name = "_outputGroupBox";
            this._outputGroupBox.Size = new System.Drawing.Size(312, 320);
            this._outputGroupBox.TabIndex = 7;
            this._outputGroupBox.TabStop = false;
            this._outputGroupBox.Text = "Output";
            // 
            // _outputPictureBox
            // 
            this._outputPictureBox.Location = new System.Drawing.Point(6, 14);
            this._outputPictureBox.Name = "_outputPictureBox";
            this._outputPictureBox.Size = new System.Drawing.Size(300, 300);
            this._outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._outputPictureBox.TabIndex = 1;
            this._outputPictureBox.TabStop = false;
            // 
            // _cannyButton
            // 
            this._cannyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cannyButton.Location = new System.Drawing.Point(488, 40);
            this._cannyButton.Name = "_cannyButton";
            this._cannyButton.Size = new System.Drawing.Size(100, 35);
            this._cannyButton.TabIndex = 6;
            this._cannyButton.Text = "邊緣檢測";
            this._cannyButton.UseVisualStyleBackColor = true;
            this._cannyButton.Click += new System.EventHandler(this.ClickCannyButton);
            // 
            // _grayButton
            // 
            this._grayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._grayButton.Location = new System.Drawing.Point(378, 40);
            this._grayButton.Name = "_grayButton";
            this._grayButton.Size = new System.Drawing.Size(100, 35);
            this._grayButton.TabIndex = 5;
            this._grayButton.Text = " 灰階處理";
            this._grayButton.UseVisualStyleBackColor = true;
            this._grayButton.Click += new System.EventHandler(this.ClickGrayButton);
            // 
            // ImageProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 447);
            this.Controls.Add(this._outputGroupBox);
            this.Controls.Add(this._cannyButton);
            this.Controls.Add(this._grayButton);
            this.Controls.Add(this._inputGroupBox);
            this.Controls.Add(this._movieButton);
            this.Controls.Add(this._cameraButton);
            this.Name = "ImageProcessForm";
            this.Text = "Live Interaction Application";
            this._inputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._inputPictureBox)).EndInit();
            this._outputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _cameraButton;
        private System.Windows.Forms.Button _movieButton;
        private System.Windows.Forms.GroupBox _inputGroupBox;
        private System.Windows.Forms.PictureBox _inputPictureBox;
        private System.Windows.Forms.GroupBox _outputGroupBox;
        private System.Windows.Forms.PictureBox _outputPictureBox;
        private System.Windows.Forms.Button _cannyButton;
        private System.Windows.Forms.Button _grayButton;
    }
}

