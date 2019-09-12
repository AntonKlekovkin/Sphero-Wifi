using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using MJpegDecoder;

namespace SpheroWiFi
{
    public partial class Form1 : Form
    {
        const int sizeX = 320;
        const int sizeY = 466;
        //const int lengthBmp = sizeX * sizeY * 3 + 54;

        FileStream fs;
        Image img;
        string strResponse;
        byte[] byteResponse;
        HttpClient client = new HttpClient();

        byte[] Command = new byte[5];   //переменная для отправки команд
        //bool flagStream = false;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr;

            sr = new StreamReader("ListIP.txt");

            var strIp = sr.ReadToEnd().Replace("\r", string.Empty).Split('\n');

            if (strIp.Length != 0)
            {
                cb_IP.Items.Clear();
                cb_IP.Items.AddRange(strIp);
                cb_IP.Text = strIp[0];

                tb_url.Text = cb_IP.Text + "/capture";
            }
            //var countIP = RefreshIP();

            //if (countIP != 0)  //если найден хоть один
            //{
            //    //cb_IP.Text = cb_IP.Items;  //выводим первый доступный
            //}

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;   //без этого не работает

            pbPhoto.Width = sizeX;
            pbPhoto.Height = sizeY;

            strResponse = string.Empty;

            TimeSpan ts = new TimeSpan(0, 0, 2);
            client.Timeout = ts;
        }


        void RefreshIP()
        {
            int ipMax = int.Parse(tbIpMax.Text);

            var ipCb = cb_IP.Text.Split('.');
            int ipStartScan = 0;
            string ipMask = string.Empty;

            try
            {
                ipStartScan = int.Parse(ipCb[3]);
                ipMask = ipCb[2];
            }
            catch
            {
                ipStartScan = 2;
                ipMask = "1";
            }

            string ipBase = "192.168." + ipMask + ".";
            int countIPs = 0;

            cb_IP.Items.Clear();

            for (int i = ipStartScan; i <= ipMax; i++)
            {
                string ipWhole = ipBase + i.ToString();
                Uri u = new Uri("http://" + ipWhole + "/check");

                cb_IP.Text = ipWhole;
                cb_IP.Refresh();
                try
                {
                    HttpWebRequest request = WebRequest.CreateHttp(u);

                    request.Timeout = 300;

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    // Get the stream associated with the response.
                    Stream receiveStream = response.GetResponseStream();

                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.ASCII);

                    var str = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();

                    if (str.Contains("Ok_123"))
                    {
                        tbStatus.Text = "OK";
                        cb_IP.Items.Add(ipWhole);
                        countIPs++;
                    }
                }
                catch { }
            }

                //Ping p = new Ping();

                //for (int i = 0; i <= 20; i++)
                //{
                //    string ipWhole = ipBase + i.ToString();

                //    PingReply rep = p.Send(ipWhole, 10);

                //    if (rep.Status == IPStatus.Success)
                //    {
                //        //host is active
                //        cb_IP.Items.Add(ipWhole);
                //        countIPs++;
                //    }
                //}

                //return countIPs;
        }

         


        async Task MyHttp(Uri u)
        {
            int numberEndJpg = 0;
            //Image img;// = Image.FromFile("jpgTest.jpg");

            //Uri u = new Uri("http://" + tb_url.Text);

            // Create a New HttpClient object and dispose it when done, so the app doesn't leak resources
            
            
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

                        //// search the end of jpg
                        //for (int i = 0; i < responseBody.Length; i++)
                        //{
                        //    if (responseBody[i] == 0xd9 && responseBody[i - 1] == 0xff)
                        //    {
                        //        numberEndJpg = i + 1;
                        //        continue;
                        //    }
                        //}

                        //numberEndJpg = responseBody.Length;

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
                            tb_Receive.AppendText("Error opening jpg\r\n");
                        }
                    }                        
                }
                else
                {
                    strResponse = Encoding.Default.GetString(responseBody);
                    byteResponse = responseBody;
                }
                

                if (!rb_Off.Checked)
                {
                    foreach (var b in responseBody)
                    {
                        if (rb_Ascii.Checked)
                        {
                            tb_Receive.AppendText(((char)b).ToString());  // вывод в виде строки
                        }
                        else if (rb_Dec.Checked)
                        {
                            tb_Receive.AppendText(b.ToString() + " ");  // вывод байтов в десятичном виде
                        }
                        else if (rb_Hex.Checked)
                        {
                            tb_Receive.AppendText(b.ToString("X2") + " ");  // вывод байтов в десятичном виде
                        }
                    }
                    tb_Receive.AppendText("\r\n");
                }

                tb_Receive.AppendText("Length = " + responseBody.Length.ToString() + "\r\n");
                    

            }
            catch (HttpRequestException e)
            {
                tb_Receive.AppendText("\nException Caught!");
                tb_Receive.AppendText(e.Message.ToString());
            }
            

            

            //response.Close();
        }

        



        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshIP();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForward1_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[1] = 1;
            Command[2] = Convert.ToByte(Convert.ToInt16(tbSpeed1.Text));

            SendRF(Command);
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[1] = 0;
            Command[2] = 0;

            SendRF(Command);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[1] = 2;
            Command[2] = Convert.ToByte(Convert.ToInt16(tbSpeed1.Text));

            SendRF(Command);
        }

        private void btnForward2_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[3] = 1;
            Command[4] = Convert.ToByte(Convert.ToInt16(tbSpeed2.Text));

            SendRF(Command);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[3] = 0;
            Command[4] = 0;

            SendRF(Command);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Command[0] = 125;
            Command[3] = 2;
            Command[4] = Convert.ToByte(Convert.ToInt16(tbSpeed2.Text));

            SendRF(Command);
        }

        public async Task SendRF(byte[] command)
        {

            //передача команды
            string str = String.Empty;
            string sep = ",";

            for (int i = 0; i < command.Length - 1; i++)
            {
                str += command[i].ToString() + sep;
            }

            str += command[command.Length - 1].ToString();

            Uri u = new Uri("http://" + cb_IP.Text + "/motor?var=" + str);

            try
            {
                await MyHttp(u);
            }
            catch
            {
                tb_Receive.AppendText("Error Http\r\n");
            }


            //if (port.IsOpen)
            //{
            //    port.Write(command, 0, command.Length);
            //    Thread.Sleep(200);
            //}
            //else
            //{
            //    tbStatusSerial.Text = "Not connect";
            //}
        }

        private void btnAngle_Click(object sender, EventArgs e)
        {
            //if (port.IsOpen)
            {
                Command[0] = 160;
                Command[3] = (Byte)(Convert.ToInt16(tbAngle.Text));
                Command[4] = (Byte)(Convert.ToInt16(tbSpeedRotate.Text));
                Command[1] = 0;
                Command[2] = 0;

                SendRF(Command);

                for (int i = 0; i < Command.Length; i++)
                {
                    Command[i] = 0;
                }

                //zaprosMpu = true;
            }
        }

        private async void btnGetAngles_Click(object sender, EventArgs e)
        {
            Command[0] = 150;
            Command[1] = 0;
            Command[2] = 0;
            Command[3] = 0;
            Command[4] = 0;

            await SendRF(Command);

            for (int i = 0; i < Command.Length; i++)
            {
                Command[i] = 0;
            }

            if(byteResponse.Length == 3)
            {
                tbAng1.Text = byteResponse[0].ToString();
                tbAng2.Text = byteResponse[1].ToString();
                tbAng3.Text = byteResponse[2].ToString();
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            var timeStart = DateTime.Now;
            
            Uri u = new Uri("http://" + cb_IP.Text + "/check");

            try
            {
                await MyHttp(u);
            }
            catch
            {
                tb_Receive.AppendText("Error Http\r\n");
            }

            tbStatus.Text = strResponse;

            var time = DateTime.Now - timeStart;

            tbStatus.AppendText(" " + time.TotalMilliseconds.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_Receive.Clear();
        }

        private async void btnPhoto_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + cb_IP.Text + "/capture");

            try
            {
                await MyHttp(u);
            }
            catch
            {
                tb_Receive.AppendText("Error Http\r\n");
            }

        }

        MjpegDecoder m_mjpeg;

        private async void StartVideo_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + cb_IP.Text + ":81/stream");

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
                tb_Receive.AppendText("Error opening jpg\r\n");
            }
        }


        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            m_mjpeg.StopStream();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Command[0] = 111;
            Command[1] = 0;
            Command[2] = 0;
            Command[3] = 0;
            Command[4] = 0;

            SendRF(Command);

            for (int i = 0; i < Command.Length; i++)
            {
                Command[i] = 0;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // определяем нажата ли клавиша Q
            if (e.KeyCode == Keys.Q)
            {
                // вызываем функцию нажатия кнопки Forward
                btnForward1.PerformClick();
            }
            else if (e.KeyCode == Keys.W)
            {                
                btnStop1.PerformClick();
            }
            else if (e.KeyCode == Keys.E)
            {
                btnBack1.PerformClick();
            }
            else if (e.KeyCode == Keys.A)
            {
                btnForward2.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                btnStop2.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                btnBack2.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Q)
            {
                // вызываем функцию нажатия кнопки Forward
                btnForward1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.W)
            {
                btnStop1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.E)
            {
                btnBack1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.A)
            {
                btnForward2.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                btnStop2.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D)
            {
                btnBack2.PerformClick();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                // вызываем функцию нажатия кнопки Forward
                btnForward1.PerformClick();
            }
            else if (e.KeyCode == Keys.W)
            {
                btnStop1.PerformClick();
            }
            else if (e.KeyCode == Keys.E)
            {
                btnBack1.PerformClick();
            }
            else if (e.KeyCode == Keys.A)
            {
                btnForward2.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                btnStop2.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                btnBack2.PerformClick();
            }
        }

        private async void btnTestRequest_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + tb_url.Text);

            try
            {
                await MyHttp(u);
            }
            catch
            {
                tb_Receive.AppendText("Error Http\r\n");
            }
        }

        private void TbTrajectoryIsEmpty()
        {
            if (tbTrajectory.Text != string.Empty)
            {
                tbTrajectory.AppendText(", ");
            }
        }
        private void btnLeftForwardTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("LEFT_FORWARD");
        }

        private void btnLeftBackTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("LEFT_BACK");
        }

        private void btnForwardTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("FORWARD");
        }

        private void btnBackTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("BACK");
        }

        private void btnRightForwardTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("RIGHT_FORWARD");
        }

        private void btnRightBackTr_Click(object sender, EventArgs e)
        {
            TbTrajectoryIsEmpty();
            tbTrajectory.AppendText("RIGHT_BACK");
        }

        private void btnStopTr_Click(object sender, EventArgs e)
        {
            Command[0] = 141;
            Command[3] = 0;
            Command[4] = 0;
            Command[1] = 0;
            Command[2] = 0;

            SendRF(Command);

            for (int i = 0; i < Command.Length; i++)
            {
                Command[i] = 0;
            }
        }

        private async void btnSendTr_Click(object sender, EventArgs e)
        {         
            string strTrajectory = tbTrajectory.Text;

            if(strTrajectory == null)
            {
                return;
            }

            string bufToStm = "";

            string delayStraight = "126," + tbTStraightTr.Text + ",";
            string delayRotate = "126," + tbTRotateTr.Text + ",";
            string stop = "125,0,0,0,0,127,";

            var arrStrings = strTrajectory.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var str in arrStrings)
            {
                if(str == "FORWARD")
                {
                    bufToStm += "125,0,0,1," + tbSpeedMovingTr.Text + "," + delayStraight;
                }
                else if (str == "BACK")
                {
                    bufToStm += "125,0,0,2," + tbSpeedMovingTr.Text + "," + delayStraight;
                }
                else if (str == "LEFT_FORWARD")
                {
                    bufToStm += "125,1," + tbSpeedRotorTr.Text + ",1," + tbSpeedMovingTr.Text + "," + delayRotate;
                }
                else if (str == "LEFT_BACK")
                {
                    bufToStm += "125,1," + tbSpeedRotorTr.Text + ",2," + tbSpeedMovingTr.Text + "," + delayRotate;
                }
                else if (str == "RIGHT_FORWARD")
                {
                    bufToStm += "125,2," + tbSpeedRotorTr.Text + ",1," + tbSpeedMovingTr.Text + "," + delayRotate;
                }
                else if (str == "RIGHT_BACK")
                {
                    bufToStm += "125,2," + tbSpeedRotorTr.Text + ",2," + tbSpeedMovingTr.Text + "," + delayRotate;
                }
            }

            bufToStm += stop;

            int l = bufToStm.Length;

            var countNumber = bufToStm.Count(s => s == ',');

            tb_Receive.AppendText($"length = {l}\r\n");
            tb_Receive.AppendText($"numbers = {countNumber}\r\n");
            tb_Receive.AppendText($"str = {bufToStm}\r\n");

            if(l > 300)
            {
                tb_Receive.AppendText("Error: Much Commands\r\n");
                return;
            }

            var bufChars = bufToStm.ToCharArray();
            int countCycles = bufChars.Length / 4;
            int countExcess = bufChars.Length % 4;

            // sending quart blocks 
            for (int i = 0; i < countCycles; i++)
            {
                Command[0] = 140;
                Command[1] = (byte)bufChars[i * 4];
                Command[2] = (byte)bufChars[i * 4 + 1];
                Command[3] = (byte)bufChars[i * 4 + 2];
                Command[4] = (byte)bufChars[i * 4 + 3];

                await SendRF(Command);
                //Thread.Sleep(100);
            }

            // sending the rest
            if (countExcess != 0)
            {             
                for (int i = 0; i < Command.Length; i++)
                {
                    Command[i] = 0;
                }
                Command[0] = 140;

                for (int i = 1; i < countExcess + 1; i++)
                {
                    Command[i] = (byte)bufChars[countCycles * 4 + i - 1];
                }

                await SendRF(Command);
            }

            // response from MC
            if (byteResponse.Length == 5)
            {
                var c = Encoding.ASCII.GetChars(byteResponse);
                string s = new string(c);

                tb_Receive.AppendText(s);                
            }

        }

        private void btnClearTr_Click(object sender, EventArgs e)
        {
            tbTrajectory.Clear();
        }

        private void btnStartTr_Click(object sender, EventArgs e)
        {
            if (cbCycle.Checked)
            {
                Command[0] = 143;
            }
            else
            {
                Command[0] = 142;
            }
            
            Command[3] = 0;
            Command[4] = 0;
            Command[1] = 0;
            Command[2] = 0;

            SendRF(Command);

            for (int i = 0; i < Command.Length; i++)
            {
                Command[i] = 0;
            }
        }

        private void testRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void photoVidoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3PhotoVideo f = new Form3PhotoVideo(cb_IP.Text);
            f.Show();
        }

        private void testRequestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2TestRequest f = new Form2TestRequest(cb_IP.Text);
            f.Show();
        }
    }
}
