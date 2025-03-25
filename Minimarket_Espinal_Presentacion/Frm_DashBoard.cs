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
    public partial class Frm_DashBoard : Form
    {
        public Frm_DashBoard()
        {
            InitializeComponent();
        }

        #region "Variables"

        private Form activeForm = null;

        #endregion


        #region "Mis metodos" 
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_Cuerpo.Controls.Add(childForm);
            //Pnl_Cuerpo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion


        private void Pnl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {

        }

        private void Frm_DashBoard_Load(object sender, EventArgs e)
        {
            this.Pnl_datos_Procesos.Visible = false;
            this.Pnl_Reportes.Visible = false;
            this.Pnl_Datos_Maestros.Visible = false;
            this.Pnl_Sistemas.Visible = false;
        }

        private void Btn_Procesos_Click(object sender, EventArgs e)
        {
            if (this.Pnl_datos_Procesos.Visible == false)
            {
                this.Pnl_datos_Procesos.Visible = true;
            }
            else
            {
                this.Pnl_datos_Procesos.Visible = false;
            }
            this.Pnl_Reportes.Visible = false;
            this.Pnl_Datos_Maestros.Visible = false;
            this.Pnl_Sistemas.Visible = false;
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            if (this.Pnl_Reportes.Visible == false)
            {
                this.Pnl_Reportes.Visible = true;
            }
            else
            {
                this.Pnl_Reportes.Visible = false;
            }
            this.Pnl_datos_Procesos.Visible = false;
            this.Pnl_Datos_Maestros.Visible = false;
            this.Pnl_Sistemas.Visible = false;

        }

        private void Btn_Datos_Maestros_Click(object sender, EventArgs e)
        {
            if(this.Pnl_Datos_Maestros.Visible == false)
            {
                this.Pnl_Datos_Maestros.Visible = true;
            }
            else
            {
                this.Pnl_Datos_Maestros.Visible = false;
            }
            this.Pnl_datos_Procesos.Visible = false;
            this.Pnl_Reportes.Visible = false;
            this.Pnl_Sistemas.Visible = false;

        }

        private void Btn_Sistemas_Click(object sender, EventArgs e)
        {
            if(this.Pnl_Sistemas.Visible == false)
            {
                this.Pnl_Sistemas.Visible = true;
            }
            else
            {
                this.Pnl_Sistemas.Visible = false;
            }
            this.Pnl_datos_Procesos.Visible = false;
            this.Pnl_Reportes.Visible = false;
            this.Pnl_Datos_Maestros.Visible = false;
        }

        private void Btn_cerrar_Seccion_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Btn_Entrada_Productos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Entrada_Productos());
        }

        private void Btn_Salida_Productos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Salida_Productos());
        }

        private void Btn_Reportes1_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Unificados.Frm_Reporte_Ingreso_ComprasProductos());
        }

        private void Btn_reportes2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Unificados.Frm_Reporte_Ingreso_AcumuladoProducto());
        }

        private void Btn_reporte3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Unificados.Frm_Reporte_Salida_VentasProductos());
        }

        private void Btn_reporte4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Unificados.Frm_Reporte_Salida_AcumuladoProducto());
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Productos());
        }

        private void Btn_Marcas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Marcas());
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Categorias());
        }

        private void Btn_almacenes_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Almacenes());
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Clientes());
        }

        private void Btn_proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Proveedores());
        }

        private void Btn_rubros_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Rubros());
        }

        private void Btn_sectores_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_SectoresDIS());
        }

        private void Btn_municipios_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_MunicipiosPRO());
        }

        private void Btn_provincias_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_ProvinciasDP());
        }

        private void Btn_unidad_medida_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Unidades_Medidas());
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Usuarios());
        }

        private void Gbx_sesion_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
