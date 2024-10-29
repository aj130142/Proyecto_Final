namespace proyecto_final2
{
    partial class Gestion_porductos
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantida = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtdeleteId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdeleteNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdeleteCodigo = new System.Windows.Forms.TextBox();
            this.ventasDataSet1 = new proyecto_final2.ventasDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductoTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCantida
            // 
            this.txtCantida.Location = new System.Drawing.Point(183, 143);
            this.txtCantida.Name = "txtCantida";
            this.txtCantida.Size = new System.Drawing.Size(189, 22);
            this.txtCantida.TabIndex = 2;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(183, 236);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(189, 22);
            this.txtCategoria.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(183, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(153, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Ingresar Producto";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(541, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtdeleteId
            // 
            this.txtdeleteId.Location = new System.Drawing.Point(541, 242);
            this.txtdeleteId.Name = "txtdeleteId";
            this.txtdeleteId.Size = new System.Drawing.Size(86, 22);
            this.txtdeleteId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agrega id para ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Eliminar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Actualizar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Agrega id para ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(541, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 22);
            this.textBox2.TabIndex = 17;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(541, 158);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 18;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(183, 294);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 22);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(183, 182);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(189, 22);
            this.txtPrecio.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(488, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 22);
            this.textBox3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            // 
            // txtdeleteNombre
            // 
            this.txtdeleteNombre.Location = new System.Drawing.Point(488, 294);
            this.txtdeleteNombre.Name = "txtdeleteNombre";
            this.txtdeleteNombre.Size = new System.Drawing.Size(189, 22);
            this.txtdeleteNombre.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Codigo";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtdeleteCodigo
            // 
            this.txtdeleteCodigo.Location = new System.Drawing.Point(488, 336);
            this.txtdeleteCodigo.Name = "txtdeleteCodigo";
            this.txtdeleteCodigo.Size = new System.Drawing.Size(189, 22);
            this.txtdeleteCodigo.TabIndex = 29;
            // 
            // ventasDataSet1
            // 
            this.ventasDataSet1.DataSetName = "ventasDataSet";
            this.ventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbProducto";
            this.bindingSource1.DataSource = this.ventasDataSet1;
            // 
            // tbProductoTableAdapter
            // 
            this.tbProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Gestion_porductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 427);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtdeleteCodigo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdeleteNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdeleteId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCantida);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Gestion_porductos";
            this.Text = "Gestionar productos";
            this.Load += new System.EventHandler(this.Gestion_porductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantida;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtdeleteId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btActualizar;
        private ventasDataSet ventasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdeleteNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdeleteCodigo;
    }
}