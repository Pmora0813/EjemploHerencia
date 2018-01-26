using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    // La clase TicketPalco hereda de Ticket
    class TicketPalco : Ticket
    {
        // constructor por defecto
        public TicketPalco()
            : base()
        {
        }

        // constructor que incia el valor del ticket 
        // note como llama al constructor de la clase base
        public TicketPalco(decimal valor)
            : base(valor)
        {
            this.PorcentajeComision = 0.05M;
        }

        // Esta propiedad sobre escribe la clase base
        public override string Nombre
        {
            get
            {
                return "Palco";
            }
        }

        public override decimal Impuesto
        {
            get
            {
                return 0.14M;
            }
        }
    }
}
