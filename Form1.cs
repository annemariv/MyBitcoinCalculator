using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using(var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bitcoinCurrency.SelectedItem.ToString() == "EUR")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinInput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultLabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
        }
    }
}
