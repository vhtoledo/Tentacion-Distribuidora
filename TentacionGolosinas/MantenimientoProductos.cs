﻿using System;
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
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
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
                string eliminar = string.Format("EXEC EliminarProductos '{0}'", textId_Producto.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("Producto Eliminado correctamente");

            }
            catch(Exception error) 
            {
                MessageBox.Show("Ha ocurrido un error: " + error);

            }

        }

        private void textId_Producto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textId_Producto.Text.Trim()) == false && string.IsNullOrEmpty(textDesc_Producto.Text.Trim()) == false && string.IsNullOrEmpty(textPre_Producto.Text.Trim()) == false)
            {
                textId_Producto.Text = "";
                textDesc_Producto.Text = "";
                textPre_Producto.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConsulPro = new ConsultarProductos();
            ConsulPro.Show();
        }
    }
}
