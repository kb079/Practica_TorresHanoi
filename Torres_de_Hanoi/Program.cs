using System;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            Console.WriteLine("Inserta discos iniciales en la torre");
            n = Convert.ToInt32(Console.ReadLine()); //Lee los discos que tiene la torre para comenzar el juego..
            Console.WriteLine("------------------------------------\n");

            //Creacion de las pilas
            Pila p1 = new Pila("Torre 1");
            Pila p2 = new Pila("Torre 2");
            Pila p3 = new Pila("Torre 3");

            //Crea y coloca los discos en la primera Torre segun el input dado.
            for (int i = n; i >= 1; i--)
            {
                Disco d = new Disco(i); //Crea disco
                p1.push(d); //Inserta en la torre 1
            }

            
            Hanoi h = new Hanoi();

            Console.WriteLine("\nFinalizado. Total movimientos: " + h.iterativo(n, p1, p2, p3)); //Llamada a la funcion iterativo para resolverlo.
            Console.ReadLine();

        }
    }
}
