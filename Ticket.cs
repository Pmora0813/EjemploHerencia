using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploHerencia
{
    // Clase base Ticket NO se puede instanciar por ser abstract
    abstract class Ticket
    {
        // constructor por defecto
        public Ticket()
        {
        }

        // constructor que incia el valor del ticket
        public Ticket(decimal valor)
        {
            this.Valor = valor;
        }

        // representa el monto del ticket
        public decimal Valor { get; set; }

        // representa el porcentaje de la comision 
        // solo se puede usar en esta clase y sus derivadas
        protected decimal PorcentajeComision { get; set; }

        // virtual permite que las propiedades derivadas se sobre-escriban
        public virtual string Nombre
        {
            get
            {
                return "Ticket";
            }
        } 
       
        // abstract indica que es obligatorio sobre-escribir este 
        // metodo
        public abstract decimal Impuesto
        {
            get;

        }
        //private double costo;

        //public double Costo
        //{
        //    get { return costo; }
        //    set { costo = value; }
        //}

        public double Costo { get; set; }
        asdadasdsadadadas
        // calcula el monto de la comision        
        public decimal CalcularComision()
        {
            return this.Valor * this.PorcentajeComision;
        }

        // sobreescribe el ToString 
        // note como el nombre que se llama pertenece al valor de la clase derivada
        public override string ToString()
        {
            return "TIPO: " + this.Nombre + " VALOR: " + this.Valor.ToString("C");
        }
    }
}
