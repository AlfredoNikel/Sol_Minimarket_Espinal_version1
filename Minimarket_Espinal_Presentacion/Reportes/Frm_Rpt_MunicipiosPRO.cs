using System;
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
    public partial class Frm_Rpt_MunicipiosPRO : Form
    {
        public Frm_Rpt_MunicipiosPRO()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_MunicipiosPRO_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_poTableAdapter.Fill(this.dataSet_MiniMarket_Espinal.USP_Listado_po, cTexto: txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
