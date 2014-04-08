using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    double color = 0.299 * img[i, j].Red + 0.587 * img[i, j].Green + 0.114 * img[i, j].Blue;
                    img[i, j] = new Bgr(color, color, color);
                }
            }
            _outputPictureBox.Image = img.ToBitmap();

            /*
            //make by pointer
            Image<Bgr, Byte> img = _sourceImage.Clone();
            Debug.WriteLine(img.NumberOfChannels);
            IntPtr ptr = img.MIplImage.imageData;
            int height = img.Height;
            int width = img.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j ++)
                {
                    int counter = i * img.MIplImage.widthStep + j * img.MIplImage.nChannels;
                    unsafe
                    {   
                        double b = ((byte*)ptr + counter)[0];
                        double g = ((byte*)ptr + counter)[1];
                        double r = ((byte*)ptr + counter)[2];
                        double color = 0.299 *r + 0.587 * g + 0.114 * b;

                        for (int k = 0; k < 3;k++ )
                            ((byte*)ptr + counter)[k]=(byte)color;
                    }
                }
            }
            _outputPictureBox.Image = img.ToBitmap();
            */
        }

        private void ClickEdgeButton(object sender, EventArgs e)
        {
            Image<Gray, Byte> img = _sourceImage.Clone().Convert<Gray, byte>();
            Image<Gray, float> sobelX = img.Sobel(1, 0, 3).AbsDiff(new Gray());
            Image<Gray, float> sobelY = img.Sobel(0, 1, 3).AbsDiff(new Gray());
            Image<Gray, float> sobel = sobelX + sobelY;
            _outputPictureBox.Image = sobel.ToBitmap();
        }
    }
}
