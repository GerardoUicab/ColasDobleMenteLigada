using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasLigadas
{
    public class Colas
    {
        private NodoColas head, tail;
              
        public Colas()
        {
            head = tail = null;
        }

        public void vaciarCola()
        {
            head = tail = null;
        }

        ///<summary>
        ///Enfila un elemento en una cola. El elemento se almacena al final de la cola
        ///</summary>
        ///<return>
        ///No devuelve valores.
        ///</return>
        ///<param name="el">
        ///Recibe como parametro un Objeto denominado el
        ///</param> 

        public void Enqueue(Object el)
        {
            if (tail == null)//La cola esta vacía y esta ingresando el primer nodo
            {
                tail = head = new NodoColas(el, head);
            }
            else
            {
                head.prev = new NodoColas(el, head);
                head = head.prev;
            }
        }

        public Object Dequeue()
        {
            if (tail == null)//Si la pila esta vacía
                return "Cola Vacía";
            else
            {
                Object temp = null;
                if (head == tail) //Si solo hay un nodo
                {
                    temp = head.info;
                    head = tail = null;
                }
                else
                {
                    temp = tail.info;
                    tail = tail.prev;
                    tail.next = null;
                }
                return temp;
            }
        }
        public void most()
        {
            for(NodoColas i=head; i != null; i=i.next)
            {
                Console.WriteLine(i.info);
            }
        }
        public bool Vacio()
        {
            return tail == null;
        }
    }

}
