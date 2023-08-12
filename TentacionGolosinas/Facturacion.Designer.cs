namespace TentacionGolosinas
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtClientes = new System.Windows.Forms.Button();
            this.BtProductos = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtColocar = new System.Windows.Forms.Button();
            this.BtFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoCliente = new LibreriaDLL.ErrorTxtBox();
            this.TxtCliente = new LibreriaDLL.ErrorTxtBox();
            this.TxtCodigoProducto = new LibreriaDLL.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new LibreriaDLL.ErrorTxtBox();
            this.TxtPrecio = new LibreriaDLL.ErrorTxtBox();
            this.TxtCantidad = new LibreriaDLL.ErrorTxtBox();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1261, 607);
            this.btnSalir.Size = new System.Drawing.Size(122, 31);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(533, 114);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(104, 32);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtClientes
            // 
            this.BtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClientes.Location = new System.Drawing.Point(714, 201);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(102, 23);
            this.BtClientes.TabIndex = 2;
            this.BtClientes.Text = "Clientes";
            this.BtClientes.UseVisualStyleBackColor = true;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // BtProductos
            // 
            this.BtProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtProductos.Location = new System.Drawing.Point(828, 201);
            this.BtProductos.Name = "BtProductos";
            this.BtProductos.Size = new System.Drawing.Size(102, 23);
            this.BtProductos.TabIndex = 3;
            this.BtProductos.Text = "Productos";
            this.BtProductos.UseVisualStyleBackColor = true;
            this.BtProductos.Click += new System.EventHandler(this.BtProductos_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.Location = new System.Drawing.Point(941, 201);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(102, 23);
            this.BtEliminar.TabIndex = 4;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtColocar
            // 
            this.BtColocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColocar.Location = new System.Drawing.Point(1055, 201);
            this.BtColocar.Name = "BtColocar";
            this.BtColocar.Size = new System.Drawing.Size(102, 23);
            this.BtColocar.TabIndex = 5;
            this.BtColocar.Text = "Colocar";
            this.BtColocar.UseVisualStyleBackColor = true;
            this.BtColocar.Click += new System.EventHandler(this.BtColocar_Click);
            // 
            // BtFacturar
            // 
            this.BtFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFacturar.Location = new System.Drawing.Point(1169, 201);
            this.BtFacturar.Name = "BtFacturar";
            this.BtFacturar.Size = new System.Drawing.Size(102, 23);
            this.BtFacturar.TabIndex = 6;
            this.BtFacturar.Text = "Facturar";
            this.BtFacturar.UseVisualStyleBackColor = true;
            this.BtFacturar.Click += new System.EventHandler(this.BtFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(158, 116);
            this.TxtCodigoCliente.Multiline = true;
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(353, 30);
            this.TxtCodigoCliente.TabIndex = 16;
            this.TxtCodigoCliente.Validar = true;
            this.TxtCodigoCliente.ValidarNumeros = false;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(158, 165);
            this.TxtCliente.Multiline = true;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(353, 27);
            this.TxtCliente.TabIndex = 17;
            this.TxtCliente.Validar = true;
            this.TxtCliente.ValidarNumeros = false;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(114, 279);
            this.TxtCodigoProducto.Multiline = true;
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(150, 28);
            this.TxtCodigoProducto.TabIndex = 18;
            this.TxtCodigoProducto.Validar = true;
            this.TxtCodigoProducto.ValidarNumeros = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(37, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 211);
            this.dataGridView1.TabIndex = 22;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 270;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 475;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 200;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(714, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 165);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BtNuevo
            // 
            this.BtNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.Location = new System.Drawing.Point(1283, 201);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(102, 23);
            this.BtNuevo.TabIndex = 24;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "Código:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 27);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cliente:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 332);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(90, 10, 90, 10);
            this.label3.Size = new System.Drawing.Size(266, 45);
            this.label3.TabIndex = 27;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 332);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(200, 10, 145, 10);
            this.label4.Size = new System.Drawing.Size(481, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 332);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.label5.Size = new System.Drawing.Size(219, 45);
            this.label5.TabIndex = 29;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(961, 332);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.label6.Size = new System.Drawing.Size(246, 45);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1153, 332);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.label7.Size = new System.Drawing.Size(230, 45);
            this.label7.TabIndex = 31;
            this.label7.Text = "Importe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(951, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(417, 264);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(171, 55);
            this.TxtDescripcion.TabIndex = 33;
            this.TxtDescripcion.Validar = true;
            this.TxtDescripcion.ValidarNumeros = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(733, 279);
            this.TxtPrecio.Multiline = true;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(141, 28);
            this.TxtPrecio.TabIndex = 34;
            this.TxtPrecio.Validar = true;
            this.TxtPrecio.ValidarNumeros = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(1029, 279);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(150, 28);
            this.TxtCantidad.TabIndex = 35;
            this.TxtCantidad.Validar = true;
            this.TxtCantidad.ValidarNumeros = false;
            // 
            // lbVendedor
            // 
            this.lbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendedor.Location = new System.Drawing.Point(158, 67);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(353, 31);
            this.lbVendedor.TabIndex = 36;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(1016, 615);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(100, 23);
            this.lbTotal.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(41, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ingresa datos del artículo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(51, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Código:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(317, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Descripción:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(671, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Precio:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(950, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Cantidad:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TentacionGolosinas.Properties.Resources.fondo9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 659);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtFacturar);
            this.Controls.Add(this.BtColocar);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtProductos);
            this.Controls.Add(this.BtClientes);
            this.Controls.Add(this.BtBuscar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.BtBuscar, 0);
            this.Controls.SetChildIndex(this.BtClientes, 0);
            this.Controls.SetChildIndex(this.BtProductos, 0);
            this.Controls.SetChildIndex(this.BtEliminar, 0);
            this.Controls.SetChildIndex(this.BtColocar, 0);
            this.Controls.SetChildIndex(this.BtFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtCodigoCliente, 0);
            this.Controls.SetChildIndex(this.TxtCliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.TxtPrecio, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.Controls.SetChildIndex(this.lbVendedor, 0);
            this.Controls.SetChildIndex(this.lbTotal, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button BtProductos;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtColocar;
        private System.Windows.Forms.Button BtFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LibreriaDLL.ErrorTxtBox TxtCodigoCliente;
        private LibreriaDLL.ErrorTxtBox TxtCliente;
        private LibreriaDLL.ErrorTxtBox TxtCodigoProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private LibreriaDLL.ErrorTxtBox TxtDescripcion;
        private LibreriaDLL.ErrorTxtBox TxtPrecio;
        private LibreriaDLL.ErrorTxtBox TxtCantidad;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}