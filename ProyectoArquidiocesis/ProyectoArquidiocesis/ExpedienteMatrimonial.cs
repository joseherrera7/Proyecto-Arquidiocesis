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

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoArquidiocesis
{
    public partial class ExpedienteMatrimonial : MaterialSkin.Controls.MaterialForm
    {
        

        public ExpedienteMatrimonial()
        {
            InitializeComponent();
            
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
           
                string oldFile = "C:\\Users\\jcher\\Documents\\Projects\\Proyecto-Arquidiocesis\\ProyectoArquidiocesis\\ProyectoArquidiocesis\\SUPLETORIA DE CONFIRMACIÓN.pdf";
                string newFile = "C:\\Users\\jcher\\Documents\\Projects\\Proyecto-Arquidiocesis\\ProyectoArquidiocesis\\ProyectoArquidiocesis\\newFile.pdf";
                PdfReader reader = new PdfReader(oldFile);
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                Document document = new Document(size);

                // open the writer
                FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // the pdf content
                PdfContentByte cb = writer.DirectContent;

                // select the font properties
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetColorFill(BaseColor.DARK_GRAY);
                cb.SetFontAndSize(bf, 8);
                cb.BeginText();

                // put the alignment and coordinates here
                cb.ShowTextAligned(1, NombreCompletoNovio.Text, 520, 640, 0);
                cb.EndText();
                PdfImportedPage page = writer.GetImportedPage(reader, 1);
                cb.AddTemplate(page, 0, 0);

            // close the streams and voilá the file should be changed :)
                document.Close();
                fs.Close();
                writer.Close();
                reader.Close();
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
    }
}
