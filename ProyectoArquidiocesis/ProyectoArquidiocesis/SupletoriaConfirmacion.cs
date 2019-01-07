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


namespace ProyectoArquidiocesis
{
    public partial class SupletoriaConfirmacion : MaterialSkin.Controls.MaterialForm
    {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //id, fecha, notario, confirmado, url doc, hashcode.
            try
            {
                DateTime today = DateTime.Today;
                //obtener los datos
                string id = lblCodigoC.Text;
                string fecha = today.ToString("d");
                string notario = txtNotario.Text;
                string confirmado = txt2Confirmado.Text;
                string urldoc = "prueba";
                string hashcode = "hashcode";

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
                    insercion.NuevaConfirmacion(id, fecha, notario, confirmado, urldoc, hashcode);
                    MessageBox.Show(null, "Supletoria de Confirmación creada exitosamente", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoad();
                    limpiar();
                }
            }
            catch
            {
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
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           // using { docx document = docx}
            
            var ap = new Microsoft.Office.Interop.Word.Application();
            Document doc = ap.Documents.Add(@"C:\Users\USER\Documents\prueba2.docx");
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
