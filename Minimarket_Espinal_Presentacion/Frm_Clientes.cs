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
    public partial class Frm_Clientes: Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_cl = 0;
        int Codigo_tdpc = 0;
        int Codigo_sx = 0;
        int Codigo_ru = 0;
        int Codigo_di = 0;
        int Estadoguarda = 0; // Sin ninguna accion

        #endregion


        #region "Mis Metodos"

        private void Formato_cl()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_cl";
            Dgv_principal.Columns[1].Width = 100;
            Dgv_principal.Columns[1].HeaderText = "TIPO DOC";
            Dgv_principal.Columns[2].Width = 120;
            Dgv_principal.Columns[2].HeaderText = "NRO DOC";
            Dgv_principal.Columns[3].Width = 280;
            Dgv_principal.Columns[3].HeaderText = "RAZON SOCIAL";
            Dgv_principal.Columns[4].Width = 145;
            Dgv_principal.Columns[4].HeaderText = "NOMBRES";
            Dgv_principal.Columns[5].Width = 145;
            Dgv_principal.Columns[5].HeaderText = "APELLIDOS";
            Dgv_principal.Columns[6].Width = 150;
            Dgv_principal.Columns[6].HeaderText = "RUBRO";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;
            Dgv_principal.Columns[12].Visible = false;
            Dgv_principal.Columns[13].Visible = false;
            Dgv_principal.Columns[14].Visible = false;
            Dgv_principal.Columns[15].Visible = false;
            Dgv_principal.Columns[16].Visible = false;
            Dgv_principal.Columns[17].Visible = false;
            Dgv_principal.Columns[18].Visible = false;
            Dgv_principal.Columns[19].Visible = false;


        }

        private void Listado_cl(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_Clientes.Listado_cl(cTexto);
                this.Formato_cl();

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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_cl"].Value))) 
           {
                MessageBox.Show("No se tiene información para visualizar","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                string Distrito = "";
                this.Codigo_cl = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_cl"].Value);
                this.Codigo_tdpc = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_tdpc"].Value);
                Txt_descripcion_tdpc.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_tdpc"].Value);
                Txt_nrodocumento_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["nrodocumento_cl"].Value);
                Txt_razon_social_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["razon_social_cl"].Value);
                Txt_nombres.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["nombres"].Value);
                Txt_apellidos.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["apellidos"].Value);
                this.Codigo_ru = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ru"].Value);
                Txt_descripcion_ru.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ru"].Value);
                Txt_email_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["email_cl"].Value);
                Txt_telefono_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["telefono_cl"].Value);
                Txt_movil_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["movil_cl"].Value);
                this.Codigo_sx = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_sx"].Value);
                Txt_descripcion_sx.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_sx"].Value);
                Txt_direccion_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["direccion_cl"].Value);
                this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);

                Distrito = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_di"].Value).Trim() + "  ||  " +
                           Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value).Trim() + "  ||  " +
                           Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_de"].Value).Trim();
                Txt_distrito.Text = Distrito;
                Txt_Observacion_cl.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["observacion_cl"].Value).Trim();



            }

        }



        private void Formato_tdpc()
        {
            Dgv_tipo_tdpc.Columns[0].Width = 210;
            Dgv_tipo_tdpc.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_tipo_tdpc.Columns[1].Visible = false;

        }

        private void Listado_tdpc()
        {
            try
            {
                Dgv_tipo_tdpc.DataSource = N_Clientes.Listado_tdpc();
                this.Formato_tdpc();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_tdpc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tipo_tdpc.CurrentRow.Cells["codigo_tdpc"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_tdpc = Convert.ToInt32(Dgv_tipo_tdpc.CurrentRow.Cells["codigo_tdpc"].Value);
                Txt_descripcion_tdpc.Text = Convert.ToString(Dgv_tipo_tdpc.CurrentRow.Cells["descripcion_tdpc"].Value);
            }

        }


        private void Formato_sx()
        {
            Dgv_sexos.Columns[0].Width = 250;
            Dgv_sexos.Columns[0].HeaderText = "SEXO";
            Dgv_sexos.Columns[1].Visible = false;

        }

        private void Listado_sx()
        {
            try
            {
                Dgv_sexos.DataSource = N_Clientes.Listado_sx();
                this.Formato_sx();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_sx()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_sexos.CurrentRow.Cells["codigo_sx"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_sx = Convert.ToInt32(Dgv_sexos.CurrentRow.Cells["codigo_sx"].Value);
                Txt_descripcion_sx.Text = Convert.ToString(Dgv_sexos.CurrentRow.Cells["descripcion_sx"].Value);
            }

        }


        private void Formato_ru()
        {
            Dgv_rubros.Columns[0].Width = 270;
            Dgv_rubros.Columns[0].HeaderText = "RUBROS";
            Dgv_rubros.Columns[1].Visible = false;

        }

        private void Listado_ru(string cTexto)
        {
            try
            {
                Dgv_rubros.DataSource = N_Clientes.Listado_ru_cl(cTexto);
                this.Formato_ru();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_ru()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_rubros.CurrentRow.Cells["codigo_ru"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ru = Convert.ToInt32(Dgv_rubros.CurrentRow.Cells["codigo_ru"].Value);
                Txt_descripcion_ru.Text = Convert.ToString(Dgv_rubros.CurrentRow.Cells["descripcion_ru"].Value);
            }

        }

        private void Formato_di()
        {
            Dgv_sectores.Columns[0].Width = 170;
            Dgv_sectores.Columns[0].HeaderText = "SECTOR";
            Dgv_sectores.Columns[1].Width = 180;
            Dgv_sectores.Columns[1].HeaderText = "MUNICIPIO";
            Dgv_sectores.Columns[2].Width = 180;
            Dgv_sectores.Columns[2].HeaderText = "PROVINCIA";
            Dgv_sectores.Columns[3].Visible = false;

        }

        private void Listado_di(string cTexto)
        {
            try
            {
                Dgv_sectores.DataSource = N_Clientes.Listado_di_cl(cTexto);
                this.Formato_di();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_di()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_sectores.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_di = Convert.ToInt32(Dgv_sectores.CurrentRow.Cells["codigo_di"].Value);
                Txt_distrito.Text = Convert.ToString(Dgv_sectores.CurrentRow.Cells["descripcion_di"].Value) + "  ||  " +
                                    Convert.ToString(Dgv_sectores.CurrentRow.Cells["descripcion_po"].Value) + "  ||  " +
                                    Convert.ToString(Dgv_sectores.CurrentRow.Cells["descripcion_de"].Value) ;
            }

        }

        private void Estado_texto(bool lestado)
        {

            Txt_nrodocumento_cl.ReadOnly = !lestado;
            Txt_razon_social_cl.ReadOnly = !lestado;
            Txt_nombres.ReadOnly = !lestado;
            Txt_apellidos.ReadOnly = !lestado;
            Txt_email_cl.ReadOnly = !lestado;
            Txt_telefono_cl.ReadOnly = !lestado;
            Txt_movil_cl.ReadOnly = !lestado;
            Txt_direccion_cl.ReadOnly = !lestado;
            Txt_Observacion_cl.ReadOnly = !lestado;

        }


        private void Limpia_texto()
        {

            Txt_nrodocumento_cl.Text = "";
            Txt_razon_social_cl.Text = "";
            Txt_nombres.Text = "";
            Txt_apellidos.Text = "";
            Txt_email_cl.Text = "";
            Txt_telefono_cl.Text = "";
            Txt_movil_cl.Text = "";
            Txt_direccion_cl.Text = "";
            Txt_Observacion_cl.Text = "";

        }




        #endregion




        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            this.Listado_cl("%");
            this.Listado_tdpc();
            this.Listado_sx();
            this.Listado_ru("%");
            this.Listado_di("%");
           
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro           
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            this.Estado_texto(true);
            Tbp_principal.SelectedIndex = 1;
            Txt_nrodocumento_cl.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2;// Actualizar Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);           
            this.Estado_texto(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_nrodocumento_cl.Focus();

        }

       

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Txt_nrodocumento_cl.Text == String.Empty || 
                Txt_descripcion_tdpc.Text == String.Empty ||
                Txt_descripcion_sx.Text == String.Empty ||
                Txt_distrito.Text == String.Empty || 
                Txt_razon_social_cl.Text == String.Empty ||
                Txt_distrito.Text == String.Empty ||
                Txt_direccion_cl.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)" ,"Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procederia a registrar la informacion
            {


                
                string Rpta = "";
                E_Clientes oCl = new E_Clientes();

                oCl.Codigo_cl = this.Codigo_cl;
                oCl.Codigo_tdpc = this.Codigo_tdpc;
                oCl.Nrodocumento_cl = Txt_nrodocumento_cl.Text.Trim();
                oCl.Razon_social_cl = Txt_razon_social_cl.Text.Trim();
                oCl.Nombres = Txt_nombres.Text.Trim();
                oCl.Apellidos = Txt_apellidos.Text.Trim();
                oCl.Codigo_sx = this.Codigo_sx;
                oCl.Codigo_ru = this.Codigo_ru;
                oCl.Email_cl = Txt_email_cl.Text.Trim();
                oCl.Telefono_cl = Txt_telefono_cl.Text.Trim();
                oCl.Movil_cl = Txt_movil_cl.Text.Trim();
                oCl.Direccion_cl = Txt_direccion_cl.Text.Trim();
                oCl.Codigo_di = this.Codigo_di;
                oCl.Observacion_cl = Txt_Observacion_cl.Text.Trim();




                Rpta = N_Clientes.Guardar_cl(Estadoguarda, oCl);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_cl("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_cl = 0;
                    this.Codigo_tdpc = 0;
                    this.Codigo_sx = 0;
                    this.Codigo_ru = 0;
                    this.Codigo_di = 0;
                    Txt_descripcion_ru.Clear();
                    Txt_descripcion_sx.Clear();
                    Txt_descripcion_tdpc.Clear();
                    Txt_distrito.Clear();

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
           

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion

            this.Codigo_cl = 0;
            this.Codigo_tdpc = 0;
            this.Codigo_sx = 0;
            this.Codigo_ru = 0;
            this.Codigo_di = 0;
            this.Estado_texto(false);
            this.Limpia_texto();
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;
           

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_cl"].Value)))
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
                    this.Codigo_cl = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_cl"].Value);
                    Rpta = N_Clientes.Eliminar_cl(this.Codigo_cl);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_cl("%");
                        this.Codigo_cl = 0;
                        MessageBox.Show("Registro eliminado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_cl(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Clientes oRpt_cl = new Reportes.Frm_Rpt_Clientes();
            oRpt_cl.txt_p1.Text = Txt_buscar.Text;
            oRpt_cl.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tdpc.Location = Btn_lupa1.Location;
            this.Pnl_Listado_tdpc.Visible = true;
        }

        private void Dgv_tipo_tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_tdpc();
            this.Pnl_Listado_tdpc.Visible = false;
            Txt_nrodocumento_cl.Focus();
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_sx.Location = Btn_lupa1.Location;
            this.Pnl_Listado_sx.Visible = true;
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tdpc.Location = Btn_lupa1.Location;
            this.Pnl_Listado_tdpc.Visible = true;
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_sx.Location = Btn_lupa1.Location;
            this.Pnl_Listado_sx.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_tdpc.Visible = false;
        }

        private void Btn_retornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado_sx.Visible = false;
        }

        private void Dgv_sexos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_sx();
            this.Pnl_Listado_sx.Visible = false;
        }



     

     

        private void Btn_buscar3_Click(object sender, EventArgs e)
        {
            this.Listado_ru(Txt_buscar3.Text.Trim());
            
            
        }

    

        private void Btn_retornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ru.Visible = false;
            
        }

  

   

        private void Dgv_sexos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_sx();
            Pnl_Listado_sx.Visible = false;
        }

        private void Dgv_rubros_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_ru();
            Pnl_Listado_ru.Visible = false;
        }

        private void Dgv_sectores_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_di();
            Pnl_listado_di.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ru.Location = Btn_lupa1.Location;
            this.Pnl_Listado_ru.Visible = true;
        }

        private void Btn_lupa4_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_di.Location = Btn_lupa1.Location;
            this.Pnl_listado_di.Visible = true;
        }

        private void Btn_buscar12_Click(object sender, EventArgs e)
        {
            this.Listado_di(Txt_buscar_7.Text.Trim());
        }

        private void Btn_retornar11_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
