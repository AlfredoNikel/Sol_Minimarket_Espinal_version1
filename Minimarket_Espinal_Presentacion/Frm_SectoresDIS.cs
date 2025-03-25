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
    public partial class Frm_SectoresDIS: Form
    {
        public Frm_SectoresDIS()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_di = 0;
        int Codigo_po = 0;
        int Estadoguarda = 0; // Sin ninguna accion

        #endregion


        #region "Mis Metodos"

        private void Formato_di()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_DI";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "SECTOR";
            Dgv_principal.Columns[2].Width = 250;
            Dgv_principal.Columns[2].HeaderText = "MUNICIPIO";
            Dgv_principal.Columns[3].Width = 250;
            Dgv_principal.Columns[3].HeaderText = "PROVINCIA";
            Dgv_principal.Columns[4].Visible = false;
        }

        private void Listado_di(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_SectoresDIS.Listado_di(cTexto);
                this.Formato_di();

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
            this.Btn_lupa1.Visible = lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_di"].Value))) 
           {
                MessageBox.Show("No se tiene información para visualizar","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value).Trim();

                this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_di"].Value).Trim();
            }

        }


        private void Formato_po_personalizado()
        {
            Dgv_Municipios.Columns[0].Width = 300;
            Dgv_Municipios.Columns[0].HeaderText = "MUNICIPIO";
            Dgv_Municipios.Columns[1].Width = 300;
            Dgv_Municipios.Columns[1].HeaderText = "PROVINCIA";
            Dgv_Municipios.Columns[1].Width = 300;
            Dgv_Municipios.Columns[2].Visible = false;
        }

        private void Listado_po_personalizado(string cTexto)
        {
            try
            {
                Dgv_Municipios.DataSource = N_SectoresDIS.Listado_po_personalizado(cTexto);
                this.Formato_po_personalizado();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_po_personalizado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Municipios.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_po = Convert.ToInt32(Dgv_Municipios.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_Municipios.CurrentRow.Cells["descripcion_po"].Value);
            }

        }

        #endregion




        private void Frm_SectoresDIS_Load(object sender, EventArgs e)
        {
            this.Listado_di("%");
            this.Listado_po_personalizado("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_di.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_di.ReadOnly = false;
            Txt_descripcion_di.Focus();

        }

        private void modif_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Txt_descripcion_po.Text == String.Empty ||
                Txt_descripcion_di.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)" ,"Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procederia a registrar la informacion
            {
                
                E_SectoresDIS oDi = new E_SectoresDIS();
                string Rpta = "";
                oDi.Codigo_di = this.Codigo_di;
                oDi.Descripcion_di = Txt_descripcion_di.Text.Trim();
                oDi.Codigo_po = this.Codigo_po;
                Rpta = N_SectoresDIS.Guardar_di(Estadoguarda, oDi);
                if(Rpta == "OK")
                {
                    this.Listado_di("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_di.Text = "";
                    Txt_descripcion_di.ReadOnly = true;
                    Txt_descripcion_po.Clear();
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_di = 0;
                    

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
            this.Codigo_di = 0;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_di = 0;
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly=true;
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_di"].Value)))
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
                    this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                    Rpta = N_SectoresDIS.Eliminar_di(this.Codigo_di);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_di("%");
                        this.Codigo_di = 0;
                        MessageBox.Show("Registro eliminado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
             this.Listado_di(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_SectoresDIS oRpt8 = new Reportes.Frm_Rpt_SectoresDIS();
            oRpt8.txt_p1.Text = Txt_buscar.Text;
            oRpt8.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_descripcion_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = false;
        }

        private void Dgv_Provincias_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_po_personalizado();
            Pnl_Listado_po.Visible = false;
            Txt_descripcion_di.Focus();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_po_personalizado(Txt_buscar1.Text.Trim());
        }

        private void Txt_descripcion_po_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Dgv__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Selecciona_item_de_po();
            //Pnl_Listado_po.Visible = false;
            //Txt_descripcion_di.Focus();
        }

        private void Dgv_Municipios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
