using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Baules b = new Baules();
            Persona persona = new Persona();
            persona.rut = "1-1";
            persona.nombre = "Juan";
            persona.fono = "965584";
            Console.WriteLine(" Cree una persona y la guardé en el baúl");
            Persona persona2 = new Persona();
            persona2.rut = "1-2";
            persona2.nombre = "Juana";
            persona2.fono = "584654465";
            Persona persona3 = new Persona();
            persona3.rut = "1-k";
            persona3.nombre = "Amanda";
            persona3.fono = "654654564654";
            b.addPersona(persona);
            b.addPersona(persona2);
            b.addPersona(persona3);
            Console.WriteLine(" Cree otra persona y la guardé en el baúl");
            b.ToString();

            // Persona lap = b.getPersona(0);
            //Console.WriteLine("Existen " + b.getTamano() + " elementos");
            Persona lap = b.getPersona("1-k");
            if (lap==null)
            {
                Console.WriteLine("No se encontraron registros con ese rut ");
            }
            else
            {
                Console.WriteLine("El nombre de la persona sacada es " + lap.nombre);
            }
            
         
          
            Console.ReadKey();
        }
    }
}
