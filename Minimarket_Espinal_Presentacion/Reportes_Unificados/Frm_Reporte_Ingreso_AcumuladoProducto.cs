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
    public partial class Frm_Reporte_Ingreso_AcumuladoProducto : Form
    {
        public Frm_Reporte_Ingreso_AcumuladoProducto()
        {
            InitializeComponent();
        }

        private void Btn_vistaprevia_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Rpt_Ingreso_AcumuladoProducto oRpt_iap = new Reportes_Unificados.Frm_Rpt_Ingreso_AcumuladoProducto();
            oRpt_iap.txt_p1.Text = Convert.ToString(Dp_Fecha_ini.Value);
            oRpt_iap.txt_p2.Text = Convert.ToString(Dp_Fecha_fine.Value);
            oRpt_iap.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dp_Fecha_fine_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dp_Fecha_ini_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
