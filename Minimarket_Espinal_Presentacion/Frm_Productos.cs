using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minimarket_Espinal_Presentacion.Reportes;
using Sol_Minimarket_Espinal_Entidades;
using Sol_Minimarket_Espinal_Negocio;

namespace Minimarket_Espinal_Presentacion
{
    public partial class Frm_Productos: Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_pr = 0;
        int Codigo_ma = 0;
        int Codigo_um = 0;
        int Codigo_ca = 0;
        int Estadoguarda = 0; // Sin ninguna accion

        #endregion


        #region "Mis Metodos"

        private void Formato_pr()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_PR";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "PRODUCTOS";
            Dgv_principal.Columns[2].Width = 170;
            Dgv_principal.Columns[2].HeaderText = "MARCAS";
            Dgv_principal.Columns[3].Width = 110;
            Dgv_principal.Columns[3].HeaderText = "U.MEDIDA";
            Dgv_principal.Columns[4].Width = 170;
            Dgv_principal.Columns[4].HeaderText = "CATEGORIA";
            Dgv_principal.Columns[5].Width = 105;
            Dgv_principal.Columns[5].HeaderText = "STOCK MIN";
            Dgv_principal.Columns[6].Width = 105;
            Dgv_principal.Columns[6].HeaderText = "STOCK MAX";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
        }

        private void Listado_pr(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_Productos.Listado_pr(cTexto);
                this.Formato_pr();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.Btn_nuevo.Enabled = lEstado;
            this.Btn_actualizar.Enabled = lEstado;
            this.Btn_eliminar.Enabled = lEstado;
            this.Btn_reporte.Enabled = lEstado;
            this.Btn_salir.Enabled = lEstado;

        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.Btn_cancelar.Visible= lEstado;
            this.Btn_guardar.Visible= lEstado;
            this.Btn_retornar.Visible= !lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_pr"].Value))) 
           {
                MessageBox.Show("No se tiene información para visualizar","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                this.Codigo_pr = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_pr.Text =Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_pr"].Value);
                this.Codigo_ma = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ma"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ma"].Value);
                this.Codigo_um = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_um"].Value);
                this.Codigo_ca = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ca"].Value);
                Txt_stock_min.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["stock_min"].Value);
                Txt_stock_max.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["stock_max"].Value);
                Txt_pu_venta.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["pu_venta"].Value);


            }

        }



        private void Formato_ma_pr()
        {
            Dgv_marcas.Columns[0].Width = 210;
            Dgv_marcas.Columns[0].HeaderText = "MARCA";
            Dgv_marcas.Columns[1].Visible = false;

        }

        private void Listado_ma_pr(string cTexto)
        {
            try
            {
                Dgv_marcas.DataSource = N_Productos.Listado_ma_pr(cTexto);
                this.Formato_ma_pr();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_ma_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_marcas.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ma = Convert.ToInt32(Dgv_marcas.CurrentRow.Cells["codigo_ma"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_marcas.CurrentRow.Cells["descripcion_ma"].Value);
            }

        }

        private void Formato_um_pr()
        {
            Dgv_medidas.Columns[0].Width = 210;
            Dgv_medidas.Columns[0].HeaderText = "MEDIDAS";
            Dgv_medidas.Columns[1].Visible = false;

        }

        private void Listado_um_pr(string cTexto)
        {
            try
            {
                Dgv_medidas.DataSource = N_Productos.Listado_um_pr(cTexto);
                this.Formato_um_pr();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_um_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_medidas.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_um = Convert.ToInt32(Dgv_medidas.CurrentRow.Cells["codigo_um"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_medidas.CurrentRow.Cells["descripcion_um"].Value);
            }

        }


        private void Formato_ca_pr()
        {
            Dgv_categorias.Columns[0].Width = 210;
            Dgv_categorias.Columns[0].HeaderText = "CATEGORIAS";
            Dgv_categorias.Columns[1].Visible = false;

        }

        private void Listado_ca_pr(string cTexto)
        {
            try
            {
                Dgv_categorias.DataSource = N_Productos.Listado_ca_pr(cTexto);
                this.Formato_ca_pr();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_ca_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_categorias.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ca = Convert.ToInt32(Dgv_categorias.CurrentRow.Cells["codigo_ca"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_categorias.CurrentRow.Cells["descripcion_ca"].Value);
            }

        }


        private void Formato_stock_actual()
        {
            Dgv_Stock_actual.Columns[0].Width = 200;
            Dgv_Stock_actual.Columns[0].HeaderText = "ALMACEN";
            Dgv_Stock_actual.Columns[1].Width = 125;
            Dgv_Stock_actual.Columns[1].HeaderText = "STOCK ACTUAL";
            Dgv_Stock_actual.Columns[2].Width = 125;
            Dgv_Stock_actual.Columns[2].HeaderText = "PU COMPRA";


        }

        private void Listado_stock_actual(int nCodigo_pr)
        {
            try
            {
                Dgv_Stock_actual.DataSource = N_Productos.Ver_Stock_Actual_ProductosxAlmacenes(nCodigo_pr);
                this.Formato_stock_actual();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }



        #endregion




        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");
            this.Listado_ma_pr("%");
            this.Listado_um_pr("%");
            this.Listado_ca_pr("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            Gbx_detalle.Visible = false;
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_pr.Text = "";
            Txt_stock_min.Text = "0";
            Txt_stock_max.Text = "0";
            Txt_pu_venta.Text= "0";
            Txt_descripcion_pr.ReadOnly = false;
            Txt_stock_min.ReadOnly = false;
            Txt_stock_max.ReadOnly = false;
            Txt_pu_venta.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_pr.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            Gbx_detalle.Visible = false;
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_pr.ReadOnly = false;
            Txt_stock_min.ReadOnly = false;
            Txt_stock_max.ReadOnly = false;
            Txt_pu_venta.ReadOnly = false;
            Txt_descripcion_pr.Focus();

        }

        private void modif_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Txt_descripcion_pr.Text == String.Empty || 
                Txt_descripcion_ma.Text == String.Empty ||
                Txt_descripcion_um.Text == String.Empty ||
                Txt_descripcion_ca.Text == String.Empty ||
                Txt_pu_venta.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)" ,"Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procederia a registrar la informacion
            {
                
                E_Productos oPr = new E_Productos();
                string Rpta = "";
                oPr.Codigo_pr = this.Codigo_pr;
                oPr.Descripcion_pr = Txt_descripcion_pr.Text.Trim();
                oPr.Codigo_ma = this.Codigo_ma;
                oPr.Codigo_um = this.Codigo_um;
                oPr.Codigo_ca = this.Codigo_ca;
                oPr.Stock_min = Convert.ToDecimal(Txt_stock_min.Text);
                oPr.Stock_max = Convert.ToDecimal(Txt_stock_max.Text);
                oPr.Pu_venta = Convert.ToDecimal(Txt_pu_venta.Text);

                Rpta = N_Productos.Guardar_pr(Estadoguarda, oPr);
                if(Rpta == "OK")
                {
                    this.Listado_pr("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_pr.Text = "";
                    Txt_stock_min.Text = "0";
                    Txt_stock_max.Text = "0";
                    Txt_pu_venta.Text = "0";
                    Txt_descripcion_pr.ReadOnly = true;
                    Txt_stock_min.ReadOnly = true;
                    Txt_stock_max.ReadOnly = true;
                    Txt_pu_venta.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_pr = 0;
                    Gbx_detalle.Visible = false;
                    Txt_descripcion_ma.Clear();
                    Txt_descripcion_um.Clear();
                    Txt_descripcion_ca.Clear();

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
            this.Codigo_pr = 0;
            Gbx_detalle.Visible = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            Gbx_detalle.Visible = false;
            this.Codigo_pr = 0;
            Txt_descripcion_pr.Text = "";
            Txt_stock_min.Text = "0";
            Txt_stock_max.Text = "0";
            Txt_pu_venta.Text = "0";    
            Txt_descripcion_pr.ReadOnly=true;
            Txt_stock_min.ReadOnly = true;
            Txt_stock_max.ReadOnly = true;
            Txt_pu_venta.ReadOnly = true;
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;
            this.Listado_stock_actual(this.Codigo_pr);
            Gbx_detalle.Visible = true;

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?","Aviso del Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);    

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_pr = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_pr"].Value);
                    Rpta = N_Productos.Eliminar_pr(this.Codigo_pr);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_pr("%");
                        this.Codigo_pr = 0;
                        MessageBox.Show("Registro eliminado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(Txt_buscar.Text.Trim()); 
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Productos oRpt_pr = new Reportes.Frm_Rpt_Productos();
            oRpt_pr.txt_p1.Text = Txt_buscar.Text;
            oRpt_pr.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ma.Location = Btn_lupa1.Location;
            this.Pnl_Listado_ma.Visible = true;
        }

        private void Dgv_marcas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ma_pr();
            this.Pnl_Listado_ma.Visible = false;
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_um.Location = Btn_lupa1.Location;
            this.Pnl_Listado_um.Visible = true;
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ma.Location = Btn_lupa1.Location;
            this.Pnl_Listado_ma.Visible = true;
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_um.Location = Btn_lupa1.Location;
            this.Pnl_Listado_um.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ma.Visible = false;
        }

        private void Btn_retornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado_um.Visible = false;
        }

        private void Dgv_medidas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_um_pr();
            this.Pnl_Listado_um.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Btn_lupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ca.Location = Btn_lupa1.Location;
            this.Pnl_Listado_ca.Visible = true;
        }

        private void Dgv_categorias_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ca_pr();
            this.Pnl_Listado_ca.Visible = false;
        }

        private void Btn_buscar3_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ca.Location = Btn_lupa1.Location;
            this.Pnl_Listado_ca.Visible = true;
        }

        private void Txt_buscar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_retornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ca.Visible = false;
        }

        private void Pnl_Listado_ma_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
