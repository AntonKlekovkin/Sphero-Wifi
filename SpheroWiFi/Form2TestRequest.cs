using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpheroWiFi
{
    public partial class Form2TestRequest : Form
    {
        //string strResponse;
        //byte[] byteResponse;
        HttpClient client = new HttpClient();

        public Form2TestRequest(string str)
        {
            InitializeComponent();

            tbUrl.Text = str + "/capture";
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            Uri u = new Uri("http://" + tbUrl.Text);

            try
            {
                await MyHttp(u);
            }
            catch
            {
                tbReceiveTest.AppendText("Error Http\r\n");
            }
        }

        async Task MyHttp(Uri u)
        {
            
            // Call asynchronous network methods in a try/catch block to handle exceptions
            try
            {
                byte[] responseBody = await client.GetByteArrayAsync(u);

                if (!rb_Off.Checked)
                {
                    foreach (var b in responseBody)
                    {
                        if (rb_Ascii.Checked)
                        {
                            tbReceiveTest.AppendText(((char)b).ToString());  // вывод в виде строки
                        }
                        else if (rb_Dec.Checked)
                        {
                            tbReceiveTest.AppendText(b.ToString() + " ");  // вывод байтов в десятичном виде
                        }
                        else if (rb_Hex.Checked)
                        {
                            tbReceiveTest.AppendText(b.ToString("X2") + " ");  // вывод байтов в десятичном виде
                        }
                    }
                    tbReceiveTest.AppendText("\r\n");
                }

                tbReceiveTest.AppendText("Length = " + responseBody.Length.ToString() + "\r\n");


            }
            catch (HttpRequestException e)
            {
                tbReceiveTest.AppendText("\nException Caught!");
                tbReceiveTest.AppendText(e.Message.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbReceiveTest.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
