namespace proyecto_final2
{
    partial class Gestion_productos
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtactuCodigo = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtActuNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdeleteNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdeleteCodigo = new System.Windows.Forms.TextBox();
            this.ventasDataSet1 = new proyecto_final2.ventasDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductoTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantida = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ActulizarPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtactuDescrip = new System.Windows.Forms.TextBox();
            this.txtactuCategoria = new System.Windows.Forms.TextBox();
            this.txtactuPrecio = new System.Windows.Forms.TextBox();
            this.eliminiPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.insertarPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.ActulizarPanel.SuspendLayout();
            this.eliminiPanel.SuspendLayout();
            this.insertarPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(177, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(177, 252);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(189, 22);
            this.txtCategoria.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 362);
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
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(182, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Actualizar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Agrega codigo para ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtactuCodigo
            // 
            this.txtactuCodigo.Location = new System.Drawing.Point(147, 36);
            this.txtactuCodigo.Name = "txtactuCodigo";
            this.txtactuCodigo.Size = new System.Drawing.Size(86, 22);
            this.txtactuCodigo.TabIndex = 17;
            this.txtactuCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtactuCodigo_KeyUp);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(147, 294);
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
            this.label10.Location = new System.Drawing.Point(22, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(177, 299);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 22);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(177, 195);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(189, 22);
            this.txtPrecio.TabIndex = 24;
            // 
            // txtActuNombre
            // 
            this.txtActuNombre.Location = new System.Drawing.Point(94, 80);
            this.txtActuNombre.Name = "txtActuNombre";
            this.txtActuNombre.Size = new System.Drawing.Size(231, 22);
            this.txtActuNombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            // 
            // txtdeleteNombre
            // 
            this.txtdeleteNombre.Location = new System.Drawing.Point(129, 49);
            this.txtdeleteNombre.Name = "txtdeleteNombre";
            this.txtdeleteNombre.Size = new System.Drawing.Size(234, 22);
            this.txtdeleteNombre.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Codigo";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtdeleteCodigo
            // 
            this.txtdeleteCodigo.Location = new System.Drawing.Point(129, 91);
            this.txtdeleteCodigo.Name = "txtdeleteCodigo";
            this.txtdeleteCodigo.Size = new System.Drawing.Size(234, 22);
            this.txtdeleteCodigo.TabIndex = 29;
            this.txtdeleteCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdeleteCodigo_KeyUp);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // txtCantida
            // 
            this.txtCantida.Location = new System.Drawing.Point(177, 153);
            this.txtCantida.Name = "txtCantida";
            this.txtCantida.Size = new System.Drawing.Size(189, 22);
            this.txtCantida.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Coloque coma, no punto decimal";
            // 
            // ActulizarPanel
            // 
            this.ActulizarPanel.Controls.Add(this.label17);
            this.ActulizarPanel.Controls.Add(this.label16);
            this.ActulizarPanel.Controls.Add(this.label15);
            this.ActulizarPanel.Controls.Add(this.txtactuDescrip);
            this.ActulizarPanel.Controls.Add(this.txtactuCategoria);
            this.ActulizarPanel.Controls.Add(this.txtactuPrecio);
            this.ActulizarPanel.Controls.Add(this.label9);
            this.ActulizarPanel.Controls.Add(this.txtactuCodigo);
            this.ActulizarPanel.Controls.Add(this.btActualizar);
            this.ActulizarPanel.Controls.Add(this.txtActuNombre);
            this.ActulizarPanel.Controls.Add(this.label2);
            this.ActulizarPanel.Controls.Add(this.label8);
            this.ActulizarPanel.Location = new System.Drawing.Point(12, 41);
            this.ActulizarPanel.Name = "ActulizarPanel";
            this.ActulizarPanel.Size = new System.Drawing.Size(359, 346);
            this.ActulizarPanel.TabIndex = 32;
            this.ActulizarPanel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Descripcion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Categoria";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Precio";
            // 
            // txtactuDescrip
            // 
            this.txtactuDescrip.Location = new System.Drawing.Point(94, 230);
            this.txtactuDescrip.Name = "txtactuDescrip";
            this.txtactuDescrip.Size = new System.Drawing.Size(231, 22);
            this.txtactuDescrip.TabIndex = 28;
            // 
            // txtactuCategoria
            // 
            this.txtactuCategoria.Location = new System.Drawing.Point(94, 176);
            this.txtactuCategoria.Name = "txtactuCategoria";
            this.txtactuCategoria.Size = new System.Drawing.Size(231, 22);
            this.txtactuCategoria.TabIndex = 27;
            // 
            // txtactuPrecio
            // 
            this.txtactuPrecio.Location = new System.Drawing.Point(94, 127);
            this.txtactuPrecio.Name = "txtactuPrecio";
            this.txtactuPrecio.Size = new System.Drawing.Size(231, 22);
            this.txtactuPrecio.TabIndex = 26;
            // 
            // eliminiPanel
            // 
            this.eliminiPanel.Controls.Add(this.label6);
            this.eliminiPanel.Controls.Add(this.btnEliminar);
            this.eliminiPanel.Controls.Add(this.label13);
            this.eliminiPanel.Controls.Add(this.txtdeleteCodigo);
            this.eliminiPanel.Controls.Add(this.txtdeleteNombre);
            this.eliminiPanel.Controls.Add(this.label12);
            this.eliminiPanel.Location = new System.Drawing.Point(12, 124);
            this.eliminiPanel.Name = "eliminiPanel";
            this.eliminiPanel.Size = new System.Drawing.Size(415, 188);
            this.eliminiPanel.TabIndex = 33;
            this.eliminiPanel.Visible = false;
            this.eliminiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.eliminiPanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Eliminar producto";
            // 
            // insertarPanel
            // 
            this.insertarPanel.Controls.Add(this.label7);
            this.insertarPanel.Controls.Add(this.label1);
            this.insertarPanel.Controls.Add(this.txtCodigo);
            this.insertarPanel.Controls.Add(this.txtNombre);
            this.insertarPanel.Controls.Add(this.label14);
            this.insertarPanel.Controls.Add(this.txtCantida);
            this.insertarPanel.Controls.Add(this.label4);
            this.insertarPanel.Controls.Add(this.txtCategoria);
            this.insertarPanel.Controls.Add(this.txtPrecio);
            this.insertarPanel.Controls.Add(this.btnAceptar);
            this.insertarPanel.Controls.Add(this.label11);
            this.insertarPanel.Controls.Add(this.label3);
            this.insertarPanel.Controls.Add(this.txtDescripcion);
            this.insertarPanel.Controls.Add(this.label5);
            this.insertarPanel.Controls.Add(this.label10);
            this.insertarPanel.Location = new System.Drawing.Point(29, 31);
            this.insertarPanel.Name = "insertarPanel";
            this.insertarPanel.Size = new System.Drawing.Size(383, 401);
            this.insertarPanel.TabIndex = 34;
            this.insertarPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Actualizar productos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertaToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertaToolStripMenuItem
            // 
            this.insertaToolStripMenuItem.Name = "insertaToolStripMenuItem";
            this.insertaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.insertaToolStripMenuItem.Text = "Inserta";
            this.insertaToolStripMenuItem.Click += new System.EventHandler(this.insertaToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 419);
            this.dataGridView1.TabIndex = 35;
            // 
            // Gestion_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertarPanel);
            this.Controls.Add(this.eliminiPanel);
            this.Controls.Add(this.ActulizarPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion_productos";
            this.Text = "Gestionar productos";
            this.Load += new System.EventHandler(this.Gestion_porductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ActulizarPanel.ResumeLayout(false);
            this.ActulizarPanel.PerformLayout();
            this.eliminiPanel.ResumeLayout(false);
            this.eliminiPanel.PerformLayout();
            this.insertarPanel.ResumeLayout(false);
            this.insertarPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtactuCodigo;
        private System.Windows.Forms.Button btActualizar;
        private ventasDataSet ventasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtActuNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdeleteNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdeleteCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel ActulizarPanel;
        private System.Windows.Forms.Panel insertarPanel;
        private System.Windows.Forms.Panel eliminiPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtactuDescrip;
        private System.Windows.Forms.TextBox txtactuCategoria;
        private System.Windows.Forms.TextBox txtactuPrecio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}