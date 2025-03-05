using System.Runtime.CompilerServices;

namespace Tarea2_C_
{
    internal class Program
    {
        /// <summary>
        /// Este metodo te devolvera un booleano, si es primo te dara TRUE si no es primo te dara FALSE
        /// </summary>
        /// <param name="numero">El numero que deberas introducir</param>
        /// <returns></returns>
        static public bool BuscarPrimo(int numero)
        {
            if (numero % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < numero; i += 2)
                {
                    if (numero % i == 0 && i != numero)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void Main(string[] args)
        {
            string fulanito = "klk";

            

            Console.WriteLine(fulanito.ToUpper());

            Console.ForegroundColor = ConsoleColor.Blue;


            #region Parte 1
            {
                double num1, num2, resultado;
                Console.WriteLine("Programa que divide\n");
                Console.WriteLine("Introduceme un numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduceme otro numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                resultado = num1 / num2;

                Console.WriteLine("El resultado de la division es: " + resultado);
            }
            #endregion

            #region Parte 2
            {
                double num1, num2, resultado;
                Console.WriteLine("Programa que multiplica\n");
                Console.WriteLine("Introduceme un numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduceme otro numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                resultado = num1 * num2;

                Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            }
            #endregion

            #region Parte 3
            {
                //Crear la parte de la ecuacion
            }
            #endregion

            #region Parte 4
            {
                int numero;
                bool esPrimo;
                Console.WriteLine("Programa que busca numeros primos\n");
                Console.WriteLine("Introduceme un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                esPrimo = BuscarPrimo(numero);

                if (esPrimo)
                {
                    Console.WriteLine("El numero " + numero + " es primo");
                }
                else
                {
                    Console.WriteLine("El numero " + numero + " no es primo");
                }
            }
            #endregion

            #region Parte 5
            {
                Console.WriteLine("Programa que imprime los numeros primos del 1 al 30");
                for (int i = 1; i <= 30; i++)
                {
                    if (BuscarPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            #endregion

            #region Parte 6
            {
                List<int> serie = new List<int>();
                serie.Add(0);

                Console.WriteLine("Imprimir la serie Fibonnaci.");
                Console.WriteLine(serie.Last());
                serie.Add(1);
                Console.WriteLine(serie.Last());
                do
                {
                    int anterior, ultimo, nuevo;

                    anterior = serie[serie.Count - 2];
                    ultimo = serie.Last();

                    nuevo = anterior + ultimo;

                    serie.Add(nuevo);
                    
                    Console.WriteLine(serie.Last());

                } while (serie.Last() < 50);
            }
            #endregion
        }
    }
}