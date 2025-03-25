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
    public partial class Frm_Usuarios: Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_us = 0;
        int Estadoguarda = 0; // Sin ninguna accion

        #endregion


        #region "Mis Metodos"

        private void Formato_us()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_US";
            Dgv_principal.Columns[1].Width = 100;
            Dgv_principal.Columns[1].HeaderText = "LOGIN";
            Dgv_principal.Columns[2].Width = 300;
            Dgv_principal.Columns[2].HeaderText = "NOMBRES";
            Dgv_principal.Columns[3].Width = 300;
            Dgv_principal.Columns[3].HeaderText = "CARGO";
            Dgv_principal.Columns[4].Visible = false;
        }

        private void Listado_us(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_Usuarios.Listado_us(cTexto);
                this.Formato_us();

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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_us"].Value))) 
           {
                MessageBox.Show("No se tiene información para visualizar","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                this.Codigo_us = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_us"].Value);
                Txt_login_us.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["login_us"].Value);
                Txt_password_us.Text = "";
                Txt_Nombres_us.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["nombres_us"].Value);
                Txt_cargo_us.Text= Convert.ToString(Dgv_principal.CurrentRow.Cells["cargo_us"].Value);
                Chk_admin_us.Checked = Convert.ToBoolean(Dgv_principal.CurrentRow.Cells["admin"].Value);


            }

        }


        #endregion




        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_Nombres_us.Text = "";
            Txt_cargo_us.Text = "";
            Chk_admin_us.Checked = false;

            Txt_login_us.ReadOnly = false;
            Txt_password_us.ReadOnly = false;
            Txt_Nombres_us.ReadOnly = false;
            Txt_cargo_us.ReadOnly = false;
            Chk_admin_us.Enabled = true;
            Tbp_principal.SelectedIndex = 1;
            Txt_login_us.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;

            Txt_login_us.ReadOnly = false;
            Txt_Nombres_us.ReadOnly= false;
            Txt_cargo_us.ReadOnly = false;
            Chk_admin_us.Enabled = true;
            Txt_password_us.ReadOnly=false;

            Txt_password_us.Focus();

        }

        private void modif_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {   
             if(Txt_password_us.Text == String.Empty && this.Estadoguarda == 1)
             {

                  MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              

             }
            else
            {

                if (Txt_login_us.Text == String.Empty ||
                    Txt_Nombres_us.Text == string.Empty)
                {

                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // Se procederia a registrar la informacion
                {

                    E_Usuarios oUs = new E_Usuarios();
                    string Rpta = "";
                    oUs.Codigo_us = this.Codigo_us;
                    oUs.Login_us = Txt_login_us.Text.Trim();
                    oUs.Password_us = Txt_password_us.Text.Trim();
                    oUs.Nombre_us = Txt_Nombres_us.Text.Trim();
                    oUs.Cargo_us = Txt_cargo_us.Text.Trim();
                    oUs.Admin = Chk_admin_us.Checked;

                    Rpta = N_Usuarios.Guardar_us(Estadoguarda, oUs);
                    if (Rpta == "OK")
                    {
                        this.Listado_us("%");
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Estadoguarda = 0; //Sin ninguna accion
                        this.Estado_Botonesprincipales(true);
                        this.Estado_Botonesprocesos(false);
                        Txt_login_us.Text = "";
                        Txt_password_us.Text = "";
                        Txt_Nombres_us.Text = "";
                        Txt_cargo_us.Text = "";
                        Chk_admin_us.Checked = false;

                        Txt_login_us.ReadOnly = true;
                        Txt_password_us.ReadOnly = true;
                        Txt_Nombres_us.ReadOnly = true;
                        Txt_cargo_us.ReadOnly = true;
                        Chk_admin_us.Enabled = false;
                        Tbp_principal.SelectedIndex = 0;
                        this.Codigo_us = 0;

                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }



        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
            this.Codigo_us = 0;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_us = 0;
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_Nombres_us.Text = "";
            Txt_cargo_us.Text = "";
            Chk_admin_us.Checked = false;

            Txt_login_us.ReadOnly = true;
            Txt_password_us.ReadOnly = true;
            Txt_Nombres_us.ReadOnly = true;
            Txt_cargo_us.ReadOnly = true;
            Chk_admin_us.Enabled = false;

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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_us"].Value)))
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
                    this.Codigo_us = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_us"].Value);
                    Rpta = N_Usuarios.Eliminar_us(this.Codigo_us);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_us("%");
                        this.Codigo_us = 0;
                        MessageBox.Show("Registro eliminado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(Txt_buscar.Text.Trim()); 
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            //Reportes.Frm_Rpt_Unidades_Medidas oRpt3 = new Reportes.Frm_Rpt_Unidades_Medidas();
            //oRpt3.txt_p1.Text = Txt_buscar.Text;
            //oRpt3.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_descripcion_um_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
