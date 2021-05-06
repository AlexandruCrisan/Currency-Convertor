using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConvertor {

    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }
        
        const string base_link = "http://free.currconv.com/api/v7/convert?q=";
        const string end = "&compact=ultra&apiKey=";
        const string api_key = "ad69ae0151a563a1f8f8";
        public string complete_url;

        public bool checked_from_ron = false;

        public double value_to_be_converted;

        public string ron = "RON", usd = "USD", euro = "EUR";

        private void Form1_Load (object sender, EventArgs e) {

        }

        private void user_input_KeyPress (object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) {
                e.Handled = true;
                String temp = user_input.Text;
                value_to_be_converted = Convert.ToDouble(temp, CultureInfo.InvariantCulture.NumberFormat);
                Debug.WriteLine("Value to be converted : " + value_to_be_converted);

                if ( ron_btn.Checked == true ) {
                    ron_value.Text = ron + " : " + value_to_be_converted.ToString();

                    double value_converted;
                    value_converted = get_conversion(ron, euro);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    euro_value.Text = "EUR : " + value_converted.ToString();

                    value_converted = get_conversion(ron, usd);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    dolar_value.Text = "USD : " + value_converted.ToString();

                } else if (euro_btn.Checked == true ) {
                    euro_value.Text = euro + " : " + value_to_be_converted.ToString();

                    double value_converted;
                    value_converted = get_conversion(euro, ron);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    ron_value.Text = "RON : " + value_converted.ToString();

                    value_converted = get_conversion(euro, usd);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    dolar_value.Text = "USD : " + value_converted.ToString();
                } else if (usd_btn.Checked == true ) {
                    dolar_value.Text = usd + " : " + value_to_be_converted.ToString();

                    double value_converted;
                    value_converted = get_conversion(usd, ron);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    ron_value.Text = "RON : " + value_converted.ToString();

                    value_converted = get_conversion(usd, euro);
                    Console.WriteLine("valoare dupa conv : " + value_converted);
                    euro_value.Text = "USD : " + value_converted.ToString();
                }
            }
        }

        public double get_conversion (string conv1, string conv2) {

            var web_client = new WebClient();

            complete_url = base_link + $"{conv1}_{conv2}" + end + api_key;
            var json_data = web_client.DownloadString(complete_url);
            dynamic valori = JObject.Parse(json_data);

            double val = Convert.ToDouble(valori[$"{conv1}_{conv2}"], System.Globalization.CultureInfo.InvariantCulture);
            val *= value_to_be_converted;

            return val;
        }
    }
}
