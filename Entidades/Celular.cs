﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular
    {
        #region Atributos
        private decimal codigo;
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

        public int Codigo { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public int Numero { get; set; }
        public string Modelo { get; set; }
        public bool Usado { get; set; }
        public DateTime Recibido { get; set; }

    }
}
