using ProyectoArquidiocesis.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    insercion.NuevaConfirmacion(fecha, notario, confirmado, urldoc, hashcode);
                    MessageBox.Show(null, "Supletoria de Confirmación creada exitosamente", "Supletoria Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
