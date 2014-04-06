﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguHW1
{
    public partial class ImageProcessForm : Form
    {
        private Image<Bgr, Byte> _sourceImage;

        public ImageProcessForm()
        {
            InitializeComponent();
        }

        private void ClickImageReadingButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PICS(*.jpg, *.jpeg)|*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _sourceImage = new Image<Bgr, Byte>(openFileDialog.FileName);
                _inputPictureBox.Image = _sourceImage.ToBitmap();
            }
        }

        //灰階處理 Gray = 0.299 * Red + 0.587 * Green + 0.114 * Blue
        private void ClickGrayButton(object sender, EventArgs e)
        {
            
            Image<Bgr, Byte> img = _sourceImage.Clone();
            for (int i = 0; i < _sourceImage.Height; i++)
            {
                for (int j = 0; j < _sourceImage.Width; j++)
                {
                    double color=0.299 * _sourceImage[i, j].Red + 0.587 * _sourceImage[i, j].Green + 0.114 * _sourceImage[i, j].Blue;
                    _sourceImage[i, j] = new Bgr(color,color,color);
                }
            }
            _outputPictureBox.Image = _sourceImage.ToBitmap();
            
           /* Image<Bgr, Byte> img = _sourceImage.Clone();
            IntPtr ptr = img.MIplImage.imageData;
            int height=img.Height;
            int width=img.Width;
            for (int i = 0; i < height; i++) 
            {
                for (int j = 0; j < width; j++)
                {
                    unsafe
                    { 
                        ((byte*)ptr + i * img.MIplImage.widthStep)[j] = 0;
                    }
                }
            }*/
            
        }
    }
}
