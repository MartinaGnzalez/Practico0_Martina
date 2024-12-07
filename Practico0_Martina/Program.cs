using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practico0_Martina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            Console.WriteLine("Ingrese el dia");
            int dia = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            int mes = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el anio");
            int anio = Int32.Parse(Console.ReadLine());

            if ((dia <= 31 && dia >= 0) && (mes <= 12 && mes >= 0) && anio > 0)
            {
                string nombreMes = ObtenerNombreMes(mes);

                Console.WriteLine($"{dia} de {nombreMes} de {anio}");
            }

            else
            {
                Console.WriteLine("Fecha Incorrecta");
            }

        }
        static string ObtenerNombreMes(int mes)
        {
            string nombreMes = "";

            switch (mes)
            {
                case 1:
                    nombreMes = "enero";
                    break;
                case 2:
                    nombreMes = "febrero";
                    break;
                case 3:
                    nombreMes = "marzo";
                    break;
                case 4:
                    nombreMes = "abril";
                    break;
                case 5:
                    nombreMes = "mayo";
                    break;
                case 6:
                    nombreMes = "junio";
                    break;
                case 7:
                    nombreMes = "julio";
                    break;
                case 8:
                    nombreMes = "agosto";
                    break;
                case 9:
                    nombreMes = "septiembre";
                    break;
                case 10:
                    nombreMes = "octubre";
                    break;
                case 11:
                    nombreMes = "noviembre";
                    break;
                case 12:
                    nombreMes = "diciembre";
                    break;
                default:
                    nombreMes = "mes inválido";
                    break;
            }

            return nombreMes;

            //ejercicio2
            /*Console.WriteLine("Ingrese el tamaño del lado del cuadrado:");
            int lado = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lado; i++)
            {
            for (int j = 0; j < lado; j++)
            {
            if (i == 0 || i == lado - 1 || j == 0 || j == lado - 1)
            {
             Console.Write("*");
            }
            else
            {
             Console.Write(" ");
            }
            }
            Console.WriteLine();
            }

            }
            */

            //ejercicio3
            /*
            while (true)
            {

            DateTime now = DateTime.Now;

            string time = now.ToString("HH:mm:ss");


            Console.Clear();


            Console.WriteLine(time);


            Thread.Sleep(1000);
            }
            */

            //ejercicio4
            /* while (true)
             {
                 Console.WriteLine("Introduce el nombre del alumno");
                 string nombre = Console.ReadLine();

                 if (string.IsNullOrWhiteSpace(nombre))
                 {
                     break;
                 }

                 Console.Write("Ingrese la nota de la parte práctica (0-10): ");
                 if (!double.TryParse(Console.ReadLine(), out double notaPractica) || notaPractica < 0 || notaPractica > 10)
                 {
                     Console.WriteLine("Error: La nota de la parte práctica no es válida.");
                     continue;
                 }

                 Console.Write("Ingrese la nota de la parte de problemas (0-10): ");
                 if (!double.TryParse(Console.ReadLine(), out double notaProblemas) || notaProblemas < 0 || notaProblemas > 10)
                 {
                     Console.WriteLine("Error: La nota de la parte de problemas no es válida.");
                     continue;
                 }

                 Console.Write("Ingrese la nota de la parte teórica (0-10): ");
                 if (!double.TryParse(Console.ReadLine(), out double notaTeorica) || notaTeorica < 0 || notaTeorica > 10)
                 {
                     Console.WriteLine("Error: La nota de la parte teórica no es válida.");
                     continue;
                 }

                 double notaFinal = (notaPractica * 0.10) + (notaProblemas * 0.50) + (notaTeorica * 0.40);

                 Console.WriteLine($"El alumno {nombre} tiene una nota final de: {notaFinal:F2}\n");
             }

             Console.WriteLine("Fin del programa.");

             */
            //ejercicio5
            // Leer el valor de N
            /*
            Console.WriteLine("Ingrese el valor de N:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int cuadrado = i * i;
                Console.WriteLine($"El cuadrado de {i} es {cuadrado}");
            }
            */

            //ejercicio6
            /*
            Console.WriteLine("Introduce un anio");
            int anio = Int32.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine($"{anio} es bisieto.");
            }
            else
            {
                Console.WriteLine($"{anio} no es bisiesto.");
            }
            */
        }
    }
}

