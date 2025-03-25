using Minimarket_Espinal_Presentacion.Reportes_Unificados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_Espinal_Presentacion
{
    public partial class MDI_Principal : Form
    {
        public MDI_Principal()
        {
            InitializeComponent();
        }

        private void MDI_Principal_Load(object sender, EventArgs e)
        {

        }

        private void proveedoresYClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marcas oFrm_ma = new Frm_Marcas();
            oFrm_ma.MdiParent = this;
            oFrm_ma.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ma.Show();
        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Unidades_Medidas oFrm_um = new Frm_Unidades_Medidas();
            oFrm_um.MdiParent = this;
            oFrm_um.StartPosition = FormStartPosition.CenterScreen;
            oFrm_um.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categorias oFrm_ca = new Frm_Categorias();
            oFrm_ca.MdiParent = this;
            oFrm_ca.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ca.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Almacenes oFrm_al = new Frm_Almacenes();
            oFrm_al.MdiParent = this;
            oFrm_al.StartPosition = FormStartPosition.CenterScreen;
            oFrm_al.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientes oFrm_cl = new Frm_Clientes();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oFrm_pv = new Frm_Proveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rubros oFrm_ru = new Frm_Rubros();
            oFrm_ru.MdiParent = this;
            oFrm_ru.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ru.Show();
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SectoresDIS oFrm_di = new Frm_SectoresDIS();
            oFrm_di.MdiParent = this;
            oFrm_di.StartPosition = FormStartPosition.CenterScreen;
            oFrm_di.Show();
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MunicipiosPRO oFrm_po = new Frm_MunicipiosPRO();
            oFrm_po.MdiParent = this;
            oFrm_po.StartPosition = FormStartPosition.CenterScreen;
            oFrm_po.Show();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProvinciasDP oFrm_de = new Frm_ProvinciasDP();
            oFrm_de.MdiParent = this;
            oFrm_de.StartPosition = FormStartPosition.CenterScreen;
            oFrm_de.Show();
        }

        private void entradasDeProductosComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrada_Productos oFrm_ep = new Frm_Entrada_Productos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void salidaDeProductosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salida_Productos oFrm_sp = new Frm_Salida_Productos();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Tbar_Producto_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void Tbar_clientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes oFrm_cl = new Frm_Clientes();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void Tbar_proveedores_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oFrm_pv = new Frm_Proveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void Tbar_entrada_productos_Click(object sender, EventArgs e)
        {
            Frm_Entrada_Productos oFrm_ep = new Frm_Entrada_Productos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void Tbar_salida_productos_Click(object sender, EventArgs e)
        {
            Frm_Salida_Productos oFrm_sp = new Frm_Salida_Productos();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ingresoDeComprasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Reporte_Ingreso_ComprasProductos oFrm_rep1 = new Reportes_Unificados.Frm_Reporte_Ingreso_ComprasProductos();
            oFrm_rep1.MdiParent = this;
            oFrm_rep1.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep1.Show();
        }

        private void salidasDeVentasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Reporte_Salida_VentasProductos oFrm_rep2 = new Reportes_Unificados.Frm_Reporte_Salida_VentasProductos();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void ingresoAcumuladoPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Reporte_Ingreso_AcumuladoProducto oFrm_rep3 = new Reportes_Unificados.Frm_Reporte_Ingreso_AcumuladoProducto();
            oFrm_rep3.MdiParent = this;
            oFrm_rep3.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep3.Show();
            
        }

        private void salidasDeVentasPorProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes_Unificados.Frm_Reporte_Salida_AcumuladoProducto oFrm_rep4 = new Reportes_Unificados.Frm_Reporte_Salida_AcumuladoProducto();
            oFrm_rep4.MdiParent = this;
            oFrm_rep4.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep4.Show();
        }
    }
    
}
