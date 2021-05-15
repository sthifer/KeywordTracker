using ExcelDataReader;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cargar_Excel()
        {
            //Ruta del fichero Excel
            string filePath = textBox1.Text;

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        reader.Read();
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1));
                        }
                    } while (reader.NextResult());

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
    }
}
