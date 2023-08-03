﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentacionGolosinas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Tentacion;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("Conexión exitosa");
            }
            catch(Exception error) 
            {
                MessageBox.Show("Ha ocurrido un error. Intente nuevamente " + error.Message);
            }

        }
    }
}
