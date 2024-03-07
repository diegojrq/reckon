
using Emgu.CV;
using Emgu.CV.Structure;
using Microsoft.Win32;

using System.Drawing;
using System.Drawing.Imaging;
using System.Timers;
using System.Windows;

namespace reckon
{
    public partial class FormMain : Form
    {

        Image<Bgr, Byte> SourceImage;
        Image<Bgr, Byte> FragmentImage;

        private static System.Timers.Timer aTimer;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_LoadSourceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();

            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the Image                
                SourceImage = new Image<Bgr, Byte>(Openfile.FileName);

                //Display the Image
                PB_SourceImage.Image = SourceImage.ToBitmap();
            }
        }

        private void BT_LoadFragmentImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();

            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the Image
                FragmentImage = new Image<Bgr, Byte>(Openfile.FileName);

                //Display the Image
                PB_FragmentImage.Image = FragmentImage.ToBitmap();
            }
        }

        private void BT_CheckImages_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> source = SourceImage; // Image B
            Image<Bgr, byte> template = FragmentImage; // Image A
            Image<Bgr, byte> imageToShow = source.Copy();

            try
            {
                Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

                double[] minValues, maxValues;
                System.Drawing.Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                // You can try different values of the threshold. I guess somewhere between 0.75 and 0.95 would be good.
                if (maxValues[0] > 0.9)
                {
                    // This is a match. Do something with it, for example draw a rectangle around it.
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);
                }
            }
            catch (Exception)
            {

                throw;
            }

            PB_CheckedImage.Image = imageToShow.ToBitmap();
        }

        private void BT_ScreenCapture_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                PB_SreenCapturedImage.Image = captureBitmap;

                //Saving the Image File (I am here Saving it in My E drive).
                //captureBitmap.Save(@"E:\Capture.jpg", ImageFormat.Jpeg);
                //Displaying the Successfull Result
                MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BT_ScreenCaptureTimer_Click(object sender, EventArgs e)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(200);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += CaptureScreenTick;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void CaptureScreenTick(Object source, ElapsedEventArgs e)
        {
            try
            {
                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                PB_SreenCapturedImage.Image = captureBitmap;

                //Saving the Image File (I am here Saving it in My E drive).
                //captureBitmap.Save(@"E:\Capture.jpg", ImageFormat.Jpeg);
                //Displaying the Successfull Result
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
