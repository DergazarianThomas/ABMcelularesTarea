using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;
namespace CapaNegocios
{
    public class NegCelulares
    {
        AdministrarCelulares DatosObjCelulares = new AdministrarCelulares();

        public int abmCelulares(string accion, Celular objCelular)
        {
            return DatosObjCelulares.abmCelulares(accion, objCelular);
        }
        public DataSet listadoCelulares(string cual)
        {
            return DatosObjCelulares.listadoCelulares(cual);
        }







    }
}
