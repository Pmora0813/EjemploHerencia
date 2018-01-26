using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    // La clase TicketVIP hereda de Ticket
    class TicketVIP : Ticket
    {
        // constructor por defecto
        public TicketVIP()
            : base()
        {
        }

        // constructor que incia el valor del ticket 
        // note como llama al constructor de la clase base
        public TicketVIP(decimal valor)
            : base(valor)
        {            
            this.PorcentajeComision = 0.1M;
        }

        public override decimal Impuesto
        {
            get
            {
                return 0.15M;
            }
        }

        // Esta propiedad sobre escribe la clase base
        public override string Nombre
        {
            get
            {
                return "VIP";
            }
        }
    }
}
