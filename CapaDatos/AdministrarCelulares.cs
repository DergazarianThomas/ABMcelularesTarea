using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
{
    public class AdministrarCelulares : DatosConexion
    {

        public int abmCelulares(string accion, Celular objCelular)
        {
            int resultado = -1;  // para controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardad consulta sql
            if (accion == "Alta")
            {
                orden = $"insert into Celulares (Codigo, Alto, Ancho, Modelo, Numero, Usado, Recibido) values ('{objCelular.Codigo}', {objCelular.Alto}, '{objCelular.Ancho}', {objCelular.Modelo}, '{objCelular.Numero}' , {objCelular.Usado}, '{objCelular.Recibido}' );";
            }
              //  orden = "insert into Celulares values (" + objCelular.Codigo + ",'" + objCelular.Alto + "'," + objCelular.Ancho + "'," + objCelular.Modelo + "'," + objCelular.Numero +  "',"  + objCelular.Usado + "'," + objCelular.Recibido + ");";

            if (accion == "Modificar")
                orden = "update Celulares set Alto='" + objCelular.Alto + "', Ancho='" + objCelular.Ancho + "', Modelo=" + objCelular.Modelo + "', Numero='" + objCelular.Numero +  "', Usado=" + objCelular.Usado +", Recibido='" + objCelular.Recibido + "' where codigo = " + objCelular.Codigo + "; ";

            if (accion == "Borrar")
                orden = "delete * from Celulares where Codigo =" + objCelular.Codigo + ";";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error de la accion {accion}", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoCelulares(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Celulares where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Celulares;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar celulares", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
