using Capa_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
   public class NCategoria
    {
        // las Funciones sera estaticas porque no se generara objetos instanciando la clase NCategoria
        //simplemente se hara referencia a la  NCategoria y al metodo en especifico
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar (string valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);
        }
        public static string Insertar (string Nombre,string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string existe = Datos.Existe(Nombre);// cargamos la funcion Existe de la clase DCategorias, validamos si hay igualdad
            if(existe.Equals("1"))
            {
                return "La Categoria ya existe";
            }
            else
            {    //creamos un objeto de la clase E_Categorias
                E_Categorias Obj = new E_Categorias(); // luego de validar si existia igualdad, cargamos el objeto de la clase E_Categoria y lo mandamos
                Obj.Nombre = Nombre;                    //  ala clase DCategorias a su funcion Insertar
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj); // mandamos el objeto a la funcion insertar
            }
           
        }
        public static string Actualizar(int Id,string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string existe = Datos.Existe(Nombre);
            if (existe.Equals("1"))
            {
                return "La Categoria ya existe";
            }
            else
            {
                E_Categorias Obj = new E_Categorias();
                Obj.IdCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
           
        }
        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(Id);
        }

    }
}
