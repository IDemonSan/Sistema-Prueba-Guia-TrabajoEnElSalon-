using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidad;

namespace App_Prueba
{
    public partial class LoginForm : Form
    {

        Entidad.Entidad_UsuarioSistema obje = new Entidad.Entidad_UsuarioSistema();
        Negocio.Negocio_UsuarioSistema objn = new Negocio.Negocio_UsuarioSistema();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Iniciar_Sesion(object sender, EventArgs e)
        {
            string nom = TxtUsuario.Text;
            string pwd = TxtContraseña.Text;

            obje.Nombre = nom;
            obje.Password = pwd;

            int usuarioValido = objn.N_Login(obje);

            switch (usuarioValido)
            {
                case -3:
                    MessageBox.Show("Usuario no encontrado");
                    this.Hide();

                    break;
                case -2:
                    MessageBox.Show("Contraseña incorrecta");
                    break;
                case 0:
                    MessageBox.Show("Usuario o contraseña incorrecta" , "Mensaje del sistema");
                    break;
                case 1:
                    MessageBox.Show("Inicio de sesión Exitoso", "Mensaje del sistema");
                    this.Hide();
                    Form vista = new frmVista();
                    vista.Show();
                    break;
            }
            
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
