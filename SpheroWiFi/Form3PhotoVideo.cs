using MJpegDecoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpheroWiFi
{
    public partial class Form3PhotoVideo : Form
    {

        FileStream fs;
        Image img;
        string strResponse;
        byte[] byteResponse;
        HttpClient client = new HttpClient();
        MjpegDecoder m_mjpeg;



        public Form3PhotoVideo(string str)
        {
            InitializeComponent();
            tbUrl.Text = str;
        }
        private Button btnClose;

        async Task MyHttp(Uri u)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions
            try
            {
                byte[] responseBody = await client.GetByteArrayAsync(u);

                if (responseBody.Length > 1000)
                {
                    if (responseBody[0] == 0xff && responseBody[1] == 0xd8)
                    {
                        if (img != null)
                        {
                            img.Dispose();
                        }

                        fs = File.Create("jpgTest.jpg");

                        
                        for (int i = 0; i < responseBody.Length; i++)
                        {
                            fs.WriteByte(responseBody[i]);
                        }

                        fs.Close();
                        fs.Dispose();

                        try
                        {
                            img = Image.FromFile("jpgTest.jpg");
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            pbPhoto.Image = img;
                        }
                        catch
                        {
                            MessageBox.Show("Error opening jpg");
                        }
                    }
                }
                else
                {
                    //strResponse = Encoding.Default.GetString(responseBody);
                    //byteResponse = responseBody;
                }


                //if (!rb_Off.Checked)
                //{
                //    foreach (var b in responseBody)
                //    {
                //        if (rb_Ascii.Checked)
                //        {
                //            tb_Receive.AppendText(((char)b).ToString());  // вывод в виде строки
                //        }
                //        else if (rb_Dec.Checked)
                //        {
                //            tb_Receive.AppendText(b.ToString() + " ");  // вывод байтов в десятичном виде
                //        }
                //        else if (rb_Hex.Checked)
                //        {
                //            tb_Receive.AppendText(b.ToString("X2") + " ");  // вывод байтов в десятичном виде
                //        }
                //    }
                //    tb_Receive.AppendText("\r\n");
                //}

                //tb_Receive.AppendText("Length = " + responseBody.Length.ToString() + "\r\n");


            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Exception Caught:" + e.Message.ToString());
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnPhoto_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + tbUrl.Text + "/capture");

            try
            {
                await MyHttp(u);
            }
            catch
            {
                MessageBox.Show("Error Http");
                //tb_Receive.AppendText("Error Http\r\n");
            }
        }

        private void btnStartVideo_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + tbUrl.Text + ":81/stream");

            // In the constructor
            m_mjpeg = new MjpegDecoder();
            m_mjpeg.FrameReady += mjpeg_FrameReady;

            m_mjpeg.ParseStream(u);
        }

        // Private method
        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            //pbPhoto.Image = e.Bitmap;

            fs = File.Create("jpgTest.jpg");

            for (int i = 0; i < e.FrameBuffer.Length; i++)
            {
                fs.WriteByte(e.FrameBuffer[i]);
            }

            fs.Close();
            fs.Dispose();

            try
            {
                img = Image.FromFile("jpgTest.jpg");
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbPhoto.Image = img;
            }
            catch
            {
                //MessageBox.Show("Error opening jpg");
            }
        }

        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            m_mjpeg.StopStream();
        }
    }
}
