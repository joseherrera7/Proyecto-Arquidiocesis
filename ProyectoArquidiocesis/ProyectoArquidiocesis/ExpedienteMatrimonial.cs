using MySql.Data.MySqlClient;
using ProyectoArquidiocesis.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace ProyectoArquidiocesis
{
    public partial class ExpedienteMatrimonial : MaterialSkin.Controls.MaterialForm
    {

        public string newFile;
        public bool impresion = false;

        public ExpedienteMatrimonial()
        {
            InitializeComponent();
            
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

                String script = "SELECT COUNT(id) FROM MATRIMONIO;";

                MySqlCommand comando = new MySqlCommand(script, conectar);

                try
                {
                    string contador = (comando.ExecuteScalar()).ToString();
                    int cont = Int32.Parse(contador) + 1;

                    if (cont < 10)
                    {
                        lblCodigoB.Text = "M000000" + cont;
                    }
                    else if (cont < 100)
                    {
                        lblCodigoB.Text = "M00000" + cont;
                    }
                    else if (cont < 1000)
                    {
                        lblCodigoB.Text = "M0000" + cont;
                    }
                    else if (cont < 10000)
                    {
                        lblCodigoB.Text = "M000" + cont;
                    }
                    else if (cont < 100000)
                    {
                        lblCodigoB.Text = "M00" + cont;
                    }
                    else if (cont < 1000000)
                    {
                        lblCodigoB.Text = "M0" + cont;
                    }
                    else if (cont < 10000000)
                    {
                        lblCodigoB.Text = "M" + cont;
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

        private void ExpedienteMatrimonial_Load(object sender, EventArgs e)
        {
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnimprimirDoc_Click(object sender, EventArgs e)
        {
            string oldFile = "C:\\Archives\\EXPEDIENTE MATRIMONIAL FORMATO 2.docx";
            newFile = "C:\\Archives\\Matrimonio - "+lblCodigoB.Text+".docx";
            using (DocX document = DocX.Load(oldFile))
            {
                
                document.ReplaceText("___________NombreNovio___________", "  "+NombreNovio.Text+ "  ");
                document.ReplaceText("___________NombreNovia___________ ", "  " + NombreNovia.Text + "  ");

                document.ReplaceText("___________NombreNotario___________", "  " + txtNotario.Text + "  ");
                

                //datos del novio
                document.ReplaceText("___nombrenovio __________________________________________________________________", NombreCompletoNovio.Text);
                document.ReplaceText("______DPI_______", DpiPasaporteNovio.Text);
                document.ReplaceText("_______Nacionalidad________",NacionalidadNovio.Text);
                document.ReplaceText("__ / __ / _____", dateTimePicker1.Text);
                document.ReplaceText("__edad__", EdadNovio.Text);
                document.ReplaceText("_estadocivil_", EstadoCivilNovio.Text);
                document.ReplaceText("___telefono____", TelefonoNovio.Text);
                document.ReplaceText("____nombre de papanovio________________", "  " + NombrePadreNovio.Text + "  ");
                document.ReplaceText("_________Nombre de mamanovio____________", "  " + NombreMadreNovio.Text + "  ");
                document.ReplaceText("____________________________direccion________novio______________________________", DireccionNovio.Text);
                document.ReplaceText("__________prefesionnovio__________", ProfesionOcupacionNovio.Text);
                document.ReplaceText("_________religionnovio_________", ReligionNovio.Text);
                document.ReplaceText("___tiempodeconocernovia___",TiempoDeConocerPretendida.Text);
                document.ReplaceText("___tiempocompromiso____", TiempoDeCompromisoNovio.Text);
                document.ReplaceText("__frecuentepracticanovio__", FrecuenciaPracticaReligion.Text);
                document.ReplaceText("____parentesconovio____", TieneParentescoConComprometida.Text );
                document.ReplaceText("__OrdenSacerdotalNovio__",TieneVotoDePerpetuaCastidadNovio.Text );
                document.ReplaceText("_____MatrimoniosPreviosNovio_______",  MatrimoniosPreviosNovio.Text );
                document.ReplaceText("__TipoMatrimonio_____", TipoDeMatrimonioNovio.Text);
                document.ReplaceText("________Sentenciadeseparacion_____________________________________________________________________________________________________",  FechaLugarRegistroDeSentenciaNovio.Text);
                document.ReplaceText("__HijospreviosNovio_", TieneHijosPreviosNovio.Text);
                document.ReplaceText("____________ComoCumplelasObligacionesNovio______________________________________",  ComoEstaCumpliendoSusObligacionesHijosNovio.Text);
                document.ReplaceText("_TratamientoDrogasNovio_",  TieneAlgunaAdiccionNovio.Text);
                document.ReplaceText("__________Explicaciontratamientodrogas_____________________",  ExplicacionAdiccionNovio.Text);
                document.ReplaceText("____ConsentimientoNovio___",  AceptaElMatrimonioConLibertadNovio.Text);
                document.ReplaceText("__IndisolubleNovio____", AceptaElMatrimonioEsIndisolubleNovio.Text);
                document.ReplaceText("___________NombreNovia___________", NombreNovio.Text);
                document.ReplaceText("__FidelidadNovio__", AceptaFidelidadAContuyeNovio.Text);
                document.ReplaceText("___AbiertaProcreacionNovio______________", AceptaElMatrimonioAbiertoAProcrearNovio.Text);
                document.ReplaceText("_______CapacitadoNovio______________", ExplicacionDeObligacionesMatrimonioNovio.Text);
                
                document.ReplaceText("__________ParroquiaBautismoNovio______",  ParroquiaBautismoNovio.Text);
                document.ReplaceText("_LibroBautismoNovio__", LibroBautismoNovio.Text);
                document.ReplaceText("__FoliobautismoNovio__", FolioBautismoNovio.Text);
                document.ReplaceText("___PartidaBautismoNovio_", PartidaBautismoNovio.Text);
                document.ReplaceText("___________ParroquiaConfirmacionNovio________", ParroquiaConfirmacionNovio.Text);
                document.ReplaceText("__LibroCOnfirmacionNovio_", LibroConfirmacionNovio.Text);
                document.ReplaceText("_FolioCOnfirmacionNovio_", FolioConfirmacionNovio.Text);
                document.ReplaceText("_PartidaConfirmacionNovio	_", PartidaConfirmacionNovio.Text);
                document.ReplaceText("______FeligresNovio_______________________________________", FeligresNovio.Text);
                document.ReplaceText("______________AsisteParroquiaNovio________________________", ParroquiaQueAsisteNovio.Text);
                document.ReplaceText("__CompletoIniciacionNovio__", CompletoLaIniciacionCristianaNovio.Text);
                document.ReplaceText("__CompletoOportunamenteNovio___", AceptoLaIniciacionCristianaNovio.Text);


                //datos de la novia
                document.ReplaceText("_________nombrenovia_____________________________________________________", NombreCompletoNovia.Text);
                document.ReplaceText("____dpiNovia_____", DPIPasaporteNovia.Text);
                document.ReplaceText("___nacionalidadnovia_______", NacionalidadNovia.Text);
                document.ReplaceText("__ / __ / __novia___", FechaDeNacimientoNovia.Text);
                document.ReplaceText("_edadnovia__", EdadNovia.Text);
                document.ReplaceText("__estadocivilnovia_", EstadoCivilNovia.Text);
                document.ReplaceText("__telefononovia_", TelefonoNovia.Text);
                document.ReplaceText("________padrenovia_________", "   "+NombrePadreNovia.Text+ "   ");
                document.ReplaceText("____________________madrenovia____________", "   " + NombreMadreNovia.Text+"   ");
                document.ReplaceText("_________________direccionnovia_____________________________________", DireccionNovia.Text);
                document.ReplaceText("_______profesionnovia__________", ProfesionNovia.Text);
                document.ReplaceText("________religionnovia__________", ReligionNovia.Text);
                document.ReplaceText("___tiempoconocerNovia___", TiempoDeConocerPRetendienteNovia.Text);
                document.ReplaceText("___tiempocompromisonovia__", TiempoDeCompromisoNovia.Text);
                document.ReplaceText("_frecuenciaReligionnovia__", FrecuenciaPracticaDeReligionNovia.Text);
                document.ReplaceText("__relacionnovia___", TieneAlgunParentesctoConSuPrometidoNovia.Text);
                document.ReplaceText("__ordensacerdotalnovia__", RecibioOrdenSacerdotalNovia.Text);
                document.ReplaceText("__matrimoniosnovia___", MatrimoniosPreviosNovia.Text);
                document.ReplaceText("__tipomatrimonionovia_", TipoDeMatrimonioPrevioNovia.Text);
                document.ReplaceText("__________________Razondivorcio________________________________________________________________________________", LugarFechaRegistroDeSentenciaNovia.Text);
                document.ReplaceText("__hijospreviosnovia__ ", HijosPreviosAlMatrimonioNovia.Text);
                document.ReplaceText("_______________obliaacioneshijsnovia_________________________________________", ComoEstaCumpliendoPbligacionesHijosNovia.Text);

                document.ReplaceText("_recibiotratamientodrogasnobia_", RecibioTratamientosNovia.Text);
                document.ReplaceText("________________explicaciontratamientonovia_________________", ExplicacionTratamientosNovia.Text);
                document.ReplaceText("___librematrimonionovia___", DaCOnsetimientoConLibertadAlMatrimonioNovia.Text);
                document.ReplaceText("____indisolublenovia___", ElMAtrimonioEsIndisolubleNovia.Text);
                document.ReplaceText("_fidelidadnovia__", FidelidadASuEsposoNovia.Text);
                document.ReplaceText("____procreacionnovia______", AbiertoAProcrearNovia.Text);
                document.ReplaceText("________obligacionesnovia___________", ComoHaLLegadoACOnocerLasObligacionesNovia.Text);
                document.ReplaceText("__________ParroquiaBautismoNovia______", PArroquiaBautismoNovia.Text);
                document.ReplaceText("_LibroBautismoNovia__", LibroBautismoNovia.Text);
                document.ReplaceText("__FoliobautismoNovia__", FolioBautismoNovia.Text);
                document.ReplaceText("___PartidaBautismoNovia_", PartidaBautismoNovia.Text);
                document.ReplaceText("___________ParroquiaConfirmacionNovia________", ParroquiaConfirmacionNovia.Text);
                document.ReplaceText("__LibroCOnfirmacionNovia_", LibroConfirmacionNovia.Text);
                document.ReplaceText("_FolioCOnfirmacionNovia_", FolioConfirmacionNovia.Text);
                document.ReplaceText("_PartidaConfirmacionNovia_", PartidaConfirmacionNovia.Text);
                document.ReplaceText("______FeligresNovia_______________________________________", FeligresNovia.Text);
                document.ReplaceText("______________AsisteParroquiaNovia________________________", ParroquiaNovia.Text);
                document.ReplaceText("__CompletoIniciacionNovia__", CompletoIniciacionCristianaNovia.Text);
                document.ReplaceText("__CompletoOportunamenteNovia___", CompletoOportunamenteIniciacionCristianaNovia.Text);

                //TESTIGOS
                document.ReplaceText("______nombretestigo1_________", NombreTestigo.Text);
                document.ReplaceText("_dpitestigo1_", DPITestigo.Text);
                document.ReplaceText("____nacionalidadtestigo1__", NacionalidadTestigo.Text);
                document.ReplaceText("___direcciontetigo1___", DomicilioTestigo.Text);
                document.ReplaceText("_edadtestigo1_", EdadTestigo.Text);
                document.ReplaceText("__telefonotestigo1__", TelefonoTestigo.Text);
                document.ReplaceText("_profesiontestio1_", ProfesionTestigo.Text);
                document.ReplaceText("_tiempotestiigo11_", TiempoDeConocerAlContrayente.Text);
                document.ReplaceText("___razonestestigo1______", RazonesDeConocerAlCOntrayente.Text);
                document.ReplaceText("_tiempotestigo12__", TiempoDeConocerAlContrayente2.Text);
                document.ReplaceText("___razonestestigo12______", RazonesDeConocerAlCOntrayente2.Text);
                document.ReplaceText("__________nombretestigo2_________", NombreTestigo2.Text);
                document.ReplaceText("_dpitestigo2___", DPITestigo2.Text);
                document.ReplaceText("____nacionalidadtestigo2__", NacionalidadTestigo2.Text);
                document.ReplaceText("__direcciontestigo2__", DomilicioTestigo2.Text);
                document.ReplaceText("_edadtestigo2_", EdadTestigo2.Text);
                document.ReplaceText("__telefonotestigo2_", TelefonoTestigo2.Text);
                document.ReplaceText("__profesiontestigo2__", ProfesionTestigo2.Text);
                document.ReplaceText("_tiempotestiigo21_", TiempoConocerCOntrayente3.Text);
                document.ReplaceText("___razonestestigo21______", RazonesCOnocerContrayente3.Text);
                document.ReplaceText("_tiempotestiigo22_", TiempoCOnocerCOntrayente4.Text);
                document.ReplaceText("___razonestestigo22______", RazonesConocerContrayente4.Text);



                document.SaveAs(newFile);
                impresion = true;
            }

        }

        private void materialSingleLineTextField11_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void FolioConfirmacionNovio_Click(object sender, EventArgs e)
        {





















        }

        private void AceptoLaIniciacionCristianaNovio_Click(object sender, EventArgs e)
        {

        }

        private void LibroBautismoNovio_Click(object sender, EventArgs e)
        {

        }

        private void ParroquiaConfirmacionNovio_Click(object sender, EventArgs e)
        {

        }

        private void FolioBautismoNovio_Click(object sender, EventArgs e)
        {

        }

        private void PartidaBautismoNovio_Click(object sender, EventArgs e)
        {

        }

        private void ParroquiaQueAsisteNovio_Click(object sender, EventArgs e)
        {

        }

        private void CompletoLaIniciacionCristianaNovio_Click(object sender, EventArgs e)
        {

        }

        private void LibroConfirmacionNovio_Click(object sender, EventArgs e)
        {

        }

        private void FeligresNovio_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField28_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SautinSoft.PdfMetamorphosis p = new SautinSoft.PdfMetamorphosis();



            if (p != null)
            {
                string docxPath = @"C:\Archives\Matrimonio - " + lblCodigoB.Text + ".docx";
                string pdfPath = Path.ChangeExtension(docxPath, ".pdf");


                // 2. Convert DOCX file to PDF file 
                if (p.DocxToPdfConvertFile(docxPath, pdfPath) == 0)
                    System.Diagnostics.Process.Start(pdfPath);
                else
                {
                    MessageBox.Show("Conversion failed!");
                }
            }
            if (impresion)
            {
                try
                {
                    DateTime today = DateTime.Today;
                    //obtener los datos
                    string id = lblCodigoB.Text;
                    string fecha = today.ToString("d");
                    string notario = txtNotario.Text;
                    string novio = NombreCompletoNovio.Text;
                    string novia = NombreCompletoNovia.Text;
                    string urldoc = newFile;

                    //Crear objeto tipo ConsultaSQL
                    ConsultaSQL insercion = new ConsultaSQL();

                    if (this.Controls.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>().Any(t => string.IsNullOrEmpty(t.Text)))
                    {
                        MessageBox.Show(null, "Faltan campos por completar", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        insercion.NuevoMatrimonio(id, fecha, notario, novio, novia, urldoc);
                        MessageBox.Show(null, "Expediente Matrimonial creado exitosamente", "Expediente Matrimonial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReLoad();
                        ClearTextBoxes();
                    }
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Debe Imprimir previo a guardar definitivamente.", "Guardar Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //id, fecha, notario, confirmado, url doc, hashcode.
 
        }
            private void ClearTextBoxes()
            {
                Action<Control.ControlCollection> func = null;
            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is MaterialSkin.Controls.MaterialSingleLineTextField)
                            (control as MaterialSkin.Controls.MaterialSingleLineTextField).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }
        
           
 
    }
}
