﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Minimarket_Espinal_Entidades;


namespace Sol_Minimarket_Espinal_Datos
{
    public class D_MunicipiosPRO
    {

        public DataTable Listado_po(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_po", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }

            catch (Exception ex)
            {
                throw ex;
            }


            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();



            }


        }

        public string Guardar_po(int nOpcion, E_MunicipiosPRO oPo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_po", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_po", SqlDbType.Int).Value = oPo.Codigo_po;
                Comando.Parameters.Add("@cDescripcion_po", SqlDbType.VarChar).Value = oPo.Descripcion_po;
                Comando.Parameters.Add("@nCodigo_de", SqlDbType.Int).Value = oPo.Codigo_de;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar los datos ";

            }

            catch (Exception ex)
            {

                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;


        }


        public string Eliminar_po(int Codigo_po)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_po", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_po", SqlDbType.Int).Value = Codigo_po;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminarlos datos ";

            }

            catch (Exception ex)
            {

                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;


        }

        public DataTable Listado_de_po(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_de_po", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }

            catch (Exception ex)
            {
                throw ex;
            }


            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();



            }


        }

    }
}
