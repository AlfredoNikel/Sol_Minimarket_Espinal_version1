namespace Minimarket_Espinal_Presentacion.Reportes
{
    partial class Frm_Rpt_Salida_Productos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_MiniMarket_Espinal = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_Espinal();
            this.uSPListadospBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_spTableAdapter = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_spTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadospBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadospBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket_Espinal_Presentacion.Reportes.Rpt_Salida_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1066, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_MiniMarket_Espinal
            // 
            this.dataSet_MiniMarket_Espinal.DataSetName = "DataSet_MiniMarket_Espinal";
            this.dataSet_MiniMarket_Espinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadospBindingSource
            // 
            this.uSPListadospBindingSource.DataMember = "USP_Listado_sp";
            this.uSPListadospBindingSource.DataSource = this.dataSet_MiniMarket_Espinal;
            // 
            // uSP_Listado_spTableAdapter
            // 
            this.uSP_Listado_spTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 37);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 7;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 411);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Salida_Productos";
            this.Text = "Frm_Rpt_Salida_Productos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadospBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadospBindingSource;
        private DataSet_MiniMarket_Espinal dataSet_MiniMarket_Espinal;
        private DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_spTableAdapter uSP_Listado_spTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}