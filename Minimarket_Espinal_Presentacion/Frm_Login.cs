using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Minimarket_Espinal_Negocio;
using Sol_Minimarket_Espinal_Entidades;

namespace Minimarket_Espinal_Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }


        #region  "Mis metodos"

        private void Login_us(string cLogin, string cPassword)
        {
            try
            {
                DataTable Data_Login = new DataTable();
                Data_Login = N_Usuarios.Login_us(cLogin, cPassword);
                if (Data_Login.Rows.Count>0)
                {
                    string cNombres = "";
                    string cCargo = ""; 
                    bool bAdmin = false;

                    cNombres = Data_Login.Rows[0][3].ToString();
                    cCargo = Data_Login.Rows[0][4].ToString();
                    bAdmin = Convert.ToBoolean(Data_Login.Rows[0][5].ToString());


                    Frm_DashBoard oDashBoard = new Frm_DashBoard();
                    oDashBoard.Lbl_nombres_us.Text = "Nombres: " + cNombres;
                    oDashBoard.Lbl_cargo.Text = "Cargo: " + cCargo;
                    oDashBoard.Chk_Admin.Checked = bAdmin;

                    if (bAdmin==true)
                    {
                        oDashBoard.Btn_Procesos.Visible = true;
                        oDashBoard.Btn_Reportes.Visible = true;
                        oDashBoard.Btn_Sistemas.Visible = true;
                        oDashBoard.Btn_Datos_Maestros.Visible = true;
                        
                    }
                    else //Usuario normal o comun
                    {

                        oDashBoard.Btn_Procesos.Visible = true;
                        oDashBoard.Btn_Reportes.Visible = true;
                        oDashBoard.Btn_Sistemas.Visible = false;
                        oDashBoard.Btn_Datos_Maestros.Visible = false;

                    }


                    oDashBoard.Show();
                    oDashBoard.FormClosed += Logout;
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Minimarket Espinal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

        private void Logout(object sender,FormClosedEventArgs e)
        {

            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_login_us.Focus();

        }

            

        #endregion

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            this.Login_us(Txt_login_us.Text, Txt_password_us.Text);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
