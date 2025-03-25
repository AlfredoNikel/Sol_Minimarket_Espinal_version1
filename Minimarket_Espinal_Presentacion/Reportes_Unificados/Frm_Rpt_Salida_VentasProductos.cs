using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_Espinal_Presentacion.Reportes_Unificados
{
    public partial class Frm_Rpt_Salida_VentasProductos : Form
    {
        public Frm_Rpt_Salida_VentasProductos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Salida_VentasProductos_Load(object sender, EventArgs e)
        {
            this.uSP_Reporte_Salidas_VentasXProductosTableAdapter.Fill(this.dataSet_Reportes_Unificados.USP_Reporte_Salidas_VentasXProductos, Fecha_ini: Convert.ToDateTime(txt_p1.Text), Fecha_fin: Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
