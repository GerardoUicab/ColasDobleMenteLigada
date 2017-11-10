using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasLigadas
{
   public class NodoColas
    {
        public NodoColas prev = null, next; //Un Nodo de cola siempre va a apuntar prev a null pues se insertar en head
        public Object info;
        public NodoColas(Object el, NodoColas sig)
        {
            info = el;
            next = sig;
        }
    }
}
