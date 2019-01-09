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

namespace ProyectoArquidiocesis
{

    public partial class SupletoriaBautizo : MaterialSkin.Controls.MaterialForm
    {
       

        public SupletoriaBautizo()
        {
            InitializeComponent();
           
        }

        private void SupletoriaBautizo_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        public void ReLoad()
        {
            lblCodigoB.Text = "";
            MySqlConnection conectar = Conexion.getConexion();

            try
            {
                //Abrir conexion
                conectar.Open();

                //crear objeto de tipo MySqlCommand

                String script = "SELECT COUNT(id) FROM bautismo;";

                MySqlCommand comando = new MySqlCommand(script, conectar);

                try
                {
                    string contador = (comando.ExecuteScalar()).ToString();
                    int cont = Int32.Parse(contador) + 1;

                    if (cont < 10)
                    {
                        lblCodigoB.Text = "B000000" + cont;
                    }
                    else if (cont < 100)
                    {
                        lblCodigoB.Text = "B00000" + cont;
                    }
                    else if (cont < 1000)
                    {
                        lblCodigoB.Text = "B0000" + cont;
                    }
                    else if (cont < 10000)
                    {
                        lblCodigoB.Text = "B000" + cont;
                    }
                    else if (cont < 100000)
                    {
                        lblCodigoB.Text = "B00" + cont;
                    }
                    else if (cont < 1000000)
                    {
                        lblCodigoB.Text = "B0" + cont;
                    }
                    else if (cont < 10000000)
                    {
                        lblCodigoB.Text = "B" + cont;
                    }
                    else
                    {
                        lblCodigoB.Text = "Error";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt5Domicilio_Click(object sender, EventArgs e)
        {

        }

        private void txt18Fecha_Click(object sender, EventArgs e)
        {

        }

        private void txt17Observaciones_Click(object sender, EventArgs e)
        {

        }

        private void txt16Certeza_Click(object sender, EventArgs e)
        {

        }

        private void txt15Padrinos_Click(object sender, EventArgs e)
        {

        }

        private void txt14ParroquiaConfir_Click(object sender, EventArgs e)
        {

        }

        private void txt12Madre_Click(object sender, EventArgs e)
        {

        }

        private void txt11Padre_Click(object sender, EventArgs e)
        {

        }

        private void txt8Dia_Click(object sender, EventArgs e)
        {

        }

        private void txt9Mes_Click(object sender, EventArgs e)
        {

        }

        private void txt10Anio_Click(object sender, EventArgs e)
        {

        }

        private void txt5Edad_Click(object sender, EventArgs e)
        {

        }

        private void txt4Testigo_Click(object sender, EventArgs e)
        {

        }

        private void txt7Juramento_Click(object sender, EventArgs e)
        {

        }

        private void txt3Motivo_Click(object sender, EventArgs e)
        {

        }

        private void txt2Bautizado_Click(object sender, EventArgs e)
        {

        }

        private void txt1Parroquia_Click(object sender, EventArgs e)
        {

        }

        private void txt13Edad_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //id, fecha, notario, bautizado, url doc, hashcode.
            try
            {
                DateTime today = DateTime.Today;
                //obtener los datos
                string id = lblCodigoB.Text;
                string fecha = today.ToString("d");
                string notario = txtNotario.Text;
                string confirmado = txt2Bautizado.Text;
                string urldoc = "prueba";
                string hashcode = "hashcode";

                //Crear objeto tipo ConsultaSQL
                ConsultaSQL insercion = new ConsultaSQL();

                if (txtNotario.Text == "" || txt10Anio.Text == "" || txt11Padre.Text == "" || txt12Madre.Text == "" || txt13Edad.Text == "" ||
                    txt14ParroquiaConfir.Text == "" || txt15Padrinos.Text == "" || txt16Certeza.Text == ""
                    || txt17Observaciones.Text == "" || txt18Fecha.Text == "" || txt1Parroquia.Text == ""
                    || txt2Bautizado.Text == "" || txt3Motivo.Text == "" || txt4Testigo.Text == ""
                    || txt5Edad.Text == "" || txt6Domicilio.Text == "" || txt7Juramento.Text == "" || txt8Dia.Text == ""
                    || txt9Mes.Text == "")
                {
                    MessageBox.Show(null, "Faltan campos por completar", "Supletoria Bautismo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    insercion.NuevoBautismo(id, fecha, notario, confirmado, urldoc, hashcode);
                    MessageBox.Show(null, "Supletoria de Bautismo creada exitosamente", "Supletoria Bautismo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNotario.Text = "";
            txt9Mes.Text = "";
            txt8Dia.Text = "";
            txt7Juramento.Text = "";
            txt6Domicilio.Text = "";
            txt5Edad.Text = "";
            txt4Testigo.Text = "";
            txt3Motivo.Text = "";
            txt2Bautizado.Text = "";
            txt1Parroquia.Text = "";
            txt18Fecha.Text = "";
            txt17Observaciones.Text = "";
            txt16Certeza.Text = "";
            txt15Padrinos.Text = "";
            txt14ParroquiaConfir.Text = "";
            txt13Edad.Text = "";
            txt12Madre.Text = "";
            txt11Padre.Text = "";
            txt10Anio.Text = "";
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
        //boton imprimir!
        private void button1_Click(object sender, EventArgs e)
        {
            string oldFile = "C:\\Archives\\SUPLETORIA DE BAUTISMO.docx";
            string newFile = "C:\\Archives\\newFile.docx";
            using (DocX document = DocX.Load(oldFile))
            {

                document.ReplaceText("________________parroquia________________________",  txt1Parroquia.Text );
                document.ReplaceText("______________________________bautizado____________________________________",  txt2Bautizado.Text );
                document.ReplaceText("______________________motivo_______________________", txt3Motivo.Text);
                document.ReplaceText("___________________________testigo___________________________________", txt4Testigo.Text);
                document.ReplaceText("____edadtestigo____", txt5Edad.Text);
                document.ReplaceText("____________________________direcciontestigo_______________________________________________________________________", txt6Domicilio.Text);
                document.ReplaceText("_____________relacion_______________________", txt7Juramento.Text);
                document.ReplaceText("__dia__", txt8Dia.Text);
                document.ReplaceText("_______mes_________", txt9Mes.Text);
                document.ReplaceText("___________año_________________", txt10Anio.Text);
                document.ReplaceText("___________________________padre____________________________", txt11Padre.Text);
                document.ReplaceText("_____________________________madre___________________________________", txt12Madre.Text);
                document.ReplaceText("____________edad_____________", txt13Edad.Text);
                document.ReplaceText("__________________________parroquiabautizo___________________________", txt14ParroquiaConfir.Text);
                document.ReplaceText("_________________________Ppadrinos____________________________________________________________________", txt15Padrinos.Text);
                document.ReplaceText("___________________________certeza____________________________________________________________", txt16Certeza.Text);
                document.ReplaceText("________________________observaciones___________________", txt17Observaciones.Text);
                document.ReplaceText("______________________________fecha________________________", txt18Fecha.Text);
                document.ReplaceText("_________notario___________", txtNotario.Text);
                



                document.SaveAs(newFile);

            }

            var ap = new Microsoft.Office.Interop.Word.Application();
            Document doc = ap.Documents.Add(@"C:\Archives\newFile.docx");
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
