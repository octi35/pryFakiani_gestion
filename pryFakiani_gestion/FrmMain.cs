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
    public partial class FrmMain : Form
    {

        clsUsuario objUsuario;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            objUsuario = new clsUsuario();
            lblconexion.Text = objUsuario.estadoConexion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();

            string nombre = textBox1.Text;
            string contraseña = textBox2.Text;

            objUsuario.ValidarUsuario(nombre, contraseña);

            // Si la validación fue exitosa
            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                objUsuario.RegistroLogInicioSesion();

                Frmprovedores frmProveedores = new Frmprovedores(nombre); // ← Pasás el nombre al constructor
                frmProveedores.Show();

                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
