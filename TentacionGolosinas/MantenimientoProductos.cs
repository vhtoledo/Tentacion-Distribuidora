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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            try
            {
                string insertar = string.Format("EXEC ActualizarProductos '{0}', '{1}', '{2}'", textId_Producto.Text.Trim(), textDesc_Producto.Text.Trim(), textPre_Producto.Text.Trim());
                Biblioteca.Herramientas(insertar);
                MessageBox.Show("Producto guardado correctamente");
                return true;
            }
            catch (Exception error) 
            {
                MessageBox.Show("Ha ocurrido un error: " +error);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarProductos '{0}'", textId_Producto.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("Producto Eliminado correctamente");

            }
            catch(Exception error) 
            {
                MessageBox.Show("Ha ocurrido un error: " + error);

            }

        }
    }
}
