﻿using System;
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
    public partial class Frm_MunicipiosPRO : Form
    {
        public Frm_MunicipiosPRO()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_po = 0;
        int Codigo_de = 0;
        int Estadoguarda = 0; // Sin ninguna accion

        #endregion


        #region "Mis Metodos"

        private void Formato_po()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_PO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "MUNICIPIOS";
            Dgv_principal.Columns[2].Width = 250;
            Dgv_principal.Columns[2].HeaderText = "PROVINCIAS";
            Dgv_principal.Columns[3].Visible = false;
        }

        private void Listado_po(string cTexto)
        {
          try
            {
                Dgv_principal.DataSource = N_MunicipiosPRO.Listado_po(cTexto);
                this.Formato_po();

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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_po"].Value))) 
           {
                MessageBox.Show("No se tiene información para visualizar","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                this.Codigo_de = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_de"].Value);
                Txt_descripcion_de.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_de"].Value).Trim();

                this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text =Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value).Trim();
            }

        }


        private void Formato_de_po()
        {
            
            Dgv_Provincias.Columns[0].Width = 300;
            Dgv_Provincias.Columns[0].HeaderText = "PROVINCIAS";
            Dgv_Provincias.Columns[1].Width = 100;
            Dgv_Provincias.Columns[1].Visible = false;
        }

        private void Listado_de_po(string cTexto)
        {
            try
            {
                Dgv_Provincias.DataSource = N_MunicipiosPRO.Listado_de_po(cTexto);
                this.Formato_de_po();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Selecciona_item_de_po()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Provincias.CurrentRow.Cells["codigo_de"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_de = Convert.ToInt32(Dgv_Provincias.CurrentRow.Cells["codigo_de"].Value);
                Txt_descripcion_de.Text = Convert.ToString(Dgv_Provincias.CurrentRow.Cells["descripcion_de"].Value);
            }

        }

        #endregion




        private void Frm_MunicipiosPRO_Load(object sender, EventArgs e)
        {
            this.Listado_po("%");
            this.Listado_de_po("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_po.Text = "";
            Txt_descripcion_po.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_po.Focus();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_po.ReadOnly = false;
            Txt_descripcion_po.Focus();

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
                Txt_descripcion_de.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)" ,"Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procederia a registrar la informacion
            {
                
                E_MunicipiosPRO oPo = new E_MunicipiosPRO();
                string Rpta = "";
                oPo.Codigo_po = this.Codigo_po;
                oPo.Descripcion_po = Txt_descripcion_po.Text.Trim();
                oPo.Codigo_de = this.Codigo_de;
                Rpta = N_MunicipiosPRO.Guardar_po(Estadoguarda, oPo);
                if(Rpta == "OK")
                {
                    this.Listado_po("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_po.Text = "";
                    Txt_descripcion_po.ReadOnly = true;
                    Txt_descripcion_de.Clear();
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_de = 0;
                    

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
            this.Codigo_po = 0;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_po = 0;
            Txt_descripcion_po.Text = "";
            Txt_descripcion_po.ReadOnly=true;
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_po"].Value)))
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
                    this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                    Rpta = N_MunicipiosPRO.Eliminar_po(this.Codigo_po);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_po("%");
                        this.Codigo_de = 0;
                        MessageBox.Show("Registro eliminado","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }

                
               
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
             this.Listado_po(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_MunicipiosPRO oRpt7 = new Reportes.Frm_Rpt_MunicipiosPRO();
            oRpt7.txt_p1.Text = Txt_buscar.Text;
            oRpt7.ShowDialog();
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
            Pnl_Listado_de.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_de.Visible = false;
        }

        private void Dgv_Provincias_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_de_po();
            Pnl_Listado_de.Visible = false;
            Txt_descripcion_po.Focus();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_de_po(Txt_buscar1.Text.Trim());
        }

        private void Txt_descripcion_po_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_Provincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
