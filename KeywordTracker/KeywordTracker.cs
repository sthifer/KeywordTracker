using ExcelDataReader;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KeywordTracker
{
    public partial class KeywordTracker : Form
    {
        public KeywordTracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Directory.GetCurrentDirectory()+ @"\Keywords.xlsx";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cargar_Excel()
        {
            //Ruta del fichero Excel
            string filePath = textBox1.Text;
            dataGridView1.Rows.Clear();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);
                    var dataTable = dataSet.Tables[0];


                    for (var i = 0; i < dataTable.Rows.Count; i++)
                    {
                        var url = $"https://free-public-api.herokuapp.com/seo_search_volume/?input=" + dataTable.Rows[i][0].ToString().Replace(" ", "+") + "&country=es";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                        StreamReader reader2 = new StreamReader(response.GetResponseStream());
                        string resp = reader2.ReadToEnd();
                        //HtmlWeb oWeb = new HtmlWeb();
                        //HtmlAgilityPack.HtmlDocument doc2 = oWeb.LoadFromBrowser("https://free-public-api.herokuapp.com/seo_search_volume/?input="+ reader.GetString(0).ToString().Replace(" ", "+") + "&country=es");
                        dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], resp, dataTable.Rows[i][6], dataTable.Rows[i][7], dataTable.Rows[i][8], dataTable.Rows[i][9], dataTable.Rows[i][10]);
                    }
                    //do
                    //{

                    //    //reader.Read();
                    //    //while (reader.Read())
                    //    //{
                    //    //    var url = $"https://free-public-api.herokuapp.com/seo_search_volume/?input=" + reader.GetString(0).ToString().Replace(" ", "+") + "&country=es";
                    //    //    var request = (HttpWebRequest)WebRequest.Create(url);
                    //    //    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    //    //    StreamReader reader2 = new StreamReader(response.GetResponseStream());
                    //    //    string resp = reader2.ReadToEnd();
                    //    //    //HtmlWeb oWeb = new HtmlWeb();
                    //    //    //HtmlAgilityPack.HtmlDocument doc2 = oWeb.LoadFromBrowser("https://free-public-api.herokuapp.com/seo_search_volume/?input="+ reader.GetString(0).ToString().Replace(" ", "+") + "&country=es");
                    //    //    dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1),null, null, reader., resp);
                    //    //}
                    //} while (reader.NextResult());

                }
            }
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            Cargar_Excel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void procesar_todo_Click(object sender, EventArgs e)
        {
            int ifor = 0;
            bool actualizado = false;
            for (ifor = 0; ifor < dataGridView1.Rows.Count; ifor++)
            {
                string url = dataGridView1.Rows[ifor].Cells[0].Value.ToString().Replace(" ", "+");
                //string url = url.Replace(" ", "+");
                actualizado = false;
                int posi = 1;
                for (int paginas = 0; paginas < 10; paginas++)
                {

                    List<string> MisTitulos = new List<string>();
                    HtmlWeb oWeb = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = oWeb.LoadFromBrowser("https://www.google.es/search?q=" + url + "&start=" + paginas + "0");

                    
                    foreach (var Nodo in doc.DocumentNode.CssSelect(".yuRUbf"))
                    {
                        //MisTitulos.Add(Nodo.InnerText);

                        if (Nodo.InnerText.ToLower().Contains(dataGridView1.Rows[ifor].Cells[1].Value.ToString().ToLower()))
                        {
                            //if (paginas == 0)
                            //{
                            var cambiopo = dataGridView1.Rows[ifor].Cells[2].Value;
                            var mejor = dataGridView1.Rows[ifor].Cells[4].Value;
                            int mejornum =0;
                            if (!string.IsNullOrEmpty(mejor.ToString())) { Convert.ToInt32(mejor); }
                            //int mejornum = Convert.ToInt32(mejor);
                            int cambio = Convert.ToInt32(cambiopo);
                            if (cambio != posi)
                            {
                                dataGridView1.Rows[ifor].Cells[3].Value = cambio - posi;
                            }
                            if (mejornum > posi)
                            {
                                dataGridView1.Rows[ifor].Cells[4].Value = posi;
                            }
                            else if (mejornum == 0)
                            {
                                dataGridView1.Rows[ifor].Cells[4].Value = posi;
                            }
                            dataGridView1.Rows[ifor].Cells[2].Value = posi;

                                actualizado = true;
                            //}
                            //else
                            //{
                            //    dataGridView1.Rows[ifor].Cells[2].Value = paginas + "" + posi;
                            //    actualizado = true;
                            //}
                            break;
                        }

                        posi++;
                    }

                    //int i = 1;
                    //foreach (var listado in MisTitulos)
                    //{
                    //    if (listado.ToLower().Contains(dataGridView1.Rows[ifor].Cells[1].Value.ToString().ToLower()))
                    //    {
                    //        if (paginas == 0)
                    //        {
                    //            dataGridView1.Rows[ifor].Cells[2].Value = i;
                    //            actualizado = true;
                    //        }
                    //        else
                    //        {
                    //            dataGridView1.Rows[ifor].Cells[2].Value = paginas + "" + i;
                    //            actualizado = true;
                    //        }
                    //        break;
                    //    }
                    //    i++;
                    //}
                    if (actualizado)
                    {
                        break;
                    }

                    

                }

                if (!actualizado)
                {
                    var cambiopo = dataGridView1.Rows[ifor].Cells[2].Value;
                    int cambio = Convert.ToInt32(cambiopo);
                    if (cambio != 100)
                    {
                        dataGridView1.Rows[ifor].Cells[3].Value = cambio - 100;
                    }
                    dataGridView1.Rows[ifor].Cells[2].Value = "+100";

                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExApp;
            ExApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook oWBook;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            oWBook = ExApp.Workbooks.Open(textBox1.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWBook.ActiveSheet;
            int ifor;
            try
            {
                for (ifor = 0; ifor < dataGridView1.Rows.Count; ifor++)
                {
                    var cambiopo = (oSheet.Cells[ifor + 2, 3] as Microsoft.Office.Interop.Excel.Range).Value;
                    int cambio = Convert.ToInt32(cambiopo);
                    if (cambio != Convert.ToInt32(dataGridView1.Rows[ifor].Cells[2].Value))
                    {
                        oSheet.Cells[ifor + 2, 4] = cambio - Convert.ToInt32(dataGridView1.Rows[ifor].Cells[2].Value);
                    }
                    oSheet.Cells[ifor + 2, 3] = dataGridView1.Rows[ifor].Cells[2].Value;
                    oSheet.Cells[ifor + 2, 4] = dataGridView1.Rows[ifor].Cells[3].Value;
                    oSheet.Cells[ifor + 2, 5] = dataGridView1.Rows[ifor].Cells[4].Value;
                    oSheet.Cells[ifor + 2, 6] = dataGridView1.Rows[ifor].Cells[5].Value;
                    oSheet.Cells[ifor + 2, 7] = (oSheet.Cells[ifor + 2, 8] as Microsoft.Office.Interop.Excel.Range).Value;
                    oSheet.Cells[ifor + 2, 8] = (oSheet.Cells[ifor + 2, 9] as Microsoft.Office.Interop.Excel.Range).Value;
                    oSheet.Cells[ifor + 2, 9] = (oSheet.Cells[ifor + 2, 10] as Microsoft.Office.Interop.Excel.Range).Value;
                    oSheet.Cells[ifor + 2, 10] = (oSheet.Cells[ifor + 2, 11] as Microsoft.Office.Interop.Excel.Range).Value;
                    oSheet.Cells[ifor + 2, 11] = dataGridView1.Rows[ifor].Cells[2].Value;
                }
            }
     catch (IOException ex)
            {
                ExApp.Visible = false;
                ExApp.UserControl = true;
                oWBook.Save();
                ExApp.Quit();
                ExApp = null;
            }
            
            ExApp.Visible = false;
            ExApp.UserControl = true;
            oWBook.Save();
            //ExApp.ActiveWorkbook.Close(true, ExcelFile, Type.Missing);
            ExApp.Quit();
            ExApp = null;
        }

        private void Automatico_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 3;
            progressBar1.Value = 0;
            buscar.PerformClick();
            progressBar1.Value += 1;
            procesar_todo.PerformClick();
            progressBar1.Value += 1;
            btnActualizar.PerformClick();
            progressBar1.Value += 1;
        }
    }
}
