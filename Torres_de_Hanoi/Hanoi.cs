using System;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //Var para guardar los movimientos realizados.
        private int mov = 0;

        //Funcion para mover un disco de una pila a otra.
        public void mover_disco(Pila a, Pila b)
        {
            int topA = a.Top; //El primer disco de la primera pila
            int topB = b.Top; //El primer disco de la segunda pila


            if (a.isEmpty()){ //Si la primera pila esta vacia
                a.push(b.pop()); //Insertar disco y extraer de la segunda pila.
            }
            else if(b.isEmpty()){
                b.push(a.pop()); //Insertar disco y extraer de la primera pila.
            }
            else if (topB < topA) { // Si el primer disco de la pila B es mas pequeno que el primero de la pila A.
                a.push(b.pop()); //Insertar disco y extraer de la segunda pila.
            }
            else
            {
                b.push(a.pop()); //Insertar disco y extraer de la primera pila.
            }

            mov++; //Aumenta la variable de movimientos hechos.
        }

        //Funcion iterativa para resolver el puzle.
        //Param: n (altura de la torre) y las tres pilas/torres.
        public int iterativo(int n, Pila ini, Pila aux, Pila fin)
        {
            //Si la altura es igual a 1
            if (n == 1)
            {
                mover_disco(ini, fin); //Mueve el disco del inicio al final.
                Console.WriteLine("* Mov. " + mov + " -- Mover disco de " + ini.nombre + " a " + fin.nombre);
            }
            else
            {
                iterativo(n - 1, ini, fin, aux); //Se vuelve a llamar a la funcion a si misma restando la altura y cambiando el movimiento del disco.
                 
                mover_disco(ini, fin); //Mueve el disco del inicio al final.
                Console.WriteLine("* Mov. " + mov + " -- Mover disco de " + ini.nombre + " a " + fin.nombre);

                iterativo(n - 1, aux, ini, fin);
            }

            return mov;
        }
    }
}