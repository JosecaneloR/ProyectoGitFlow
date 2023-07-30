using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeNegocio;

namespace Sistema_de_Inventario
{
    public partial class ConsultarProductos : Form
    {
        Negocio con = new Negocio();
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            TablaProductos.DataSource = con.consultaCN();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Inventario form = new Inventario();
            form.Show();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            TablaProductos.DataSource = con.consultaParametroCN(Filtro.Text, Parametro.Text);
        }
    }
}
