namespace proyecto_final2
{
    partial class GestionarStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cBoxTipoMov = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxIdProducto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMovimientosStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDataSet = new proyecto_final2.ventasDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMovimientosStockTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbMovimientosStockTableAdapter();
            this.tbProductoTableAdapter1 = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMovimientosStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(26, 118);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 32);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(160, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 32);
            this.txtCantidad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(643, 78);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(128, 32);
            this.txtObservaciones.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Observaciones";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(26, 156);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(128, 32);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cBoxTipoMov
            // 
            this.cBoxTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTipoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipoMov.FormattingEnabled = true;
            this.cBoxTipoMov.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cBoxTipoMov.Location = new System.Drawing.Point(294, 77);
            this.cBoxTipoMov.Name = "cBoxTipoMov";
            this.cBoxTipoMov.Size = new System.Drawing.Size(128, 33);
            this.cBoxTipoMov.TabIndex = 11;
            this.cBoxTipoMov.SelectedIndexChanged += new System.EventHandler(this.cBoxTipoMov_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de movimiento";
            // 
            // cBoxIdProducto
            // 
            this.cBoxIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxIdProducto.FormattingEnabled = true;
            this.cBoxIdProducto.Location = new System.Drawing.Point(26, 79);
            this.cBoxIdProducto.Name = "cBoxIdProducto";
            this.cBoxIdProducto.Size = new System.Drawing.Size(128, 33);
            this.cBoxIdProducto.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimientoDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoMovimientoDataGridViewTextBoxColumn,
            this.fechaMovimientoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbMovimientosStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 220);
            this.dataGridView1.TabIndex = 14;
            // 
            // idMovimientoDataGridViewTextBoxColumn
            // 
            this.idMovimientoDataGridViewTextBoxColumn.DataPropertyName = "Id_Movimiento";
            this.idMovimientoDataGridViewTextBoxColumn.HeaderText = "Id_Movimiento";
            this.idMovimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMovimientoDataGridViewTextBoxColumn.Name = "idMovimientoDataGridViewTextBoxColumn";
            this.idMovimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMovimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoMovimientoDataGridViewTextBoxColumn
            // 
            this.tipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoMovimientoDataGridViewTextBoxColumn.Name = "tipoMovimientoDataGridViewTextBoxColumn";
            this.tipoMovimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaMovimientoDataGridViewTextBoxColumn
            // 
            this.fechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento";
            this.fechaMovimientoDataGridViewTextBoxColumn.HeaderText = "FechaMovimiento";
            this.fechaMovimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaMovimientoDataGridViewTextBoxColumn.Name = "fechaMovimientoDataGridViewTextBoxColumn";
            this.fechaMovimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbMovimientosStockBindingSource
            // 
            this.tbMovimientosStockBindingSource.DataMember = "tbMovimientosStock";
            this.tbMovimientosStockBindingSource.DataSource = this.ventasDataSet;
            // 
            // ventasDataSet
            // 
            this.ventasDataSet.DataSetName = "ventasDataSet";
            this.ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha";
            // 
            // tbMovimientosStockTableAdapter
            // 
            this.tbMovimientosStockTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductoTableAdapter1
            // 
            this.tbProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // GestionarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxIdProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxTipoMov);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "GestionarStock";
            this.Text = "Gestionar Stock";
            this.Load += new System.EventHandler(this.GestionarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMovimientosStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cBoxTipoMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxIdProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ventasDataSet ventasDataSet;
        private System.Windows.Forms.BindingSource tbMovimientosStockBindingSource;
        private ventasDataSetTableAdapters.tbMovimientosStockTableAdapter tbMovimientosStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter1;
    }
}