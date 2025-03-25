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
    public class N_MunicipiosPRO
    {
        public static DataTable Listado_po(string cTexto)
        {
            D_MunicipiosPRO Datos = new D_MunicipiosPRO();
            return Datos.Listado_po(cTexto);
        }

        public static string Guardar_po(int nOpcion, E_MunicipiosPRO oPo)
        {
            D_MunicipiosPRO Datos = new D_MunicipiosPRO();
            return Datos.Guardar_po(nOpcion, oPo);
        }


        public static string Eliminar_po(int Codigo_po)
        {
            D_MunicipiosPRO Datos = new D_MunicipiosPRO();
            return Datos.Eliminar_po(Codigo_po);
        }

        public static DataTable Listado_de_po(string cTexto)
        {
            D_MunicipiosPRO Datos = new D_MunicipiosPRO();
            return Datos.Listado_de_po(cTexto);
        }

    }
}
