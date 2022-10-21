using Capa_Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DCategoria
    {
        public DataTable Listar() // devuelve un objeto del tipo datatable
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable(); // representa una tabla en memoria
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_listar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado); //llenamos el dataTable con su metodo load con el valor obtenido (Resultado)
                return tabla;
            }
            catch (Exception ex) // catch para controlar si surge un error en nuestro codigo dentro del try 
            {
                throw ex;
               
            }
            finally // se ejecuta en ambas opciones (Try,catch)
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
        public DataTable Buscar(string valor) //espera un parametro para buscar
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable(); // representa una tabla en memoria
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_buscar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor",SqlDbType.VarChar).Value= valor;// devuelve un DataTable que coincida con el parametro
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado); //llenamos el dataTable con su metodo load con el valor obtenido (Resultado)
                return tabla;
            }
            catch (Exception ex) // catch para controlar si surge un error en nuestro codigo dentro del try 
            {
                throw ex;

            }
            finally // se ejecuta en ambas opciones (Try,catch)
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
        public string Existe(string valor) // nos devuelve una cadena  de texto,espera un objeto que se insertara 
                                                 //en la tabla categoria de la base de datos
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_existe,", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@exite";// enlazamos ParExiste con @existe del procedimientoAlmacenado
                ParExiste.SqlDbType = SqlDbType.Int; // declaramos el tipo de dato
                ParExiste.Direction = ParameterDirection.Output;// se indica que es un parametro de salida
                comando.Parameters.Add(ParExiste);// se agrega al comando
                sqlcon.Open();
               comando.ExecuteNonQuery();// luego que se ejecuta el Procedimiento ParExiste toma valor
                Rpta = Convert.ToString(ParExiste.Value);// convertimos ParExiste a string

            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Insertar(E_Categorias Obj  ) // nos devuelve una cadena  de texto,espera un objeto que se insertara 
                                                   //en la tabla categoria de la base de datos
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_insertar,",sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                 

            }
            catch (Exception ex)
            {

                Rpta= ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Actualizar(E_Categorias Obj)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_actualizar,", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";


            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Eliminar(int Id) //espera un el id del registro que se quiere eliminar
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_eliminar,", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value =Id;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_activar,", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" :"No se pudo activar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_desactivar,", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
    }
}
