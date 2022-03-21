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


    }
}