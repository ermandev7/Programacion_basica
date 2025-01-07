using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming
{
    public class Persona
    {
        string nombre = "";
        int edad = 0;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Datos de la persona :");
            Console.WriteLine("Nombre : " +nombre);
            Console.WriteLine("Edad : " +edad);
        }
        public void EsMayorDeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine(nombre +" es mayor de edad");
            }
            else
            {
                Console.WriteLine(nombre + " no es mayor de edad");
            }
        }

    }
}
