using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguHW2
{
    public partial class ImageProcessForm : Form
    {
        private Capture _capture;
        private Image<Bgr, Byte> _image;
        private System.Windows.Forms.Timer _movieTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer _cameraTimer = new System.Windows.Forms.Timer();

        public ImageProcessForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            _movieTimer.Stop();
            _movieTimer.Tick -= TickMovieTimer;
            _cameraTimer.Stop();
            _cameraTimer.Tick -= TickCameraTimer;
        }

        private void ClickCameraButton(object sender, EventArgs e)
        {
            Clear();

            try
            {
                _capture = new Capture(0);
                double fps = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
                _cameraTimer.Interval = Convert.ToInt16(1);
                _cameraTimer.Tick += TickCameraTimer;
                _cameraTimer.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("無法找到攝影機，請確定是否有連接");
            }
        }

        void TickCameraTimer(object sender, EventArgs e)
        {
            _image = _capture.QueryFrame();
            if (_image != null)
            {
                _inputPictureBox.Image = _image.ToBitmap();
            }
        }

        private void ClickMovieButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Clear();

                 try
                {
                    _capture = new Capture(openFileDialog.FileName);
                    double fps = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
                    _movieTimer.Interval = Convert.ToInt16(1000.0 / fps);
                    _movieTimer.Tick += TickMovieTimer;
                    _movieTimer.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("影片錯誤");
                }
            }
        }

        void TickMovieTimer(object sender, EventArgs e)
        {
            _image = _capture.QueryFrame();
            if (_image != null)
            {
                _inputPictureBox.Image = _image.ToBitmap();
            }
            else
            {
                _movieTimer.Stop();
            }
        }
    }
}
