using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class TicketSol : Ticket
    {

        public decimal valor { get; set; }

        public TicketSol()
        {
           
        }

        public TicketSol(decimal valor)
            : base(valor)
        {
            this.PorcentajeComision = 0.05M;
        }

        public override decimal Impuesto
        {
            get
            {
                return 0.13M;
            }
        }

        public override string Nombre
        {
            get
            {
                return "Sol";
            }
        }


        public decimal CalcularComision()
        {
            return this.Valor * this.PorcentajeComision;
        }

        


    }
}
