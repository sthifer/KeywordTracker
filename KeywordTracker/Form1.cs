
using HtmlAgilityPack;
using Newtonsoft.Json;
using ScrapySharp.Extensions;
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

namespace KeywordTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            //System.Net.WebClient client = new WebClient();
            //client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12");
            //client.Headers.Add("Accept", "*/*");
            //client.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
            //client.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");

            //string reply = client.DownloadString("https://www.google.es/search?q=navaleno+que+ver");

            //var jsonresult = JsonConvert.DeserializeObject<reply>(result);
            string url = textBox1.Text.Replace(" ","+");
            //Console.WriteLine(reply);
            List<string> MisTitulos = new List<string>();
            HtmlWeb oWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = oWeb.LoadFromBrowser("https://www.google.com/search?q="+ url);

            //HtmlNode Body = doc.DocumentNode.CssSelect("body").First();

            //string sBody = Body.InnerHtml;

            foreach (var Nodo in doc.DocumentNode.CssSelect(".yuRUbf"))
            {
                MisTitulos.Add(Nodo.InnerText);
                //MisTutulos.Add(doc.DocumentNode.SelectNodes("<a href=").First().InnerText);
            }

            int i = 1;
            foreach (var listado in MisTitulos)
            {
                //listado.Contains("jmffdftravel.es");
                //int compara = string.Compare(listado, "jmffdftravel.es");
                if (listado.Contains("jmtravel.es"))
                {
                    richTextBox1.Text = "La Key " + textBox1.Text + " se encuentra en la posición:" + i;
                    break;
                }
                i++;
            }

            //Console.WriteLine(MisTutulos);
        }
    }
}
