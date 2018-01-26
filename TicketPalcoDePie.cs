using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class TicketPalcoDePie : Ticket
    {
        public TicketPalcoDePie()
            : base()
        {

        }

        public TicketPalcoDePie(decimal precio)
            : base(precio)
        {
            this.PorcentajeComision = 0.05M;
        }

        public override decimal Impuesto
        {
            get
            {
                return 0.25M;
            }
        }

        public override string Nombre
        {
            get
            {
                return "Palco de pie";
            }
        }
    }
}
