﻿namespace Minimarket_Espinal_Presentacion.Reportes_Unificados
{
    partial class Frm_Rpt_Acumulado_Salida_AcumuladoProducto
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
            this.dataSet_Reportes_Unificados = new Minimarket_Espinal_Presentacion.Reportes_Unificados.DataSet_Reportes_Unificados();
            this.uSPReporteSalidasAcumuladoXProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Reporte_Salidas_AcumuladoXProductoTableAdapter = new Minimarket_Espinal_Presentacion.Reportes_Unificados.DataSet_Reportes_UnificadosTableAdapters.USP_Reporte_Salidas_AcumuladoXProductoTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Unificados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidasAcumuladoXProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPReporteSalidasAcumuladoXProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket_Espinal_Presentacion.Reportes_Unificados.Rpt_Salida_acumuladoProducto." +
    "rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(967, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Reportes_Unificados
            // 
            this.dataSet_Reportes_Unificados.DataSetName = "DataSet_Reportes_Unificados";
            this.dataSet_Reportes_Unificados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPReporteSalidasAcumuladoXProductoBindingSource
            // 
            this.uSPReporteSalidasAcumuladoXProductoBindingSource.DataMember = "USP_Reporte_Salidas_AcumuladoXProducto";
            this.uSPReporteSalidasAcumuladoXProductoBindingSource.DataSource = this.dataSet_Reportes_Unificados;
            // 
            // uSP_Reporte_Salidas_AcumuladoXProductoTableAdapter
            // 
            this.uSP_Reporte_Salidas_AcumuladoXProductoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(12, 59);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 20);
            this.txt_p2.TabIndex = 6;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 33);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 5;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Acumulado_Salida_AcumuladoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Acumulado_Salida_AcumuladoProducto";
            this.Text = "Frm_Rpt_Acumulado_Salida_AcumuladoProducto";
            this.Load += new System.EventHandler(this.Frm_Rpt_Acumulado_Salida_AcumuladoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Unificados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidasAcumuladoXProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteSalidasAcumuladoXProductoBindingSource;
        private DataSet_Reportes_Unificados dataSet_Reportes_Unificados;
        private DataSet_Reportes_UnificadosTableAdapters.USP_Reporte_Salidas_AcumuladoXProductoTableAdapter uSP_Reporte_Salidas_AcumuladoXProductoTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}