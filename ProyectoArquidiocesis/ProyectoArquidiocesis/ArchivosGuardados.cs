using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArquidiocesis
{
    public partial class ArchivosGuardados : MaterialSkin.Controls.MaterialForm
    {
        bool matrimonio = false;
        bool confirmacion = false;
        bool bautismo = false;
        public ArchivosGuardados()
        {
            InitializeComponent();
        }

        private void ArchivosGuardados_Load(object sender, EventArgs e)
        {
            matrimonio = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Notario");
            comboBox1.Items.Add("Fecha");
            comboBox1.Items.Add("Novio");
            comboBox1.Items.Add("Novia");
            MySqlConnection conectar = Conexion.getConexion();


            try
            {

                //Abrir conexion
                //conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand("select id as 'Identificador', fecha as 'Fecha', " +
                    "notario as 'Notario Eclesiástico', novio as 'Novio', novia as 'Novia' from matrimonio;", conectar);

                conectar.Open();
                DataTable datos = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(datos);

                dataGridView1.DataSource = datos;
                //dataGridView1.DataBind();


                conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        private void btnMatrimonio_Click(object sender, EventArgs e)
        {
            matrimonio = true;
            bautismo = false;
            confirmacion = false;
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Notario");
            comboBox1.Items.Add("Fecha");
            comboBox1.Items.Add("Novio");
            comboBox1.Items.Add("Novia");

            MySqlConnection conectar = Conexion.getConexion();


            try
            {

                //Abrir conexion
                //conectar.Open();


                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand("select id as 'Identificador', fecha as 'Fecha', " +
                    "notario as 'Notario Eclesiástico', novio as 'Novio', novia as 'Novia' from matrimonio;", conectar);

                conectar.Open();
                DataTable datos = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(datos);

                dataGridView1.DataSource = datos;
                //dataGridView1.DataBind();


                conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        private void btnConfirmacion_Click(object sender, EventArgs e)
        {
            matrimonio = false;
            bautismo = false;
            confirmacion = true;
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Notario");
            comboBox1.Items.Add("Fecha");
            comboBox1.Items.Add("Confirmado");

            MySqlConnection conectar = Conexion.getConexion();


            try
            {

                //Abrir conexion
                //conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand("select id as 'Identificador', fecha as 'Fecha', " +
                    "notario as 'Notario Eclesiástico', confirmado as 'Confirmado' from confirmacion;", conectar);

                conectar.Open();
                DataTable datos = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(datos);

                dataGridView1.DataSource = datos;
                //dataGridView1.DataBind();


                conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        private void btnBautismo_Click(object sender, EventArgs e)
        {
            matrimonio = false;
            bautismo = true;
            confirmacion = false;
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Notario");
            comboBox1.Items.Add("Fecha");
            comboBox1.Items.Add("Bautizado");

            MySqlConnection conectar = Conexion.getConexion();


            try
            {

                //Abrir conexion
                //conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand("select id as 'Identificador', fecha as 'Fecha'," +
                    " notario as 'Notario Eclesiástico', bautizado as 'Bautizado' from bautismo;", conectar);

                conectar.Open();
                DataTable datos = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(datos);

                dataGridView1.DataSource = datos;
                //dataGridView1.DataBind();


                conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = Conexion.getConexion();
            string buscar = txtBuscar.Text;
            string elemento = comboBox1.Text.ToLower();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT id as 'Identificador', fecha as 'Fecha', " +
                    "notario as 'Notario Eclesiástico', novio as 'Novio', novia as 'Novia' FROM MATRIMONIO", conectar);
                //crear objeto de tipo MySqlCommand
                if (matrimonio == true)
                {
                    comando.CommandText = "SELECT id as 'Identificador', fecha as 'Fecha'," +
                        " notario as 'Notario Eclesiástico', novio as 'Novio', novia as 'Novia' " +
                        "FROM MATRIMONIO WHERE " + elemento + " = '"+buscar+"';";
                }
                else if (bautismo == true)
                {
                    comando.CommandText = "SELECT id as 'Identificador', fecha as 'Fecha', " +
                        "notario as 'Notario Eclesiástico', bautizado as 'Bautizado' " +
                        "FROM BAUTISMO WHERE " + elemento + " = '" + buscar + "';";

                }
                else if (confirmacion == true)
                {
                    comando.CommandText = "SELECT id as 'Identificador', fecha as 'Fecha', " +
                        " notario as 'Notario Eclesiástico', confirmado as 'Confirmado' " +
                        "FROM CONFIRMACION WHERE " + elemento + " = '" + buscar + "';";
                }

                //MySqlCommand comando = new MySqlCommand("SELECT * FROM BAUTISMO", conectar);

                conectar.Open();
                DataTable datos = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(datos);

                dataGridView1.DataSource = datos;
                //dataGridView1.DataBind();


                conectar.Close();
                txtBuscar.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        private void bntAbrir_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = Conexion.getConexion();
            string id = txtAbrir.Text;
            //Abrir conexion
            conectar.Open();

            //crear objeto de tipo MySqlCommand
            string script = "";

            if (matrimonio == true)
            {
                 script = "select urlDoc from matrimonio where id = '" + id + "'";
            }
            if (bautismo == true)
            {
                 script = "select urlDoc from bautismo where id = '" + id + "'";
            }
            if (confirmacion == true) {
                 script = "select urlDoc from confirmacion where id = '" + id + "'";

            }



            MySqlCommand comando = new MySqlCommand(script, conectar);

            try
            {
                string url = (comando.ExecuteScalar()).ToString();
                if (url != "")
                {
                    Process.Start(url);
                    txtAbrir.Text = "";
                }
                else
                {
                    MessageBox.Show("Dato inválido, verificar si el ID es correcto", "Abrir Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conectar.Close();

            }
            catch
            {
                MessageBox.Show("Dato inválido, verificar si el ID es correcto", "Abrir Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conectar.Close();
            }

        }
    }
}

