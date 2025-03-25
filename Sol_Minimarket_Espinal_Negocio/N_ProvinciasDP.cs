using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Minimarket_Espinal_Entidades;
using Sol_Minimarket_Espinal_Datos;


namespace Sol_Minimarket_Espinal_Negocio
{
    public class N_ProvinciasDP
    {
        public static DataTable Listado_de(string cTexto)
        {
            D_ProvinciasDP Datos = new D_ProvinciasDP();
            return Datos.Listado_de(cTexto);
        }

        public static string Guardar_de(int nOpcion, E_ProvinciasDP oDe)
        {
            D_ProvinciasDP Datos = new D_ProvinciasDP();
            return Datos.Guardar_de(nOpcion, oDe);
        }


        public static string Eliminar_de(int Codigo_de)
        {
            D_ProvinciasDP Datos = new D_ProvinciasDP();
            return Datos.Eliminar_de(Codigo_de);
        }

    }
}
