using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    sealed class TicketNoHeredado
    {
    }

    // No se puede derivar de una clase sealed. Error de compilacion
    //class OtroTicket : TicketNoHeredado
    //{
    //}
}
