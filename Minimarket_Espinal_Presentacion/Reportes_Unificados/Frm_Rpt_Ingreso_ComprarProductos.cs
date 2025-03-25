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
    public partial class Frm_Rpt_Ingreso_ComprarProductos : Form
    {
        public Frm_Rpt_Ingreso_ComprarProductos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Ingreso_ComprarProductos_Load(object sender, EventArgs e)
        {
            this.uSP_Reporte_Ingreso_ComprasXProductosTableAdapter.Fill(this.dataSet_Reportes_Unificados.USP_Reporte_Ingreso_ComprasXProductos,Fecha_ini: Convert.ToDateTime(txt_p1.Text), Fecha_fin:Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
