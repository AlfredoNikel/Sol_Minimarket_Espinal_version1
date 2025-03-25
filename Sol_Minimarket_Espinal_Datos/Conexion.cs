using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Sol_Minimarket_Espinal_Datos
{
    public class Conexion
    {
        private string Base_de_datos;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;


        private Conexion()
        {
            this.Base_de_datos = "BD_Minimarket_Espinal";
            this.Servidor = "DESKTOP-4D33T94\\SQLEXPRESS";
            this.Usuario = "sistemas";
            this.Clave = "12345";
            this.Seguridad = false;
        }

        public SqlConnection crearConexion() 
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base_de_datos + ";";
                
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario+"; Password="+ this.Clave;
                }

              
            
            }

            catch (Exception ex)
            {

                Cadena = null;

                throw ex;

            }

            return Cadena;
        
        }

      public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }

            return Con;
        }

    }
}
