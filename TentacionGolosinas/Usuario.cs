﻿using LibreriaDLL;
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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios Where id_usuario=" + Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta);

            lNombre.Text = Data.Tables[0].Rows[0]["username"].ToString();
            lUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            lUserCodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = Data.Tables[0].Rows[0]["imagen"].ToString();
            pictureBox1.Image = Image.FromFile(imagen);
        }
    }
}
