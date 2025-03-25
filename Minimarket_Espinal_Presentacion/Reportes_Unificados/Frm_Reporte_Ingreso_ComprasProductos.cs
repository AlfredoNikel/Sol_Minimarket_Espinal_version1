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
    public partial class Frm_Reporte_Ingreso_ComprasProductos : Form
    {
        public Frm_Reporte_Ingreso_ComprasProductos()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_vistaprevia_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Rpt_Ingreso_ComprarProductos oRpt_icp = new Reportes_Unificados.Frm_Rpt_Ingreso_ComprarProductos();
            oRpt_icp.txt_p1.Text = Convert.ToString(Dp_Fecha_ini.Value);
            oRpt_icp.txt_p2.Text = Convert.ToString(Dp_Fecha_fine.Value);
            oRpt_icp.ShowDialog();
        }

        private void Dp_Fecha_ini_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
