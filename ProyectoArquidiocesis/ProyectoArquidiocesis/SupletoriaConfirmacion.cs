//using Windows.Data.Pdf
using MySql.Data.MySqlClient;
using ProyectoArquidiocesis.Datos;
using System;
using Microsoft.Office.Interop.Word;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;


namespace ProyectoArquidiocesis
{
    public partial class SupletoriaConfirmacion : MaterialSkin.Controls.MaterialForm
    {
        public string newFilePDF;
        public string newFile;
        public bool impresion = false;

        public SupletoriaConfirmacion()
        {
            InitializeComponent();

        }

        private void SupletoriaConfirmacion_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        public void ReLoad()
        {
            lblCodigoC.Text = "";
            MySqlConnection conectar = Conexion.getConexion();

            try
            {
                //Abrir conexion
                conectar.Open();

                //crear objeto de tipo MySqlCommand

                String script = "SELECT COUNT(id) FROM confirmacion;";

                MySqlCommand comando = new MySqlCommand(script, conectar);

                try
                {
                    string contador = (comando.ExecuteScalar()).ToString();
                    int cont = Int32.Parse(contador) + 1;

                    if (cont < 10)
                    {
                        lblCodigoC.Text = "C000000" + cont;
                    }
                    else if (cont < 100)
                    {
                        lblCodigoC.Text = "C00000" + cont;
                    }
                    else if (cont < 1000)
                    {
                        lblCodigoC.Text = "C0000" + cont;
                    }
                    else if (cont < 10000)
                    {
                        lblCodigoC.Text = "C000" + cont;
                    }
                    else if (cont < 100000)
                    {
                        lblCodigoC.Text = "C00" + cont;
                    }
                    else if (cont < 1000000)
                    {
                        lblCodigoC.Text = "C0" + cont;
                    }
                    else if (cont < 10000000)
                    {
                        lblCodigoC.Text = "C" + cont;
                    }
                    else
                    {
                        lblCodigoC.Text = "Error";
                    }
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Entro catch1 Contador, " + ex.ToString());
                    conectar.Close();
                }
            }
            catch (Exception exx)
            {
                Console.WriteLine("Entro catch2 PASS, " + exx.ToString());
            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }
        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (impresion)
            {

                DialogResult resultado = MessageBox.Show("¿Segur@ que desea guardar los datos, no podrá editar los datos después de guardado.?", "Guardar Archivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {

                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    wordDocument = appWord.Documents.Open(newFile);
                    wordDocument.ExportAsFixedFormat(newFilePDF, WdExportFormat.wdExportFormatPDF);
                    //id, fecha, notario, confirmado, url doc, hashcode.
                    try
                    {
                        DateTime today = DateTime.Today;
                        //obtener los datos
                        string id = lblCodigoC.Text;
                        string fecha = today.ToString("d");
                        string notario = txtNotario.Text;
                        string confirmado = txt2Confirmado.Text;
                        string urldoc = newFile.Replace(".docx", ".pdf");

                        //Crear objeto tipo ConsultaSQL
                        ConsultaSQL insercion = new ConsultaSQL();

                        if (txtNotario.Text == "" || txt9Anio.Text == "" || txt8Mes.Text == "" || txt7Dia.Text == "" || txt6Juramento.Text == "" ||
                            txt5Domicilio.Text == "" || txt4Testigo.Text == "" || txt3Motivo.Text == ""
                            || txt2Confirmado.Text == "" || txt1Parroquia.Text == "" || txt15Certeza.Text == ""
                            || txt14Padrinos.Text == "" || txt13Edad.Text == "" || txt12ParroquiaConfir.Text == ""
                            || txt11Madre.Text == "" || txt10Padre.Text == "")
                        {
                            MessageBox.Show(null, "Faltan campos por completar", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            insercion.NuevaConfirmacion(id, fecha, notario, confirmado, urldoc);
                            MessageBox.Show(null, "Supletoria de Confirmación creada exitosamente", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad();
                            limpiar();
                            System.IO.File.Delete(newFile);
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Debe Imprimir previo a guardar definitivamente.", "Guardar Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void limpiar()
        {
            txt10Padre.Text = "";
            txt11Madre.Text = "";
            txt12ParroquiaConfir.Text = "";
            txt13Edad.Text = "";
            txt14Padrinos.Text = "";
            txt15Certeza.Text = "";
            txt1Parroquia.Text = "";
            txt2Confirmado.Text = "";
            txt3Motivo.Text = "";
            txt4Testigo.Text = "";
            txt5Domicilio.Text = "";
            txt6Juramento.Text = "";
            txt7Dia.Text = "";
            txt8Mes.Text = "";
            txt9Anio.Text = "";
            txtNotario.Text = "";
            newFile = "";
            impresion = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (txtNotario.Text == "" || txt9Anio.Text == "" || txt8Mes.Text == "" || txt7Dia.Text == "" || txt6Juramento.Text == "" ||
    txt5Domicilio.Text == "" || txt4Testigo.Text == "" || txt3Motivo.Text == ""
    || txt2Confirmado.Text == "" || txt1Parroquia.Text == "" || txt15Certeza.Text == ""
    || txt14Padrinos.Text == "" || txt13Edad.Text == "" || txt12ParroquiaConfir.Text == ""
    || txt11Madre.Text == "" || txt10Padre.Text == "")
            {
  MessageBox.Show(null, "Faltan campos por completar", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                string oldFile = "C:\\Archives\\SUPLETORIA DE CONFIRMACIÓN.docx";
                newFile = "C:\\Archives\\Confirmacion - " + lblCodigoC.Text + ".docx";
                newFilePDF = "C:\\Archives\\Confirmacion - " + lblCodigoC.Text + ".pdf";
                using (DocX document = DocX.Load(oldFile))
                {

                document.ReplaceText("_CODIGO_", lblCodigoC.Text);
                document.ReplaceText("_________________parroquia________________", txt1Parroquia.Text);
                document.ReplaceText("_________________________nombre_________________________________", txt2Confirmado.Text);
                document.ReplaceText("________________________motivo____________________", txt3Motivo.Text);
                document.ReplaceText("___________________________testigo__________________________________", txt4Testigo.Text);
                document.ReplaceText("__________________________direccion_________________________________________________________________________________________", txt5Domicilio.Text);
                document.ReplaceText("_________________________certeza______________________________________", txt6Juramento.Text);
                document.ReplaceText("___dia__", txt7Dia.Text);
                document.ReplaceText("________mes_______", txt8Mes.Text);
                document.ReplaceText("________año________________", txt9Anio.Text);
                document.ReplaceText("_________________________padre_______________________________", txt10Padre.Text);
                document.ReplaceText("_______________________________madre________________________________", txt11Madre.Text);
                document.ReplaceText("___________________parroquiaconfirmacion______________________________", txt12ParroquiaConfir.Text);
                document.ReplaceText("__edad___", txt13Edad.Text);
                document.ReplaceText("____________________________padrinos_______________________________________________________________________________________", txt14Padrinos.Text);
                document.ReplaceText("____________________________certeza2_______________________________________________________________________________", txt15Certeza.Text);
                document.ReplaceText("______notario____________", txtNotario.Text);

                document.SaveAs(newFile);
                impresion = true;
                }


                var ap = new Microsoft.Office.Interop.Word.Application();
                Document doc = ap.Documents.Add(newFile);
                //Document document = ap.Documents.Open(@"C:\Users\USER\Documents\prueba.docx");

                //PrintDialog dialogPrint = new PrintDialog();

                // ap.Visible = false;

                PrintDialog pDialog = new PrintDialog();
                if (pDialog.ShowDialog() == DialogResult.OK)
                {
                    ap.ActivePrinter = pDialog.PrinterSettings.PrinterName;
                    doc.PrintOut(); //this will also work: doc.PrintOut();
                    doc.Close(SaveChanges: false);
                    doc = null;
                }


                MessageBox.Show("Proceso de impresión iniciado.", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // <EDIT to include Jason's suggestion>
                //((Microsoft.Office.Interop.Word._Application)ap).Quit(SaveChanges: false);
                // </EDIT>

                // Original: 
                ap.Quit(SaveChanges: false);
                ap = null;
            }
        }
    }
}
