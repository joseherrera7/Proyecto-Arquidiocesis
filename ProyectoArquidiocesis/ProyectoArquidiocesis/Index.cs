using System;
using System.Windows.Forms;

namespace ProyectoArquidiocesis
{
    public partial class Index : MaterialSkin.Controls.MaterialForm
    {
        ExpedienteMatrimonial expedienteMatrimonial;
        SupletoriaBautizo supletoriaBautizo;
        SupletoriaConfirmacion supletoriaConfirmacion;
        ArchivosGuardados archivos;
        public Index()
        {
            InitializeComponent();
            expedienteMatrimonial = new ExpedienteMatrimonial();
            supletoriaBautizo = new SupletoriaBautizo();
            supletoriaConfirmacion = new SupletoriaConfirmacion();
            archivos = new ArchivosGuardados();
        }

        private void BtnSupletoriaConfirmacion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExpedienteMatrimonial_Click(object sender, EventArgs e)
        {
            if (expedienteMatrimonial.IsDisposed)
            {
                expedienteMatrimonial = new ExpedienteMatrimonial();
                expedienteMatrimonial.Show();
            }
            else
            {
                expedienteMatrimonial.Show();
                expedienteMatrimonial.Activate();
            }


        }

        private void BtnSupletoriaBautizo_Click(object sender, EventArgs e)
        {
            if (supletoriaBautizo.IsDisposed)
            {
                supletoriaBautizo = new SupletoriaBautizo();
                supletoriaBautizo.Show();
            }
            else
            {
                supletoriaBautizo.Show();
                supletoriaBautizo.Activate();
            }


        }

        private void BtnSupletoriaConfirmacion_Click_1(object sender, EventArgs e)
        {
            if (supletoriaConfirmacion.IsDisposed)
            {
                supletoriaConfirmacion = new SupletoriaConfirmacion();
                supletoriaConfirmacion.Show();
            }
            else
            {
                supletoriaConfirmacion.Show();
                supletoriaConfirmacion.Activate();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (archivos.IsDisposed)
            {
                archivos = new ArchivosGuardados();
                archivos.Show();
            }
            else
            {
                archivos.Show();
                archivos.Activate();
            }
        }
    }
}
