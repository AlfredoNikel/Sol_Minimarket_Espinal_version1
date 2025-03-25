namespace Minimarket_Espinal_Presentacion.Reportes
{
    partial class Frm_Rpt_Rubros
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
            this.uSPListadoruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_ruTableAdapter = new Minimarket_Espinal_Presentacion.Reportes.DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_ruTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadoruBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket_Espinal_Presentacion.Reportes.Rpt_Rubros.rdlc";
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
            // uSPListadoruBindingSource
            // 
            this.uSPListadoruBindingSource.DataMember = "USP_Listado_ru";
            this.uSPListadoruBindingSource.DataSource = this.dataSet_MiniMarket_Espinal;
            // 
            // uSP_Listado_ruTableAdapter
            // 
            this.uSP_Listado_ruTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(33, 40);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            this.txt_p1.TextChanged += new System.EventHandler(this.txt_p1_TextChanged);
            // 
            // Frm_Rpt_Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Rubros";
            this.Text = "Frm_Rpt_Rubros";
            this.Load += new System.EventHandler(this.Frm_Rpt_Rubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket_Espinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadoruBindingSource;
        private DataSet_MiniMarket_Espinal dataSet_MiniMarket_Espinal;
        private DataSet_MiniMarket_EspinalTableAdapters.USP_Listado_ruTableAdapter uSP_Listado_ruTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}