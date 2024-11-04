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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.IdCheck = new System.Windows.Forms.CheckBox();
            this.CantidadCheck = new System.Windows.Forms.CheckBox();
            this.PrecioCheck = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDataSet1 = new proyecto_final2.ventasDataSet();
            this.tbProductoTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 384);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Cantidad"});
            this.comboBox1.Location = new System.Drawing.Point(1213, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // IdCheck
            // 
            this.IdCheck.AutoSize = true;
            this.IdCheck.Location = new System.Drawing.Point(12, 12);
            this.IdCheck.Name = "IdCheck";
            this.IdCheck.Size = new System.Drawing.Size(96, 20);
            this.IdCheck.TabIndex = 3;
            this.IdCheck.Text = "Id producto";
            this.IdCheck.UseVisualStyleBackColor = true;
            // 
            // CantidadCheck
            // 
            this.CantidadCheck.AutoSize = true;
            this.CantidadCheck.Location = new System.Drawing.Point(114, 12);
            this.CantidadCheck.Name = "CantidadCheck";
            this.CantidadCheck.Size = new System.Drawing.Size(83, 20);
            this.CantidadCheck.TabIndex = 5;
            this.CantidadCheck.Text = "Cantidad";
            this.CantidadCheck.UseVisualStyleBackColor = true;
            // 
            // PrecioCheck
            // 
            this.PrecioCheck.AutoSize = true;
            this.PrecioCheck.Location = new System.Drawing.Point(203, 12);
            this.PrecioCheck.Name = "PrecioCheck";
            this.PrecioCheck.Size = new System.Drawing.Size(68, 20);
            this.PrecioCheck.TabIndex = 6;
            this.PrecioCheck.Text = "Precio";
            this.PrecioCheck.UseVisualStyleBackColor = true;
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
            // buscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 486);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.PrecioCheck);
            this.Controls.Add(this.CantidadCheck);
            this.Controls.Add(this.IdCheck);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "buscarProductos";
            this.Text = "Buscardor";
            this.Load += new System.EventHandler(this.buscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ventasDataSet ventasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox IdCheck;
        private System.Windows.Forms.CheckBox CantidadCheck;
        private System.Windows.Forms.CheckBox PrecioCheck;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtID;
    }
}