namespace proyecto_final2
{
    partial class buscarProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdCheck = new System.Windows.Forms.CheckBox();
            this.CantidadCheck = new System.Windows.Forms.CheckBox();
            this.PrecioCheck = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtstockmenor = new System.Windows.Forms.TextBox();
            this.StockdownCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.predeCheck = new System.Windows.Forms.CheckBox();
            this.timeAntiguedad = new System.Windows.Forms.DateTimePicker();
            this.antiguedadCheck = new System.Windows.Forms.CheckBox();
            this.recienteCheck = new System.Windows.Forms.CheckBox();
            this.timeventas = new System.Windows.Forms.DateTimePicker();
            this.timeAntiguedad2 = new System.Windows.Forms.DateTimePicker();
            this.txtFechaI = new System.Windows.Forms.Label();
            this.txtFechaF = new System.Windows.Forms.Label();
            this.timeventasF = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDataSet1 = new proyecto_final2.ventasDataSet();
            this.tbProductoTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDataSet = new proyecto_final2.ventasDataSet();
            this.tbMovimientosStockTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbMovimientosStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(634, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // IdCheck
            // 
            this.IdCheck.AutoSize = true;
            this.IdCheck.Location = new System.Drawing.Point(153, 12);
            this.IdCheck.Name = "IdCheck";
            this.IdCheck.Size = new System.Drawing.Size(96, 20);
            this.IdCheck.TabIndex = 3;
            this.IdCheck.Text = "Id producto";
            this.IdCheck.UseVisualStyleBackColor = true;
            // 
            // CantidadCheck
            // 
            this.CantidadCheck.AutoSize = true;
            this.CantidadCheck.Location = new System.Drawing.Point(255, 12);
            this.CantidadCheck.Name = "CantidadCheck";
            this.CantidadCheck.Size = new System.Drawing.Size(104, 20);
            this.CantidadCheck.TabIndex = 5;
            this.CantidadCheck.Text = "Stock mayor";
            this.CantidadCheck.UseVisualStyleBackColor = true;
            // 
            // PrecioCheck
            // 
            this.PrecioCheck.AutoSize = true;
            this.PrecioCheck.Location = new System.Drawing.Point(499, 12);
            this.PrecioCheck.Name = "PrecioCheck";
            this.PrecioCheck.Size = new System.Drawing.Size(68, 20);
            this.PrecioCheck.TabIndex = 6;
            this.PrecioCheck.Text = "Precio";
            this.PrecioCheck.UseVisualStyleBackColor = true;
            this.PrecioCheck.CheckedChanged += new System.EventHandler(this.PrecioCheck_CheckedChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 48);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(634, 22);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.Visible = false;
            this.txtPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyUp);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 48);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(634, 22);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Visible = false;
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(634, 22);
            this.txtID.TabIndex = 9;
            this.txtID.Visible = false;
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // txtstockmenor
            // 
            this.txtstockmenor.Location = new System.Drawing.Point(12, 48);
            this.txtstockmenor.Name = "txtstockmenor";
            this.txtstockmenor.Size = new System.Drawing.Size(634, 22);
            this.txtstockmenor.TabIndex = 10;
            this.txtstockmenor.Visible = false;
            this.txtstockmenor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtstock_KeyUp);
            // 
            // StockdownCheck
            // 
            this.StockdownCheck.AutoSize = true;
            this.StockdownCheck.Location = new System.Drawing.Point(365, 12);
            this.StockdownCheck.Name = "StockdownCheck";
            this.StockdownCheck.Size = new System.Drawing.Size(115, 20);
            this.StockdownCheck.TabIndex = 11;
            this.StockdownCheck.Text = "Stock menor a";
            this.StockdownCheck.UseVisualStyleBackColor = true;
            this.StockdownCheck.CheckedChanged += new System.EventHandler(this.stockCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "(predeterminado para buscar nombre, codigo, categoria)";
            // 
            // predeCheck
            // 
            this.predeCheck.AutoSize = true;
            this.predeCheck.Location = new System.Drawing.Point(12, 12);
            this.predeCheck.Name = "predeCheck";
            this.predeCheck.Size = new System.Drawing.Size(126, 20);
            this.predeCheck.TabIndex = 13;
            this.predeCheck.Text = "Predeterminado";
            this.predeCheck.UseVisualStyleBackColor = true;
            // 
            // timeAntiguedad
            // 
            this.timeAntiguedad.Location = new System.Drawing.Point(684, 50);
            this.timeAntiguedad.Name = "timeAntiguedad";
            this.timeAntiguedad.Size = new System.Drawing.Size(200, 22);
            this.timeAntiguedad.TabIndex = 14;
            this.timeAntiguedad.ValueChanged += new System.EventHandler(this.timeAntiguedad_ValueChanged);
            // 
            // antiguedadCheck
            // 
            this.antiguedadCheck.AutoSize = true;
            this.antiguedadCheck.Location = new System.Drawing.Point(686, 10);
            this.antiguedadCheck.Name = "antiguedadCheck";
            this.antiguedadCheck.Size = new System.Drawing.Size(102, 20);
            this.antiguedadCheck.TabIndex = 15;
            this.antiguedadCheck.Text = "Fecha stock";
            this.antiguedadCheck.UseVisualStyleBackColor = true;
            // 
            // recienteCheck
            // 
            this.recienteCheck.AutoSize = true;
            this.recienteCheck.Location = new System.Drawing.Point(801, 10);
            this.recienteCheck.Name = "recienteCheck";
            this.recienteCheck.Size = new System.Drawing.Size(71, 20);
            this.recienteCheck.TabIndex = 16;
            this.recienteCheck.Text = "Ventas";
            this.recienteCheck.UseVisualStyleBackColor = true;
            this.recienteCheck.CheckedChanged += new System.EventHandler(this.recienteCheck_CheckedChanged);
            // 
            // timeventas
            // 
            this.timeventas.Location = new System.Drawing.Point(686, 50);
            this.timeventas.Name = "timeventas";
            this.timeventas.Size = new System.Drawing.Size(200, 22);
            this.timeventas.TabIndex = 18;
            this.timeventas.ValueChanged += new System.EventHandler(this.timeventas_ValueChanged);
            // 
            // timeAntiguedad2
            // 
            this.timeAntiguedad2.Location = new System.Drawing.Point(921, 50);
            this.timeAntiguedad2.Name = "timeAntiguedad2";
            this.timeAntiguedad2.Size = new System.Drawing.Size(200, 22);
            this.timeAntiguedad2.TabIndex = 19;
            this.timeAntiguedad2.Visible = false;
            this.timeAntiguedad2.ValueChanged += new System.EventHandler(this.timeAntiguedad2_ValueChanged);
            // 
            // txtFechaI
            // 
            this.txtFechaI.AutoSize = true;
            this.txtFechaI.Location = new System.Drawing.Point(683, 31);
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(106, 16);
            this.txtFechaI.TabIndex = 20;
            this.txtFechaI.Text = "Fecha comienzo";
            this.txtFechaI.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFechaF
            // 
            this.txtFechaF.AutoSize = true;
            this.txtFechaF.Location = new System.Drawing.Point(918, 31);
            this.txtFechaF.Name = "txtFechaF";
            this.txtFechaF.Size = new System.Drawing.Size(77, 16);
            this.txtFechaF.TabIndex = 21;
            this.txtFechaF.Text = "Fecha Final";
            // 
            // timeventasF
            // 
            this.timeventasF.Location = new System.Drawing.Point(921, 50);
            this.timeventasF.Name = "timeventasF";
            this.timeventasF.Size = new System.Drawing.Size(200, 22);
            this.timeventasF.TabIndex = 22;
            this.timeventasF.ValueChanged += new System.EventHandler(this.timeventasF_ValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbProducto";
            this.bindingSource1.DataSource = this.ventasDataSet1;
            // 
            // ventasDataSet1
            // 
            this.ventasDataSet1.DataSetName = "ventasDataSet";
            this.ventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductoTableAdapter
            // 
            this.tbProductoTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbMovimientosStock";
            this.bindingSource2.DataSource = this.ventasDataSet;
            // 
            // ventasDataSet
            // 
            this.ventasDataSet.DataSetName = "ventasDataSet";
            this.ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMovimientosStockTableAdapter
            // 
            this.tbMovimientosStockTableAdapter.ClearBeforeFill = true;
            // 
            // buscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 486);
            this.Controls.Add(this.timeventasF);
            this.Controls.Add(this.txtFechaF);
            this.Controls.Add(this.txtFechaI);
            this.Controls.Add(this.timeAntiguedad2);
            this.Controls.Add(this.timeventas);
            this.Controls.Add(this.recienteCheck);
            this.Controls.Add(this.antiguedadCheck);
            this.Controls.Add(this.timeAntiguedad);
            this.Controls.Add(this.predeCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockdownCheck);
            this.Controls.Add(this.txtstockmenor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.PrecioCheck);
            this.Controls.Add(this.CantidadCheck);
            this.Controls.Add(this.IdCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "buscarProductos";
            this.Text = "Buscardor";
            this.Load += new System.EventHandler(this.buscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ventasDataSet ventasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox IdCheck;
        private System.Windows.Forms.CheckBox CantidadCheck;
        private System.Windows.Forms.CheckBox PrecioCheck;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtstockmenor;
        private System.Windows.Forms.CheckBox StockdownCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox predeCheck;
        private System.Windows.Forms.DateTimePicker timeAntiguedad;
        private System.Windows.Forms.CheckBox antiguedadCheck;
        private System.Windows.Forms.CheckBox recienteCheck;
        private System.Windows.Forms.DateTimePicker timeventas;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DateTimePicker timeAntiguedad2;
        private System.Windows.Forms.Label txtFechaI;
        private System.Windows.Forms.Label txtFechaF;
        private ventasDataSet ventasDataSet;
        private ventasDataSetTableAdapters.tbMovimientosStockTableAdapter tbMovimientosStockTableAdapter;
        private System.Windows.Forms.DateTimePicker timeventasF;
    }
}