using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Baules
    {
        ArrayList personas = new ArrayList();

        /**
         * Agrega personas al arreglo
         */
        internal void addPersona(Persona p)
        {
            personas.Add(p);
        }
        /**Busca personas por rut
         */
        internal Persona getPersona(String rut)
        {
            //solicito el tamaño del arreglo
            int totElem = this.getTamano();
            //recorro el arreglo desde cero mientras sea menor al tamaño...
            //Por qué menor? porque empecé en cero
            for(int i = 0; i < totElem; i++)
            {
                //saco la persona en la posición i
                //en realidad se la pido al metodo getPersona() que busca por posición
                Persona personaBusqueda = this.getPersona(i);
                //comparo los rut's, podría haberlo hecho de manera directa pero lo guardé en variables
                String rutPb = personaBusqueda.rut;
                //Si el rut que llega, es igual al rut en la persona sacada del arreglo entonces devuelvo esa persona
                if (rut == rutPb)
                {
                    return personaBusqueda;
                }

            }

            //Si llegué hasta acá es porque no encontré ninguna persona con el rut pasado y devuelve null

            return null;
        }
        /**
         * Devueve una persona de una posicion específica
         */
        internal Persona getPersona(int pos)
        {
            return (Persona)personas[pos];
        }

        /**
         * Retorna el tamaño del arreglo
         * Visto de otra forma
         * retorna la cantidad de objetos (personas) guardados en el arreglo
         */
        internal int getTamano()
        {
            return personas.Count;
        }
        internal ArrayList getPersonas()
        {
            return personas;
        }








    }
}
