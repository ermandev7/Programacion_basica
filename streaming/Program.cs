internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        bool exit = false;
        while (!exit)
        {
            Console.Clear(); Console.WriteLine("MENÚ DE OPCIONES:");
            Console.WriteLine("1. Calcular el sueldo");
            Console.WriteLine("2. Estructuras condicionales anidadas ");
            Console.WriteLine("3. Opción "); 
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                   
                    int horasTrabajadas = 0;
                    int costoHora = 0;
                    int sueldo = 0;
                    Console.WriteLine("Ingrese las horas trabajadas");
                    horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el costo por hora");
                    costoHora = Convert.ToInt32(Console.ReadLine());
                    sueldo = costoHora * horasTrabajadas;
                    Console.WriteLine("Su sueldo es : " + sueldo);
                    break;
                case "2":
                    int nota1 = 0;
                    int nota2 = 0;
                    int nota3 = 0;
                    int promedio = 0;
                    Console.WriteLine("Introduzca la primer nota");
                    nota1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca la segunda nota");
                    nota2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca la tercer nota");
                    nota3 = Convert.ToInt32(Console.ReadLine());
                    promedio = (nota1 + nota2 + nota3) / 3;
                    if (promedio >= 7)
                    {
                        Console.WriteLine("Promocionado");
                    }
                    else
                    {
                        if (promedio >= 4 && promedio < 7)
                        {
                            Console.WriteLine("Regular");
                        }
                        if (promedio < 4)
                        {
                            Console.WriteLine("Reprobado");
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Has elegido la Opción 3");
                    break;
                case "4": exit = true; 
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
            if (!exit)
            {
                Console.WriteLine("Presiona cualquier tecla para continuar..."); Console.ReadKey();
            }
        }
    }
}