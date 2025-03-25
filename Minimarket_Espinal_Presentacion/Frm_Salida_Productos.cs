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
    public partial class Frm_Salida_Productos: Form
    {
        public Frm_Salida_Productos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_sp = 0;
        int Codigo_tde = 0;
        int Codigo_cl = 0;
        int Estadoguarda = 0;
        DataTable TablaDetalle = new DataTable();


        #endregion


        #region "Mis Metodos"

        private void Formato_sp()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_SP";
            Dgv_principal.Columns[1].Width = 150;
            Dgv_principal.Columns[1].HeaderText = "TIPO DOC";
            Dgv_principal.Columns[2].Width = 130;
            Dgv_principal.Columns[2].HeaderText = "NRO DOC";
            Dgv_principal.Columns[3].Width = 150;
            Dgv_principal.Columns[3].HeaderText = "FECHA DOC";
            Dgv_principal.Columns[4].Width = 200;
            Dgv_principal.Columns[4].HeaderText = "NRO.DOC CLI";
            Dgv_principal.Columns[5].Width = 155;
            Dgv_principal.Columns[5].HeaderText = "CLIENTE";
            Dgv_principal.Columns[6].Width = 140;
            Dgv_principal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;




        }

        private void Listado_sp(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_Salida_Productos.Listado_sp(cTexto);
                this.Formato_sp();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.Btn_nuevo.Enabled = lEstado;
            this.Btn_eliminar.Enabled = lEstado;
            this.Btn_reporte.Enabled = lEstado;
            this.Btn_salir.Enabled = lEstado;

        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.Btn_cancelar.Visible= lEstado;
            this.Btn_guardar.Visible= lEstado;

            this.Btn_agregar.Visible= lEstado;
            this.Btn_quitar.Visible= lEstado;
            this.Btn_lupa1.Visible = lEstado;
            this.Btn_lupa2.Visible = lEstado;
           
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_sp"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_sp = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_sp"].Value);
                this.Codigo_tde = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_tde"].Value);
                this.Codigo_cl = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_cl"].Value);
                Txt_descripcion_tde.Text = Dgv_principal.CurrentRow.Cells["descripcion_tde"].Value.ToString();
                Txt_nrodocumento_sp.Text = Dgv_principal.CurrentRow.Cells["nrodocumento_sp"].Value.ToString();
                Dtp_fecha_sp.Value = Convert.ToDateTime(Dgv_principal.CurrentRow.Cells["fecha_sp"].Value);
                Txt_razon_social_cl.Text = Dgv_principal.CurrentRow.Cells["razon_social_cl"].Value.ToString();              
                Txt_Observacion_sp.Text = Dgv_principal.CurrentRow.Cells["observacion_sp"].Value.ToString();
                Txt_subtotal.Text = Dgv_principal.CurrentRow.Cells["subtotal"].Value.ToString();
                Txt_itbis.Text = Dgv_principal.CurrentRow.Cells["itbis"].Value.ToString();
                Txt_total_importe.Text = Dgv_principal.CurrentRow.Cells["total_importe"].Value.ToString();
               
                Dgv_Detalle.DataSource = N_Salida_Productos.Listado_detalle_sp(this.Codigo_sp);
                this.Formato_detalle();

            }

        }


        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_pr",System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_ma",System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Pu_venta", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            this.TablaDetalle.AcceptChanges();

            Dgv_Detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();


        }

        private void Agragar_item(string cDescripcion_pr,
                                  string cDescripcion_ma,
                                  string cDescripcion_um,
                                  decimal nCantidad,
                                  decimal nPu_venta,
                                  decimal n_Total,
                                  int nCodigo_pr)
        {
            DataRow xfila = TablaDetalle.NewRow();  
            xfila["Descripcion_pr"] = cDescripcion_pr;
            xfila["Descripcion_ma"] = cDescripcion_ma;
            xfila["Descripcion_um"] = cDescripcion_um;
            xfila["Cantidad"] = nCantidad;
            xfila["Pu_venta"] = nPu_venta;
            xfila["Total"] = n_Total;
            xfila["Codigo_pr"] = nCodigo_pr;
            this.TablaDetalle.Rows.Add(xfila);
            TablaDetalle.AcceptChanges();


        }

        private void Formato_detalle()
        {
            Dgv_Detalle.Columns[0].Width = 260;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 200;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 85;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 95;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 120;
            Dgv_Detalle.Columns[4].HeaderText = "PU VENTA";
            Dgv_Detalle.Columns[5].Width = 100;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;
            Dgv_Detalle.Columns[5].ReadOnly = true;



        }

        


        private void Formato_tde()
        {
            Dgv_tipo_tde.Columns[0].Width = 210;
            Dgv_tipo_tde.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_tipo_tde.Columns[1].Visible = false;

        }

        private void Listado_tde()
        {
            try
            {
                Dgv_tipo_tde.DataSource = N_Salida_Productos.Listado_tde();
                this.Formato_tde();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_tde()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tipo_tde.CurrentRow.Cells["codigo_tde"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_tde = Convert.ToInt32(Dgv_tipo_tde.CurrentRow.Cells["codigo_tde"].Value);
                Txt_descripcion_tde.Text = Convert.ToString(Dgv_tipo_tde.CurrentRow.Cells["descripcion_tde"].Value);
            }

        }


        


      

        

        

        private void Formato_cl()
        {
            Dgv_clientes.Columns[0].Width = 170;
            Dgv_clientes.Columns[0].HeaderText = "CLIENTE";
            Dgv_clientes.Columns[1].Width = 180;
            Dgv_clientes.Columns[1].HeaderText = "TIPO DOC";
            Dgv_clientes.Columns[2].Width = 180;
            Dgv_clientes.Columns[2].HeaderText = "RNC /CEDULA";
            Dgv_clientes.Columns[3].Visible = false;

        }

        private void Listado_cl(string cTexto)
        {
            try
            {
                Dgv_clientes.DataSource = N_Salida_Productos.Listado_cl_sp(cTexto);
                this.Formato_cl();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_cl()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_clientes.CurrentRow.Cells["codigo_cl"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_cl = Convert.ToInt32(Dgv_clientes.CurrentRow.Cells["codigo_cl"].Value);
                Txt_nrodocumento_cl.Text = Convert.ToString(Dgv_clientes.CurrentRow.Cells["nrodocumento_cl"].Value);
                Txt_razon_social_cl.Text = Convert.ToString(Dgv_clientes.CurrentRow.Cells["razon_social_cl"].Value);
                if (this.Codigo_cl == 1) //Si es cosumidor generico
                {
                   Txt_nrodocumento_cl.ReadOnly =false;
                   Txt_razon_social_cl.ReadOnly = false;
                   Txt_nrodocumento_cl.Focus();

                }
                else // Para los demas clientes
                {
                    Txt_nrodocumento_cl.ReadOnly = true;
                    Txt_razon_social_cl.ReadOnly = true;
                }




            }

        }

        private void Formato_pr()
        {
            Dgv_productos.Columns[0].Width = 220;
            Dgv_productos.Columns[0].HeaderText = "PRODUCTO";
            Dgv_productos.Columns[1].Width = 160;
            Dgv_productos.Columns[1].HeaderText = "MARCA";
            Dgv_productos.Columns[2].Width = 90;
            Dgv_productos.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_productos.Columns[3].Width = 190;
            Dgv_productos.Columns[3].HeaderText = "CATEGORIA";
            Dgv_productos.Columns[4].Width = 150;
            Dgv_productos.Columns[4].HeaderText = "STOCK ACTUAL";
            Dgv_productos.Columns[5].Width = 150;
            Dgv_productos.Columns[5].HeaderText = "PU VENTA";
            Dgv_productos.Columns[6].Visible = false;

        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_productos.DataSource = N_Salida_Productos.Listado_pr_sp(cTexto);
                this.Formato_pr();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_pr()
        {   
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_productos.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                string xDescripcion_pr;
                string xDescripcion_ma;
                string xDescripcion_um;
                decimal xCantidad;
                decimal xPu_venta;
                decimal xTotal;
                int xCodigo_pr;


                bool Agregar = true;

                xCodigo_pr = Convert.ToInt32(Dgv_productos.CurrentRow.Cells["codigo_pr"].Value);
               
                foreach (DataRow Filatem in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatem["Codigo_pr"]) == xCodigo_pr)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuentra agregado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Agregar == true) 
                {

                    xDescripcion_pr = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_pr"].Value);
                    xDescripcion_ma = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_ma"].Value);
                    xDescripcion_um = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_um"].Value);
                    xCantidad = Convert.ToDecimal(Dgv_productos.CurrentRow.Cells["stock_actual"].Value);
                    xPu_venta = Convert.ToDecimal(Dgv_productos.CurrentRow.Cells["pu_venta"].Value);
                    xTotal = decimal.Round(xCantidad * xPu_venta, 2);


                    this.Agragar_item(xDescripcion_pr,
                                      xDescripcion_ma,
                                      xDescripcion_um,
                                      xCantidad,
                                      xPu_venta,
                                      xTotal,
                                      xCodigo_pr);

                    this.Calcular_totales();


                }

            }

        }

        private void Estado_texto(bool lestado)
        {

            Txt_nrodocumento_sp.ReadOnly = !lestado;
            Txt_Observacion_sp.ReadOnly = !lestado;
            Dtp_fecha_sp.Enabled = lestado;


        }


        private void Limpia_texto()
        {

            Txt_nrodocumento_sp.Text=""; //al guardar los cambion coloca las cajas en balnco
            Txt_Observacion_sp.Clear(); //otra forma de al guardar los cambion coloca las cajas en balnco
            Txt_subtotal.Clear();
            Txt_itbis.Clear();
            Txt_total_importe.Clear();
            this.Crear_TablaDetalle();


        }


        private void Calcular_totales()
        {
            decimal nSubtotal = 0;
            decimal nItbis = 0;
            decimal nTotal_importe = 0;

            if (Dgv_Detalle.Rows.Count==0)
            {
                nSubtotal = 0;
                nItbis = 0;
                nTotal_importe = 0;

            }
            else
            {
                TablaDetalle.AcceptChanges();
                foreach (DataRow Filatem in TablaDetalle.Rows)
                {
                    nTotal_importe = nTotal_importe + Convert.ToDecimal(Filatem["total"]);
                }

                decimal nPorcentajeITBIS = 0.18m;
                nSubtotal = nTotal_importe / (1 + nPorcentajeITBIS);
                nItbis = decimal.Round(nTotal_importe - nSubtotal, 2);

                Txt_subtotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                Txt_itbis.Text = nItbis.ToString("#0.00");
                Txt_total_importe.Text = decimal.Round(nTotal_importe, 2).ToString("#0.00");
            }




        }



        #endregion




        private void Frm_Salida_Productos_Load(object sender, EventArgs e)
        {
            
            this.Listado_tde();
            this.Listado_cl("%");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1;
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = false;
            this.Estado_texto(true);
            Tbp_principal.SelectedIndex = 0;
            Txt_nrodocumento_sp.Focus();

        }





        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (Txt_descripcion_tde.Text == string.Empty  ||
                Txt_nrodocumento_sp.Text == string.Empty  ||
                Txt_razon_social_cl.Text == string.Empty  ||
                
                Dgv_Detalle.Rows.Count==0)

            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                // Se procederia a registrar la informacion



                string Rpta = "";
                E_Salida_Productos oSp = new E_Salida_Productos();

                oSp.Codigo_sp = this.Codigo_sp;
                oSp.Codigo_tde = this.Codigo_tde;
                oSp.Nrodocumento_sp = Txt_nrodocumento_sp.Text.Trim();
                oSp.Codigo_cl = this.Codigo_cl;
                oSp.Nrodocumento_cl = Txt_nrodocumento_cl.Text.Trim();
                oSp.Razon_social_cl = Txt_razon_social_cl.Text.Trim();
                oSp.Fecha_sp = Dtp_fecha_sp.Value;
                oSp.Observacion = Txt_Observacion_sp.Text.Trim();
                oSp.Subtotal = Convert.ToDecimal(Txt_subtotal.Text.Trim());
                oSp.itbis = Convert.ToDecimal(Txt_itbis.Text.Trim());
                oSp.total_importe = Convert.ToDecimal(Txt_total_importe.Text.Trim());

                this.TablaDetalle.AcceptChanges();

                Rpta = N_Salida_Productos.Guardar_sp(oSp, TablaDetalle);
                if (Rpta != string.Empty)
                {
                    this.Codigo_sp = Convert.ToInt32(Rpta);
                    MessageBox.Show("Los datos han sido guardados correctamente # "+ this.Codigo_sp, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //En esta parte al darle guardar generamos la factura

                    Reportes.Frm_Rpt_Imprimir_Venta_Generada oRpt_print = new Reportes.Frm_Rpt_Imprimir_Venta_Generada();
                    oRpt_print.txt_p1.Text = Convert.ToString(this.Codigo_sp);
                    oRpt_print.ShowDialog();

                    //Fin de la generacion de la factura

                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    Dgv_Detalle.Columns[3].ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_sp = 0;
                    this.Codigo_tde = 0;
                    this.Codigo_cl = 0;
                    this.Estadoguarda = 0;
                    Txt_descripcion_tde.Clear();
                    Txt_nrodocumento_sp.Clear();
                    Txt_razon_social_cl.Clear();                    
                    Txt_Observacion_sp.Clear();


                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

 

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {   
            
            this.Codigo_sp = 0;
            this.Codigo_tde = 0;
            this.Codigo_cl = 0;
            this.Estadoguarda = 0;

            this.Estado_texto(false);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = true;
            
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
           

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_sp"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de anular el registro seleccionado?","Aviso del Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);    

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_sp = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_sp"].Value);
                    Rpta = N_Salida_Productos.Eliminar_sp(this.Codigo_sp);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_sp("%");
                        this.Limpia_texto();
                        this.Codigo_sp = 0;
                        MessageBox.Show("Registro anulado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        Tbp_principal.SelectedIndex = 1;
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_sp(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Salida_Productos oRpt_sp = new Reportes.Frm_Rpt_Salida_Productos();
            oRpt_sp.txt_p1.Text = Txt_buscar.Text;
            oRpt_sp.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tde.Location = Btn_lupa1.Location;
            this.Pnl_Listado_tde.Visible = true;
        }

        private void Dgv_tipo_tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_tde();
            this.Pnl_Listado_tde.Visible = false;
            Txt_nrodocumento_sp.Focus();
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_cl.Location = Btn_lupa1.Location;
            this.Pnl_listado_cl.Visible = true;
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tde.Location = Btn_lupa1.Location;
            this.Pnl_Listado_tde.Visible = true;
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            //this.Pnl_Listado_sx.Location = Btn_lupa1.Location;
            //this.Pnl_Listado_sx.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_tde.Visible = false;
        }

      

       

        private void label13_Click(object sender, EventArgs e)
        {

        }

  

     

     

        private void Pnl_Listado_ma_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

       

       

        private void Dgv_clientes_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_cl();
            Pnl_listado_cl.Visible = false;
        }

       

        private void Btn_lupa4_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_cl.Location = Btn_lupa1.Location;
            this.Pnl_listado_cl.Visible = true;
        }

        

        private void Btn_retornar11_Click(object sender, EventArgs e)
        {
            Pnl_listado_cl.Visible = false;
        }

        private void Btn_buscar12_Click(object sender, EventArgs e)
        {
            this.Listado_cl(Txt_buscar_7.Text);
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {   
            Pnl_listado_pr.Location = Txt_nrodocumento_sp.Location;
            Pnl_listado_pr.Visible = true;
            Txt_buscar4.Focus();
        }

        private void Btn_retornar4_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Visible = false;
        }

        private void Btn_buscar4_Click(object sender, EventArgs e)
        {
            this.Listado_pr(Txt_buscar4.Text);
        }

        private void Dgv_productos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pr();
            Pnl_listado_pr.Visible = false;
        }

        private void Dgv_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            if(this.Estadoguarda==1)
            {
                DataRow yFila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFila["Cantidad"]);
                decimal yPu_venta = Convert.ToDecimal(yFila["Pu_venta"]);
                yFila["Total"] = decimal.Round(yCantidad * yPu_venta, 2).ToString("#0.00");
                this.Calcular_totales();
            }

           

        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.Rows.Count>0)
            {
                Dgv_Detalle.Rows.Remove(Dgv_Detalle.CurrentRow);
                Dgv_Detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.Calcular_totales();

            }
        }

      
    }
}
