using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAjedrez.Piezas
{
    public class Torre : PiezaAjedrez
    {

        public override string Mover()
        {
            return "El Torre se mueve en Linea Recta";
        }
    }
}
