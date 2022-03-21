using System.Collections.Generic;
using System.Linq;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public string nombre; //Identificacion/numero de la torre
        private int top; //Variable para saber cual es el disco que está encima
        public List<Disco> Elementos { get; set; } //Lista de los discos que tiene la pila/torre

        public int Top { get => top; set => top = value; } //Getter

        //Constructor
        public Pila(string nombre)
        {
            this.nombre = nombre;   
            Elementos = new List<Disco>();
          
            top = 0;
        }
        //Método para añadir un disco a la torre.
        public void push(Disco d)
        {
            Elementos.Add(d);
            top = d.Valor;         
        }

        //Método para eliminar un disco de la torre. Devuelve el disco extraido.
        public Disco pop()
        {
           
            Disco d = Elementos.Last(); //Busca el ultimo disco añadido, que es el top

            Elementos.Remove(d); //Elimina el disco de la lista

            if (isEmpty()) top = 0; //Si la torre se queda vacia se reinicia su top
            
            return d; //Devuelve el disco extraido
        }                
        //Método para saber si la torre está vacia o no.
        public bool isEmpty()
        {
            if (Elementos.Count == 0) return true;

            return false;
        }

    }
}
