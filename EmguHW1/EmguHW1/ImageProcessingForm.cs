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
                _outputPictureBox.Image = null;
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

        private void ClickHistogramButton(object sender, EventArgs e)
        {
            Image<Gray, Byte> img = _sourceImage.Clone().Convert<Gray, Byte>();
            int cdfMin = -1;
            int width = img.Width;
            int height = img.Height;
            int total = width * height;
            int[] grayPer = new int[256];
            int[] sumGray = new int[256];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    grayPer[(int)img[i, j].Intensity]++;
                }
            }

            sumGray[0] = grayPer[0];
            for (int i = 1; i < 256; i++)
            {
                sumGray[i] = sumGray[i - 1] + grayPer[i];
                if (cdfMin == -1 && sumGray[i] != 0)
                    cdfMin = sumGray[i];
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double cdf = sumGray[(int)img[i, j].Intensity];
                    img[i, j] = new Gray(255 * (cdf - cdfMin) / (total - cdfMin));
                }
            }
            _outputPictureBox.Image = img.ToBitmap();
        }

        private void ClickThresholdButton(object sender, EventArgs e)
        {
            Image<Gray, Byte> img = _sourceImage.Clone().Convert<Gray, byte>();
            img = img.ThresholdBinary(new Gray(128), new Gray(255));
            _outputPictureBox.Image = img.ToBitmap();
        }

        private void ClickSmoothButton(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img = _sourceImage.Clone();
            img = img.SmoothBlur(5, 5);
            _outputPictureBox.Image = img.ToBitmap();
        }

        private void ClickHoughLineButton(object sender, EventArgs e)
        {
            Image<Bgr, Byte> src = _sourceImage.Clone();
            Image<Gray, Byte> img = _sourceImage.Clone().Convert<Gray, byte>();
            img=img.ThresholdBinary(new Gray(115), new Gray(255));
            img = img.Erode(1);
            img = img.Dilate(1);
            img = img.Erode(2);
            img = img.Dilate(2);

            LineSegment2D[][] lines = img.HoughLines(100, 200, 1, Math.PI / 180.0, 60, 60, 10);
            foreach (var line in lines[0])
            {
                src.Draw(line, new Bgr(0, 255, 0), 2);
            }
            _outputPictureBox.Image = src.ToBitmap();
        }

        private void ClickRisePointButton(object sender, EventArgs e)
        {
            Image<Ycc,Byte> img = _sourceImage.Clone().Convert<Ycc,Byte>();
            int width=img.Width;
            int height=img.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //顏色是皮膚色
                    if (img[i, j].Cr >= 138 && img[i, j].Cr <= 173 && img[i, j].Cb >= 77 && img[i, j].Cb <= 127)
                    {
                        img[i, j] = new Ycc(16,128,128);
                    }
                }
            }
            _outputPictureBox.Image = img.ToBitmap();
        }
    }
}
