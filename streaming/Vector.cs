using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming
{
    public class Vector
    {
        int[] sueldo;
        public void CargarDatos(int can)
        {
            sueldo = new int[can];
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine("Intruzca un Sueldo");
                sueldo[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine(sueldo[i]);
            }
        }
    }
    
}
