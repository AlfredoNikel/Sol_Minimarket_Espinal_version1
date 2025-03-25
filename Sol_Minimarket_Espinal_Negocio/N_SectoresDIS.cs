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
    public class N_SectoresDIS
    {
        public static DataTable Listado_di(string cTexto)
        {
            D_SectoresDIS Datos = new D_SectoresDIS();
            return Datos.Listado_di(cTexto);
        }

        public static string Guardar_di(int nOpcion, E_SectoresDIS oDi)
        {
            D_SectoresDIS Datos = new D_SectoresDIS();
            return Datos.Guardar_di(nOpcion, oDi);
        }


        public static string Eliminar_di(int Codigo_di)
        {
            D_SectoresDIS Datos = new D_SectoresDIS();
            return Datos.Eliminar_di(Codigo_di);
        }

        public static DataTable Listado_po_personalizado(string cTexto)
        {
            D_SectoresDIS Datos = new D_SectoresDIS();
            return Datos.Listado_po_personalizado(cTexto);
        }

    }
}
