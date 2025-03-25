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
    public partial class Frm_Reporte_Salida_AcumuladoProducto : Form
    {
        public Frm_Reporte_Salida_AcumuladoProducto()
        {
            InitializeComponent();
        }

        private void Btn_vistaprevia_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Rpt_Acumulado_Salida_AcumuladoProducto oRpt_isp = new Reportes_Unificados.Frm_Rpt_Acumulado_Salida_AcumuladoProducto();
            oRpt_isp.txt_p1.Text = Convert.ToString(Dp_Fecha_ini.Value);
            oRpt_isp.txt_p2.Text = Convert.ToString(Dp_Fecha_fine.Value);
            oRpt_isp.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
