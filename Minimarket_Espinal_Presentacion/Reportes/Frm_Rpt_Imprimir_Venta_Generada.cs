﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_Espinal_Presentacion.Reportes
{
    public partial class Frm_Rpt_Imprimir_Venta_Generada : Form
    {
        public Frm_Rpt_Imprimir_Venta_Generada()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Imprimir_Venta_Generada_Load(object sender, EventArgs e)
        {
            this.uSP_Imprimir_Venta_GeneradaTableAdapter.Fill(this.dataSet_MiniMarket_Espinal.USP_Imprimir_Venta_Generada, nCodigo_sp:Convert.ToInt32(txt_p1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
