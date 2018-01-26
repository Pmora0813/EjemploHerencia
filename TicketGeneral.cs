using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    // La clase TicketGeneral hereda de Ticket
    class TicketGeneral : Ticket
    {
        // constructor por defecto
        public TicketGeneral()
            : base()
        {
        }

        // constructor que incia el valor del ticket 
        // note como llama al constructor de la clase base
        public TicketGeneral(decimal valor)
            : base(valor)
        {
            this.PorcentajeComision = 0.02M;
        }

        public override decimal Impuesto
        {
            get
            {
                return 0.13M;
            }
        }

        // Esta propiedad sobre escribe la clase base
        public override string Nombre
        {
            get
            {
                return "General";
            }
        }       

        // Esta propiedad se oculta, llamando a la clase base
        //public new string Nombre
        //{
        //    get
        //    {
        //        return "General";
        //    }
        //}
    }
}
