using System;
using System.Windows.Forms;

namespace ProyectoArquidiocesis
{
    public partial class Index : MaterialSkin.Controls.MaterialForm
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnSupletoriaConfirmacion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExpedienteMatrimonial_Click(object sender, EventArgs e)
        {
            ExpedienteMatrimonial expedienteMatrimonial = new ExpedienteMatrimonial();
            expedienteMatrimonial.Show();
            
        }

        private void BtnSupletoriaBautizo_Click(object sender, EventArgs e)
        {
            SupletoriaBautizo supletoriaBautizo = new SupletoriaBautizo();
            supletoriaBautizo.Show();
        }

        private void BtnSupletoriaConfirmacion_Click_1(object sender, EventArgs e)
        {
            SupletoriaConfirmacion supletoriaConfirmacion = new SupletoriaConfirmacion();
            supletoriaConfirmacion.Show();
        }
    }
}
