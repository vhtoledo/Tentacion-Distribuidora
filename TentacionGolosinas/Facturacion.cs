using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace TentacionGolosinas
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string vendedor = "SELECT * FROM Usuarios WHERE id_usuario = " + Login.Codigo;

            DataSet ds;

            ds = Biblioteca.Herramientas(vendedor);

            lbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("SELECT Nombre_cliente FROM Clientes WHERE id_clientes = '{0}'", TxtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    TxtCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    TxtCodigoProducto.Focus();
                }
            }
            catch (Exception error) 
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
    }
}
