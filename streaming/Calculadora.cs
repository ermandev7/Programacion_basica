using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming
{
    public class Calculadora
    {
        int num1 = 0;
        int num2 = 0;
        public void CargarDatos()
        {
            Console.WriteLine("Introduzca el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public int Sumar()
        {
            return num1 + num2;
        }
        public int Restar()
        {
            return num1 - num2;
        }
        // div
        //mul
    }
}
