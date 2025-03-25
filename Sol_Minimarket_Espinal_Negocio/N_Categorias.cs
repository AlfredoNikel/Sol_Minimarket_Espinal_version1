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
    public class N_Categorias
    {
        public static DataTable Listado_ca(string cTexto)
        {
            D_categorias Datos = new D_categorias();
            return Datos.Listado_ca(cTexto);
        }

        public static string Guardar_ca(int nOpcion, E_Categorias oCa)
        {
            D_categorias Datos = new D_categorias();
            return Datos.Guardar_ca(nOpcion, oCa);
        }


        public static string Eliminar_ca(int Codigo_ca)
        {
            D_categorias Datos = new D_categorias();
            return Datos.Eliminar_ca(Codigo_ca);
        }

    }
}
