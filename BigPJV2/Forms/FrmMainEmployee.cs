using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BigPJV2.Forms
{
    public partial class FrmMainEmployee : Form
    {
        //public Account account = null;
        public FrmMainEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice = null;

        private void FrmMainEmployee_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboCameras.Items.Add(filter.Name);
            }
            cboCameras.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCameras.SelectedIndex].MonikerString);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCameras.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1
                .Start();
        }


        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_Scanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmMainEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_Scanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pb_Scanner.Image);

                if (result != null)
                {
                    timer1.Stop();
                    MessageBox.Show(result.ToString());
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }
    }
}
