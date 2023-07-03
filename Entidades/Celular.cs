using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular
    {
        #region Atributos
        private int codigo;
        private decimal alto;
        private decimal ancho;
        private int numero;
        private string modelo;
        private bool usado;
        private DateTime recibido;
        #endregion
        #region Constructores
        public Celular() 
        { }
        public Celular(int Codigo, decimal Alto, decimal Ancho, int Num, string Modelo, bool Usado, DateTime Recibido)
        {
            this.codigo = Codigo;
            this.alto = Alto;
            this.ancho = Ancho;
            this.numero = Num;
            this.modelo = Modelo;
            this.usado = Usado;
            this.recibido = Recibido;
        }
        #endregion
        #region Metodos
        public void Cargar()
        {

        }
        #endregion

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public decimal Alto { get { return alto; } set { alto = value; } }
        public decimal Ancho { get { return ancho; } set { ancho = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public string Modelo { get { return modelo; } set { modelo= value; } }
        public bool Usado { get { return usado; } set { usado = value; } }
        public DateTime Recibido { get { return recibido; } set { recibido = value; } }

    }
}
