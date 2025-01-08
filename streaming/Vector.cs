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
        public void Ordenar()
        {
            for (int k = 0; k < sueldo.Length; k++)
            {
                for (int f = 0; f < sueldo.Length - 1 - k; f++)
                {
                    if (sueldo[f] > sueldo[f + 1])
                    {
                        int aux;
                        aux = sueldo[f];
                        sueldo[f] = sueldo[f + 1];
                        sueldo[f + 1] = aux;
                    }
                }
            }
        }
        public void Ordenar2()
        {
            for (int k = 0; k < sueldo.Length; k++)
            {
                for (int f = 0; f < sueldo.Length - 1 - k; f++)
                {
                    if (sueldo[f] < sueldo[f + 1])
                    {
                        int aux;
                        aux = sueldo[f];
                        sueldo[f] = sueldo[f + 1];
                        sueldo[f + 1] = aux;
                    }
                }
            }
        }
    }
    
}
