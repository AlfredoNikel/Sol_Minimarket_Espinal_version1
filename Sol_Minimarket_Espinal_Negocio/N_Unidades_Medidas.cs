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
    public class N_Unidades_Medidas
    {
        public static DataTable Listado_um(string cTexto)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Listado_um(cTexto);
        }

        public static string Guardar_um(int nOpcion, E_Unidades_Medidas oUm)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Guardar_um(nOpcion, oUm);
        }


        public static string Eliminar_um(int Codigo_um)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Eliminar_um(Codigo_um);
        }

    }
}
