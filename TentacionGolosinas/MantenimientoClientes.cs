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
            if(Biblioteca.ValidarFormulario(this, errorProvider1) == false)
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
            else
            {
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

        private void textId_Cliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId_Cliente.Text.Trim()) == false && string.IsNullOrEmpty(textNombre.Text.Trim()) == false && string.IsNullOrEmpty(textApellido.Text.Trim()) == false && string.IsNullOrEmpty(textTel.Text.Trim()) == false && string.IsNullOrEmpty(textEmail.Text.Trim()) == false)
            {
                textId_Cliente.Text = "";
                textNombre.Text = "";
                textApellido.Text = "";
                textTel.Text = "";
                textEmail.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarCliente ConsulClien = new ConsultarCliente();
            ConsulClien.Show();
        }
    }
}
