namespace Minimarket_Espinal_Presentacion.Reportes
{
    partial class Frm_Rpt_ProvinciasDP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_MiniMarket_Espinal = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_Espinal();
            this.uSPListadodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_deTableAdapter = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_deTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uSPListadodeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket_Espinal_Presentacion.Reportes.Rpt_ProvinciasDP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_MiniMarket_Espinal
            // 
            this.dataSet_MiniMarket_Espinal.DataSetName = "DataSet_MiniMarket_Espinal";
            this.dataSet_MiniMarket_Espinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadodeBindingSource
            // 
            this.uSPListadodeBindingSource.DataMember = "USP_Listado_de";
            this.uSPListadodeBindingSource.DataSource = this.dataSet_MiniMarket_Espinal;
            // 
            // uSP_Listado_deTableAdapter
            // 
            this.uSP_Listado_deTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(22, 36);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            this.txt_p1.TextChanged += new System.EventHandler(this.txt_p1_TextChanged);
            // 
            // Frm_Rpt_ProvinciasDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_ProvinciasDP";
            this.Text = "Frm_Rpt_ProvinciasDP";
            this.Load += new System.EventHandler(this.Frm_Rpt_ProvinciasDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadodeBindingSource;
        private DataSet_MiniMarket_Espinal dataSet_MiniMarket_Espinal;
        private DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_deTableAdapter uSP_Listado_deTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}