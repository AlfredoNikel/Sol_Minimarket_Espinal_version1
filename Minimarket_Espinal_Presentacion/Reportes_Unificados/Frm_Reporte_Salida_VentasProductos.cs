﻿using System;
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
    public partial class Frm_Reporte_Salida_VentasProductos : Form
    {
        public Frm_Reporte_Salida_VentasProductos()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_vistaprevia_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Rpt_Salida_VentasProductos oRpt_svp = new Reportes_Unificados.Frm_Rpt_Salida_VentasProductos();
            oRpt_svp.txt_p1.Text = Convert.ToString(Dp_Fecha_ini.Value);
            oRpt_svp.txt_p2.Text = Convert.ToString(Dp_Fecha_fine.Value);
            oRpt_svp.ShowDialog();
        }
    }
}
