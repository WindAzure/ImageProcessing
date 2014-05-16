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
        private Capture _capture = new Capture(0);
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public ImageProcessForm()
        {
            InitializeComponent();
        }

        private void ClickCameraButton(object sender, EventArgs e)
        {
            _capture = new Capture(0);
            Image<Bgr, Byte> image;
            double rate = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
            int delay = (int)(1000.0 / 1);
            while (true)
            {
                _inputPictureBox.Image = _capture.QueryFrame().ToBitmap();
                CvInvoke.cvWaitKey(delay);
            }
            /* Application.Idle -= Application_Idle;

             try
             {
                 _capture = new Capture(0);
                 Application.Idle += Application_Idle;
             }
             catch (Exception)
             {
                 MessageBox.Show("無法找到攝影機，請確定是否有連接");
             }*/
        }

        void Application_Idle(object sender, EventArgs e)
        {
            _inputPictureBox.Image = _capture.QueryFrame().ToBitmap();
        }

        private void ClickMovieButton(object sender, EventArgs e)
        {
          // Application.Idle -= Application_Idle;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                 try
                {
                    _capture = new Capture(openFileDialog.FileName);
                    double fps = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
                    _timer.Interval = Convert.ToInt16(1000 / fps);
                    _timer.Tick += _timer_Tick;
                    _timer.Start();
                    //Application.Idle += Application_Idle;
                }
                catch (Exception)
                {
                    MessageBox.Show("無法找到攝影機，請確定是否有連接");
                }
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img = _capture.QueryFrame();
            if(img!=null)
                _inputPictureBox.Image=img.ToBitmap();
        }
    }
}
