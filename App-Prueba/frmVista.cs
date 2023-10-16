using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad;
using Negocio;

namespace App_Prueba
{
    public partial class frmVista : Form
    {

        Negocio_Cliente negocio_Cliente = new Negocio_Cliente();

        public frmVista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            dvgClientes.DataSource = negocio_Cliente.VistaCliente();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            dvgClientes.DataSource = negocio_Cliente.BuscarCliente(txtBuscar.Text);
        }
    }
}
