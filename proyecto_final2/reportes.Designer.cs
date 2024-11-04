namespace proyecto_final2
{
    partial class reportes
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
            this.tbProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDataSet1 = new proyecto_final2.ventasDataSet();
            this.tbVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbVentasTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbVentasTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductoTableAdapter = new proyecto_final2.ventasDataSetTableAdapters.tbProductoTableAdapter();
            this.tbProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductoBindingSource1
            // 
            this.tbProductoBindingSource1.DataMember = "tbProducto";
            this.tbProductoBindingSource1.DataSource = this.ventasDataSet1;
            // 
            // ventasDataSet1
            // 
            this.ventasDataSet1.DataSetName = "ventasDataSet";
            this.ventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVentasBindingSource
            // 
            this.tbVentasBindingSource.DataMember = "tbVentas";
            this.tbVentasBindingSource.DataSource = this.ventasDataSet1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbVentas";
            this.bindingSource1.DataSource = this.ventasDataSet1;
            // 
            // tbVentasTableAdapter
            // 
            this.tbVentasTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbProducto";
            this.bindingSource2.DataSource = this.ventasDataSet1;
            // 
            // tbProductoTableAdapter
            // 
            this.tbProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductoBindingSource
            // 
            this.tbProductoBindingSource.DataMember = "tbProducto";
            this.tbProductoBindingSource.DataSource = this.ventasDataSet1;
            // 
            // tbVentasBindingSource1
            // 
            this.tbVentasBindingSource1.DataMember = "tbVentas";
            this.tbVentasBindingSource1.DataSource = this.ventasDataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(268, 146);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Enabled = false;
            this.Name = "reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ventasDataSet ventasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ventasDataSetTableAdapters.tbVentasTableAdapter tbVentasTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private ventasDataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.BindingSource tbProductoBindingSource;
        private System.Windows.Forms.BindingSource tbVentasBindingSource;
        private System.Windows.Forms.BindingSource tbProductoBindingSource1;
        private System.Windows.Forms.BindingSource tbVentasBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}