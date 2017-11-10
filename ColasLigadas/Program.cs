using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Colas colaPrueba = new Colas();//Cola
            int res = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("***********PROGRAMA DE COLAS UTILIZANDO LISTAS DOBLEMENTE LIGADAS***********");
                Console.WriteLine("****************************************************************************\n\n");
                Console.WriteLine("Selecciona tu opción");
                Console.WriteLine("1.- Enfilar (Enqueue)");
                Console.WriteLine("2.- Des-enfilar (Dequeue)");
                Console.WriteLine("3.- Ver elementos de la cola");
                Console.WriteLine("4.-Borrar cola");
                Console.WriteLine("5.- Salir");
                res = int.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.Write("Escribe el elemento a guardar: ");
                        colaPrueba.Enqueue(Console.ReadLine());
                        if (colaPrueba != null)
                        {
                            Console.WriteLine("Se inserto elemento");
                        }
                        break;
                    case 2:
                        Console.WriteLine("El elemento des-enfilado es: ");
                        if (!colaPrueba.Vacio())
                            Console.WriteLine(colaPrueba.Dequeue());
                        else
                            Console.WriteLine("Cola vacía");
                        Console.ReadKey();
                        break;
                    case 3:
                            colaPrueba.most();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            while (res != 5);
        }
    }
}
