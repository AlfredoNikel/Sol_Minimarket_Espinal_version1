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
    public partial class Frm_Rpt_SectoresDIS : Form
    {
        public Frm_Rpt_SectoresDIS()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_SectoresDIS_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_diTableAdapter.Fill(this.dataSet_MiniMarket_Espinal.USP_Listado_di, cTexto: txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
