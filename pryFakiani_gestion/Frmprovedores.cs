using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFakiani_gestion
{
    public partial class Frmprovedores : Form
    {
        public Frmprovedores(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }

        string nombreUsuario;

        private void FrmPropiedades_Load(object sender, EventArgs e)
        {
            // Mostrar usuario y fecha/hora en el statusstrip
            lblUsuario.Text = "Usuario: " + nombreUsuario;
            lblFechaHora.Text = "Fecha/Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


            string ruta = @"../../REQUERIMIENTOS/datosProveedor.txt"; // Ajustá si es necesario

            if (System.IO.File.Exists(ruta))
            {
                DataTable dt = new DataTable();

                // Definir las columnas deseadas
                dt.Columns.Add("Nº");
                dt.Columns.Add("Entidad");
                dt.Columns.Add("APERTURA");
                dt.Columns.Add("Nº EXPTE.");
                dt.Columns.Add("JUZG.");
                dt.Columns.Add("JURISD");
                dt.Columns.Add("DIRECCION");
                dt.Columns.Add("LIQUIDADOR RESPONSABLE");

                string[] lineas = System.IO.File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    // Separar por tabulación o coma, según cómo esté tu archivo
                    string[] datos = linea.Split('\t'); // o usar .Split(',')

                    if (datos.Length == 8)
                    {
                        dt.Rows.Add(datos);
                    }
                }

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de propiedades.");
            }
        }
    }
}

