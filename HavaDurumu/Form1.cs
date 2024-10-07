using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HavaDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public void islem1()
        {
            if (TB1.Text == "")
                MessageBox.Show("Lütfen ilk önce bir lokasyon giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form1 frm = new Form1();

                string htmlCode = "";

                using(WebClient client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    htmlCode = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={TB1.Text}&appid=72187a2b0a597b5b1c986a0eb2f5ded9&lang-tr");
                }

                dynamic stuff = JObject.Parse(htmlCode);

                dynamic sicaklik = stuff.main.temp;
                int veriSicaklik = (sicaklik - 273);

                L1.Text = veriSicaklik.ToString() + " °C";
                L1.Location = new Point(frm.Size.Width / 2 - L1.Size.Width / 2 - 10, 140);

                dynamic status = stuff.weather[0].description;

                L2.Text = status;
                L2.Location = new Point(frm.Size.Width / 2 - L2.Size.Width / 2 - 10, 201);

                dynamic country = stuff.sys.country;
                dynamic name = stuff.name;

                L3.Text = $"{name}, {country}";
                L3.Location = new Point(frm.Size.Width / 2 - L3.Size.Width / 2 - 10, 335);

                TB1.Text = "";
            }
                
             
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L1.Text = "";
            L2.Text = "";
            L3.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Thread islem = new Thread(() => islem1());
            islem.Start();
        }
    }
}
