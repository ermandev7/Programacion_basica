using streaming;

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
            Console.WriteLine("3. Condiciones compuestas con operadores lógicos "); 
            Console.WriteLine("4. Estructura repetitiva while "); 
            Console.WriteLine("5. Estructura repetitiva for "); 
            Console.WriteLine("6. Estructura repetitiva do while "); 
            Console.WriteLine("7. Cadenas de caracteres "); 
            Console.WriteLine("8. Persona obj "); 
            Console.WriteLine("9. Calculadora "); 
            Console.WriteLine("10. Vector "); 

            Console.WriteLine("0. Salir");
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
                    int n1 = 0;
                    int n2 = 0;
                    int n3 = 0;
                    Console.WriteLine("Introduzca el primer numero");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo numero");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca el tercer numero");
                    n3 = Convert.ToInt32(Console.ReadLine());
                    if (n1 > n2 && n1 > n3)
                    {
                        Console.WriteLine("Es mayor: " + n1);
                    }
                    else
                    {
                        if (n2 > n3)
                        {
                            Console.WriteLine("Es mayor: " + n2);
                        }
                        else
                        {
                            Console.WriteLine("Es mayor: " + n3);
                        }
                    }
                    break;
                case "4":
                    //while
                    int x = 1;
                    while (x <= 100)
                    {
                        Console.WriteLine(x);
                       // x++;
                       x = x + 1 ;
                    }
                    Console.WriteLine("fin...");
                    break;
                case "5":
                    //for
                    for (int i = 0; i <= 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("fin...");
                    break;
                case "6":
                    // do while
                    int valor = 0;
                    do
                    {
                       
                        Console.WriteLine("Introduzca un numero maximo de 3 dig.");
                        valor = Convert.ToInt32(Console.ReadLine());    
                        if (valor >= 100)
                        {
                            Console.WriteLine("Tiene 3 dig.");
                        }
                        else
                        {
                            if (valor >= 10)
                            {
                                Console.WriteLine("Tiene 2 dig.");
                            }
                            else
                            {
                                Console.WriteLine("Tiene 1 dig.");
                            }
                        }
                    }
                    while (valor != 0);
                    Console.WriteLine("Fin..");

                    break;
                case "7":
                    //cadena de catacter
                    string nom1 = "";
                    int edad1 = 0;
                    string nom2 = "";
                    int edad2 = 0;
                    Console.WriteLine("ingrese el primer nombre");
                    nom1 = Console.ReadLine();
                    Console.WriteLine("ingrese su edad");
                    edad1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese el segundo nombre");
                    nom2 = Console.ReadLine();
                    Console.WriteLine("ingrese su edad");
                    edad2 = Convert.ToInt32(Console.ReadLine());
                    if (edad1 > edad2)
                    {
                        Console.WriteLine("es mayor "+nom1+" tiene "+edad1);
                    }
                    else
                    {
                        Console.WriteLine("es mayor " + nom2 + " tiene " +edad2 );
                        
                    }

                    break;
                case "8":
                    Console.WriteLine("Persona obj");
                    Persona personaObj = new Persona();
                    personaObj.Inicializar();
                    personaObj.Imprimir();
                    personaObj.EsMayorDeEdad();
                    break;
                case "9":
                    //calculadora
                    Console.Clear();    
                    Console.WriteLine("calculadora");
                    Calculadora calculadoraObj = new Calculadora();
                    calculadoraObj.CargarDatos();
                   // int reslt = calculadoraObj.Sumar();
                    int reslt = calculadoraObj.Restar();
                    Console.WriteLine("Resultado : "+reslt);
                    break;
                case "10": 
                    //vector
                    Vector vectorObj = new Vector();
                    Console.WriteLine("Cargando ...");
                    vectorObj.CargarDatos(5);
                    Console.WriteLine("Imprimiendo ...");
                    vectorObj.Imprimir();
                    break;
                case "0": 
                    exit = true; 
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
            if (!exit)
            {
                Console.WriteLine("Presiona cualquier tecla para continuar..."); 
                Console.ReadKey();
            }
        }
    }
}