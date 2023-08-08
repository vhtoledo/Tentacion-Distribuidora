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
    public partial class MantenimientoClientes : Mantenimiento 
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            try
            {
                string insertar = string.Format("EXEC ActualizarClientes '{0}', '{1}', '{2}', '{3}', '{4}'", textId_Cliente.Text.Trim(), textNombre.Text.Trim(), textApellido.Text.Trim(), textTel.Text.Trim(), textEmail.Text.Trim());
                Biblioteca.Herramientas(insertar);
                MessageBox.Show("Cliente guardado correctamente");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarClientes '{0}'", textId_Cliente.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("Cliente Eliminado correctamente");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);

            }

        }
    }
}
