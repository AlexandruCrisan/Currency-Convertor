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

                    assign(ron, euro, usd);

                } else if (euro_btn.Checked == true ) {
                    euro_value.Text = euro + " : " + value_to_be_converted.ToString();

                    assign(euro, ron, usd);
                } else if (usd_btn.Checked == true ) {
                    dolar_value.Text = usd + " : " + value_to_be_converted.ToString();

                    assign(usd, euro, ron);
                }
            }
        }

        public double get_conversion (string conv1, string conv2) {
            var web_client = new WebClient();

            complete_url = base_link + $"{conv1}_{conv2}" + end + api_key;
            var json_data = web_client.DownloadString(complete_url);
            var valori = JObject.Parse(json_data);
            
            double val = Convert.ToDouble(valori[$"{conv1}_{conv2}"], System.Globalization.CultureInfo.InvariantCulture);
            val *= value_to_be_converted;

            return val;
        }

        public void assign (string from, string to1, string to2) {
            double value_converted1;
            double value_converted2;

            value_converted1 = get_conversion(from, to1);
            value_converted2 = get_conversion(from, to2);

            switch ( from ) {
                case "RON":
                    switch ( to1 ) {
                        case "EUR":
                        euro_value.Text = "EUR : " + value_converted1.ToString();
                        dolar_value.Text = "USD : " + value_converted2.ToString();
                        break;

                        case "USD":
                        dolar_value.Text = "USD : " + value_converted1.ToString();
                        euro_value.Text = "EUR : " + value_converted2.ToString();
                        break;
                    }
                break;

                case "EUR":
                    switch ( to1 ) {
                        case "RON":
                        ron_value.Text = "RON : " + value_converted1.ToString();
                        dolar_value.Text = "USD : " + value_converted2.ToString();
                        break;

                        case "USD":
                        ron_value.Text = "RON : " + value_converted2.ToString();
                        dolar_value.Text = "USD : " + value_converted1.ToString();
                        break;
                    }
                break;

                case "USD":
                    switch( to1 ) {
                        case "RON":
                            ron_value.Text = "RON : " + value_converted1.ToString();
                            euro_value.Text = "EUR : " + value_converted2.ToString();
                        break;

                        case "EUR":
                            ron_value.Text = "RON : " + value_converted2.ToString();
                            euro_value.Text = "EUR : " + value_converted1.ToString();
                        break;
                    }
                break;
            }
        }
    }
}
