namespace Minimarket_Espinal_Presentacion.Reportes
{
    partial class Frm_Rpt_Categorias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPListadocaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_MiniMarket_Espinal = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_Espinal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMiniMarketEspinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_caTableAdapter = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_caTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMiniMarketEspinalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPListadocaBindingSource
            // 
            this.uSPListadocaBindingSource.DataMember = "USP_Listado_ca";
            this.uSPListadocaBindingSource.DataSource = this.dataSet_MiniMarket_Espinal;
            // 
            // dataSet_MiniMarket_Espinal
            // 
            this.dataSet_MiniMarket_Espinal.DataSetName = "DataSet_MiniMarket_Espinal";
            this.dataSet_MiniMarket_Espinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadocaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket_Espinal_Presentacion.Reportes.Rpt_categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 288);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetMiniMarketEspinalBindingSource
            // 
            this.dataSetMiniMarketEspinalBindingSource.DataSource = this.dataSet_MiniMarket_Espinal;
            this.dataSetMiniMarketEspinalBindingSource.Position = 0;
            // 
            // uSP_Listado_caTableAdapter
            // 
            this.uSP_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 27);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 288);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Categorias";
            this.Text = "Reporte de categorías";
            this.Load += new System.EventHandler(this.Frm_Rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMiniMarketEspinalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadocaBindingSource;
        private DataSet_MiniMarket_Espinal dataSet_MiniMarket_Espinal;
        private System.Windows.Forms.BindingSource dataSetMiniMarketEspinalBindingSource;
        private DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_caTableAdapter uSP_Listado_caTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}