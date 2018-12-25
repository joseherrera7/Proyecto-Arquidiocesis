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

    public partial class SupletoriaBautizo : MaterialSkin.Controls.MaterialForm
    {
       

        public SupletoriaBautizo()
        {
            InitializeComponent();
            //txt1Parroquia.Scale.AutoScaleMode = 0;
            
            this.AutoScaleMode = 0;
           
        }

        private void SupletoriaBautizo_Load(object sender, EventArgs e)
        {
            
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

                    insercion.NuevoBautismo(fecha, notario, confirmado, urldoc, hashcode);
                    MessageBox.Show(null, "Supletoria de Bautismo creada exitosamente", "Supletoria Bautismo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
