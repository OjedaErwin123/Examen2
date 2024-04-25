// See https://aka.ms/new-console-template for more information
using System;

namespace CalculadoraMovimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bienvenido a la Calculadora de Movimiento");
                Console.WriteLine("Seleccione el tipo de movimiento:");
                Console.WriteLine("1. Movimiento Rectilíneo Uniforme (MRU)");
                Console.WriteLine("2. Movimiento Rectilíneo Uniformemente Acelerado (MRUA)");
                Console.WriteLine("3. Salir");
                Console.WriteLine("4. Base del Cuadrado");
                //A partir de la 12 a la 16 mostraremos lo primero que vera el usuario "Interfaz de usuario"
                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    continue;
                }
                //En el if 18 es por si llega a poner un numero incorrecto para ejecutar algo del menu
                //El IF de 26 es por si escoje SALIR para que acabe el programa
                if (opcion == 3)
                    break;

                if (opcion == 1 || opcion == 2)
                {
                    Console.WriteLine("¿Qué desea calcular?");
                    Console.WriteLine("1. Distancia");
                    Console.WriteLine("2. Tiempo");
                    Console.WriteLine("3. Velocidad");
                }

                
                if (opcion == 4)
                {
                    Console.WriteLine("¿Qué desea calcular?");
                    Console.WriteLine("1. Area");
                }

                if (!int.TryParse(Console.ReadLine(), out int opcionCalculo) || opcionCalculo < 1 || opcionCalculo > 4)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    continue;
                }

                //La linea 28 a la 31 mostramos un nuevo menu al usuario
                //El IF de la 32 es por si escojiera un valor no contemplado en el menu

                switch (opcion)
                {
                    case 1:
                        CalcularMRU(opcionCalculo);
                        break;
                    case 2:
                        CalcularMRUA(opcionCalculo);
                        break;
                    case 4:
                        BaseCuadrado(opcionCalculo);
                        break;
                }
                //En el case 1 llamara a la funcion calcularMRU de 53 a la 83
                //En el case 2 llamara a la funcion calcularMRU de 53 a la 83
            }
        }

        static void CalcularMRU(int opcionCalculo) //Funcion MRU
        {
            double v, t, distancia;
            Console.WriteLine("Ingrese la velocidad (m/s):");
            if (!double.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            

            Console.WriteLine("Ingrese el tiempo (s):");
            if (!double.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }


            switch (opcionCalculo)
            {
                case 1:
                    distancia = v * t;
                    Console.WriteLine($"La distancia recorrida es: {distancia} metros.");
                    break;
                case 2:
                    Console.WriteLine($"El tiempo transcurrido es: {v / t} segundos.");
                    break;
                case 3:
                    Console.WriteLine($"La velocidad es: {v / t} m/s.");
                    break;
            }
        }

        static void BaseCuadrado(int opcionCalculo)
        {
            double b, h, area;
            Console.WriteLine("Ingrese su base:");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            

            Console.WriteLine("Ingrese su altura:");
            if (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }
        


            switch (opcionCalculo)
            {
                case 1:
                    area = b * h;
                    Console.WriteLine($"La area del cuadrado es: {area} metros cuadrado.");
                    break;
        }
        }

        static void CalcularMRUA(int opcionCalculo) //funcion MRUA
        {
            double vi, vf, a, t;
            Console.WriteLine("Ingrese la velocidad inicial (m/s):");
            if (!double.TryParse(Console.ReadLine(), out vi))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            Console.WriteLine("Ingrese la velocidad final (m/s):");
            if (!double.TryParse(Console.ReadLine(), out vf))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            Console.WriteLine("Ingrese la aceleración (m/s^2):");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            Console.WriteLine("Ingrese el tiempo (s):");
            if (!double.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }

            switch (opcionCalculo)
            {
                case 1:
                    double distancia = (vf * vf - vi * vi) / (2 * a);
                    Console.WriteLine($"La distancia recorrida es: {distancia} metros.");
                    break;
                case 2:
                    Console.WriteLine($"El tiempo transcurrido es: {(vf - vi) / a} segundos.");
                    break;
                case 3:
                    Console.WriteLine($"La velocidad inicial es: {vf - a * t} m/s.");
                    break;
                case 4:
                    Console.WriteLine($"La velocidad final es: {vi + a * t} m/s.");
                    break;
            }
        }
    }
}